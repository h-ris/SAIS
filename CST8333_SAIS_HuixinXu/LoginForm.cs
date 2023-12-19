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

/*
 * This is the class that primarily deals with the login functionality. 
 * It is designed to interact with a SQL Server database to authenticate users.
 */
namespace CST8333_SAIS_HuixinXu
{
    // LoginForm is a partial class inheriting from Form
    public partial class LoginForm : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ris\source\repos\CST8333_SAIS_HuixinXu\CST8333_SAIS_HuixinXu\assets\SAIS_HuixinXu.mdf;Integrated Security=True;Connect Timeout=30");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(userName.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    conn.Open();

                    String selectData = "SELECT * FROM users WHERE username = @username AND password = @password ";

                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", userName.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Login successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error connecting database: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = showPassword.Checked ? '\0' : '*';
        }
    }
}
