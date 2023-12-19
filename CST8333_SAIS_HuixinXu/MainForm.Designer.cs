namespace CST8333_SAIS_HuixinXu
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.AddInstructor = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dashboardForm1 = new CST8333_SAIS_HuixinXu.DashboardForm();
            this.addStudentsForm1 = new CST8333_SAIS_HuixinXu.AddStudentsForm();
            this.addTeachersForm1 = new CST8333_SAIS_HuixinXu.AddTeachersForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 30);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exitBtn
            // 
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(1573, 1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(22, 24);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "x";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "School Administration Info System | Main";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Logout);
            this.panel2.Controls.Add(this.AddInstructor);
            this.panel2.Controls.Add(this.AddStudent);
            this.panel2.Controls.Add(this.Dashboard);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 770);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.Location = new System.Drawing.Point(109, 633);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(71, 63);
            this.Logout.TabIndex = 5;
            this.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout.UseCompatibleTextRendering = true;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AddInstructor
            // 
            this.AddInstructor.AutoSize = true;
            this.AddInstructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddInstructor.FlatAppearance.BorderSize = 2;
            this.AddInstructor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddInstructor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInstructor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInstructor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AddInstructor.Image = ((System.Drawing.Image)(resources.GetObject("AddInstructor.Image")));
            this.AddInstructor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddInstructor.Location = new System.Drawing.Point(32, 501);
            this.AddInstructor.Name = "AddInstructor";
            this.AddInstructor.Size = new System.Drawing.Size(241, 70);
            this.AddInstructor.TabIndex = 4;
            this.AddInstructor.Text = "Add Instructor";
            this.AddInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddInstructor.UseVisualStyleBackColor = true;
            this.AddInstructor.Click += new System.EventHandler(this.AddInstructor_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.AutoSize = true;
            this.AddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudent.FlatAppearance.BorderSize = 2;
            this.AddStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudent.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AddStudent.Image = ((System.Drawing.Image)(resources.GetObject("AddStudent.Image")));
            this.AddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStudent.Location = new System.Drawing.Point(32, 397);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(241, 70);
            this.AddStudent.TabIndex = 3;
            this.AddStudent.Text = "Add Student";
            this.AddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard.FlatAppearance.BorderSize = 2;
            this.Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.Image")));
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(32, 292);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(241, 70);
            this.Dashboard.TabIndex = 2;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, admin!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardForm1.Location = new System.Drawing.Point(298, 30);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1302, 770);
            this.dashboardForm1.TabIndex = 4;
            // 
            // addStudentsForm1
            // 
            this.addStudentsForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStudentsForm1.Location = new System.Drawing.Point(298, 30);
            this.addStudentsForm1.Name = "addStudentsForm1";
            this.addStudentsForm1.Size = new System.Drawing.Size(1302, 770);
            this.addStudentsForm1.TabIndex = 3;
            // 
            // addTeachersForm1
            // 
            this.addTeachersForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTeachersForm1.Location = new System.Drawing.Point(298, 30);
            this.addTeachersForm1.Name = "addTeachersForm1";
            this.addTeachersForm1.Size = new System.Drawing.Size(1302, 770);
            this.addTeachersForm1.TabIndex = 2;
            this.addTeachersForm1.Load += new System.EventHandler(this.addTeachersForm1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.dashboardForm1);
            this.Controls.Add(this.addStudentsForm1);
            this.Controls.Add(this.addTeachersForm1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1600, 800);
            this.MinimumSize = new System.Drawing.Size(1600, 800);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button AddInstructor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exitBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AddTeachersForm addTeachersForm1;
        private AddStudentsForm addStudentsForm1;
        private DashboardForm dashboardForm1;
    }
}