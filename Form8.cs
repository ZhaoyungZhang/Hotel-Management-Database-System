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
    public partial class Workermanage : Form
    
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public Workermanage()
        {
            InitializeComponent();
            asc.RenewControlRect(this);
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workeradd workeradd = new Workeradd();
            workeradd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // try
            //{
                string a0 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string a1 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string a2 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string a3 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string a4 = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string a5 = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string a6 = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string a7 = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                Wokerupadate wokerupadate = new Wokerupadate(a0, a1, a2, a3, a4, a5, a6, a7);
                wokerupadate.ShowDialog();
                
                dataGridView1.Rows.Clear();//清空旧数据
                Dao dao = new Dao();
                string sql;
                string b0, b1, b2, b3, b4, b5, b6,b7;

                sql = "select * from [dbo].[员工信息] ";
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
                    string[] table = { b0, b1, b2, b3, b4, b5, b6,b7 };
                    dataGridView1.Rows.Add(table);
                }
            //}
            //catch
            //{
              //  MessageBox.Show("选中失败！");
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
 

        private void Workermanage_Load(object sender, EventArgs e)
        {
            label1.Tag = 9999;
            label2.Tag = 9999;
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5, a6, a7;

            sql = "select * from [dbo].[员工信息] ";
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
            label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5, a6, a7;

            sql = $"select * from [dbo].[员工信息] where 员工姓名 like '%{textBox1.Text}%' ";
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

            sql = "select * from [dbo].[员工信息] ";
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
        string job;
        private void button3_Click(object sender, EventArgs e)
        {
            job = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();//职位
            try
            {
                string wid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                label2.Text = wid;
                DialogResult dr = MessageBox.Show("是否确认删除？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    if (job == "经理")
                    {
                        string sql = $"delete from [dbo].[员工信息] where 员工号='{wid}';" +
                            $"delete from [dbo].[经理信息] where 经理号='{wid}'";
                        Dao dao = new Dao();
                        if (dao.Execute(sql) > 0)
                        {
                            MessageBox.Show("删除成功！");

                        }
                        else
                            MessageBox.Show("删除失败！");
                    }
                    else
                    {
                        string sql = $"delete from [dbo].[员工信息] where 员工号='{wid}'";
                           
                        Dao dao = new Dao();
                        if (dao.Execute(sql) > 0)
                        {
                            MessageBox.Show("删除成功！");

                        }
                        else
                            MessageBox.Show("删除失败！");
                    }
                }
            }
            catch
            {
                MessageBox.Show("请现在表格中选中要删除的员工！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            job= dataGridView1.SelectedRows[0].Cells[4].Value.ToString();//职位;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4, a5, a6, a7;

            sql = $"select * from [dbo].[员工信息] where 员工号 = '{textBox2.Text}' ";
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
    }
}
