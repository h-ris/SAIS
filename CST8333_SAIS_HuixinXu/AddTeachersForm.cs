using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CST8333_SAIS_HuixinXu
{
    public partial class AddTeachersForm : UserControl
    {


        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ris\source\repos\CST8333_SAIS_HuixinXu\CST8333_SAIS_HuixinXu\assets\SAIS_HuixinXu.mdf;Integrated Security=True;Connect Timeout=30");

        public AddTeachersForm()
        {
            InitializeComponent();
            teacherDisplayData();
        }

        private void teacherDisplayData()
        {
            AddTeachersData addTeachersData = new AddTeachersData();
            teacher_gridData.DataSource = addTeachersData.teacherData();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (teacherID.Text == "" || teacherName.Text == "" || gender.Text == ""
                || address.Text == "" || status.Text == "" || teacherPic.Image == null || imagePath == null)
            {
                MessageBox.Show("Please fill all the blank fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        // check if any duplicate teacherID
                        string checkTeacherID = "SELECT COUNT(*) FROM teachers WHERE teacher_id = @TeacherID";

                        using(SqlCommand checkTID = new SqlCommand(checkTeacherID, conn) )
                        {
                           /* SqlDataAdapter cAdapter = new SqlDataAdapter(checkTID);
                            DataTable cTable = new DataTable();
                            cAdapter.Fill(cTable);*/

                            checkTID.Parameters.AddWithValue("@TeacherID", teacherID.Text.Trim());
                           int count = (int)checkTID.ExecuteScalar();

                            if(count > 0)
                            {
                                MessageBox.Show("Teacher ID: " + teacherID.Text.Trim() + " already exists", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO teachers " +
                                "(teacher_id, teacher_name, teacher_gender, teacher_address, teacher_status, teacher_image, date_insert) " +
                                "VALUES (@TeacherID, @TeacherName, @TeacherGender, @TeacherAddress, @TeacherStatus, @TeacherImage, @DateInsert)";

                                // save teacher's image to directory
                                string path = Path.Combine(@"C:\Users\Ris\source\repos\CST8333_SAIS_HuixinXu\CST8333_SAIS_HuixinXu\TeacherImage\", teacherID.Text.Trim() + ".jpg");
                                string directoryPath = Path.GetDirectoryName(path);

                                if(!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                
                                File.Copy(imagePath, path, true);

                                using(SqlCommand cmd  = new SqlCommand(insertData, conn) )
                                {
                                    cmd.Parameters.AddWithValue("@TeacherID", teacherID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@TeacherName", teacherName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@TeacherGender", gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@TeacherAddress", address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@TeacherStatus", status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@TeacherImage", path);
                                    cmd.Parameters.AddWithValue("@DateInsert", today.ToString());

                                    cmd.ExecuteNonQuery();

                                    teacherDisplayData();
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

        private void teacher_gridData_Paint(object sender, PaintEventArgs e)
        {

        }


        public void clearField()
        {
            teacherID.Text = "";
            teacherName.Text = "";
            gender.SelectedIndex = -1;
            address.Text = "";
            status.SelectedIndex = -1;
            teacherPic.Image = null;
            imagePath = "";
        }


        private String imagePath;
        private void ImportBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";

            if(open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;
                teacherPic.ImageLocation = imagePath;
            }
        }

        private void teacherPic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void teacher_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = teacher_gridData.Rows[e.RowIndex];
                teacherID.Text = row.Cells[1].Value.ToString();
                teacherName.Text = row.Cells[2].Value.ToString();
                gender.Text = row.Cells[3].Value.ToString();
                address.Text = row.Cells[4].Value.ToString();
                imagePath = row.Cells[5].Value.ToString();

                string imageData = row.Cells[5].Value.ToString();
                if(imageData != null && imageData.Length > 0)
                {
                    teacherPic.Image = Image.FromFile(imageData);
                }else
                {
                    teacherPic.Image = null;
                }

                status.Text = row.Cells[6].Value.ToString();
                
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (teacherID.Text == "" || teacherName.Text == "" || gender.Text == ""
                || address.Text == "" || status.Text == "" || teacherPic.Image == null || imagePath == null)
            {
                MessageBox.Show("Please select item first", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to update TeacherID: " + teacherID.Text.Trim() + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                        if(check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            String updateData = "UPDATE teachers SET teacher_name = @TeacherName, teacher_gender = @TeacherGender, " +
                                "teacher_address = @TeacherAddress, teacher_status = @TeacherStatus, date_update = @DateUpdate" +
                                " WHERE teacher_id = @TeacherID";

                            // save teacher's image to directory
                            // string path = Path.Combine(@"C:\Users\Ris\source\repos\CST8333_SAIS_HuixinXu\CST8333_SAIS_HuixinXu\TeacherImage\", teacherID.Text.Trim() + ".jpg");
                            
                            /* string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(imagePath, path, true); */

                            using (SqlCommand cmd = new SqlCommand(updateData, conn))
                            {
                                cmd.Parameters.AddWithValue("@TeacherID", teacherID.Text.Trim());
                                cmd.Parameters.AddWithValue("@TeacherName", teacherName.Text.Trim());
                                cmd.Parameters.AddWithValue("@TeacherGender", gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@TeacherAddress", address.Text.Trim());
                                cmd.Parameters.AddWithValue("@TeacherStatus", status.Text.Trim());
                                //cmd.Parameters.AddWithValue("@TeacherImage", path);
                                cmd.Parameters.AddWithValue("@DateUpdate", today.ToString());

                                cmd.ExecuteNonQuery();

                                teacherDisplayData();
                                MessageBox.Show("Updated successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearField();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearField();
                        }
                    
                    }catch(Exception ex)
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(teacherID.Text == "")
            {
                MessageBox.Show("Please select item first", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if(conn.State != ConnectionState.Open)
                {

                    DialogResult check = MessageBox.Show("Are you sure to delete teacherID: " + teacherID.Text + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(check == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();

                            string deleteData = "UPDATE teachers SET date_delete = @DateDelete WHERE teacher_id = @TeacherID";

                            DateTime today = DateTime.Today;
                            using (SqlCommand cmd = new SqlCommand(deleteData, conn))
                            {
                                cmd.Parameters.AddWithValue("@TeacherID", teacherID.Text.Trim());
                                cmd.Parameters.AddWithValue("@DateDelete", today.ToString());

                                cmd.ExecuteNonQuery();

                                teacherDisplayData();
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
