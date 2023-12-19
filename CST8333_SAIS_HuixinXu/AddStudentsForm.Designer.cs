namespace CST8333_SAIS_HuixinXu
{
    partial class AddStudentsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.studentPic = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.section = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.student_gridData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.status);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.studentPic);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.AddBtn);
            this.panel2.Controls.Add(this.ImportBtn);
            this.panel2.Controls.Add(this.section);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.grade);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.address);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.studentName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.studentID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(21, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 348);
            this.panel2.TabIndex = 3;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Enrolled",
            "Pending",
            "Graduated"});
            this.status.Location = new System.Drawing.Point(886, 86);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(121, 28);
            this.status.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(768, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Status";
            // 
            // studentPic
            // 
            this.studentPic.Location = new System.Drawing.Point(1088, 18);
            this.studentPic.Name = "studentPic";
            this.studentPic.Size = new System.Drawing.Size(128, 128);
            this.studentPic.TabIndex = 19;
            this.studentPic.TabStop = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(916, 259);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(128, 53);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click_1);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clearBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(690, 259);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(128, 53);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.updateBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(457, 259);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(128, 53);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click_1);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(229, 259);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(128, 53);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ImportBtn
            // 
            this.ImportBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ImportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.ImportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ImportBtn.ForeColor = System.Drawing.Color.White;
            this.ImportBtn.Location = new System.Drawing.Point(1088, 152);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(128, 32);
            this.ImportBtn.TabIndex = 13;
            this.ImportBtn.Text = "Import";
            this.ImportBtn.UseVisualStyleBackColor = false;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // section
            // 
            this.section.FormattingEnabled = true;
            this.section.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.section.Location = new System.Drawing.Point(886, 15);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(121, 28);
            this.section.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(768, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Section";
            // 
            // grade
            // 
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.grade.Location = new System.Drawing.Point(505, 155);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(121, 28);
            this.grade.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Grade";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(505, 15);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(195, 96);
            this.address.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address";
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.gender.Location = new System.Drawing.Point(141, 155);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 28);
            this.gender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(141, 83);
            this.studentName.Multiline = true;
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(195, 28);
            this.studentName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Name";
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(141, 15);
            this.studentID.Multiline = true;
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(195, 28);
            this.studentID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.student_gridData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(21, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 338);
            this.panel1.TabIndex = 2;
            // 
            // student_gridData
            // 
            this.student_gridData.AllowUserToAddRows = false;
            this.student_gridData.AllowUserToDeleteRows = false;
            this.student_gridData.AllowUserToResizeRows = false;
            this.student_gridData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.student_gridData.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.student_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.student_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_gridData.EnableHeadersVisualStyles = false;
            this.student_gridData.Location = new System.Drawing.Point(23, 62);
            this.student_gridData.Name = "student_gridData";
            this.student_gridData.ReadOnly = true;
            this.student_gridData.RowHeadersVisible = false;
            this.student_gridData.RowHeadersWidth = 62;
            this.student_gridData.RowTemplate.Height = 28;
            this.student_gridData.Size = new System.Drawing.Size(1211, 251);
            this.student_gridData.TabIndex = 1;
            this.student_gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_gridData_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Data";
            // 
            // AddStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudentsForm";
            this.Size = new System.Drawing.Size(1303, 738);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.ComboBox section;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView student_gridData;
        private System.Windows.Forms.PictureBox studentPic;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label8;
    }
}
