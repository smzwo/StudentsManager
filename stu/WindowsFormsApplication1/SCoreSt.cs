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
    public partial class SCoreSt : Form
    {
        public SCoreSt()
        {
            InitializeComponent();
        }

        private void SCoreSt_Load(object sender, EventArgs e)
        {
            string strcon = "Data Source=(local);Initial Catalog=课设; Integrated Security=True";

            SqlConnection conn = new SqlConnection(strcon);
            SqlConnection conn2 = new SqlConnection(strcon);
            conn.Open();
            conn2.Open();

            SqlCommand comm = new SqlCommand("select distinct(CYEAR) from ScoreSearch", conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(0));
            }
           
            
            SqlCommand comm2 = new SqlCommand("select distinct(CTERM) from ScoreSearch", conn2);
            SqlDataReader reader2 = comm2.ExecuteReader();
            while (reader2.Read())
            {
                comboBox2.Items.Add(reader2.GetString(0));
            }

            conn.Close();
            conn2.Close();
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
       
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //union all
            string Sno = Login.IDnew;
            //检测是否传入正确值MessageBox.Show(Sno);
            string search = "CNO,CNAME,CYEAR,CTERM,CCREDIT,CNATURE,SCORE";
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
            if (courseYear == "" && courseTerm == "")
            {
                
                selCourse(string.Format("select " + search + "  from ScoreSearch where SNO='{0}'",Sno));
            }
            else if (courseYear != "" && courseTerm == "")
            {
                selCourse(string.Format("select " + search + " from ScoreSearch where CYEAR='{0}' and SNO='{1}'", courseYear, Sno));
            }
            else if (courseYear == "" && courseTerm != "")
            {
                selCourse(string.Format("select " + search + "  from ScoreSearch where CTERM='{0}' and SNO='{1}'", courseTerm, Sno));
            }
            else
            {
                selCourse(string.Format("select " + search + "  from ScoreSearch where CYEAR='{0}'and CTERM='{1}' and SNO='{2}'", courseYear, courseTerm, Sno));
            }
            int n = dataGridView1.Rows.Count;
            //MessageBox.Show(n.ToString());
            double num = 0;
            for (int i = 0; i < n-1; i++)
            {
                //绩点
                //xinxi= dataGridView1.Rows[i].Cells["score"].Value.ToString();
                num += Convert.ToDouble(dataGridView1.Rows[i].Cells["score"].Value.ToString());
                //MessageBox.Show(num.ToString());
               
                //num = num+Convert.ToDouble(xinxi);
                //MessageBox.Show(xinxi.ToString());


            }
            num = (num-50*n);
            num = num / n;
            MessageBox.Show(num.ToString());
            avgbox.Text = num.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
