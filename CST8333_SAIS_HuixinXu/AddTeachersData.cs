using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CST8333_SAIS_HuixinXu
{
    class AddTeachersData
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ris\source\repos\CST8333_SAIS_HuixinXu\CST8333_SAIS_HuixinXu\assets\SAIS_HuixinXu.mdf;Integrated Security=True;Connect Timeout=30");

        public int ID {  get; set; }
        public string TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherGender { get; set; }
        public string TeacherAddress { get; set; }
        public string TeacherImage { get; set; }
        public string TeacherStatus { get; set; }
        public string DateInsert { get; set; }
        

        public List<AddTeachersData> teacherData()
        {
            List<AddTeachersData> listTeachersData = new List<AddTeachersData>();
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT * FROM teachers WHERE date_delete IS NULL";
                    using(SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddTeachersData addTeachersData = new AddTeachersData();

                            addTeachersData.ID = (int)reader["id"];
                            addTeachersData.TeacherID = reader["teacher_id"].ToString();
                            addTeachersData.TeacherName = reader["teacher_name"].ToString();
                            addTeachersData.TeacherGender = reader["teacher_gender"].ToString();
                            addTeachersData.TeacherAddress = reader["teacher_address"].ToString();
                            addTeachersData.TeacherImage = reader["teacher_image"].ToString();
                            addTeachersData.TeacherStatus = reader["teacher_status"].ToString();
                            addTeachersData.DateInsert = reader["date_insert"].ToString();

                            listTeachersData.Add(addTeachersData);
                        }
                        reader.Close();

                    }
                }catch (Exception ex)
                {
                    Console.WriteLine("Error connecting database: " + ex);
                }finally { conn.Close(); }
            }

            return listTeachersData;
        }
    }
}
