namespace WindowsFormsApplication1
{
    partial class ACourseManage
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.查询 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cterm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.查询.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(419, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "学年：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(309, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "学期：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(596, 41);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(104, 34);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // 查询
            // 
            this.查询.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.查询.Controls.Add(this.comboBox1);
            this.查询.Controls.Add(this.btnSelect);
            this.查询.Controls.Add(this.label2);
            this.查询.Controls.Add(this.comboBox2);
            this.查询.Controls.Add(this.label1);
            this.查询.Location = new System.Drawing.Point(71, 33);
            this.查询.Name = "查询";
            this.查询.Size = new System.Drawing.Size(794, 111);
            this.查询.TabIndex = 10;
            this.查询.TabStop = false;
            this.查询.Text = "查询";
            this.查询.Enter += new System.EventHandler(this.查询_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cno,
            this.Cname,
            this.Cyear,
            this.Cterm,
            this.Ccredit,
            this.Cnature});
            this.dataGridView1.Location = new System.Drawing.Point(71, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(794, 327);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cno
            // 
            this.Cno.DataPropertyName = "Cno";
            this.Cno.HeaderText = "课程号";
            this.Cno.Name = "Cno";
            // 
            // Cname
            // 
            this.Cname.DataPropertyName = "Cname";
            this.Cname.HeaderText = "课程名";
            this.Cname.Name = "Cname";
            // 
            // Cyear
            // 
            this.Cyear.DataPropertyName = "Cyear";
            this.Cyear.HeaderText = "学年";
            this.Cyear.Name = "Cyear";
            // 
            // Cterm
            // 
            this.Cterm.DataPropertyName = "Cterm";
            this.Cterm.HeaderText = "学期";
            this.Cterm.Name = "Cterm";
            // 
            // Ccredit
            // 
            this.Ccredit.DataPropertyName = "Ccredit";
            this.Ccredit.HeaderText = "学分";
            this.Ccredit.Name = "Ccredit";
            // 
            // Cnature
            // 
            this.Cnature.DataPropertyName = "Cnature";
            this.Cnature.HeaderText = "种类";
            this.Cnature.Name = "Cnature";
            // 
            // ACourseManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.查询);
            this.Name = "ACourseManage";
            this.Text = "课程查询";
            this.Load += new System.EventHandler(this.ACourseManage_Load);
            this.查询.ResumeLayout(false);
            this.查询.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox 查询;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cterm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnature;
    }
}