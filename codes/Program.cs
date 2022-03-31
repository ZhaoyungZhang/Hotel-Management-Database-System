using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 酒店后台管理应用
{
    static class Program
    {
        public static string loginId = "";//登录的用户ID 方便后面再用
        public static int isyg = 0, isjl = 0;//判断是员工还是经理
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainmanager());
            //frmLogin frmLogin = new frmLogin();
            //if (frmLogin.ShowDialog() == DialogResult.OK && isjl == 1)
            //{
            //    Application.Run(new mainmanager());
            //}
            //else if (isyg == 1)
            //{
            //    Application.Run(new mainworker());
            //}


        }
    }
}
