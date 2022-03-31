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
    public partial class updateclient : Form
    {
        string clientid;
        string id;
        string zt;
        int cf = 0;
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public updateclient()
        {
            InitializeComponent(); this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }
        public updateclient(string cid,string idcard,string name,string pnum,string level,string Z)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
            label6.Text = clientid= cid;
            textBox1.Text = id=idcard;
            textBox2.Text = name;
            textBox3.Text = pnum;
            textBox4.Text = level;
            zt = Z;
        }

        private void updateclient_Load(object sender, EventArgs e)
        {
            asc.RenewControlRect(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = textBox1.Text;
            if (zt == "已入住" || zt == "已预约")
            {//禁止删除正在进行业务的客户
                MessageBox.Show("禁止修改正在进行业务的客户信息！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dao dao = new Dao();
            string sql = $"select * from [dbo].[客户] where 客户身份证号='{id}' and 客户编号 !={clientid}";
            IDataReader dc = dao.read(sql);
            if (dc.Read())
            {//表明有重复的身份证号 不可修改
                cf = 1;
            }
            if (cf == 1)
            {
                MessageBox.Show("客户身份证号已存在！禁止出现重复身份证号！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox4.Text!= "VIP"&&textBox4.Text != "VVIP"&&textBox4.Text!="普通")
            {//禁止删除正在进行业务的客户
                MessageBox.Show("请输入正确的客户类别！普通/VIP/VVIP !", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    DialogResult dr = MessageBox.Show("是否确认修改？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        string sql1 = $"update [dbo].[客户] set 客户身份证号='{textBox1.Text}',客户姓名='{textBox2.Text}',客户手机号='{textBox3.Text}',客户类别='{textBox4.Text}' where 客户编号={clientid};";
                        if (dao.Execute(sql1) > 0)
                        {
                            MessageBox.Show("修改成功！");

                        }
                        else
                            MessageBox.Show("修改失败！");
                    }
                    else return;
                }
                else
                    MessageBox.Show("禁止输入为空！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("出现错误，请联系程序员DEBUG！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
