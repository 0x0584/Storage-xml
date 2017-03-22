using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MagApp.Properties
;

namespace MagApp
{
    public partial class LoginForm : Form
    {
        SqlServer sql;

        public LoginForm()
        {
            InitializeComponent();

            sql = new SqlServer();
            sql.Connection.ConnectionString = "Data Source = (local);" + 
                "Initial Catalog = GEST; Integrated Security=true;";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            tbpassword.PasswordChar = '*';
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            bool exists = false, isadmin = false;
            string username = tbusername.Text, password = tbpassword.Text,
                query = "SELECT * FROM USERS";

            if (username != "" && password != "")
            {
                #region init SqlServer instance
                sql.Connection.Open();
                sql.Commander.CommandText = query;
                sql.Reader = sql.Commander.ExecuteReader();
                #endregion

                while (sql.Reader.Read())
                {
                    // temporary variables
                    string db_username, db_password, db_title;

                    #region init temporary variables
                    db_username = sql.Reader["username"].ToString();
                    db_password = sql.Reader["pass"].ToString();
                    db_title = sql.Reader["title"].ToString();
                    #endregion

                    if (username == db_username && password == db_password)
                        exists = true;

                    if (exists && db_title == "admin") isadmin = true;
                }

                #region Closing `Connection` and `Reader`
                sql.Connection.Close();
                sql.Reader.Close();
                #endregion

                if (!exists) label1.Text = "USERNAME (AND/OR PASSWORD) IS WRONG";
                else
                {
                    MainForm main = new MainForm(isadmin);
                    this.Hide();
                    main.ShowDialog();

                    main.Dispose();
                    main.Close();

                    tbpassword.Text = tbusername.Text = "";
                    this.Show(); 
                }
            }
            else label1.Text = "ERROR, MUST FILL ALL TEH FIELDS";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) tbpassword.PasswordChar = '*';
            else tbpassword.PasswordChar = '\0';
        }
    }
}
