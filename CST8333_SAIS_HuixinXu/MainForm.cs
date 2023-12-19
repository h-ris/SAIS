using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST8333_SAIS_HuixinXu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            /*this.StartPosition = FormStartPosition.Manual;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;*/
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.displayEnrolledStudentToday();
            dashboardForm.displayTotalEnrollStd();
            dashboardForm.displayTotalTeacher();
            dashboardForm.displayTotalGradStd();
            dashboardForm.Update();

            dashboardForm1.Visible = true;
            dashboardForm1.Update();
            addStudentsForm1.Visible = false;
            addTeachersForm1.Visible = false;
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addStudentsForm1.Visible = true;
            addStudentsForm1.Update();
            addTeachersForm1.Visible = false;
        }

        private void AddInstructor_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addStudentsForm1.Visible = false;
            addTeachersForm1.Visible = true;
            addTeachersForm1.Update();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*this.StartPosition = FormStartPosition.Manual;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addTeachersForm1_Load(object sender, EventArgs e)
        {

        }

    }
}