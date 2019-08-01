namespace WindowsFormsApplication1
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.reBtn = new System.Windows.Forms.Button();
            this.stuButton = new System.Windows.Forms.RadioButton();
            this.adminButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.passwdBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(183, 300);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 38);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // reBtn
            // 
            this.reBtn.Location = new System.Drawing.Point(366, 300);
            this.reBtn.Name = "reBtn";
            this.reBtn.Size = new System.Drawing.Size(122, 38);
            this.reBtn.TabIndex = 1;
            this.reBtn.Text = "重置";
            this.reBtn.UseVisualStyleBackColor = true;
            this.reBtn.Click += new System.EventHandler(this.reBtn_Click);
            // 
            // stuButton
            // 
            this.stuButton.AutoSize = true;
            this.stuButton.Checked = true;
            this.stuButton.Location = new System.Drawing.Point(233, 139);
            this.stuButton.Name = "stuButton";
            this.stuButton.Size = new System.Drawing.Size(58, 19);
            this.stuButton.TabIndex = 2;
            this.stuButton.TabStop = true;
            this.stuButton.Text = "学生";
            this.stuButton.UseVisualStyleBackColor = true;
            this.stuButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // adminButton
            // 
            this.adminButton.AutoSize = true;
            this.adminButton.Location = new System.Drawing.Point(357, 139);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(73, 19);
            this.adminButton.TabIndex = 3;
            this.adminButton.TabStop = true;
            this.adminButton.Text = "管理员";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(180, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(180, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "密码：";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(274, 196);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(214, 25);
            this.IDBox.TabIndex = 6;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // passwdBox
            // 
            this.passwdBox.Location = new System.Drawing.Point(274, 236);
            this.passwdBox.Name = "passwdBox";
            this.passwdBox.PasswordChar = '*';
            this.passwdBox.Size = new System.Drawing.Size(214, 25);
            this.passwdBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文楷体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(204, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "班级管理系统";
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwdBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.stuButton);
            this.Controls.Add(this.reBtn);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.Text = "欢迎";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button reBtn;
        private System.Windows.Forms.RadioButton stuButton;
        private System.Windows.Forms.RadioButton adminButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox passwdBox;
        private System.Windows.Forms.Label label3;
    }
}