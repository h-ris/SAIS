using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST8333_SAIS_HuixinXu
{
    internal class AddStudentData
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ris\source\repos\CST8333_SAIS_HuixinXu\CST8333_SAIS_HuixinXu\assets\SAIS_HuixinXu.mdf;Integrated Security=True;Connect Timeout=30");

        public int ID { get; set; }
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public string StudentAddress { get; set; }
        public string StudentGrade { get; set; }
        public string StudentSection { get; set; }
        public string StudentImage { get; set; }
        public string StudentStatus { get; set; }
        public string DateInsert { get; set; }


        public List<AddStudentData> studentData()
        {
            List<AddStudentData> listStudentData = new List<AddStudentData>();
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT * FROM students WHERE date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddStudentData addStudentData = new AddStudentData();

                            addStudentData.ID = (int)reader["id"];
                            addStudentData.StudentID = reader["student_id"].ToString();
                            addStudentData.StudentName = reader["student_name"].ToString();
                            addStudentData.StudentGender = reader["student_gender"].ToString();
                            addStudentData.StudentAddress = reader["student_address"].ToString();
                            addStudentData.StudentGrade = reader["student_grade"].ToString();
                            addStudentData.StudentSection = reader["student_section"].ToString();
                            addStudentData.StudentStatus = reader["student_status"].ToString();
                            addStudentData.StudentImage = reader["student_image"].ToString();
                            addStudentData.DateInsert = reader["date_insert"].ToString();

                            listStudentData.Add(addStudentData);
                        }
                        reader.Close();

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting database: " + ex);
                }
                finally { conn.Close(); }
            }

            return listStudentData;
        }


        public List<AddStudentData> dashboardGenData()
        {
            List<AddStudentData> listData = new List<AddStudentData>();

            if(conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    DateTime today = DateTime.Today;

                    string sql = "SELECT * FROM students WHERE student_status = 'Enrolled' AND date_insert = @DateInsert AND date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@DateInsert", today.ToString());

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddStudentData addStudentData = new AddStudentData();

                            addStudentData.ID = (int)reader["id"];
                            addStudentData.StudentID = reader["student_id"].ToString();
                            addStudentData.StudentName = reader["student_name"].ToString();
                            addStudentData.StudentGender = reader["student_gender"].ToString();
                            addStudentData.StudentAddress = reader["student_address"].ToString();
                            addStudentData.StudentGrade = reader["student_grade"].ToString();
                            addStudentData.StudentSection = reader["student_section"].ToString();
                            addStudentData.StudentStatus = reader["student_status"].ToString();
                            addStudentData.StudentImage = reader["student_image"].ToString();
                            addStudentData.DateInsert = reader["date_insert"].ToString();

                            listData.Add(addStudentData);
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }finally { conn.Close(); }
            }

            return listData;
        }

    }
}
