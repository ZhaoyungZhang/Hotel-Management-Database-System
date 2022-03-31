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
    public partial class Wokerupadate : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        string WID = "";
        public Wokerupadate()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }
        public Wokerupadate(string a0, string a1, string a2, string a3, string a4, string a5, string a6,string a7)
        {
            InitializeComponent();
            asc.RenewControlRect(this);
            WID = textBox1.Text = a0;
            textBox2.Text = a1;
            textBox3.Text = a2;
            textBox4.Text = a3;
            textBox5.Text = a4;
            textBox6.Text = a5;
            textBox7.Text = a6;
            textBox8.Text = a7;
        }
        private void Wokerupadate_Load(object sender, EventArgs e)
        {
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 4)
            {
                MessageBox.Show("员工号必须为四位数字！请重新输入");
                return;
            }
            if (textBox3.Text != "男" && textBox3.Text != "女")
            {
                MessageBox.Show("员工性别输入有误！请重新输入");
                return;
            }
            if (textBox7.Text.Length != 6)
            {
                MessageBox.Show("员工密码必须为六位！请重新输入");
                return;
            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("输入不能为空！");
                return;
            }
            if (textBox5.Text == "经理")
            {
                string sql = $"update [dbo].[员工信息] set 员工号='{textBox1.Text}',员工姓名='{textBox2.Text}',员工性别='{textBox3.Text}',员工身份证号='{textBox4.Text}',员工职位='{textBox5.Text}',员工工资='{textBox6.Text}',员工密码='{textBox7.Text}',员工手机号='{textBox8.Text}' where 员工号='{WID}';" +
                    $"update [dbo].[经理信息] set 经理号='{textBox1.Text}',经理姓名='{textBox2.Text}' where 经理号='{textBox1.Text}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 0)
                {
                    MessageBox.Show("修改成功！");

                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
            else 
            {
                string sql = $"update [dbo].[员工信息] set 员工号='{textBox1.Text}',员工姓名='{textBox2.Text}',员工性别='{textBox3.Text}',员工身份证号='{textBox4.Text}',员工职位='{textBox5.Text}',员工工资='{textBox6.Text}',员工密码='{textBox7.Text}',员工手机号='{textBox8.Text}' where 员工号='{WID}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 0)
                {
                    MessageBox.Show("修改成功！");

                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
        }
    }
    
}
