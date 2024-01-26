namespace School_Management_System
{
    partial class Leave_Apply_Form
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lv_lecname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lv_lvid = new System.Windows.Forms.TextBox();
            this.dt_lv_lvdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lv_reason = new System.Windows.Forms.TextBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.datagrid_leave = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_leave)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 64;
            this.label3.Text = "Leave Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 63;
            this.label2.Text = "Lecturer Name";
            // 
            // txt_lv_lecname
            // 
            this.txt_lv_lecname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lv_lecname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lv_lecname.Location = new System.Drawing.Point(191, 160);
            this.txt_lv_lecname.Name = "txt_lv_lecname";
            this.txt_lv_lecname.Size = new System.Drawing.Size(190, 28);
            this.txt_lv_lecname.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "Leave ID";
            // 
            // txt_lv_lvid
            // 
            this.txt_lv_lvid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lv_lvid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lv_lvid.Location = new System.Drawing.Point(179, 110);
            this.txt_lv_lvid.Name = "txt_lv_lvid";
            this.txt_lv_lvid.ReadOnly = true;
            this.txt_lv_lvid.Size = new System.Drawing.Size(202, 28);
            this.txt_lv_lvid.TabIndex = 60;
            // 
            // dt_lv_lvdate
            // 
            this.dt_lv_lvdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_lv_lvdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_lv_lvdate.Location = new System.Drawing.Point(584, 112);
            this.dt_lv_lvdate.Name = "dt_lv_lvdate";
            this.dt_lv_lvdate.Size = new System.Drawing.Size(172, 28);
            this.dt_lv_lvdate.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 67;
            this.label4.Text = "Reason";
            // 
            // txt_lv_reason
            // 
            this.txt_lv_reason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lv_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lv_reason.Location = new System.Drawing.Point(554, 160);
            this.txt_lv_reason.Name = "txt_lv_reason";
            this.txt_lv_reason.Size = new System.Drawing.Size(202, 28);
            this.txt_lv_reason.TabIndex = 66;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(353, 213);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(85, 36);
            this.materialFlatButton1.TabIndex = 68;
            this.materialFlatButton1.Text = "Submit";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // datagrid_leave
            // 
            this.datagrid_leave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_leave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_leave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.datagrid_leave.Location = new System.Drawing.Point(48, 277);
            this.datagrid_leave.Name = "datagrid_leave";
            this.datagrid_leave.ReadOnly = true;
            this.datagrid_leave.RowHeadersVisible = false;
            this.datagrid_leave.RowHeadersWidth = 51;
            this.datagrid_leave.RowTemplate.Height = 24;
            this.datagrid_leave.Size = new System.Drawing.Size(707, 343);
            this.datagrid_leave.TabIndex = 69;
            this.datagrid_leave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_leave_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Leave ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Lecturer Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Leave Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Reason";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Leave_Apply_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.datagrid_leave);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_lv_reason);
            this.Controls.Add(this.dt_lv_lvdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_lv_lecname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_lv_lvid);
            this.Name = "Leave_Apply_Form";
            this.Text = "Leave Apply Form";
            this.Load += new System.EventHandler(this.Leave_Apply_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_leave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lv_lecname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lv_lvid;
        private System.Windows.Forms.DateTimePicker dt_lv_lvdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_lv_reason;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataGridView datagrid_leave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}