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
    public partial class workerroom : Form
    {
        public workerroom()
        {
            InitializeComponent(); this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }

        private void workerroom_Load(object sender, EventArgs e)
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
            }
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
                string[] table = { a0, a1, a2, a3, a4, a5 };
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
                string[] table = { a0, a1, a2, a3, a4, a5 };
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

                string[] table = { a0, a1, a2, a3, a4, a5 };
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
                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
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

    }
}
