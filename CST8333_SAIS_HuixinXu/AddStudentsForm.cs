using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CST8333_SAIS_HuixinXu
{
    public partial class AddStudentsForm : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ris\source\repos\CST8333_SAIS_HuixinXu\CST8333_SAIS_HuixinXu\assets\SAIS_HuixinXu.mdf;Integrated Security=True;Connect Timeout=30");

        public AddStudentsForm()
        {
            InitializeComponent();
            displayStudentData();
        }

        public void displayStudentData()
        {
            AddStudentData addStudentData = new AddStudentData();
            student_gridData.DataSource = addStudentData.studentData();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (studentID.Text == "" || studentName.Text == "" || gender.Text == ""
                || address.Text == "" || status.Text == "" || studentPic.Image == null ||
                grade.Text == "" || section.Text == "" || imagePath == null)
            {
                MessageBox.Show("Please fill all the blank fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        // check if any duplicate studentID
                        string checkStudentID = "SELECT COUNT(*) FROM students WHERE student_id = @StudentID";

                        using (SqlCommand checkSID = new SqlCommand(checkStudentID, conn))
                        {

                            checkSID.Parameters.AddWithValue("@StudentID", studentID.Text.Trim());
                            int count = (int)checkSID.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("Student ID: " + studentID.Text.Trim() + " already exists", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO students " +
                                "(student_id, student_name, student_gender, student_address, student_grade, student_section, student_status, student_image, date_insert) " +
                                "VALUES (@StudentID, @StudentName, @StudentGender, @StudentAddress, @StudentGrade, @StudentSection, @StudentStatus, @StudentImage, @DateInsert)";

                                // save student's image to directory
                                string path = Path.Combine(@"C:\Users\Ris\source\repos\CST8333_SAIS_HuixinXu\CST8333_SAIS_HuixinXu\StudentImage\", studentID.Text.Trim() + ".jpg");
                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(imagePath, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, conn))
                                {
                                    cmd.Parameters.AddWithValue("@StudentID", studentID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@StudentName", studentName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@StudentGender", gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@StudentAddress", address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@StudentGrade", grade.Text.Trim());
                                    cmd.Parameters.AddWithValue("@StudentSection", section.Text.Trim());
                                    cmd.Parameters.AddWithValue("@StudentStatus", status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@StudentImage", path);
                                    cmd.Parameters.AddWithValue("@DateInsert", today.ToString());

                                    cmd.ExecuteNonQuery();

                                    displayStudentData();
                                    MessageBox.Show("Added successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearField();
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting database: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (studentID.Text == "" || studentName.Text == "" || gender.Text == ""
                || address.Text == "" || status.Text == "" || studentPic.Image == null ||
                grade.Text == "" || section.Text == "" || imagePath == null)
            {
                MessageBox.Show("Please select item first", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to update StudentID: " + studentID.Text.Trim() + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            String updateData = "UPDATE students SET student_name = @StudentName, student_gender = @StudentGender, " +
                                "student_address = @StudentAddress, student_grade = @StudentGrade, student_section = @StudentSection, " +
                               "student_status = @StudentStatus, date_update = @DateUpdate WHERE student_id = @StudentID";



                            using (SqlCommand cmd = new SqlCommand(updateData, conn))
                            {
                                cmd.Parameters.AddWithValue("@StudentID", studentID.Text.Trim());
                                cmd.Parameters.AddWithValue("@StudentName", studentName.Text.Trim());
                                cmd.Parameters.AddWithValue("@StudentGender", gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@StudentAddress", address.Text.Trim());
                                cmd.Parameters.AddWithValue("@StudentGrade", grade.Text.Trim());
                                cmd.Parameters.AddWithValue("@StudentSection", section.Text.Trim());
                                cmd.Parameters.AddWithValue("@StudentStatus", status.Text.Trim());
                                cmd.Parameters.AddWithValue("@DateUpdate", today.ToString());

                                cmd.ExecuteNonQuery();

                                displayStudentData();
                                MessageBox.Show("Updated successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearField();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearField();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting database: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearField();
        }

        public void clearField()
        {
            studentID.Text = "";
            studentName.Text = "";
            gender.SelectedIndex = -1;
            address.Text = "";
            grade.SelectedIndex = -1;
            section.SelectedIndex = -1;
            status.SelectedIndex = -1;
            studentPic.Image = null;
            imagePath = "";
        }

        private String imagePath;
        private void ImportBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;
                studentPic.ImageLocation = imagePath;
            }
        }

        private void student_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = student_gridData.Rows[e.RowIndex];
                studentID.Text = row.Cells[1].Value.ToString();
                studentName.Text = row.Cells[2].Value.ToString();
                gender.Text = row.Cells[3].Value.ToString();
                address.Text = row.Cells[4].Value.ToString();
                grade.Text = row.Cells[5].Value.ToString();
                section.Text = row.Cells[6].Value.ToString();
                
                imagePath = row.Cells[5].Value.ToString();

                string imageData = row.Cells[7].Value.ToString();
                if (imageData != null && imageData.Length > 0)
                {
                    studentPic.Image = Image.FromFile(imageData);
                }
                else
                {
                    studentPic.Image = null;
                }

                status.Text = row.Cells[8].Value.ToString();

            }
        }

        

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (studentID.Text == "")
            {
                MessageBox.Show("Please select item first", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {

                    DialogResult check = MessageBox.Show("Are you sure to delete StudentID: " + studentID.Text + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();

                            string deleteData = "UPDATE students SET date_delete = @DateDelete WHERE student_id = @StudentID";

                            DateTime today = DateTime.Today;
                            using (SqlCommand cmd = new SqlCommand(deleteData, conn))
                            {
                                cmd.Parameters.AddWithValue("@StudentID", studentID.Text.Trim());
                                cmd.Parameters.AddWithValue("@DateDelete", today.ToString());

                                cmd.ExecuteNonQuery();

                                displayStudentData();
                                MessageBox.Show("Deleted successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearField();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error connecting database: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
