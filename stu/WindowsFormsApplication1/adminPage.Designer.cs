namespace WindowsFormsApplication1
{
    partial class adminPage
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.必修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem,
            this.学生信息管理ToolStripMenuItem,
            this.课程信息管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1333, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.选项ToolStripMenuItem.Text = "选项";
            this.选项ToolStripMenuItem.Click += new System.EventHandler(this.选项ToolStripMenuItem_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 学生信息管理ToolStripMenuItem
            // 
            this.学生信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生用户管理ToolStripMenuItem,
            this.学生信息管理ToolStripMenuItem1});
            this.学生信息管理ToolStripMenuItem.Name = "学生信息管理ToolStripMenuItem";
            this.学生信息管理ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.学生信息管理ToolStripMenuItem.Text = "学生信息管理";
            // 
            // 学生用户管理ToolStripMenuItem
            // 
            this.学生用户管理ToolStripMenuItem.Name = "学生用户管理ToolStripMenuItem";
            this.学生用户管理ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.学生用户管理ToolStripMenuItem.Text = "学生用户管理";
            this.学生用户管理ToolStripMenuItem.Click += new System.EventHandler(this.学生用户管理ToolStripMenuItem_Click);
            // 
            // 学生信息管理ToolStripMenuItem1
            // 
            this.学生信息管理ToolStripMenuItem1.Name = "学生信息管理ToolStripMenuItem1";
            this.学生信息管理ToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.学生信息管理ToolStripMenuItem1.Text = "学生信息管理";
            this.学生信息管理ToolStripMenuItem1.Click += new System.EventHandler(this.学生信息管理ToolStripMenuItem1_Click);
            // 
            // 课程信息管理ToolStripMenuItem
            // 
            this.课程信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选修ToolStripMenuItem,
            this.必修ToolStripMenuItem});
            this.课程信息管理ToolStripMenuItem.Name = "课程信息管理ToolStripMenuItem";
            this.课程信息管理ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.课程信息管理ToolStripMenuItem.Text = "课程信息管理";
            this.课程信息管理ToolStripMenuItem.Click += new System.EventHandler(this.课程信息管理ToolStripMenuItem_Click);
            // 
            // 选修ToolStripMenuItem
            // 
            this.选修ToolStripMenuItem.Name = "选修ToolStripMenuItem";
            this.选修ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.选修ToolStripMenuItem.Text = "选修";
            this.选修ToolStripMenuItem.Click += new System.EventHandler(this.选修ToolStripMenuItem_Click);
            // 
            // 必修ToolStripMenuItem
            // 
            this.必修ToolStripMenuItem.Name = "必修ToolStripMenuItem";
            this.必修ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.必修ToolStripMenuItem.Text = "非选修";
            this.必修ToolStripMenuItem.Click += new System.EventHandler(this.必修ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1333, 494);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Sno";
            this.Column1.HeaderText = "学号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Sname";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ssex";
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Saddress";
            this.Column4.HeaderText = "家庭住址";
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Stell";
            this.Column5.HeaderText = "电话";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Sqq";
            this.Column6.HeaderText = "QQ";
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // adminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminPage";
            this.Text = "主页";
            this.Load += new System.EventHandler(this.adminPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选修ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 必修ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}