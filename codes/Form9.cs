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
    public partial class Workeradd : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public Workeradd()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Workeradd_Load(object sender, EventArgs e)
        {
            asc.RenewControlRect(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length!=4)
            {
                MessageBox.Show("员工号必须为四位数字！请重新输入");
                return;
            }
            if (textBox3.Text != "男"&& textBox3.Text != "女")
            {
                MessageBox.Show("员工性别输入有误！请重新输入");
                return;
            }
            if (textBox7.Text.Length != 6)
            {
                MessageBox.Show("员工密码必须为六位！请重新输入");
                return;
            }
            //try
            //{
                Dao dao = new Dao();
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox5.Text != "")

                {

                    if (textBox5.Text == "经理")
                    {
                        string sql = $"insert into[dbo].[员工信息] values('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}','{textBox5.Text}', '{textBox6.Text}', '{textBox7.Text}', '{textBox8.Text}');" +
                            $"insert into [dbo].[经理信息] values('{textBox1.Text}','{textBox2.Text}');";
                        int n = dao.Execute(sql);
                        if (n > 1)
                            MessageBox.Show("添加成功！");
                        else
                            MessageBox.Show("添加失败！");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                    }
                   else
                    {
                        string sql = $"insert into[dbo].[员工信息] values('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}','{textBox5.Text}', '{textBox6.Text}', '{textBox7.Text}', '{textBox8.Text}')";
                        int n = dao.Execute(sql);
                        if (n > 0)
                            MessageBox.Show("添加成功！");
                        else
                            MessageBox.Show("添加失败！");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                    }
                }
                else
                    MessageBox.Show("输入不能为空！");
           // }
            //catch
           // {
             //   MessageBox.Show("禁止添加已入职员工！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // return;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
