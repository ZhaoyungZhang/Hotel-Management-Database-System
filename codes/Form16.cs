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
    public partial class clientmanage : Form
    {
        public clientmanage()
        {
            InitializeComponent(); this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clientmanage_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5, a6, a7;

            sql = "select * from [dbo].[客户] ";
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
                a7 = dc[7].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5, a6, a7 };
                dataGridView1.Rows.Add(table);
            }
            label4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+"  "+ dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "  " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string cid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            chongzhi chongzhi = new chongzhi(cid);
            chongzhi.ShowDialog();

            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5, a6, a7;

            sql = "select * from [dbo].[客户] ";
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
                a7 = dc[7].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5, a6, a7 };
                dataGridView1.Rows.Add(table);
            }
            label4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "  " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5, a6, a7;

            sql = $"select * from [dbo].[客户] where 客户姓名 like '%{textBox1.Text}%' ";
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
                a7 = dc[7].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5, a6, a7 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5, a6, a7;

            sql = $"select * from [dbo].[客户] where 客户身份证号 like '%{textBox2.Text}%' ";
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
                a7 = dc[7].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5, a6, a7 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5, a6, a7;

            sql = $"select * from [dbo].[客户] where 客户类别 like '%{textBox3.Text}%' ";
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
                a7 = dc[7].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5, a6, a7 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5, a6, a7;

            sql = "select * from [dbo].[客户] ";
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
                a7 = dc[7].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5, a6, a7 };
                dataGridView1.Rows.Add(table);
            }
            label4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "  " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {//mo默认 客户  删除 编号 不更新  因为 历史订单中可能需要 相关的编号 删除后 就不一致了  容易错误
            try
            {
                string cid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
               
                DialogResult dr = MessageBox.Show("是否确认删除？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string zt = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();//获得入住状态
                    if (zt == "已入住" || zt == "已预约")
                    {//禁止删除正在进行业务的客户
                        MessageBox.Show("禁止删除正在进行业务的客户！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int cash = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                    if (cash!=0)
                    {//禁止删除正在使用的房间
                        MessageBox.Show("禁止删除有余额的客户！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string sql = $"delete from [dbo].[客户] where 客户编号='{cid}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功！");

                    }
                    else
                        MessageBox.Show("删除失败！");
                }

            }
            catch
            {
                MessageBox.Show("请现在表格中选中要删除的客户！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            countchange countchange = new countchange();
            countchange.ShowDialog();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a =dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            if(a!="未入住")
            {
                MessageBox.Show("禁止修改正在进行业务的客户信息！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string a0 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string a1 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string a2 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string a3 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string a5 = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string a7 = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                // string a6 = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                updateclient updateclient = new updateclient(a0, a1, a2, a3, a5, a7);
                updateclient.ShowDialog();

                dataGridView1.Rows.Clear();//清空旧数据
                Dao dao = new Dao();
                string sql;
                string b0, b1, b2, b3, b4, b5, b6, b7;


                sql = "select * from [dbo].[客户] ";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    b0 = dc[0].ToString();
                    b1 = dc[1].ToString();
                    b2 = dc[2].ToString();
                    b3 = dc[3].ToString();
                    b4 = dc[4].ToString();
                    b5 = dc[5].ToString();
                    b6 = dc[6].ToString();
                    b7 = dc[7].ToString();
                    string[] table = { b0, b1, b2, b3, b4, b5, b6, b7 };
                    dataGridView1.Rows.Add(table);
                }
                label4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "  " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            }
            catch
            {
                MessageBox.Show("请先选中房间再进行修改！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADDCLIENT aDDCLIENT = new ADDCLIENT();
            aDDCLIENT.ShowDialog();
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string b0, b1, b2, b3, b4, b5, b6, b7;


            sql = "select * from [dbo].[客户] ";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                b0 = dc[0].ToString();
                b1 = dc[1].ToString();
                b2 = dc[2].ToString();
                b3 = dc[3].ToString();
                b4 = dc[4].ToString();
                b5 = dc[5].ToString();
                b6 = dc[6].ToString();
                b7 = dc[7].ToString();
                string[] table = { b0, b1, b2, b3, b4, b5, b6, b7 };
                dataGridView1.Rows.Add(table);
            }
            label4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "  " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
