using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class adminPage : Form
    {
        AStudentManage asm;
        AStudentInfomationM asim;
        ACourseManage acm;
        ACourseManageX acmx;
         Login login = new Login();
        public adminPage()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void 选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定注销吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                login.Visible = true;
                login.clear_passwd_ID(login);
                Close();
            }
        }
        public void CloseFrom()
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                Close();
            }
        }

        private void 学生用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseFrom();
            asm = new AStudentManage();
            asm.Show();
            //asm.MdiParent = this;
        }

        private void 学生信息管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.CloseFrom();
            asim = new AStudentInfomationM();
            asim.Show();
            //asim.MdiParent = this;
        }

        private void 选修ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该区域功能尚在建设，暂不开放", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*this.CloseFrom();
            acmx = new ACourseManageX();
            acmx.Show();*/
            //acmx.MdiParent = this;
        }

        private void 必修ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseFrom();
            acm = new ACourseManage();
            acm.Show();
            //acm.MdiParent = this;
        }

        private void adminPage_Load(object sender, EventArgs e)
        {
            showInfo("select * from Tb_Student");
        }

        private void 课程信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void showInfo(string str)
        {
            string strcon = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";//建立连接
            SqlConnection conn = new SqlConnection(strcon);
            //打开连接
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            da.Fill(ds); //把数据填充到dataset
            dataGridView1.DataSource = ds.Tables[0]; //将数据集绑定datagridview,完成显示 dataGridView1要显示的数据是数据集ds里的第一张表
            conn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
