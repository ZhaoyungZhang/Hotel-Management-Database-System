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
   
    public partial class ADDCLIENT : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        int cf = 0;
        public ADDCLIENT()
        {
            InitializeComponent();
            textBox4.Text = "0";
            textBox5.Text = "普通";
        }
        int maxid;//当前最大编号
        float zk=1;
        private void button1_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql1= $"select * from [dbo].[客户] where [客户身份证号] ='{textBox2.Text}'";
            IDataReader dc1 = dao.read(sql1);

            if(dc1.Read())
            {
                cf = 1;//代表重复
                MessageBox.Show("客户已存在！不允许重复创建！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql2= $"select max(客户编号) from [dbo].客户";
            IDataReader dc2 = dao.read(sql2);
            if (dc2.Read())
            {//实现客户编号自动递增
                maxid = int.Parse(dc2[0].ToString());
            }
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                //插入的客户 默认信息
                {
                    if (textBox5.Text != "VIP" && textBox5.Text != "VVIP" && textBox5.Text != "普通")
                    {
                        MessageBox.Show("客户类别有误！请重新输入！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sql3= $"select 享受折扣 from [dbo].客户 where 客户类别='{textBox5.Text}'";
                    IDataReader dc3 = dao.read(sql3);
                    if (dc3.Read())
                    {//折扣
                        zk = float.Parse(dc3[0].ToString());
                           
                    }



                    string sql4 = $"insert into [dbo].[客户] values({maxid + 1}, '{textBox2.Text }', '{textBox1.Text}', '{textBox3.Text }', '{int.Parse(textBox4.Text)}', '{textBox5.Text}','{zk}','未入住')";
                    int n = dao.Execute(sql4);
                    if (n > 0)
                    {
                        MessageBox.Show("客户添加成功！");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                    }

                    else
                        MessageBox.Show("添加失败！");

                }
                else
                {
                    MessageBox.Show("输入为空！请重新输入！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
           }
           catch
           {
                MessageBox.Show("出现错误！！请联系程序员DEBUG！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void ADDCLIENT_Load(object sender, EventArgs e)
        {
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
            asc.RenewControlRect(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
