namespace 酒店后台管理应用
{
    partial class odmanage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odmanage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.房间修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消预约订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改预约订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.当前订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.正在入住ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预约订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(496, 32);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 566);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "订单号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "客户编号";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "房间号";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "入住时间";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "预计退房时间";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "订单状态";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.房间修改ToolStripMenuItem,
            this.当前订单ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 32);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 房间修改ToolStripMenuItem
            // 
            this.房间修改ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.取消预约订单ToolStripMenuItem,
            this.修改预约订单ToolStripMenuItem});
            this.房间修改ToolStripMenuItem.Name = "房间修改ToolStripMenuItem";
            this.房间修改ToolStripMenuItem.Size = new System.Drawing.Size(124, 28);
            this.房间修改ToolStripMenuItem.Text = "订单修改";
            // 
            // 取消预约订单ToolStripMenuItem
            // 
            this.取消预约订单ToolStripMenuItem.Name = "取消预约订单ToolStripMenuItem";
            this.取消预约订单ToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.取消预约订单ToolStripMenuItem.Text = "取消预约订单";
            this.取消预约订单ToolStripMenuItem.Click += new System.EventHandler(this.取消预约订单ToolStripMenuItem_Click_1);
            // 
            // 修改预约订单ToolStripMenuItem
            // 
            this.修改预约订单ToolStripMenuItem.Name = "修改预约订单ToolStripMenuItem";
            this.修改预约订单ToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.修改预约订单ToolStripMenuItem.Text = "修改预约订单";
            this.修改预约订单ToolStripMenuItem.Click += new System.EventHandler(this.修改预约订单ToolStripMenuItem_Click);
            // 
            // 当前订单ToolStripMenuItem
            // 
            this.当前订单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部订单ToolStripMenuItem,
            this.正在入住ToolStripMenuItem,
            this.预约订单ToolStripMenuItem});
            this.当前订单ToolStripMenuItem.Name = "当前订单ToolStripMenuItem";
            this.当前订单ToolStripMenuItem.Size = new System.Drawing.Size(124, 28);
            this.当前订单ToolStripMenuItem.Text = "查看订单";
            this.当前订单ToolStripMenuItem.Click += new System.EventHandler(this.当前订单ToolStripMenuItem_Click);
            // 
            // 全部订单ToolStripMenuItem
            // 
            this.全部订单ToolStripMenuItem.Name = "全部订单ToolStripMenuItem";
            this.全部订单ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.全部订单ToolStripMenuItem.Text = "全部订单";
            this.全部订单ToolStripMenuItem.Click += new System.EventHandler(this.全部订单ToolStripMenuItem_Click);
            // 
            // 正在入住ToolStripMenuItem
            // 
            this.正在入住ToolStripMenuItem.Name = "正在入住ToolStripMenuItem";
            this.正在入住ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.正在入住ToolStripMenuItem.Text = "入住订单";
            this.正在入住ToolStripMenuItem.Click += new System.EventHandler(this.正在入住ToolStripMenuItem_Click);
            // 
            // 预约订单ToolStripMenuItem
            // 
            this.预约订单ToolStripMenuItem.Name = "预约订单ToolStripMenuItem";
            this.预约订单ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.预约订单ToolStripMenuItem.Text = "预约订单";
            this.预约订单ToolStripMenuItem.Click += new System.EventHandler(this.预约订单ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(74, 28);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // odmanage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 598);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "odmanage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订单管理";
            this.Load += new System.EventHandler(this.odmanage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 房间修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 当前订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 正在入住ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预约订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStripMenuItem 全部订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消预约订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改预约订单ToolStripMenuItem;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}