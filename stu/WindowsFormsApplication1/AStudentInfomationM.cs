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
    public partial class AStudentInfomationM : Form
    {
        public AStudentInfomationM()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string sno = SnoBox.Text.Trim().ToString();
            string sname = SnameBox.Text.Trim().ToString();
            string sex = SexBox.Text.Trim().ToString();
            string adr = SaddressBox.Text.Trim().ToString();
            string tell = StellBox.Text.Trim().ToString();
            string qw = SqqBox.Text.Trim().ToString();
            int k = 0;
            //string strcon2 = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";
            //SqlConnection conn = new SqlConnection(strcon2);
            //conn.Open();
            //string strsql = string.Format("insert Tb_Student(Sno,Sname,Ssex,Saddress,Stell,Sqq) values('{0}','{1}','{2}','{3}','{4}','{5}')", sno, sname, sex, adr, tell, qw);
            //SqlCommand cmd = new SqlCommand(strsql, conn);
            //cmd.ExecuteNonQuery();
            string strcon2 = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";
            string sql = "Insert_Student";
            SqlConnection conStr = new SqlConnection(strcon2);
            SqlCommand INs = new SqlCommand(sql, conStr);
            INs.CommandType = CommandType.StoredProcedure;
            INs.Parameters.Add("@Sno", SqlDbType.Char).Value = sno;
            INs.Parameters.Add("@Sname", SqlDbType.VarChar).Value = sname;
            INs.Parameters.Add("@Ssex", SqlDbType.Char).Value = sex;
            INs.Parameters.Add("@Saddress", SqlDbType.VarChar).Value = adr;
            INs.Parameters.Add("@Stell", SqlDbType.Char).Value = tell;
            INs.Parameters.Add("@Sqq", SqlDbType.Char).Value = qw;
            INs.Parameters.Add("@rtn", SqlDbType.Int).Value = k;
            conStr.Open();
            SqlDataAdapter SqlDataAdapter1 = new SqlDataAdapter(INs);
            DataTable DT = new DataTable();
            SqlDataAdapter1.Fill(DT);
            conStr.Close();
            if (k == 1)
            {
                MessageBox.Show("添加成功，账号默认学号，密码默认为000", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(k == 2)
            {
                MessageBox.Show("信息更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(k==0)
            {
                MessageBox.Show("该生已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
