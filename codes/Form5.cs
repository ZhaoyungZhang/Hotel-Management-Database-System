using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainWindows;
namespace 酒店后台管理应用
{
    public partial class roomadd : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public roomadd()
        {
         
            InitializeComponent();
            asc.RenewControlRect(this);
            this.Cursor = default;
        }

        private void roomadd_Load(object sender, EventArgs e)
        {
            label1.Tag = 9999;
            label2.Tag = 9999;
            label3.Tag = 9999;
            label4.Tag = 9999;
            label5.Tag = 9999;
           
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length!=3)
            {
                MessageBox.Show("输入房间号长度有误！请重新输入！");
                return;
            }
            if (textBox2.Text != "普通"|| textBox2.Text != "VIP"||textBox2.Text != "VVIP")
            {
                MessageBox.Show("输入房间类型有误！请重新输入！");
                return;
            }
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""&&textBox5.Text!="")
                //默认添加的房间都可入住
                {
                    Dao dao = new Dao();
                    string sql = $"insert into[dbo].[房间信息] values('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}','可入住')";
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
                }
                else
                    MessageBox.Show("输入不能为空！");
            }
            catch
            {
                MessageBox.Show("禁止重复添加房间！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
