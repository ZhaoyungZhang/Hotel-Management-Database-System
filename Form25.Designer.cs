namespace 酒店后台管理应用
{
    partial class Form25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form25));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查询空房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.普通房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIP房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vVIP房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已预约房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已入住房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户充值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询空房间ToolStripMenuItem,
            this.已预约房间ToolStripMenuItem,
            this.已入住房间ToolStripMenuItem,
            this.客户充值ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查询空房间ToolStripMenuItem
            // 
            this.查询空房间ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.普通房间ToolStripMenuItem,
            this.vIP房间ToolStripMenuItem,
            this.vVIP房间ToolStripMenuItem});
            this.查询空房间ToolStripMenuItem.Name = "查询空房间ToolStripMenuItem";
            this.查询空房间ToolStripMenuItem.Size = new System.Drawing.Size(161, 29);
            this.查询空房间ToolStripMenuItem.Text = "查询空房间";
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
            // 已预约房间ToolStripMenuItem
            // 
            this.已预约房间ToolStripMenuItem.Name = "已预约房间ToolStripMenuItem";
            this.已预约房间ToolStripMenuItem.Size = new System.Drawing.Size(161, 29);
            this.已预约房间ToolStripMenuItem.Text = "已预约房间";
            this.已预约房间ToolStripMenuItem.Click += new System.EventHandler(this.已预约房间ToolStripMenuItem_Click);
            // 
            // 已入住房间ToolStripMenuItem
            // 
            this.已入住房间ToolStripMenuItem.Name = "已入住房间ToolStripMenuItem";
            this.已入住房间ToolStripMenuItem.Size = new System.Drawing.Size(161, 29);
            this.已入住房间ToolStripMenuItem.Text = "已入住房间";
            this.已入住房间ToolStripMenuItem.Click += new System.EventHandler(this.已入住房间ToolStripMenuItem_Click);
            // 
            // 客户充值ToolStripMenuItem
            // 
            this.客户充值ToolStripMenuItem.Name = "客户充值ToolStripMenuItem";
            this.客户充值ToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.客户充值ToolStripMenuItem.Text = "客户充值";
            this.客户充值ToolStripMenuItem.Click += new System.EventHandler(this.客户充值ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(551, 564);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "房间号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "类型";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "价格";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "床型";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "窗型";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(721, 377);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 25);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(721, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 25);
            this.textBox1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(576, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 49);
            this.label5.TabIndex = 14;
            this.label5.Text = "预约天数";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(576, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 57);
            this.label4.TabIndex = 13;
            this.label4.Text = "房间号";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(576, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 70);
            this.label3.TabIndex = 12;
            this.label3.Text = "当前客户未入住";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(576, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 57);
            this.label2.TabIndex = 11;
            this.label2.Text = "当前客户未预约";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(576, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 90);
            this.label1.TabIndex = 10;
            this.label1.Text = "当前客户编号：";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(615, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 71);
            this.button1.TabIndex = 17;
            this.button1.Text = "预约";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(721, 328);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 25);
            this.textBox3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(576, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 49);
            this.label6.TabIndex = 18;
            this.label6.Text = "预约时间";
            // 
            // Form25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 598);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form25";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预约入住";
            this.Load += new System.EventHandler(this.Form25_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查询空房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 普通房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIP房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vVIP房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已预约房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已入住房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户充值ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
    }
}