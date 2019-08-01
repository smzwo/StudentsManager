using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        static public string IDnew;
        static public string name;
        static public string pass;
        static public string welcome;
        public Login()
        {
            //Login.ID = null;
            InitializeComponent();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strsql_query = "";
            if (IDBox.Text != string.Empty && passwdBox.Text != string.Empty)
            {
                
                string ID2 = IDBox.Text.Trim().ToString();
                string passwd = passwdBox.Text.Trim().ToString();

                string strcon = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strcon);

                conn.Open();
                if (stuButton.Checked)
                {
                    strsql_query = string.Format("select * from Tb_SLogin where  Sno='{0}' and Spassword='{1}'", ID2, passwd);
                }
                else if (adminButton.Checked)
                {
                    strsql_query = string.Format("select * from Tb_Admin where  id='{0}' and Password='{1}'", ID2, passwd);
                }
                SqlCommand cmd_query = new SqlCommand(strsql_query, conn);
                SqlDataReader dr = cmd_query.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (stuButton.Checked)
                    {
                        Login.name = dr["Sname"].ToString();
                       
                        welcome = "欢迎  " + name + "  同学登录本系统";
                    }
                    else if (adminButton.Checked)
                    {
                        Login.name = dr["id"].ToString();
                    }
                    dr.Close();
                    

                    if (stuButton.Checked)
                    {
                        StudentPage stu = new StudentPage();
                        pass = passwd;
                        IDnew = ID2;
                        MessageBox.Show(welcome);
                        stu.Show();
                    }
                    else
                    {
                        adminPage main = new adminPage();
                        main.Show();
                    }
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwdBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("用户名或密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void reBtn_Click(object sender, EventArgs e)
        {
            IDBox.Text = "";
            passwdBox.Text = "";
        }
        private void Login_Load(object sender, EventArgs e)//光标TAB换行
        {
            IDBox.TabIndex = 0;
            passwdBox.TabIndex = 1;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void clear_passwd_ID(Login l)
        {
            l.passwdBox.Text = "";
            l.IDBox.Text = "";
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
