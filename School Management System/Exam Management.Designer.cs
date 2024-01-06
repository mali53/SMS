namespace School_Management_System
{
    partial class Exam_Management
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
            this.btn_mg_exdelete = new System.Windows.Forms.Button();
            this.btn_mg_exupdate = new System.Windows.Forms.Button();
            this.btn_mg_exsubmit = new System.Windows.Forms.Button();
            this.dt_mg_exdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mg_exninvigilatorname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mg_exname = new System.Windows.Forms.TextBox();
            this.txt_mg_exid = new System.Windows.Forms.TextBox();
            this.dt_mg_extsearchdate = new System.Windows.Forms.DateTimePicker();
            this.dt_mg_extime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_Exam = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_mg_std_grade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Exam)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mg_exdelete
            // 
            this.btn_mg_exdelete.BackColor = System.Drawing.Color.Red;
            this.btn_mg_exdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mg_exdelete.ForeColor = System.Drawing.Color.White;
            this.btn_mg_exdelete.Location = new System.Drawing.Point(660, 212);
            this.btn_mg_exdelete.Name = "btn_mg_exdelete";
            this.btn_mg_exdelete.Size = new System.Drawing.Size(96, 39);
            this.btn_mg_exdelete.TabIndex = 81;
            this.btn_mg_exdelete.Text = "Delete";
            this.btn_mg_exdelete.UseVisualStyleBackColor = false;
            this.btn_mg_exdelete.Click += new System.EventHandler(this.btn_mg_exdelete_Click);
            // 
            // btn_mg_exupdate
            // 
            this.btn_mg_exupdate.BackColor = System.Drawing.Color.Orange;
            this.btn_mg_exupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mg_exupdate.Location = new System.Drawing.Point(544, 212);
            this.btn_mg_exupdate.Name = "btn_mg_exupdate";
            this.btn_mg_exupdate.Size = new System.Drawing.Size(96, 39);
            this.btn_mg_exupdate.TabIndex = 80;
            this.btn_mg_exupdate.Text = "Update";
            this.btn_mg_exupdate.UseVisualStyleBackColor = false;
            this.btn_mg_exupdate.Click += new System.EventHandler(this.btn_mg_exupdate_Click);
            // 
            // btn_mg_exsubmit
            // 
            this.btn_mg_exsubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_mg_exsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mg_exsubmit.ForeColor = System.Drawing.Color.White;
            this.btn_mg_exsubmit.Location = new System.Drawing.Point(428, 212);
            this.btn_mg_exsubmit.Name = "btn_mg_exsubmit";
            this.btn_mg_exsubmit.Size = new System.Drawing.Size(96, 39);
            this.btn_mg_exsubmit.TabIndex = 79;
            this.btn_mg_exsubmit.Text = "Submit";
            this.btn_mg_exsubmit.UseVisualStyleBackColor = false;
            this.btn_mg_exsubmit.Click += new System.EventHandler(this.btn_mg_exsubmit_Click);
            // 
            // dt_mg_exdate
            // 
            this.dt_mg_exdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_mg_exdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_mg_exdate.Location = new System.Drawing.Point(175, 154);
            this.dt_mg_exdate.Name = "dt_mg_exdate";
            this.dt_mg_exdate.Size = new System.Drawing.Size(202, 28);
            this.dt_mg_exdate.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 22);
            this.label5.TabIndex = 72;
            this.label5.Text = "Name of Invigilator";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 71;
            this.label7.Text = "Exam Time";
            // 
            // txt_mg_exninvigilatorname
            // 
            this.txt_mg_exninvigilatorname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mg_exninvigilatorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mg_exninvigilatorname.Location = new System.Drawing.Point(217, 244);
            this.txt_mg_exninvigilatorname.Name = "txt_mg_exninvigilatorname";
            this.txt_mg_exninvigilatorname.Size = new System.Drawing.Size(160, 28);
            this.txt_mg_exninvigilatorname.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 68;
            this.label4.Text = "Exam Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 67;
            this.label3.Text = "Exam Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 66;
            this.label2.Text = "Exam ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_mg_exname
            // 
            this.txt_mg_exname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mg_exname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mg_exname.Location = new System.Drawing.Point(175, 110);
            this.txt_mg_exname.Name = "txt_mg_exname";
            this.txt_mg_exname.Size = new System.Drawing.Size(202, 28);
            this.txt_mg_exname.TabIndex = 65;
            // 
            // txt_mg_exid
            // 
            this.txt_mg_exid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mg_exid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mg_exid.Location = new System.Drawing.Point(554, 110);
            this.txt_mg_exid.Name = "txt_mg_exid";
            this.txt_mg_exid.ReadOnly = true;
            this.txt_mg_exid.Size = new System.Drawing.Size(202, 28);
            this.txt_mg_exid.TabIndex = 64;
            this.txt_mg_exid.TextChanged += new System.EventHandler(this.txt_mg_exid_TextChanged);
            // 
            // dt_mg_extsearchdate
            // 
            this.dt_mg_extsearchdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_mg_extsearchdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_mg_extsearchdate.Location = new System.Drawing.Point(577, 158);
            this.dt_mg_extsearchdate.Name = "dt_mg_extsearchdate";
            this.dt_mg_extsearchdate.Size = new System.Drawing.Size(179, 28);
            this.dt_mg_extsearchdate.TabIndex = 83;
            this.dt_mg_extsearchdate.ValueChanged += new System.EventHandler(this.dt_mg_extsearchdate_ValueChanged);
            // 
            // dt_mg_extime
            // 
            this.dt_mg_extime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_mg_extime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_mg_extime.Location = new System.Drawing.Point(175, 196);
            this.dt_mg_extime.Name = "dt_mg_extime";
            this.dt_mg_extime.Size = new System.Drawing.Size(202, 28);
            this.dt_mg_extime.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 85;
            this.label1.Text = "Search By Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGrid_Exam
            // 
            this.dataGrid_Exam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Exam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGrid_Exam.Location = new System.Drawing.Point(35, 332);
            this.dataGrid_Exam.Name = "dataGrid_Exam";
            this.dataGrid_Exam.ReadOnly = true;
            this.dataGrid_Exam.RowHeadersWidth = 51;
            this.dataGrid_Exam.RowTemplate.Height = 24;
            this.dataGrid_Exam.Size = new System.Drawing.Size(728, 338);
            this.dataGrid_Exam.TabIndex = 86;
            this.dataGrid_Exam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Exam_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Exam ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Exam Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Exam Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Exam Time";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Name of Invigilator";
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
            // cmb_mg_std_grade
            // 
            this.cmb_mg_std_grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mg_std_grade.FormattingEnabled = true;
            this.cmb_mg_std_grade.Items.AddRange(new object[] {
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
            this.cmb_mg_std_grade.Location = new System.Drawing.Point(175, 287);
            this.cmb_mg_std_grade.Name = "cmb_mg_std_grade";
            this.cmb_mg_std_grade.Size = new System.Drawing.Size(202, 30);
            this.cmb_mg_std_grade.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 105;
            this.label6.Text = "Grade";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(428, 270);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(328, 39);
            this.btn_clear.TabIndex = 107;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Exam_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 710);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cmb_mg_std_grade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGrid_Exam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_mg_extime);
            this.Controls.Add(this.dt_mg_extsearchdate);
            this.Controls.Add(this.btn_mg_exdelete);
            this.Controls.Add(this.btn_mg_exupdate);
            this.Controls.Add(this.btn_mg_exsubmit);
            this.Controls.Add(this.dt_mg_exdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_mg_exninvigilatorname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mg_exname);
            this.Controls.Add(this.txt_mg_exid);
            this.Name = "Exam_Management";
            this.Text = "Exam_Management";
            this.Load += new System.EventHandler(this.Exam_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Exam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_mg_exdelete;
        private System.Windows.Forms.Button btn_mg_exupdate;
        private System.Windows.Forms.Button btn_mg_exsubmit;
        private System.Windows.Forms.DateTimePicker dt_mg_exdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mg_exninvigilatorname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mg_exname;
        private System.Windows.Forms.TextBox txt_mg_exid;
        private System.Windows.Forms.DateTimePicker dt_mg_extsearchdate;
        private System.Windows.Forms.DateTimePicker dt_mg_extime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_Exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cmb_mg_std_grade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_clear;
    }
}