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
    public partial class Form24 : Form
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
        public Form24()
        {
            InitializeComponent();
        }

        public Form24(string clientID)
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
                MessageBox.Show("顾客已预约，请按预约办理入住！");
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
                MessageBox.Show("顾客未预约，请选择房间办理入住！");
            }

        }

        int maxorderID;//当前最大的订单ID
        private void Form24_Load(object sender, EventArgs e)
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
                string[] table = { a0, a1, a2, a3, a4};
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
                string[] table = { a0, a1, a2, a3, a4};
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
        static float cash;
        static float price;
        static int yycsday;//定金的天数
        float cccccc;
        float csjf;//定金
        System.DateTime sjrzday = Convert.ToDateTime(System.DateTime.Now.ToString("D"));//实际入住时间

        DateTime yjrzsj;//预计入住时间
        DateTime sjtfday;//实际退房时间
        private void button1_Click(object sender, EventArgs e)
        {
            yycsday = planday;
           

            //入住需要更改 入住信息 房间信息 客户余额,折扣
            Dao dao = new Dao();
            //check
            if (is_ruzhu == 1)//已经入住
            {
                MessageBox.Show("客户已入住，禁止重复入住！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("输入为空！请重新输入！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql0 = $"select 房间号 from [dbo].[房间信息] where 房间号='{textBox1.Text}'";
            IDataReader dc0 = dao.read(sql0);
            if(!dc0.Read())
            {
                
                    MessageBox.Show("房间不存在！请重新输入！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                
            }

            int day = int.Parse(textBox2.Text);

            if (is_yy == 1)//已经预约了
            {
                if (textBox1.Text != brid)//输入房间号不是预约的
                {
                    MessageBox.Show("必须按照预约进行入住！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (is_yy == 1 && day != planday)
                {
                    DialogResult dr = MessageBox.Show("入住天数与原计划不同，是否确认修改？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {//入住天数与原计划不同，是否确认修改
                        planday = day;
                        textBox2.Text = day.ToString();

                    }
                    else
                    {
                        textBox2.Text = planday.ToString();
                        day = planday;
                        return;
                    }

                }

            }


            sjtfday = sjrzday.AddDays(day);
            string sjrztime = sjrzday.ToString("yyyy-MM-dd");
            string sjtftime = sjtfday.ToString("yyyy-MM-dd");



            string sql1, sql2;//先看余额够不够

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
                cccccc = float.Parse(dc2[0].ToString());
                price = float.Parse(dc2[0].ToString()) * day * zk;
            }
            float x = cash - price;
            if (x > 0)//余额够的时候 进行入住！
            {

                DialogResult dialogResult = MessageBox.Show($"需缴费{price}元,是否入住？", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);


                if (DialogResult.Yes == dialogResult)//确定入住
                {
                    if (is_ruzhu == 0 && is_yy == 0)//这是 没预约 没入住的情况
                    {
                        string sql;
                        sql = $"insert into [dbo].入住信息 values('{orderID}','{cID }','{textBox1.Text }','{sjrztime}',{textBox2.Text},'{sjtftime}','已入住');" +
                            $"update [dbo].房间信息 set 状态='已入住' where 房间号='{textBox1.Text }';" +
                            $"update[dbo].客户 set 账户余额 ={x},状态='已入住' where 客户编号={cID}";

                        if (dao.Execute(sql) > 2)//三条命令
                        {
                            MessageBox.Show("入住成功！");
                        }
                    }
                    else if (is_yy == 1)//预约的时候
                    {

                        string sql10 = $"select 入住时间 from [dbo].入住信息 where 订单号={orderID}";//
                        IDataReader dc10 = dao.read(sql10);
                        if(dc10.Read())
                        {
                            yjrzsj = Convert.ToDateTime(dc10[0].ToString());//得到预计退房时间
                        }


                        TimeSpan span = sjrzday.Subtract(yjrzsj);
                        int dayDiff = span.Days;//预约超时天数

                        if(dayDiff>0)
                        {//超时了
                            float csjf;//超时缴费
                            float bili =0.1F;
                            csjf = cccccc * yycsday * zk*bili;
                           MessageBox.Show($"预约超时{dayDiff}天，定金{csjf}元 不退还！", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        }
                       else  if (dayDiff <= 0)
                        {//超时了
                           
                            float bili = 0.1F;
                            csjf = cccccc * yycsday * zk * bili;
                            string sql100 = $"update[dbo].客户 set 账户余额 ={cash+csjf},状态='已入住' where 客户编号={cID} ";
                            
                            if(dao.Execute(sql100)>0)
                            MessageBox.Show($"未超时，定金{csjf}元已退还！", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            else
                                MessageBox.Show($"未超时，定金{csjf}元退还失败！", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        }
                      
                        string sql;
                        sql = $" update [dbo].入住信息 set 入住时间='{sjrztime}',计划天数={textBox2.Text}, 预计退房时间='{sjtftime}',订单状态 = '已入住' where 订单号 ={orderID}; " +
                            $"update [dbo].房间信息 set 状态='已入住' where 房间号='{textBox1.Text }';" +
                            $"update[dbo].客户 set 账户余额 ={cash+csjf-price},状态='已入住' where 客户编号={cID} ";

                        if (dao.Execute(sql) > 2)//三条命令
                        {
                            MessageBox.Show("入住成功！");
                        }
                    }
                }
            }
            else//余额不足
            {

                MessageBox.Show("余额不足，请充值后入住！");
            }
        }
    }
}
