using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MainWindows;

namespace 酒店后台管理应用
{
    public partial class roommanage : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        
        public roommanage()
        {
            InitializeComponent();
            // Table1();
            asc.RenewControlRect(this);
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }

        private void roommanage_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[房间信息] ";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
                // a6 = dc[6].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }//Table();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //从数据库读取数据 显示在表格中
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5, a6;
            if (全部房间ToolStripMenuItem.Checked == true)
            { sql = "select * from [dbo].[房间信息] ";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a5 = dc[5].ToString();
                    a6 = dc[6].ToString();
                    string[] table = { a0, a1, a2, a3, a4, a5, a6 };
                    dataGridView1.Rows.Add(table);
                }
                dc.Close();
                dao.DaoClose();
            }
            else if(已入住房间ToolStripMenuItem.Checked==true)
            {
               sql = "select * from [dbo].[房间信息] where 入住状态='是'";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a5 = dc[5].ToString();
                    a6 = dc[6].ToString();
                    string[] table = { a0, a1, a2, a3, a4, a5, a6 };
                    dataGridView1.Rows.Add(table);
                }
                dc.Close();
                dao.DaoClose();
            }
            else if(未入住房间ToolStripMenuItem.Checked==true)
            {  sql = "select * from [dbo].[房间信息] where 入住状态='否'";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a5 = dc[5].ToString();
                    a6 = dc[6].ToString();
                    string[] table = { a0, a1, a2, a3, a4, a5, a6 };
                    dataGridView1.Rows.Add(table);
                }
                dc.Close();
                dao.DaoClose();
            }
            else if(已预约房间ToolStripMenuItem.Checked==true)
            {
                sql = "select * from [dbo].[房间信息] where 预约状态='否'";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a5 = dc[5].ToString();
                    a6 = dc[6].ToString();
                    string[] table = { a0, a1, a2, a3, a4, a5, a6 };
                    dataGridView1.Rows.Add(table);
                }
                dc.Close();
                dao.DaoClose();
            }
            else if(普通房间ToolStripMenuItem.Checked==true)
            {
                sql = "select * from [dbo].[房间信息] where 房间类型='普通'";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a5 = dc[5].ToString();
                    a6 = dc[6].ToString();
                    string[] table = { a0, a1, a2, a3, a4, a5, a6 };
                    dataGridView1.Rows.Add(table);
                }
                dc.Close();
                dao.DaoClose();
            }
            else if(vIP房间ToolStripMenuItem.Checked==true)
            {
               sql = "select * from [dbo].[房间信息] where 房间类型='VIP'";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a5 = dc[5].ToString();
                    a6 = dc[6].ToString();
                    string[] table = { a0, a1, a2, a3, a4, a5, a6 };
                    dataGridView1.Rows.Add(table);
                }
                dc.Close();
                dao.DaoClose();
            }
            else if(vVIP房间ToolStripMenuItem.Checked==true)
            { sql = "select * from [dbo].[房间信息] where 房间类型='VVIP'";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a5 = dc[5].ToString();
                    a6 = dc[6].ToString();
                    string[] table = { a0, a1, a2, a3, a4, a5, a6 };
                    dataGridView1.Rows.Add(table);
                }
                dc.Close();
                dao.DaoClose();
            }
            else if(有窗房间ToolStripMenuItem .Checked==true)
            { sql = "select * from [dbo].[房间信息] where 窗型='有窗'";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a5 = dc[5].ToString();
                    a6 = dc[6].ToString();
                    string[] table = { a0, a1, a2, a3, a4, a5, a6 };
                    dataGridView1.Rows.Add(table);
                }
                dc.Close();
                dao.DaoClose();
            }
            else if(无窗房间ToolStripMenuItem.Checked==true)
            { sql = "select * from [dbo].[房间信息] where 窗型='无窗'";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a5 = dc[5].ToString();
                    a6 = dc[6].ToString();
                    string[] table = { a0, a1, a2, a3, a4, a5, a6 };
                    dataGridView1.Rows.Add(table);
                }
                dc.Close();
                dao.DaoClose();
            }
            else if(大床房ToolStripMenuItem.Checked==true)
            { sql = "select * from [dbo].[房间信息] where 床型='大床'"; 
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a5 = dc[5].ToString();
                    a6 = dc[6].ToString();
                    string[] table = { a0, a1, a2, a3, a4, a5, a6 };
                    dataGridView1.Rows.Add(table);
                }
                dc.Close();
                dao.DaoClose();
            }
            else if(双人剑ToolStripMenuItem .Checked ==true)
            { sql = "select * from [dbo].[房间信息] where 床型='双人'";
                IDataReader dc = dao.read(sql);
                while(dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a5 = dc[5].ToString();
                    a6 = dc[6].ToString();
                    string[] table = { a0, a1, a2, a3, a4, a5, a6 };
                    dataGridView1.Rows.Add(table);
                }
                dc.Close();
                dao.DaoClose();
            }
          

        }

        public void Table1()
        {
         
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
           
            string sql;
            string a0, a1, a2, a3, a4, a5, a6;

            sql = "select * from [dbo].[房间信息] ";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
                a6 = dc[6].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5, a6 };
                dataGridView1.Rows.Add(table);
            }
            //dc.Close();
            //dao.DaoClose();
            
        }
        private void 全部房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;
           
                sql = "select * from [dbo].[房间信息] ";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a5 = dc[5].ToString();
                   // a6 = dc[6].ToString();
                    string[] table = { a0, a1, a2, a3, a4, a5};
                    dataGridView1.Rows.Add(table);
                }
                //dc.Close();
                //dao.DaoClose();
            
        }

        private void 已入住房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[房间信息] where 状态='已入住'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
               // a6 = dc[6].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void 可入住房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;
            sql = "select * from [dbo].[房间信息] where 状态='可入住'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
               // a6 = dc[6].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5};
                dataGridView1.Rows.Add(table);
            }
        }

        private void 已预约房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[房间信息] where 状态='已预约'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
                //a6 = dc[6].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }
        }

     

        private void 普通房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[房间信息] where 房间类型='普通'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
               // a6 = dc[6].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void vIP房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[房间信息] where 房间类型='VIP'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
                //a6 = dc[6].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void vVIP房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[房间信息] where 房间类型='VVIP'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
               // a6 = dc[6].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void 有窗房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[房间信息] where 窗型='有窗'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
               
                string[] table = { a0, a1, a2, a3, a4, a5};
                dataGridView1.Rows.Add(table);
            }
        }

        private void 无窗房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[房间信息] where 窗型='无窗'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
                //a6 = dc[6].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void 大床房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[房间信息] where 床型='大床'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
              //  a6 = dc[6].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void 双人剑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[房间信息] where 床型='双人'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
               // a6 = dc[6].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5};
                dataGridView1.Rows.Add(table);
            }
        }

        private void 添加房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomadd roomadd = new roomadd();
            roomadd.ShowDialog();
        }

        private void 删除房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomdelete roomdelete = new roomdelete();
            roomdelete.ShowDialog();

        }

        private void 修改房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string a0 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string a1 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string a2 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string a3 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string a4 = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
               string a5 = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
               // string a6 = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                roomupdate roomupdate = new roomupdate(a0, a1, a2, a3, a4,a5);
                roomupdate.ShowDialog();
                dataGridView1.Rows.Clear();//清空旧数据
                Dao dao = new Dao();
                string sql;
                string b0, b1, b2, b3, b4,b5;

                sql = "select * from [dbo].[房间信息] ";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    b0 = dc[0].ToString();
                    b1 = dc[1].ToString();
                    b2 = dc[2].ToString();
                    b3 = dc[3].ToString();
                    b4 = dc[4].ToString();
                    b5 = dc[5].ToString();
                //    b6 = dc[6].ToString();
                    string[] table = { b0, b1, b2, b3, b4, b5};
                    dataGridView1.Rows.Add(table);
                }
            }
            catch
            {
               MessageBox.Show("请先选中房间再进行修改！");
            }
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string b0, b1, b2, b3, b4, b5;

            sql = "select * from [dbo].[房间信息] ";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                b0 = dc[0].ToString();
                b1 = dc[1].ToString();
                b2 = dc[2].ToString();
                b3 = dc[3].ToString();
                b4 = dc[4].ToString();
                b5 = dc[5].ToString();
               // b6 = dc[6].ToString();
                string[] table = { b0, b1, b2, b3, b4, b5 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void 房间修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
