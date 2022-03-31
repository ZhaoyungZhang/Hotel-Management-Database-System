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
    public partial class chongzhi : Form
    {
        string level;
        string cid;
        public chongzhi()
        {
            InitializeComponent();
           
        }
        public chongzhi(string cilentID)
        {
            InitializeComponent();
            cid = cilentID;
            textBox1.Text  =cilentID;
            Dao dao = new Dao();
            //string sql;
            //string a0, a1, a2, a3;

        }
        private void button1_Click(object sender, EventArgs e)
        {
  
            Dao dao = new Dao();
            string sql;
            //string a0, a1, a2, a3;
            //充值必须累加！！！！！！！！！！！！！！！！！！！！！！！
            sql = $"declare @i int;set @i = (select 账户余额 from[dbo].客户 where 客户编号 = '{textBox1.Text}');UPDATE[dbo].客户 SET 账户余额 = @i + {textBox2.Text} WHERE 客户编号 = '{textBox1.Text}'  ";
            // IDataReader dc = dao.read(sql);
            if (dao.Execute(sql) > 0)//充值成功
            {
                string sql2 = $"select 客户类别 from [dbo].客户 where 客户编号= {textBox1.Text}";
                IDataReader dc = dao.read(sql2);
                if (dc.Read())
                { level = dc[0].ToString(); }//get level


                if (int.Parse(textBox2.Text) >= 5000 && level == "VIP")
                {
                    string sql3 = $"update [dbo].客户 set 客户类别='VVIP',享受折扣=0.8 where 客户编号 ={int.Parse(textBox1.Text)}";
                    if (dao.Execute(sql3) > 0)
                        MessageBox.Show("充值成功！单次充值满5000，顾客已升级为VVIP!");
                }
                else if (int.Parse(textBox2.Text) >= 5000 &&  level == "普通")
                {
                    string sql3 = $"update [dbo].客户 set 客户类别='VVIP',享受折扣=0.8 where 客户编号 ={int.Parse(textBox1.Text)}";
                    if (dao.Execute(sql3) > 0)
                        MessageBox.Show("充值成功！单次充值满5000，顾客已升级为VVIP!");
                }
                else if (int.Parse(textBox2.Text) >= 1000 && level == "普通")
                {
                    string sql3 = $"update [dbo].客户 set 客户类别='VIP',享受折扣=0.9 where 客户编号 ={int.Parse(textBox1.Text)}";
                    if (dao.Execute(sql3) > 0)
                        MessageBox.Show("充值成功！单次充值满1000，顾客已升级为VIP！");
                }
                else MessageBox.Show("充值成功！");
            }
            else
                MessageBox.Show("充值失败！请重试！");
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         AutoSizeFormClass asc = new AutoSizeFormClass();
        private void chongzhi_Load(object sender, EventArgs e)
        {
          
            asc.RenewControlRect(this);
            label1.Tag = 9999;
            label2.Tag = 9999;
            label3.Tag = 9999;
            label5.Tag = 9999;
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }

        private void chongzhi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chongzhi_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
