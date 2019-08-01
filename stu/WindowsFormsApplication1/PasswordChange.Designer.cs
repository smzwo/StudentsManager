namespace WindowsFormsApplication1
{
    partial class PasswordChange
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
            this.changeP = new System.Windows.Forms.Panel();
            this.Fanhui = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.OP = new System.Windows.Forms.TextBox();
            this.NP = new System.Windows.Forms.TextBox();
            this.NameS = new System.Windows.Forms.TextBox();
            this.SnameS = new System.Windows.Forms.Label();
            this.NewP = new System.Windows.Forms.Label();
            this.Sname = new System.Windows.Forms.Label();
            this.OldP = new System.Windows.Forms.Label();
            this.SID = new System.Windows.Forms.Label();
            this.changeP.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeP
            // 
            this.changeP.Controls.Add(this.Fanhui);
            this.changeP.Controls.Add(this.Save);
            this.changeP.Controls.Add(this.ID);
            this.changeP.Controls.Add(this.OP);
            this.changeP.Controls.Add(this.NP);
            this.changeP.Controls.Add(this.NameS);
            this.changeP.Controls.Add(this.SnameS);
            this.changeP.Controls.Add(this.NewP);
            this.changeP.Controls.Add(this.Sname);
            this.changeP.Controls.Add(this.OldP);
            this.changeP.Controls.Add(this.SID);
            this.changeP.Location = new System.Drawing.Point(27, 12);
            this.changeP.Name = "changeP";
            this.changeP.Size = new System.Drawing.Size(659, 428);
            this.changeP.TabIndex = 0;
            this.changeP.Paint += new System.Windows.Forms.PaintEventHandler(this.changeP_Paint);
            // 
            // Fanhui
            // 
            this.Fanhui.Location = new System.Drawing.Point(362, 330);
            this.Fanhui.Name = "Fanhui";
            this.Fanhui.Size = new System.Drawing.Size(131, 30);
            this.Fanhui.TabIndex = 10;
            this.Fanhui.Text = "返回";
            this.Fanhui.UseVisualStyleBackColor = true;
            this.Fanhui.Click += new System.EventHandler(this.Fanhui_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(146, 330);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(131, 30);
            this.Save.TabIndex = 9;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(243, 137);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(221, 25);
            this.ID.TabIndex = 8;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // OP
            // 
            this.OP.Location = new System.Drawing.Point(243, 193);
            this.OP.Name = "OP";
            this.OP.Size = new System.Drawing.Size(221, 25);
            this.OP.TabIndex = 7;
            // 
            // NP
            // 
            this.NP.Location = new System.Drawing.Point(243, 242);
            this.NP.Name = "NP";
            this.NP.Size = new System.Drawing.Size(221, 25);
            this.NP.TabIndex = 6;
            // 
            // NameS
            // 
            this.NameS.Location = new System.Drawing.Point(298, 77);
            this.NameS.Name = "NameS";
            this.NameS.ReadOnly = true;
            this.NameS.Size = new System.Drawing.Size(100, 25);
            this.NameS.TabIndex = 5;
            // 
            // SnameS
            // 
            this.SnameS.AutoSize = true;
            this.SnameS.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SnameS.Location = new System.Drawing.Point(277, 86);
            this.SnameS.Name = "SnameS";
            this.SnameS.Size = new System.Drawing.Size(0, 20);
            this.SnameS.TabIndex = 4;
            // 
            // NewP
            // 
            this.NewP.AutoSize = true;
            this.NewP.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewP.Location = new System.Drawing.Point(142, 247);
            this.NewP.Name = "NewP";
            this.NewP.Size = new System.Drawing.Size(89, 20);
            this.NewP.TabIndex = 3;
            this.NewP.Text = "新密码：";
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sname.Location = new System.Drawing.Point(142, 82);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(69, 20);
            this.Sname.TabIndex = 2;
            this.Sname.Text = "姓名：";
            // 
            // OldP
            // 
            this.OldP.AutoSize = true;
            this.OldP.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OldP.Location = new System.Drawing.Point(142, 192);
            this.OldP.Name = "OldP";
            this.OldP.Size = new System.Drawing.Size(89, 20);
            this.OldP.TabIndex = 1;
            this.OldP.Text = "原密码：";
            // 
            // SID
            // 
            this.SID.AutoSize = true;
            this.SID.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SID.Location = new System.Drawing.Point(142, 136);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(69, 20);
            this.SID.TabIndex = 0;
            this.SID.Text = "账号：";
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 452);
            this.Controls.Add(this.changeP);
            this.Name = "PasswordChange";
            this.Text = "更改密码";
            this.changeP.ResumeLayout(false);
            this.changeP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel changeP;
        private System.Windows.Forms.Label SID;
        private System.Windows.Forms.Label Sname;
        private System.Windows.Forms.Label OldP;
        private System.Windows.Forms.Label NewP;
        private System.Windows.Forms.Label SnameS;
        private System.Windows.Forms.Button Fanhui;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox OP;
        private System.Windows.Forms.TextBox NP;
        private System.Windows.Forms.TextBox NameS;
    }
}