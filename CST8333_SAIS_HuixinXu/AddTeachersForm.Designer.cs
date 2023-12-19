namespace CST8333_SAIS_HuixinXu
{
    partial class AddTeachersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.teacherPic = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacherID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacher_gridData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.teacherPic);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.AddBtn);
            this.panel2.Controls.Add(this.ImportBtn);
            this.panel2.Controls.Add(this.status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.address);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.teacherName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.teacherID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(21, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 348);
            this.panel2.TabIndex = 3;
            // 
            // teacherPic
            // 
            this.teacherPic.Location = new System.Drawing.Point(1088, 18);
            this.teacherPic.Name = "teacherPic";
            this.teacherPic.Size = new System.Drawing.Size(128, 128);
            this.teacherPic.TabIndex = 18;
            this.teacherPic.TabStop = false;
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
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(227, 259);
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
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status.Location = new System.Drawing.Point(886, 15);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(121, 28);
            this.status.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(768, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Status";
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
            // teacherName
            // 
            this.teacherName.Location = new System.Drawing.Point(141, 83);
            this.teacherName.Multiline = true;
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(195, 28);
            this.teacherName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher Name";
            // 
            // teacherID
            // 
            this.teacherID.Location = new System.Drawing.Point(141, 15);
            this.teacherID.Multiline = true;
            this.teacherID.Name = "teacherID";
            this.teacherID.Size = new System.Drawing.Size(195, 28);
            this.teacherID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teacher ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.teacher_gridData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(21, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 338);
            this.panel1.TabIndex = 2;
            // 
            // teacher_gridData
            // 
            this.teacher_gridData.AllowUserToAddRows = false;
            this.teacher_gridData.AllowUserToDeleteRows = false;
            this.teacher_gridData.AllowUserToResizeRows = false;
            this.teacher_gridData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.teacher_gridData.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacher_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.teacher_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacher_gridData.EnableHeadersVisualStyles = false;
            this.teacher_gridData.Location = new System.Drawing.Point(23, 65);
            this.teacher_gridData.Name = "teacher_gridData";
            this.teacher_gridData.ReadOnly = true;
            this.teacher_gridData.RowHeadersVisible = false;
            this.teacher_gridData.RowHeadersWidth = 62;
            this.teacher_gridData.RowTemplate.Height = 28;
            this.teacher_gridData.Size = new System.Drawing.Size(1211, 251);
            this.teacher_gridData.TabIndex = 2;
            this.teacher_gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacher_gridData_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Data";
            // 
            // AddTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddTeachersForm";
            this.Size = new System.Drawing.Size(1303, 738);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacherID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView teacher_gridData;
        private System.Windows.Forms.PictureBox teacherPic;
    }
}
