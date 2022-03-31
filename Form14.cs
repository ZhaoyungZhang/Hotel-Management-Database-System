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
    public partial class odmanage : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public odmanage()
        {
            InitializeComponent(); this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }

        private void 正在入住ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[入住信息] where 订单状态='已入住'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[5].ToString();
                a5 = dc[6].ToString();

                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void 预约订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[入住信息] where 订单状态='已预约'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[5].ToString();
                a5 = dc[6].ToString();

                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[入住信息]";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[5].ToString();
                a5 = dc[6].ToString();

                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void 全部订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[入住信息]";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[5].ToString();
                a5 = dc[6].ToString();

                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void 取消预约订单ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            try
            {
                string zt = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                if (zt == "已入住")
                {
                    MessageBox.Show("禁止取消已入住订单！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string oid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string cid = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string rid = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                //string a3 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                // string a4 = "1";
                //string a5 = "1";
                // string a6 = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                //  Form15 form15 = new Form15(a0, a1, a2, a3, a4);
                //form15.ShowDialog();
                Dao dao = new Dao();
                string sql = $"delete from [dbo].入住信息 where 订单号={oid};" +
                    $"UPDATE[dbo].[入住信息] set 订单号 = 订单号 - 1  where 订单号> {oid};" +
                    $"update[dbo].[房间信息] set 状态 = '可入住' where 房间号 = {rid};" +
                    $"update[dbo].客户 set 状态 = '未入住' where 客户编号 = {cid}; ";
              
                DialogResult dr = MessageBox.Show("是否确认取消订单？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    if (dao.Execute(sql) > 3)
                    {
                        MessageBox.Show("取消预约订单成功！！");


                        dataGridView1.Rows.Clear();//清空旧数据

                        string sql1;
                        string b0, b1, b2, b3, b4, b5;

                        sql1 = "select * from [dbo].[入住信息]";
                        IDataReader dc = dao.read(sql1);
                        while (dc.Read())
                        {
                            b0 = dc[0].ToString();
                            b1 = dc[1].ToString();
                            b2 = dc[2].ToString();
                            b3 = dc[3].ToString();
                            b4 = dc[5].ToString();
                            b5 = dc[6].ToString();

                            string[] table = { b0, b1, b2, b3, b4, b5 };
                            dataGridView1.Rows.Add(table);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("请先选中订单再进行修改！");
            }
        
    }

        

        private void 当前订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改预约订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string zt = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                if (zt == "已入住")
                {
                    MessageBox.Show("禁止修改已入住订单！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string a0 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string a1 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string a2 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string a3 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string a4 = "1";
                //string a5 = "1";
                // string a6 = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                Form15 form15 = new Form15(a0, a1, a2, a3, a4);
                form15.ShowDialog();

                dataGridView1.Rows.Clear();//清空旧数据
                Dao dao = new Dao();
                string sql;
                string b0, b1, b2, b3, b4, b5;

                sql = "select * from [dbo].[入住信息]";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    b0 = dc[0].ToString();
                    b1 = dc[1].ToString();
                    b2 = dc[2].ToString();
                    b3 = dc[3].ToString();
                    b4 = dc[5].ToString();
                    b5 = dc[6].ToString();

                    string[] table = { b0, b1, b2, b3, b4, b5 };
                    dataGridView1.Rows.Add(table);
                }
            }
            catch
            {
                MessageBox.Show("请先选中订单再进行修改！");
            }
        }

        private void odmanage_Load(object sender, EventArgs e)
        {
            asc.RenewControlRect(this);
         
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5;

            sql = "select * from [dbo].[入住信息]";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[5].ToString();
                a5 = dc[6].ToString();

                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }
        }
    }
}
