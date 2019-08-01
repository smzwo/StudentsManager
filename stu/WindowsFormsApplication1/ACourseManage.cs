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
    public partial class ACourseManage : Form
    {
        public ACourseManage()
        {
            InitializeComponent();
        }
        public void selCourse(string sqlStr)
        {
            string strcon = "Data Source=(local);Initial Catalog=课设; Integrated Security=True";

            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(sqlStr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void ACourseManage_Load(object sender, EventArgs e)
        {
            string strcon = "Data Source=(local);Initial Catalog=课设; Integrated Security=True";

            SqlConnection conn = new SqlConnection(strcon);
            SqlConnection conn2 = new SqlConnection(strcon);
            conn.Open();
            conn2.Open();

            SqlCommand comm = new SqlCommand("select distinct Cyear from Tb_Course", conn);
            SqlDataReader reader = comm.ExecuteReader();
            SqlCommand comm2 = new SqlCommand("select distinct Cterm from Tb_Course", conn2);
            SqlDataReader reader2 = comm2.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(0));
            }
            while(reader2.Read())
            {
                comboBox2.Items.Add(reader2.GetString(0));
            }

            conn.Close();
            conn2.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string courseYear = comboBox1.Text.ToString();
            string courseTerm = comboBox2.Text.ToString();
            if (courseYear == "" && courseTerm == "")
            {
                btnSelect.Text = "查询全部";
            }
            else
            {
                btnSelect.Text = "查询";
            }
            if (courseYear ==""&& courseTerm =="")
            {                
                selCourse("select * from Tb_Course ");
            }
            else if(courseYear != "" && courseTerm == "")
            {
                selCourse(string.Format("select * from Tb_Course where Cyear='{0}'",courseYear));
            }
            else if(courseYear == "" && courseTerm != "")
            {
                selCourse(string.Format("select * from Tb_Course where Cterm='{0}'", courseTerm));
            }
            else
            {
                selCourse(string.Format("select * from Tb_Course where Cyear='{0}'and Cterm='{1}'", courseYear, courseTerm));
            }
        }

        private void 查询_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
