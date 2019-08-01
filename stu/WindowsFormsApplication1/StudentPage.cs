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
    
    public partial class StudentPage : Form
    {
       // bool One = false;
        Login login = new Login();
        SCoreSt scst;
        PasswordChange pc;
        
        public StudentPage()
        {
            InitializeComponent();
            this.IsMdiContainer = false;

        }
        public void CloseFrom()
        {

        }
        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定注销吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {

                Login login = new Login();
                login.Visible = true;
                login.clear_passwd_ID(login);
                Close();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                Close();
            }
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseFrom();
            scst = new SCoreSt();
            scst.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseFrom();
            pc = new PasswordChange();
            pc.Show(); 
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int clickTimes;
            object tag = this.btnChange.Tag;
            if (tag == null)
            {
                clickTimes = 0;
            }
            else
            {
                clickTimes = Convert.ToInt32(tag);
            }
            this.btnChange.Tag = ++clickTimes;
            if ((clickTimes % 2) == 1)
            //if(One == false)
            {
                string word = "保存";
                btnChange.Text = word.ToString();
                SaddressBox.ReadOnly = false;
                StellBox.ReadOnly = false;
                SqqBox.ReadOnly = false;
               // One = true;
            }
            else
            {
                //SnoBox.ReadOnly = false;
                string a = SnoBox.Text.Trim().ToString();
                //SnameBox.ReadOnly = false;
                string b = SnameBox.Text.Trim().ToString();
                //SexBox.ReadOnly = false;
                string c = SexBox.Text.Trim().ToString();
                //Char[] cc = c.ToCharArray();
                //由于数据库端对于Ssex列添加check('男','女')的约束，导致存储时出现问题，于是将该约束删去。
                string d = SaddressBox.Text.Trim().ToString();
                string g = StellBox.Text.Trim().ToString();
                string f = SqqBox.Text.Trim().ToString();
                string sql = "Insert_Student";
                string strcon2 = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";
                
                SqlConnection conStr = new SqlConnection(strcon2);
                SqlCommand INs = new SqlCommand(sql, conStr);
                INs.CommandType = CommandType.StoredProcedure;
                INs.Parameters.Add("@Sno", SqlDbType.Char).Value = a;
                INs.Parameters.Add("@Sname", SqlDbType.VarChar).Value = b;
                INs.Parameters.Add("@Ssex", SqlDbType.Char).Value = c;
                INs.Parameters.Add("@Saddress", SqlDbType.VarChar).Value = d;
                INs.Parameters.Add("@Stell", SqlDbType.Char).Value = g;
                INs.Parameters.Add("@Sqq", SqlDbType.Char).Value = f;
                INs.Parameters.Add("@rtn", SqlDbType.Int).Value = 2;
                conStr.Open();
                SqlDataAdapter SqlDataAdapter1 = new SqlDataAdapter(INs);
                DataTable DT = new DataTable();
                SqlDataAdapter1.Fill(DT);
                conStr.Close();
                MessageBox.Show("修改成功！");
                string word = "修改";
                btnChange.Text = word.ToString();
                SaddressBox.ReadOnly = true;
                StellBox.ReadOnly = true;
                SqqBox.ReadOnly = true;
                //

                //

            }
        }
        private void StudentPage_Load(object sender, EventArgs e)
        {
            string Sno = Login.IDnew;
            //MessageBox.Show(Sno);//测试有没有传过来
            string strcon = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SnoBox.Text = Login.IDnew;
            string strsql1 = string.Format("select Sname from Tb_Student where Sno='{0}'", Sno);
            SqlCommand SNAME = new SqlCommand(strsql1, conn);
            SnameBox.Text = SNAME.ExecuteScalar().ToString().Trim();
            string strsql2 = string.Format("select Ssex from Tb_Student where Sno='{0}'", Sno);
            SqlCommand SEX = new SqlCommand(strsql2, conn);
            SexBox.Text = SEX.ExecuteScalar().ToString().Trim();
            string strsql3 = string.Format("select Saddress from Tb_Student where Sno='{0}'", Sno);
            SqlCommand SAD = new SqlCommand(strsql3, conn);
            SaddressBox.Text = SAD.ExecuteScalar().ToString().Trim();
            string strsql4 = string.Format("select Stell from Tb_Student where Sno='{0}'", Sno);
            SqlCommand STEL = new SqlCommand(strsql4, conn);
            StellBox.Text = STEL.ExecuteScalar().ToString().Trim();
            string strsql5 = string.Format("select Sqq from Tb_Student where Sno='{0}'", Sno);
            SqlCommand SQQ = new SqlCommand(strsql5,conn);
            SqqBox.Text = SQQ.ExecuteScalar().ToString().Trim();
            conn.Close();
        }

        //private void StudentPage_Load(object sender, EventArgs e)
        //{

        //}

        //private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{

        //}
    }
}
