namespace CST8333_SAIS_HuixinXu
{
    partial class StartPage
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
            this.components = new System.ComponentModel.Container();
            this.SAIS_txt = new System.Windows.Forms.Label();
            this.schoolPic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.author = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SAIS_txt
            // 
            this.SAIS_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SAIS_txt.AutoSize = true;
            this.SAIS_txt.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAIS_txt.ForeColor = System.Drawing.Color.White;
            this.SAIS_txt.Location = new System.Drawing.Point(82, 163);
            this.SAIS_txt.Name = "SAIS_txt";
            this.SAIS_txt.Size = new System.Drawing.Size(355, 23);
            this.SAIS_txt.TabIndex = 0;
            this.SAIS_txt.Text = "School Administration Info System";
            this.SAIS_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SAIS_txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // schoolPic
            // 
            this.schoolPic.Image = global::CST8333_SAIS_HuixinXu.Properties.Resources.school1;
            this.schoolPic.Location = new System.Drawing.Point(225, 57);
            this.schoolPic.Name = "schoolPic";
            this.schoolPic.Size = new System.Drawing.Size(80, 80);
            this.schoolPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.schoolPic.TabIndex = 1;
            this.schoolPic.TabStop = false;
            this.schoolPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 20);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 20);
            this.panel2.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Microsoft Tai Le", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.author.Location = new System.Drawing.Point(352, 261);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(161, 16);
            this.author.TabIndex = 3;
            this.author.Text = "Author: Huixin Xu@Nov 2023";
            this.author.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(525, 300);
            this.Controls.Add(this.author);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.schoolPic);
            this.Controls.Add(this.SAIS_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SAIS_txt;
        private System.Windows.Forms.PictureBox schoolPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label author;
    }
}

