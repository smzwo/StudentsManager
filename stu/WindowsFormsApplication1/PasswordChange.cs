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
    
    public partial class PasswordChange : Form
    {
        Login login = new Login();
        public static string NameChange;
        public PasswordChange()
        {

            InitializeComponent();
            NameS.Text = Login.name;

            NameChange = NameS.Text.Trim().ToString();

        }



        private void changeP_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Save_Click(object sender, EventArgs e)
        {
            string id = ID.Text.Trim().ToString();
            string old = OP.Text.Trim().ToString();
            string np = NP.Text.Trim().ToString();
            //string strsql_query = "";
            string strcon = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            if (ID.Text != string.Empty && OP.Text != string.Empty && NP.Text != string.Empty)
            {
                //MessageBox.Show(Login.IDnew+Login.pass);调试数值有没有传过来
                if (id == Login.IDnew && old == Login.pass)
                {

                    //SqlCommand cmd_query = new SqlCommand(strsql_query, conn);
                    string strsql = string.Format("update Tb_SLogin set  Spassword='{0}' where Sno='{1}'and Sname='{2}'", np, id,NameChange);
                    SqlCommand cmd = new SqlCommand(strsql, conn);
                    cmd.ExecuteNonQuery();
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("请正确输入原始账号、密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public void CloseFrom()
        {

        }
        private void Fanhui_Click(object sender, EventArgs e)
        {
            this.CloseFrom(); 
    
    }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

