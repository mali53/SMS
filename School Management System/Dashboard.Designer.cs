namespace School_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btn_dash_Admin = new System.Windows.Forms.Button();
            this.btn_dash_student = new System.Windows.Forms.Button();
            this.btn_dash_lect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dash_Admin
            // 
            this.btn_dash_Admin.AccessibleName = "btn.admin";
            this.btn_dash_Admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dash_Admin.BackgroundImage")));
            this.btn_dash_Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_dash_Admin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_dash_Admin.FlatAppearance.BorderSize = 0;
            this.btn_dash_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dash_Admin.Location = new System.Drawing.Point(124, 107);
            this.btn_dash_Admin.Name = "btn_dash_Admin";
            this.btn_dash_Admin.Size = new System.Drawing.Size(147, 119);
            this.btn_dash_Admin.TabIndex = 1;
            this.btn_dash_Admin.UseVisualStyleBackColor = true;
            this.btn_dash_Admin.Click += new System.EventHandler(this.btn_dash_Admin_Click);
            // 
            // btn_dash_student
            // 
            this.btn_dash_student.AccessibleName = "btn.student";
            this.btn_dash_student.BackColor = System.Drawing.Color.Transparent;
            this.btn_dash_student.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dash_student.BackgroundImage")));
            this.btn_dash_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_dash_student.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_dash_student.FlatAppearance.BorderSize = 0;
            this.btn_dash_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dash_student.Location = new System.Drawing.Point(392, 107);
            this.btn_dash_student.Name = "btn_dash_student";
            this.btn_dash_student.Size = new System.Drawing.Size(147, 119);
            this.btn_dash_student.TabIndex = 2;
            this.btn_dash_student.UseVisualStyleBackColor = false;
            this.btn_dash_student.Click += new System.EventHandler(this.btn_dash_student_Click);
            // 
            // btn_dash_lect
            // 
            this.btn_dash_lect.AccessibleName = "btn.lecturer";
            this.btn_dash_lect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dash_lect.BackgroundImage")));
            this.btn_dash_lect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_dash_lect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_dash_lect.FlatAppearance.BorderSize = 0;
            this.btn_dash_lect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dash_lect.Location = new System.Drawing.Point(633, 107);
            this.btn_dash_lect.Name = "btn_dash_lect";
            this.btn_dash_lect.Size = new System.Drawing.Size(147, 119);
            this.btn_dash_lect.TabIndex = 3;
            this.btn_dash_lect.UseVisualStyleBackColor = true;
            this.btn_dash_lect.Click += new System.EventHandler(this.btn_dash_lect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Admin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(677, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lecturer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(929, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School_Management_System.Properties.Resources.vivid_blurred_colorful_background;
            this.ClientSize = new System.Drawing.Size(927, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_dash_lect);
            this.Controls.Add(this.btn_dash_student);
            this.Controls.Add(this.btn_dash_Admin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dashboard";
            this.Text = "TechCube School Management System";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_dash_Admin;
        private System.Windows.Forms.Button btn_dash_student;
        private System.Windows.Forms.Button btn_dash_lect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

