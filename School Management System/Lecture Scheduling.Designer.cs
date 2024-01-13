namespace School_Management_System
{
    partial class Lecture_Scheduling
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_grade = new System.Windows.Forms.ComboBox();
            this.dataGrid_Lecture = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_lectime = new System.Windows.Forms.DateTimePicker();
            this.dt_lecsearchdate = new System.Windows.Forms.DateTimePicker();
            this.btn_mg_exdelete = new System.Windows.Forms.Button();
            this.btn_mg_exupdate = new System.Windows.Forms.Button();
            this.btn_mg_exsubmit = new System.Windows.Forms.Button();
            this.dt_lecdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lecname = new System.Windows.Forms.TextBox();
            this.txt_lecid = new System.Windows.Forms.TextBox();
            this.cmb_lecturername = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Lecture)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 123;
            this.label6.Text = "Grade";
            // 
            // cmb_grade
            // 
            this.cmb_grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_grade.FormattingEnabled = true;
            this.cmb_grade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cmb_grade.Location = new System.Drawing.Point(167, 264);
            this.cmb_grade.Name = "cmb_grade";
            this.cmb_grade.Size = new System.Drawing.Size(202, 30);
            this.cmb_grade.TabIndex = 124;
            // 
            // dataGrid_Lecture
            // 
            this.dataGrid_Lecture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Lecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Lecture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGrid_Lecture.Location = new System.Drawing.Point(27, 309);
            this.dataGrid_Lecture.Name = "dataGrid_Lecture";
            this.dataGrid_Lecture.ReadOnly = true;
            this.dataGrid_Lecture.RowHeadersVisible = false;
            this.dataGrid_Lecture.RowHeadersWidth = 51;
            this.dataGrid_Lecture.RowTemplate.Height = 24;
            this.dataGrid_Lecture.Size = new System.Drawing.Size(728, 193);
            this.dataGrid_Lecture.TabIndex = 122;
            this.dataGrid_Lecture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Exam_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Lecture ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Lecture Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Lecture Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lecture Time";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Name of Lecturer";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Grade";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 121;
            this.label1.Text = "Search By Date";
            // 
            // dt_lectime
            // 
            this.dt_lectime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_lectime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_lectime.Location = new System.Drawing.Point(167, 173);
            this.dt_lectime.Name = "dt_lectime";
            this.dt_lectime.Size = new System.Drawing.Size(202, 28);
            this.dt_lectime.TabIndex = 120;
            // 
            // dt_lecsearchdate
            // 
            this.dt_lecsearchdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_lecsearchdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_lecsearchdate.Location = new System.Drawing.Point(569, 135);
            this.dt_lecsearchdate.Name = "dt_lecsearchdate";
            this.dt_lecsearchdate.Size = new System.Drawing.Size(179, 28);
            this.dt_lecsearchdate.TabIndex = 119;
            // 
            // btn_mg_exdelete
            // 
            this.btn_mg_exdelete.BackColor = System.Drawing.Color.Red;
            this.btn_mg_exdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mg_exdelete.ForeColor = System.Drawing.Color.White;
            this.btn_mg_exdelete.Location = new System.Drawing.Point(652, 189);
            this.btn_mg_exdelete.Name = "btn_mg_exdelete";
            this.btn_mg_exdelete.Size = new System.Drawing.Size(96, 39);
            this.btn_mg_exdelete.TabIndex = 118;
            this.btn_mg_exdelete.Text = "Delete";
            this.btn_mg_exdelete.UseVisualStyleBackColor = false;
            this.btn_mg_exdelete.Click += new System.EventHandler(this.btn_mg_exdelete_Click);
            // 
            // btn_mg_exupdate
            // 
            this.btn_mg_exupdate.BackColor = System.Drawing.Color.Orange;
            this.btn_mg_exupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mg_exupdate.Location = new System.Drawing.Point(536, 189);
            this.btn_mg_exupdate.Name = "btn_mg_exupdate";
            this.btn_mg_exupdate.Size = new System.Drawing.Size(96, 39);
            this.btn_mg_exupdate.TabIndex = 117;
            this.btn_mg_exupdate.Text = "Update";
            this.btn_mg_exupdate.UseVisualStyleBackColor = false;
            this.btn_mg_exupdate.Click += new System.EventHandler(this.btn_mg_exupdate_Click);
            // 
            // btn_mg_exsubmit
            // 
            this.btn_mg_exsubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_mg_exsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mg_exsubmit.ForeColor = System.Drawing.Color.White;
            this.btn_mg_exsubmit.Location = new System.Drawing.Point(420, 189);
            this.btn_mg_exsubmit.Name = "btn_mg_exsubmit";
            this.btn_mg_exsubmit.Size = new System.Drawing.Size(96, 39);
            this.btn_mg_exsubmit.TabIndex = 116;
            this.btn_mg_exsubmit.Text = "Submit";
            this.btn_mg_exsubmit.UseVisualStyleBackColor = false;
            this.btn_mg_exsubmit.Click += new System.EventHandler(this.btn_mg_exsubmit_Click);
            // 
            // dt_lecdate
            // 
            this.dt_lecdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_lecdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_lecdate.Location = new System.Drawing.Point(167, 131);
            this.dt_lecdate.Name = "dt_lecdate";
            this.dt_lecdate.Size = new System.Drawing.Size(202, 28);
            this.dt_lecdate.TabIndex = 115;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 114;
            this.label5.Text = "Name of Lecturer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 22);
            this.label7.TabIndex = 113;
            this.label7.Text = "Lecture Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 111;
            this.label4.Text = "Lecture Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 110;
            this.label3.Text = "Lecture Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 109;
            this.label2.Text = "Lecture ID";
            // 
            // txt_lecname
            // 
            this.txt_lecname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lecname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lecname.Location = new System.Drawing.Point(167, 87);
            this.txt_lecname.Name = "txt_lecname";
            this.txt_lecname.Size = new System.Drawing.Size(202, 28);
            this.txt_lecname.TabIndex = 108;
            // 
            // txt_lecid
            // 
            this.txt_lecid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lecid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lecid.Location = new System.Drawing.Point(546, 87);
            this.txt_lecid.Name = "txt_lecid";
            this.txt_lecid.ReadOnly = true;
            this.txt_lecid.Size = new System.Drawing.Size(202, 28);
            this.txt_lecid.TabIndex = 107;
            // 
            // cmb_lecturername
            // 
            this.cmb_lecturername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_lecturername.FormattingEnabled = true;
            this.cmb_lecturername.Location = new System.Drawing.Point(195, 220);
            this.cmb_lecturername.Name = "cmb_lecturername";
            this.cmb_lecturername.Size = new System.Drawing.Size(174, 30);
            this.cmb_lecturername.TabIndex = 125;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Tan;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(420, 247);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(328, 39);
            this.btn_clear.TabIndex = 126;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Lecture_Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 531);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cmb_lecturername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_grade);
            this.Controls.Add(this.dataGrid_Lecture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_lectime);
            this.Controls.Add(this.dt_lecsearchdate);
            this.Controls.Add(this.btn_mg_exdelete);
            this.Controls.Add(this.btn_mg_exupdate);
            this.Controls.Add(this.btn_mg_exsubmit);
            this.Controls.Add(this.dt_lecdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_lecname);
            this.Controls.Add(this.txt_lecid);
            this.Name = "Lecture_Scheduling";
            this.Text = "Lecture Scheduling";
            this.Load += new System.EventHandler(this.Lecture_Scheduling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Lecture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_grade;
        private System.Windows.Forms.DataGridView dataGrid_Lecture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_lectime;
        private System.Windows.Forms.DateTimePicker dt_lecsearchdate;
        private System.Windows.Forms.Button btn_mg_exdelete;
        private System.Windows.Forms.Button btn_mg_exupdate;
        private System.Windows.Forms.Button btn_mg_exsubmit;
        private System.Windows.Forms.DateTimePicker dt_lecdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lecname;
        private System.Windows.Forms.TextBox txt_lecid;
        private System.Windows.Forms.ComboBox cmb_lecturername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_clear;
    }
}