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
    public partial class Form25 : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        string cID;
        int is_ruzhu = 0;//初始设为为辅助
        string brid;//已预约的房间号
        int is_yy = 0;//是否预约的标志
        string level;//客户类别
        float zk;//享受折扣
        int orderID;//当前客户所处理的订单号
        int planday;//计划天数，当然 计划天数可以到店更改
        public Form25()
        {
            InitializeComponent();
        }
        public Form25(string clientID)
        {
            InitializeComponent();
            cID = clientID;
            Dao dao = new Dao();

            //看级别和折扣
            string sql0 = $"select 客户类别,享受折扣 from [dbo].客户 where 客户编号={clientID}";
            IDataReader dc0 = dao.read(sql0);
            if (dc0.Read())
            {
                level = dc0[0].ToString();//找level
                zk = float.Parse(dc0[1].ToString());
            }
            label1.Text = $"客户编号:{clientID},客户为{level}客户!" +
                $"折扣: {zk}";


            string sql;//看是否预约
            sql = $"select * from [dbo].客户 where 客户编号={clientID} and 状态='已预约'";
            IDataReader dc = dao.read(sql);


            string sql4 = $"select * from [dbo].客户 where 客户编号={clientID} and 状态='已入住'";
            IDataReader dc3 = dao.read(sql4);//看是否入住

            if (dc3.Read())//客户已经入住
            {
                is_ruzhu = 1;//客户已入住 后面保证入住 不重复
                MessageBox.Show("顾客已入住，禁止重复入住！");
            
                string rid, sql2;
                sql2 = $"select 入住房间号 from [dbo].[入住信息] where 客户编号={clientID} and 订单状态='已入住'";
                IDataReader dc4 = dao.read(sql2);
                if (dc4.Read())
                {
                    rid = dc4[0].ToString();
                    //提示入住房间号 因为在退房的时候必须删除 入住信息
                    //入住信息 只保存一个当前入住的信息 ，再弄个表 历史入住！历史入住 在退房后才进入历史入住!

                    label5.Text = $"当前客户已入住房间{rid}，禁止重复入住！";
                }
                else
                    MessageBox.Show("发生错误，请咨询程序员!");
            }



            else if (dc.Read())//客户已经预约,且没入住
            {//预约信息 只保存正在预约的 入住时把某条预约放进历史预约
                MessageBox.Show("顾客已预约，禁止重复预约！");
             
                is_yy = 1;//
                string rid, sql2;
                sql2 = $"select 入住房间号,计划天数 from [dbo].[入住信息] where 客户编号={clientID} and 订单状态='已预约'";
                IDataReader dc1 = dao.read(sql2);
                if (dc1.Read())
                {
                    brid = rid = dc1[0].ToString();//book room 赋值
                    planday = int.Parse(dc1[1].ToString());
                    //提示预约房间号
                    label2.Text = $"当前客户已预约{rid}房间！";

                    textBox1.Text = rid;
                    textBox2.Text = planday.ToString();
                }
                else
                    MessageBox.Show("发生错误，请找ZZYdebug");
            }
            else //客户没预约 没入住
            {
                MessageBox.Show("顾客未预约，请选择房间办理预约！");

            }
        }
        int maxorderID;//当前最大的订单ID
        private void Form25_Load(object sender, EventArgs e)
        {
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";

            asc.RenewControlRect(this);
            label1.Tag = 9999;
            label2.Tag = 9999;
            label3.Tag = 9999;
            label4.Tag = 9999;
            label5.Tag = 9999;
            //订单号处理 
            Dao dao = new Dao();
            if (is_yy == 1)
            {//已预约 没入住 的情况  这种情况 订单已经存在 只需要修改一些状太？
                string sql = $"select 订单号 from [dbo].入住信息 where 客户编号={cID} and 订单状态='已预约'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {//找到预约的那个订单号
                 // maxorderID = int.Parse(dc[0].ToString());
                    orderID = int.Parse(dc[0].ToString());
                }

            }
            else if (is_ruzhu == 1)
            {//已入住 的情况  这种情况 订单已经存在 找出订单号 在最后退房的时候 可能需要？
                string sql = $"select 订单号 from [dbo].入住信息 where 客户编号={cID} and 订单状态='已入住'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {//找到预约的那个订单号
                 // maxorderID = int.Parse(dc[0].ToString());
                    orderID = int.Parse(dc[0].ToString());
                }

            }
            else
            {//未入住的情况
                string sql = $"select max(订单号) from [dbo].入住信息 ";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {//找到max订单号
                    maxorderID = int.Parse(dc[0].ToString());
                    orderID = maxorderID + 1;//订单号递增
                }
            }
        }

        private void 普通房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4;

            sql = "select * from [dbo].[房间信息] where 房间类型='普通'and 状态='可入住'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();


                string[] table = { a0, a1, a2, a3, a4 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void vIP房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4;

            sql = "select * from [dbo].[房间信息] where 房间类型='VIP'and 状态='可入住'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();


                string[] table = { a0, a1, a2, a3, a4 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void vVIP房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4;

            sql = "select * from [dbo].[房间信息] where 房间类型='VVIP'and 状态='可入住'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();


                string[] table = { a0, a1, a2, a3, a4 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void 已预约房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4;

            sql = "select * from [dbo].[房间信息] where 状态='已预约'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                string[] table = { a0, a1, a2, a3, a4 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void 已入住房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql;
            string a0, a1, a2, a3, a4;

            sql = "select * from [dbo].[房间信息] where 状态='已入住'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                string[] table = { a0, a1, a2, a3, a4 };
                dataGridView1.Rows.Add(table);
            }
        }

        private void 客户充值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chongzhi chongzhi = new chongzhi(cID);
            chongzhi.ShowDialog();
            Dao dao = new Dao();

            //刷新级别和折扣
            string sql0 = $"select 客户类别,享受折扣 from [dbo].客户 where 客户编号={cID}";
            IDataReader dc0 = dao.read(sql0);
            if (dc0.Read())
            {
                level = dc0[0].ToString();//找level
                zk = float.Parse(dc0[1].ToString());
            }
            label1.Text = $"客户编号:{cID},客户为{level}客户!" +
                $"折扣{zk}";
        }
        static float cash;
        static float orderprice;
        DateTime yysj;//预约时间
        DateTime yjtfsj;//预计退房时间
        private void button1_Click(object sender, EventArgs e)
        {

            yysj = Convert.ToDateTime(textBox3.Text);//输入格式2020-12-16
            yjtfsj = yysj.AddDays(double.Parse(textBox2.Text));//预计退房时间

            string yytime=yysj.ToString("yyyy-MM-dd");
            string yjtftime = yjtfsj.ToString("yyyy-MM-dd");
            
            //预约需要更改 入住信息 房间信息 客户咋宏泰,折扣
            //预约要交10%押金  最后按时到店 退费
            Dao dao = new Dao();
            //check
            if (is_ruzhu == 1)//已经入住
            {
                MessageBox.Show("客户已入住，禁止重复入住！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (is_yy == 1)//已经入住
            {
                MessageBox.Show("客户已预约，禁止重复预约！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("输入为空！请重新输入！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql0 = $"select 房间号 from [dbo].[房间信息] where 房间号='{textBox1.Text}'";
            IDataReader dc0 = dao.read(sql0);
            if (!dc0.Read())
            {

                MessageBox.Show("房间不存在！请重新输入！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            int day = int.Parse(textBox2.Text);

            string sql1, sql2;//先看余额够不够
            float dj = 0.1F;
            sql1 = $"select 账户余额 from[dbo].客户 where 客户编号 = {cID}";
            sql2 = $"select 价格 from [dbo].房间信息 where 房间号='{textBox1.Text }'";
            IDataReader dc1 = dao.read(sql1);
            IDataReader dc2 = dao.read(sql2);
            if (dc1.Read())//客户余额赋值
            {
                cash = float.Parse(dc1[0].ToString());
            }
            if (dc2.Read())//房间价格赋值
            {
                orderprice = float.Parse(dc2[0].ToString()) * day * zk*dj;//需要付10%总价格的定金 
            }


            
            DialogResult dialogResult = MessageBox.Show($"客户正在预约,是否确定预约？", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            float x = cash - orderprice;
            if(x<0&& DialogResult.Yes == dialogResult)
            {
                MessageBox.Show("客户余额不足！请充值后预约！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (DialogResult.Yes == dialogResult)//确定预约
                {
                    if (is_ruzhu == 0 && is_yy == 0)//这是 没预约 的情况
                    {
                        DialogResult dialogResult1 = MessageBox.Show($"客户预约需付定金{orderprice}元,是否确定预约？", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                        if (DialogResult.Yes == dialogResult1)//付款
                        {
                            string sql;
                            sql = $"insert into [dbo].入住信息 values('{orderID}','{cID }','{textBox1.Text }','{yytime}',{textBox2.Text},'{yjtftime}','已预约');" +
                                $"update [dbo].房间信息 set 状态='已预约' where 房间号='{textBox1.Text }';" +
                                $"update[dbo].客户 set 账户余额 ={x},状态='已预约' where 客户编号={cID}";

                            if (dao.Execute(sql) > 2)//三条命令
                            {
                                MessageBox.Show("预约入住办理成功！");
                            }
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("预约出错！请咨询程序员", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        
        }
    }
    
}
