using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//加入数据库命名空间
using MainWindows;

namespace 酒店后台管理应用
{
   
    public partial class frmLogin : Form
    {
       
        AutoSizeFormClass asc = new AutoSizeFormClass();

        public frmLogin()
        {
            
            frmWelcome fw = new frmWelcome();
            fw.Show();//show出欢迎窗口
            System.Threading.Thread.Sleep(3000);//欢迎窗口停留时间3s
            fw.Close();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
            asc.RenewControlRect(this);
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            // backcolor属性为color.FromArgb(100, 220, 220, 220);
           // button1.BackColor = Color.FromArgb(100, 220, 220, 220);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取文本框中的值
            string userid = this.textBox1.Text;
            string password = this.textBox2.Text;
            if (radioButtonworker.Checked == true)
            {
                if (userid.Equals("") || password.Equals(""))//用户名或密码为空
                {
                    MessageBox.Show("用户名或密码不能为空");
                }
                else//用户名或密码不为空
                {
                    string connectionString = "Data Source=LAPTOP-8PAESPIS;Initial Catalog=HotelDB;Persist Security Info=True;User ID=sa;Password=asdjb12138";
                    SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                    SqlCon.Open(); //打开数据库
                    string sql = "Select * from [dbo].[员工信息] where 员工职位='普通员工' and 员工号='" + userid + "' and 员工密码='" + password + "'";//查找用户sql语句
                    SqlCommand cmd = new SqlCommand(sql, SqlCon);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader sdr;
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())         //从结果中找到
                    {
                        MessageBox.Show("登录成功", "提示");
                        Program.isyg = 1;
                        Program.loginId = this.textBox1.Text;//让 loginID获得 当前登录者的ID！

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误", "提示");
                        return;
                    }
                }
            }
            else if (radioButtonmanage.Checked  == true)
            {
                if (userid.Equals("") || password.Equals(""))//用户名或密码为空
                {
                    MessageBox.Show("用户名或密码不能为空");
                }
                else//用户名或密码不为空
                {
                    string connectionString = "Data Source=LAPTOP-8PAESPIS;Initial Catalog=HotelDB;Persist Security Info=True;User ID=sa;Password=asdjb12138";
                    SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                    SqlCon.Open(); //打开数据库
                    string sql = "Select * from [dbo].[员工信息] where 员工职位='经理' and 员工号='" + userid + "' and 员工密码='" + password + "'";//查找用户sql语句
                    SqlCommand cmd = new SqlCommand(sql, SqlCon);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader sdr;
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())         //从结果中找到
                    {
                        MessageBox.Show("登录成功", "提示");
                        Program.isjl = 1;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误", "提示");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择您的登陆角色！", "提示");
                return;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.PasswordChar = '*';//掩码 掩盖密码
        }
       
    }
}
