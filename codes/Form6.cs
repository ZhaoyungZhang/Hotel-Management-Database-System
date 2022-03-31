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
    public partial class roomdelete : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public roomdelete()
        {
            InitializeComponent();
            label1.Tag = 9999;
            label2.Tag = 9999;
            asc.RenewControlRect(this);
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
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
               
                string[] table = { a0, a1, a2, a3, a4, a5};
                dataGridView1.Rows.Add(table);
            }
        
            //dc.Close();
            //dao.DaoClose();
        }

        private void roomdelete_Load(object sender, EventArgs e)
        {

            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string rid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                label2.Text = rid;
                DialogResult dr = MessageBox.Show("是否确认删除？", "信息提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(dr==DialogResult.OK)
                {
                    string zt = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();//获得入住状态
                    if(zt=="已入住"||zt=="已预约")
                    {//禁止删除正在使用的房间
                        MessageBox.Show("禁止删除正在使用的房间！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string sql = $"delete from [dbo].[房间信息] where 房间号='{rid}'";
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
                MessageBox.Show("请现在表格中选中要删除的房间！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
