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
    public partial class book : Form
    {
        public book()
        {
           
            InitializeComponent(); this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }
        AutoSizeFormClass asc = new AutoSizeFormClass();
        int maxid;
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void book_Load(object sender, EventArgs e)
        {
            asc.RenewControlRect(this);
            label1.Tag = 9999;
            label2.Tag = 9999;
            label3.Tag = 9999;
            label4.Tag = 9999;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();

            //string a0, a1, a2, a3;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("输入为空！请重新输入！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox2.Text.Length != 18)
            {
                MessageBox.Show("输入身份证号位数有误,请重新输入！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //找当前最大客户编号
            string sql2;
            sql2 = $"select max(客户编号) from [dbo].客户";
            IDataReader dc2 = dao.read(sql2);
            if (dc2.Read())
            {//实现客户编号自动递增
                maxid = int.Parse(dc2[0].ToString());
            }

            string sql = $"select * from [dbo].[客户] where [客户身份证号] ='{textBox2.Text}'";
            //身份证号不允许重复，按身份证来查询
            IDataReader dc = dao.read(sql);

            //做姓名/手机号的更新
            if (dc.Read())
            {
                string name = dc[2].ToString();//客户姓名
                string p = dc[2].ToString();
                if (name != textBox1.Text || p != textBox3.Text)
                {//如果名字不相同 则更新名字
                    string s = $"update [dbo].客户 set 客户姓名='{textBox1.Text}',客户手机号='{textBox3.Text}' where 客户身份证号='{textBox2.Text}'";
                    if (dao.Execute(s) > 0)
                    {
                        MessageBox.Show("顾客信息已更新到最新！");
                    }
                }
            }

            if (dc.Read())//客户不是首次入住
            {
                MessageBox.Show("欢迎顾客光临，继续办理预约入住业务！");
                //跳转到 选择房

                string sql4, clientID;
                sql4 = $"select 客户编号 from [dbo].[客户] where [客户身份证号] ='{textBox2.Text}'";
                IDataReader d4 = dao.read(sql4);
                if (d4.Read())
                {
                    clientID = d4[0].ToString();
                    // if (dr1 == DialogResult.OK)
                    //  this.Close();

                    //rzdjform1 rzdjform1 = new rzdjform1(clientID);
                    //rzdjform1.ShowDialog();
                    Form25 form25 = new Form25(clientID);
                    form25.ShowDialog();

                }
                else
                    MessageBox.Show("出现错误，请联系程序员！");
            }
            else //客户不存在的时候
            {
                string sql3;
                //没有客户的时候 编号是当前编号最大值加一 金额都 设为零,默认为普通用户，并且客户不存在 肯定没预约没入住 默认 未入住
                sql3 = $"insert into [dbo].[客户] ([客户编号],[客户身份证号] ,[客户姓名],[客户手机号],[账户余额] ,[客户类别],[享受折扣],[状态]) values({maxid + 1}, '{textBox2.Text }', '{textBox1.Text}', '{textBox3.Text }', '0', '普通','1','未入住')";
                //dao.Execute(sql3);//再执行插入
                if (dao.Execute(sql3) > 0)
                {
                    MessageBox.Show("顾客首次办理预约入住，已自动办理为会员！");

                    string sql4, clientID;
                    sql4 = $"select 客户编号 from [dbo].[客户] where [客户姓名]='{textBox1.Text}' and [客户身份证号] ='{textBox2.Text}'";
                    IDataReader d21 = dao.read(sql4);
                    if (d21.Read())
                    {
                        clientID = d21[0].ToString();

                        //跳转到 选择房间
                        // if (dr2 == DialogResult.OK)
                        //this.Close();
                        Form25 form25 = new Form25(clientID);
                        form25.ShowDialog();
                        //  this.Hide();


                    }
                }
                else
                    MessageBox.Show("顾客首次预约入住，办理会员失败！");
            }
        }
    }
}
