using MainWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 酒店后台管理应用
{
    public partial class Form15 : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public Form15()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }
        string oid, clid, roid, rzt, originroomid;
        int daylong;
        public Form15(string orderID, string cid, string rid, string rztime, string dday)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
            oid = orderID;
            clid = cid;
            roid = rid;
            originroomid = rid;
            rzt = rztime;
           
            label1.Text = $"当前订单号： {orderID}";
            label2.Text = $"当前客户编号： {cid}";
            
            textBox3.Text = rid;
            textBox4.Text = rztime;
            textBox5.Text = "1";
            //textBox4.Text = a3;
            //textBox5.Text = a4;
            //zt = a5;
            // textBox7.Text = a6;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            asc.RenewControlRect(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        string zt;
        private void button1_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            roid = textBox3.Text;
            rzt = textBox4.Text;
            
            daylong = int.Parse(textBox5.Text);
            
            DateTime rzsj;//入住时间
            DateTime tfsj;//退房时间
            
            rzsj= Convert.ToDateTime(textBox4.Text);
            tfsj = rzsj.AddDays(int.Parse(textBox3.Text));//退房时间
            string rztime = rzsj.ToString("yyyy-MM-dd"); 
            string tftime=tfsj.ToString("yyyy-MM-dd");
            try
            {//修改预约 可能有问题的就是 房间
                if (textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    string sql = $"select 状态 from [dbo].房间信息 where 房间号={roid}";
                    IDataReader dc = dao.read(sql);
                    if(dc.Read())
                    {
                        zt = dc[0].ToString();   
                    }
                    if (zt != "可入住" && originroomid !=textBox3.Text)
                    {//禁止update其他人正在使用的房间
                        MessageBox.Show("禁止预约正在入住的房间！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        string sql1 = $"update [dbo].[房间信息] set 状态='已预约' where 房间号='{roid}'" +
                            $"update [dbo].[房间信息] set 状态='可入住' where 房间号='{originroomid}'"+
                            $"update [dbo].入住信息 set  入住房间号 = {roid},入住时间 = '{rztime}',计划天数 = {textBox5.Text},预计退房时间 ='{tftime}' where 订单号 = {oid}";
                           

                        if (dao.Execute(sql1) > 1)
                        {
                            MessageBox.Show("修改预约订单成功！");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("输入不能为空！");
                }
            }
            catch
            {
                MessageBox.Show("输入格式错误！");
            }
        }
    }
}
