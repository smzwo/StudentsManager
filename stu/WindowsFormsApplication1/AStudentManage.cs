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
    public partial class AStudentManage : Form
    {
        public AStudentManage()
        {
            
            InitializeComponent();

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

        private void okBtn_Click(object sender, EventArgs e)
        {
           
            if (sIDBox.Text == "" || sPasswdBox.Text == "" || sNameBox.Text == "")
            {
                MessageBox.Show("请输入内容！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sID = sIDBox.Text.Trim();
                string sName = sNameBox.Text.Trim();
                string sPasswd = sPasswdBox.Text.Trim();

                string strcon = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";//建立连接
                SqlConnection conn = new SqlConnection(strcon);
                //打开连接
                conn.Open();
                string strsql_query = string.Format("select * from Tb_SLogin where Sno='{0}'", sID);
                SqlCommand cmd_query = new SqlCommand(strsql_query, conn);

                SqlDataReader dr = cmd_query.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("该课学生已存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    string strsql_insert = string.Format("insert into Tb_SLogin(Sno,Sname,Spassword) values('{0}','{1}','{2}')", sID, sName, sPasswd);
                    SqlCommand cmd2 = new SqlCommand(strsql_insert, conn);
                    cmd2.ExecuteNonQuery();
                    showInfo("select * from Tb_SLogin");
                    MessageBox.Show("插入成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            sIDBox.Text = "";
            sPasswdBox.Text = "";
            sNameBox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    DialogResult r = MessageBox.Show("是否删除该学生登录账户？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (r == DialogResult.Yes)
                    {
                        string del = "";
                        int rs = this.dataGridView1.CurrentRow.Index;
                        string bianhao = this.dataGridView1.Rows[rs].Cells["studentId"].Value.ToString();
                        string strcon2 = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";
                        SqlConnection conn3 = new SqlConnection(strcon2);
                        conn3.Open();        
                        del = string.Format("delete from Tb_SLogin where Sno='{0}'", bianhao);
                        SqlCommand cmd_query = new SqlCommand(del, conn3);
                        cmd_query.ExecuteNonQuery();
                        if (cmd_query.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("删除成功");
                        }

                    }
                    dataGridView1.Rows.RemoveAt(e.RowIndex);//删除当前行
                }
            }
        
        }

        private void AStudentManage_Load(object sender, EventArgs e)
        {
            showInfo("select * from Tb_SLogin");
        }
    }
    }

