namespace School_Management_System
{
    partial class StudentGrading
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
            this.labelstudentID = new System.Windows.Forms.Label();
            this.labelstudentname = new System.Windows.Forms.Label();
            this.label2subject = new System.Windows.Forms.Label();
            this.label3grade = new System.Windows.Forms.Label();
            this.label4marks = new System.Windows.Forms.Label();
            this.textBox1namestu = new System.Windows.Forms.TextBox();
            this.textBox2subject = new System.Windows.Forms.TextBox();
            this.textBoxmarks = new System.Windows.Forms.TextBox();
            this.textBox4grade = new System.Windows.Forms.TextBox();
            this.button1addgrading = new System.Windows.Forms.Button();
            this.comboBoxstuid = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelstudentID
            // 
            this.labelstudentID.AutoSize = true;
            this.labelstudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstudentID.Location = new System.Drawing.Point(31, 77);
            this.labelstudentID.Name = "labelstudentID";
            this.labelstudentID.Size = new System.Drawing.Size(94, 22);
            this.labelstudentID.TabIndex = 90;
            this.labelstudentID.Text = "Student ID";
            // 
            // labelstudentname
            // 
            this.labelstudentname.AutoSize = true;
            this.labelstudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstudentname.Location = new System.Drawing.Point(31, 140);
            this.labelstudentname.Name = "labelstudentname";
            this.labelstudentname.Size = new System.Drawing.Size(124, 22);
            this.labelstudentname.TabIndex = 91;
            this.labelstudentname.Text = "Student Name";
            // 
            // label2subject
            // 
            this.label2subject.AutoSize = true;
            this.label2subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2subject.Location = new System.Drawing.Point(31, 206);
            this.label2subject.Name = "label2subject";
            this.label2subject.Size = new System.Drawing.Size(70, 22);
            this.label2subject.TabIndex = 92;
            this.label2subject.Text = "Subject";
            // 
            // label3grade
            // 
            this.label3grade.AutoSize = true;
            this.label3grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3grade.Location = new System.Drawing.Point(31, 340);
            this.label3grade.Name = "label3grade";
            this.label3grade.Size = new System.Drawing.Size(60, 22);
            this.label3grade.TabIndex = 93;
            this.label3grade.Text = "Grade";
            // 
            // label4marks
            // 
            this.label4marks.AutoSize = true;
            this.label4marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4marks.Location = new System.Drawing.Point(31, 274);
            this.label4marks.Name = "label4marks";
            this.label4marks.Size = new System.Drawing.Size(58, 22);
            this.label4marks.TabIndex = 94;
            this.label4marks.Text = "Marks";
            // 
            // textBox1namestu
            // 
            this.textBox1namestu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1namestu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1namestu.Location = new System.Drawing.Point(227, 140);
            this.textBox1namestu.Name = "textBox1namestu";
            this.textBox1namestu.Size = new System.Drawing.Size(202, 28);
            this.textBox1namestu.TabIndex = 96;
            // 
            // textBox2subject
            // 
            this.textBox2subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2subject.Location = new System.Drawing.Point(227, 200);
            this.textBox2subject.Name = "textBox2subject";
            this.textBox2subject.Size = new System.Drawing.Size(202, 28);
            this.textBox2subject.TabIndex = 97;
            // 
            // textBoxmarks
            // 
            this.textBoxmarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxmarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmarks.Location = new System.Drawing.Point(227, 274);
            this.textBoxmarks.Name = "textBoxmarks";
            this.textBoxmarks.Size = new System.Drawing.Size(202, 28);
            this.textBoxmarks.TabIndex = 98;
            this.textBoxmarks.TextChanged += new System.EventHandler(this.textBoxmarks_TextChanged);
            // 
            // textBox4grade
            // 
            this.textBox4grade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4grade.Location = new System.Drawing.Point(227, 340);
            this.textBox4grade.Name = "textBox4grade";
            this.textBox4grade.Size = new System.Drawing.Size(202, 28);
            this.textBox4grade.TabIndex = 99;
            // 
            // button1addgrading
            // 
            this.button1addgrading.BackColor = System.Drawing.Color.LimeGreen;
            this.button1addgrading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1addgrading.ForeColor = System.Drawing.Color.White;
            this.button1addgrading.Location = new System.Drawing.Point(183, 443);
            this.button1addgrading.Name = "button1addgrading";
            this.button1addgrading.Size = new System.Drawing.Size(96, 39);
            this.button1addgrading.TabIndex = 100;
            this.button1addgrading.Text = "Add";
            this.button1addgrading.UseVisualStyleBackColor = false;
            this.button1addgrading.Click += new System.EventHandler(this.button1addgrading_Click);
            // 
            // comboBoxstuid
            // 
            this.comboBoxstuid.FormattingEnabled = true;
            this.comboBoxstuid.Location = new System.Drawing.Point(227, 74);
            this.comboBoxstuid.Name = "comboBoxstuid";
            this.comboBoxstuid.Size = new System.Drawing.Size(202, 24);
            this.comboBoxstuid.TabIndex = 101;
            // 
            // StudentGrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 542);
            this.Controls.Add(this.comboBoxstuid);
            this.Controls.Add(this.button1addgrading);
            this.Controls.Add(this.textBox4grade);
            this.Controls.Add(this.textBoxmarks);
            this.Controls.Add(this.textBox2subject);
            this.Controls.Add(this.textBox1namestu);
            this.Controls.Add(this.label4marks);
            this.Controls.Add(this.label3grade);
            this.Controls.Add(this.label2subject);
            this.Controls.Add(this.labelstudentname);
            this.Controls.Add(this.labelstudentID);
            this.Name = "StudentGrading";
            this.Text = "Student Grading";
            this.Load += new System.EventHandler(this.StudentGrading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelstudentID;
        private System.Windows.Forms.Label labelstudentname;
        private System.Windows.Forms.Label label2subject;
        private System.Windows.Forms.Label label3grade;
        private System.Windows.Forms.Label label4marks;
        private System.Windows.Forms.TextBox textBox1namestu;
        private System.Windows.Forms.TextBox textBox2subject;
        private System.Windows.Forms.TextBox textBoxmarks;
        private System.Windows.Forms.TextBox textBox4grade;
        private System.Windows.Forms.Button button1addgrading;
        private System.Windows.Forms.ComboBox comboBoxstuid;
    }
}