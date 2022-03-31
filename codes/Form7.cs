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
    public partial class roomupdate : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        string ID = "";
        string zt;
        public roomupdate()
        {
            InitializeComponent();
            asc.RenewControlRect(this);
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }
        public roomupdate(string a0,string a1,string a2,string a3,string a4,string a5)
        {
            InitializeComponent();
            ID = textBox1.Text = a0;
            textBox2.Text=a1;
            textBox3.Text = a2;
            textBox4.Text = a3;
            textBox5.Text = a4;
            zt = a5;
           // textBox7.Text = a6;
        }
        private void roomupdate_Load(object sender, EventArgs e)
        {
            label1.Tag = 9999;
            label2.Tag = 9999;
            label3.Tag = 9999;
            label4.Tag = 9999;
            label5.Tag = 9999;
            asc.RenewControlRect(this);
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 3)
            {
                MessageBox.Show("输入房间号长度有误！请重新输入！");
                return;
            }
            if (textBox2.Text != "普通" || textBox2.Text != "VIP" || textBox2.Text != "VVIP")
            {
                MessageBox.Show("输入房间类型有误！请重新输入！");
                return;
            }
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    if (zt == "已入住" || zt == "已预约")
                    {//禁止update正在使用的房间
                        MessageBox.Show("禁止修改正在使用的房间！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string sql = $"update [dbo].[房间信息] set 房间号='{textBox1.Text}',房间类型='{textBox2.Text}',价格='{textBox3.Text}',床型='{textBox4.Text}',窗型='{textBox5.Text}' where 房间号='{ID}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("修改成功！");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("输入不能为空！");
                }
            }
            catch
            {
               MessageBox.Show("错误信息！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
           // textBox6.Text = "";
           // textBox7.Text = "";
        }
    }
}
