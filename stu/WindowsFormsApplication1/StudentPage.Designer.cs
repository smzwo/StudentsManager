namespace WindowsFormsApplication1
{
    partial class StudentPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SnoBox = new System.Windows.Forms.TextBox();
            this.SaddressBox = new System.Windows.Forms.TextBox();
            this.SnameBox = new System.Windows.Forms.TextBox();
            this.StellBox = new System.Windows.Forms.TextBox();
            this.SexBox = new System.Windows.Forms.TextBox();
            this.SqqBox = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem,
            this.成绩查询ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 28);
            this.menuStrip1.TabIndex = 0;
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
            // 成绩查询ToolStripMenuItem
            // 
            this.成绩查询ToolStripMenuItem.Name = "成绩查询ToolStripMenuItem";
            this.成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.成绩查询ToolStripMenuItem.Text = "成绩查询";
            this.成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.成绩查询ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(431, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "宿舍：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(431, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(68, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(68, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(392, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "QQ/微信：";
            // 
            // SnoBox
            // 
            this.SnoBox.Location = new System.Drawing.Point(165, 54);
            this.SnoBox.Name = "SnoBox";
            this.SnoBox.ReadOnly = true;
            this.SnoBox.Size = new System.Drawing.Size(184, 25);
            this.SnoBox.TabIndex = 7;
            this.SnoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaddressBox
            // 
            this.SaddressBox.Location = new System.Drawing.Point(527, 144);
            this.SaddressBox.Name = "SaddressBox";
            this.SaddressBox.ReadOnly = true;
            this.SaddressBox.Size = new System.Drawing.Size(184, 25);
            this.SaddressBox.TabIndex = 8;
            this.SaddressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SnameBox
            // 
            this.SnameBox.Location = new System.Drawing.Point(527, 55);
            this.SnameBox.Name = "SnameBox";
            this.SnameBox.ReadOnly = true;
            this.SnameBox.Size = new System.Drawing.Size(184, 25);
            this.SnameBox.TabIndex = 9;
            this.SnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StellBox
            // 
            this.StellBox.Location = new System.Drawing.Point(165, 249);
            this.StellBox.Name = "StellBox";
            this.StellBox.ReadOnly = true;
            this.StellBox.Size = new System.Drawing.Size(184, 25);
            this.StellBox.TabIndex = 10;
            this.StellBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SexBox
            // 
            this.SexBox.Location = new System.Drawing.Point(165, 144);
            this.SexBox.Name = "SexBox";
            this.SexBox.ReadOnly = true;
            this.SexBox.Size = new System.Drawing.Size(184, 25);
            this.SexBox.TabIndex = 11;
            this.SexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SqqBox
            // 
            this.SqqBox.Location = new System.Drawing.Point(527, 249);
            this.SqqBox.Name = "SqqBox";
            this.SqqBox.ReadOnly = true;
            this.SqqBox.Size = new System.Drawing.Size(184, 25);
            this.SqqBox.TabIndex = 12;
            this.SqqBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(337, 329);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(112, 38);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 408);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.SqqBox);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.StellBox);
            this.Controls.Add(this.SnameBox);
            this.Controls.Add(this.SaddressBox);
            this.Controls.Add(this.SnoBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentPage";
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.StudentPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SnoBox;
        private System.Windows.Forms.TextBox SaddressBox;
        private System.Windows.Forms.TextBox SnameBox;
        private System.Windows.Forms.TextBox StellBox;
        private System.Windows.Forms.TextBox SexBox;
        private System.Windows.Forms.TextBox SqqBox;
        private System.Windows.Forms.Button btnChange;
    }
}

