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
    public partial class tfdj : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public tfdj()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = System.DateTime.Now.ToString();
        }

        private void tfdj_Load(object sender, EventArgs e)
        {
            timer1.Start();//显示当前时间 自行查看超时没
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
            label2.Text = $"当前选中订单号: {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}";
        }

        public tfdj(int cd,int rd,string yj)
        {
            InitializeComponent();

        }
        int maxod;//当前最大ORDERID
        int odid;//入住信息中的订单编号
        int cid;//客户编号
        int rid;//房间号
        DateTime yjday;//预计退房时间
        DateTime rzsj;//入住时间
        System.DateTime sjtfday = Convert.ToDateTime(System.DateTime.Now.ToString("D"));
        int price=0;
        DialogResult dr;
        float yue=0;//账户余额 
        float zxf=0;//总消费
        float zk=0;//折扣

        private void 房间修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                Dao dao = new Dao();
                string zt = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                if (zt != "已入住")
                {
                    MessageBox.Show("只能退房登记已入住的订单！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                

                odid= int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                cid = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                rid = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                yjday =Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                rzsj= Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

                //manxid
                string sql1 = "select max(订单号) from [dbo].历史订单";
                IDataReader dc1 = dao.read(sql1);
                if(dc1.Read())
                maxod= int.Parse(dc1[0].ToString());


                //房间价格
                string sql2 = $"select 价格 from [dbo].房间信息 where 房间号={rid}";
                IDataReader dc2 = dao.read(sql2);
                if (dc2.Read())
                   price=int.Parse(dc2[0].ToString());

                //余额
                string sql3 = $"select 账户余额,享受折扣 from [dbo].客户 where 客户编号={cid}";
                IDataReader dc3 = dao.read(sql3);
                if (dc3.Read())
                { yue = float.Parse(dc3[0].ToString());
                    zk=float.Parse(dc3[1].ToString());
                }

                //check 是否超时
                TimeSpan span = sjtfday.Subtract(yjday);
                int dayDiff = span.Days;//超时天数
                float jf=0;
                jf = dayDiff * price;


                //总消费
                TimeSpan span1 = yjday.Subtract(rzsj);
                int dayDiff1 = span1.Days;//入住登记时候计划天数
                
                if (dayDiff > 0)
                {//超时的
                    jf = dayDiff * price;
                    zxf = price * dayDiff1 * zk + dayDiff * price;//总消费=入住预计天数*价格*折扣+超时天数*价格

                // MessageBox.Show($"该订单超时{dayDiff}天！需额外缴费{jf}元!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dr = MessageBox.Show($"该订单超时{dayDiff}天！需额外缴费{jf}元! 是否确认退房？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        if (jf > yue)
                        {
                            MessageBox.Show($"客户余额不足!请充值后退房", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {//客户余额充足 进行 退房  1.修改余额 2.修改客户状态 3.修改房间状态4.修改入住信息订单 5.增加新的历史订单
                            string sjtftime=sjtfday.ToString("yyyy-MM-dd");
                            string rztime=rzsj.ToString("yyyy-MM-dd");

                            string sql4 = $"update [dbo].客户 set 账户余额=账户余额-{jf},状态='未入住' where 客户编号={cid};" +
                                $"update [dbo].[房间信息] set 状态='可入住' where 房间号={rid};" +
                                $"delete from [dbo].入住信息 where 订单号={odid};" +
                                $"insert into [dbo].历史订单 values({maxod + 1},{cid},'{rid}','{rztime}','{sjtftime}',{jf},{zxf});";

                        int a = dao.Execute(sql4);
                        if (a > 3)
                            {
                                MessageBox.Show("退房登记成功！欢迎下次光临!");
                                
                            }
                            else
                            {
                                MessageBox.Show("退房登记失败！请重试!");
                                
                            }

                        }
                    }
                }
                else 
                {//没超时的  提前也可
                zxf = price * dayDiff1 * zk;
                dr =MessageBox.Show($"订单未超时，无需额外缴费！是否确认退房？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        string sjtftime = sjtfday.ToString("yyyy-MM-dd");
                        string rztime = rzsj.ToString("yyyy-MM-dd");
                        //客户余额充足 进行 退房  1.修改余额 2.修改客户状态 3.修改房间状态4.修改入住信息订单 5.增加新的历史订单
                        string sql5 = $"update [dbo].客户 set 状态='未入住' where 客户编号={cid};" +
                            $"update [dbo].房间信息 set 状态='可入住' where 房间号={rid};" +
                            $"delete from [dbo].入住信息 where 订单号={odid};" +
                            $"insert into [dbo].历史订单 values({maxod + 1},{cid},'{rid}','{rztime}','{sjtftime}',0,{zxf})";

                    int a = dao.Execute(sql5);
                            
                        if (a > 3)
                        {
                            MessageBox.Show("退房登记成功！欢迎下次光临!");
                            
                        }
                        else
                        {
                            MessageBox.Show("退房登记失败！请重试!");
                            
                        }
                    }
                }


                dataGridView1.Rows.Clear();//清空旧数据
               
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
                MessageBox.Show("请先选中订单再进行退房！");
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

        private void 修改预约订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = $"当前选中订单号: {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 客户充值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cID = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            chongzhi chongzhi = new chongzhi(cID);
            chongzhi.ShowDialog();

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
