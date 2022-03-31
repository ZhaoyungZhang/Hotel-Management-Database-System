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
    public partial class countchange : Form
    {
        public countchange()
        {
            InitializeComponent(); this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    if (float.Parse(textBox1.Text) < 1.0 && float.Parse(textBox1.Text) > 0 && float.Parse(textBox2.Text) < 1.0 && float.Parse(textBox2.Text) > 0)
                    {
                        DialogResult dr = MessageBox.Show("是否确认修改折扣力度？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            string sql = $"update [dbo].[客户] set 享受折扣={float.Parse(textBox1.Text)} where 客户类别='VIP';" +
                                $"update [dbo].[客户] set 享受折扣={float.Parse(textBox2.Text)} where 客户类别='VVIP';";
                            Dao dao = new Dao();
                            if (dao.Execute(sql) > 1)
                            {
                                MessageBox.Show("修改成功！");
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入正确的折扣！");
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
            textBox1.Text ="";
            textBox2.Text = "";
        }
  AutoSizeFormClass asc = new AutoSizeFormClass();
        private void countchange_Load(object sender, EventArgs e)
        {
            asc.RenewControlRect(this);
        }
    }
}
