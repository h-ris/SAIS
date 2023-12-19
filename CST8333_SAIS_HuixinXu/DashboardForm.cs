using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST8333_SAIS_HuixinXu
{
    public partial class DashboardForm : UserControl
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ris\source\repos\CST8333_SAIS_HuixinXu\CST8333_SAIS_HuixinXu\assets\SAIS_HuixinXu.mdf;Integrated Security=True;Connect Timeout=30");

        public DashboardForm()
        {
            InitializeComponent();

            displayTotalEnrollStd();
            displayTotalTeacher();
            displayTotalGradStd();

            displayEnrolledStudentToday();
        }


        public void displayTotalEnrollStd()
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {

                    conn.Open();
                    string selectData = "SELECT COUNT(id) FROM students WHERE student_status = 'Enrolled' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        int tempES = 0;
                        if (reader.Read())
                        {
                            tempES = Convert.ToInt32(reader[0]);

                            enrolledStd.Text = tempES.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting database: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
            enrolledStd.Refresh();
        }


        public void displayTotalTeacher()
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {

                    conn.Open();
                    string selectData = "SELECT COUNT(id) FROM teachers WHERE teacher_status = 'Active' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        int tempTT = 0;
                        if (reader.Read())
                        {
                            tempTT = Convert.ToInt32(reader[0]);

                            totalTea.Text = tempTT.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting database: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }


        public void displayTotalGradStd()
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {

                    conn.Open();
                    string selectData = "SELECT COUNT(id) FROM students WHERE student_status = 'Graduated' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        int tempGS = 0;
                        if (reader.Read())
                        {
                            tempGS = Convert.ToInt32(reader[0]);

                            gradStd.Text = tempGS.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting database: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }


        public void displayEnrolledStudentToday()
        {
            AddStudentData addSD = new AddStudentData();

            dataGridView1.DataSource = addSD.dashboardGenData();

        }


    }
}