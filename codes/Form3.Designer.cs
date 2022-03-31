namespace 酒店后台管理应用
{
    partial class roommanage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roommanage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.房间修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房间查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已预约房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已入住房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.未入住房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.类型查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.普通房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIP房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vVIP房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.有窗房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.无窗房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大床房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.双人剑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(324, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(616, 565);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "房间号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "房间类型";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "价格";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "床型";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "窗型";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "状态";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.房间修改ToolStripMenuItem,
            this.房间查询ToolStripMenuItem,
            this.类型查询ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 房间修改ToolStripMenuItem
            // 
            this.房间修改ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加房间ToolStripMenuItem,
            this.删除房间ToolStripMenuItem,
            this.修改房间ToolStripMenuItem});
            this.房间修改ToolStripMenuItem.Name = "房间修改ToolStripMenuItem";
            this.房间修改ToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.房间修改ToolStripMenuItem.Text = "房间修改";
            this.房间修改ToolStripMenuItem.Click += new System.EventHandler(this.房间修改ToolStripMenuItem_Click);
            // 
            // 添加房间ToolStripMenuItem
            // 
            this.添加房间ToolStripMenuItem.Name = "添加房间ToolStripMenuItem";
            this.添加房间ToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.添加房间ToolStripMenuItem.Text = "添加房间";
            this.添加房间ToolStripMenuItem.Click += new System.EventHandler(this.添加房间ToolStripMenuItem_Click);
            // 
            // 删除房间ToolStripMenuItem
            // 
            this.删除房间ToolStripMenuItem.Name = "删除房间ToolStripMenuItem";
            this.删除房间ToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.删除房间ToolStripMenuItem.Text = "删除房间";
            this.删除房间ToolStripMenuItem.Click += new System.EventHandler(this.删除房间ToolStripMenuItem_Click);
            // 
            // 修改房间ToolStripMenuItem
            // 
            this.修改房间ToolStripMenuItem.Name = "修改房间ToolStripMenuItem";
            this.修改房间ToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.修改房间ToolStripMenuItem.Text = "修改房间";
            this.修改房间ToolStripMenuItem.Click += new System.EventHandler(this.修改房间ToolStripMenuItem_Click);
            // 
            // 房间查询ToolStripMenuItem
            // 
            this.房间查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部房间ToolStripMenuItem,
            this.已预约房间ToolStripMenuItem,
            this.已入住房间ToolStripMenuItem,
            this.未入住房间ToolStripMenuItem});
            this.房间查询ToolStripMenuItem.Name = "房间查询ToolStripMenuItem";
            this.房间查询ToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.房间查询ToolStripMenuItem.Text = "房间查询";
            // 
            // 全部房间ToolStripMenuItem
            // 
            this.全部房间ToolStripMenuItem.Name = "全部房间ToolStripMenuItem";
            this.全部房间ToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.全部房间ToolStripMenuItem.Text = "全部房间";
            this.全部房间ToolStripMenuItem.Click += new System.EventHandler(this.全部房间ToolStripMenuItem_Click);
            // 
            // 已预约房间ToolStripMenuItem
            // 
            this.已预约房间ToolStripMenuItem.Name = "已预约房间ToolStripMenuItem";
            this.已预约房间ToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.已预约房间ToolStripMenuItem.Text = "已预约房间";
            this.已预约房间ToolStripMenuItem.Click += new System.EventHandler(this.已预约房间ToolStripMenuItem_Click);
            // 
            // 已入住房间ToolStripMenuItem
            // 
            this.已入住房间ToolStripMenuItem.Name = "已入住房间ToolStripMenuItem";
            this.已入住房间ToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.已入住房间ToolStripMenuItem.Text = "已入住房间";
            this.已入住房间ToolStripMenuItem.Click += new System.EventHandler(this.已入住房间ToolStripMenuItem_Click);
            // 
            // 未入住房间ToolStripMenuItem
            // 
            this.未入住房间ToolStripMenuItem.Name = "未入住房间ToolStripMenuItem";
            this.未入住房间ToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.未入住房间ToolStripMenuItem.Text = "可入住房间";
            this.未入住房间ToolStripMenuItem.Click += new System.EventHandler(this.可入住房间ToolStripMenuItem_Click);
            // 
            // 类型查询ToolStripMenuItem
            // 
            this.类型查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.普通房间ToolStripMenuItem,
            this.vIP房间ToolStripMenuItem,
            this.vVIP房间ToolStripMenuItem,
            this.有窗房间ToolStripMenuItem,
            this.无窗房间ToolStripMenuItem,
            this.大床房ToolStripMenuItem,
            this.双人剑ToolStripMenuItem});
            this.类型查询ToolStripMenuItem.Name = "类型查询ToolStripMenuItem";
            this.类型查询ToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.类型查询ToolStripMenuItem.Text = "类型查询";
            // 
            // 普通房间ToolStripMenuItem
            // 
            this.普通房间ToolStripMenuItem.Name = "普通房间ToolStripMenuItem";
            this.普通房间ToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.普通房间ToolStripMenuItem.Text = "普通房间";
            this.普通房间ToolStripMenuItem.Click += new System.EventHandler(this.普通房间ToolStripMenuItem_Click);
            // 
            // vIP房间ToolStripMenuItem
            // 
            this.vIP房间ToolStripMenuItem.Name = "vIP房间ToolStripMenuItem";
            this.vIP房间ToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.vIP房间ToolStripMenuItem.Text = "VIP房间";
            this.vIP房间ToolStripMenuItem.Click += new System.EventHandler(this.vIP房间ToolStripMenuItem_Click);
            // 
            // vVIP房间ToolStripMenuItem
            // 
            this.vVIP房间ToolStripMenuItem.Name = "vVIP房间ToolStripMenuItem";
            this.vVIP房间ToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.vVIP房间ToolStripMenuItem.Text = "VVIP房间";
            this.vVIP房间ToolStripMenuItem.Click += new System.EventHandler(this.vVIP房间ToolStripMenuItem_Click);
            // 
            // 有窗房间ToolStripMenuItem
            // 
            this.有窗房间ToolStripMenuItem.Name = "有窗房间ToolStripMenuItem";
            this.有窗房间ToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.有窗房间ToolStripMenuItem.Text = "有窗房间";
            this.有窗房间ToolStripMenuItem.Click += new System.EventHandler(this.有窗房间ToolStripMenuItem_Click);
            // 
            // 无窗房间ToolStripMenuItem
            // 
            this.无窗房间ToolStripMenuItem.Name = "无窗房间ToolStripMenuItem";
            this.无窗房间ToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.无窗房间ToolStripMenuItem.Text = "无窗房间";
            this.无窗房间ToolStripMenuItem.Click += new System.EventHandler(this.无窗房间ToolStripMenuItem_Click);
            // 
            // 大床房ToolStripMenuItem
            // 
            this.大床房ToolStripMenuItem.Name = "大床房ToolStripMenuItem";
            this.大床房ToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.大床房ToolStripMenuItem.Text = "大床房";
            this.大床房ToolStripMenuItem.Click += new System.EventHandler(this.大床房ToolStripMenuItem_Click);
            // 
            // 双人剑ToolStripMenuItem
            // 
            this.双人剑ToolStripMenuItem.Name = "双人剑ToolStripMenuItem";
            this.双人剑ToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.双人剑ToolStripMenuItem.Text = "双人间";
            this.双人剑ToolStripMenuItem.Click += new System.EventHandler(this.双人剑ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
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
            // roommanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 598);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "roommanage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间管理";
            this.Load += new System.EventHandler(this.roommanage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 房间修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房间查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已入住房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 未入住房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已预约房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 类型查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 普通房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIP房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vVIP房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 有窗房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 无窗房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大床房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 双人剑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部房间ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}