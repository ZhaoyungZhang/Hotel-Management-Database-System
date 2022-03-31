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
    public partial class mainworker : Form
    {
        public mainworker()
        {
            InitializeComponent(); this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//SteelBlue.ssk";
        }

        private void 入住登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rzdjform rzdjform = new rzdjform();
            rzdjform.ShowDialog();
        }

        private void 退房登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tfdj tfdj = new tfdj();
            tfdj.ShowDialog();
        }

        private void 房间管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workerroom workerroom = new workerroom();
            workerroom.ShowDialog();
        }

        private void 客户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientmanage clientmanage = new clientmanage();
            clientmanage.ShowDialog();
        }

        private void 当前订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            odmanage odmanage = new odmanage();
            odmanage.ShowDialog();
        }

        private void 历史订单ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lsdorder lsdorder = new lsdorder();
            lsdorder.ShowDialog();
        }

        private void mainworker_Load(object sender, EventArgs e)
        {

        }

        private void 预约入住ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book book = new book();
            book.ShowDialog();
        }
    }
}
