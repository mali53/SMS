namespace School_Management_System
{
    partial class View_Paid_Students
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
            this.dataGrid_view_pd_std = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_view_stdid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_mg_fesearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_view_pd_std)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_view_pd_std
            // 
            this.dataGrid_view_pd_std.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.dataGrid_view_pd_std.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_view_pd_std.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_view_pd_std.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGrid_view_pd_std.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGrid_view_pd_std.Location = new System.Drawing.Point(26, 141);
            this.dataGrid_view_pd_std.Name = "dataGrid_view_pd_std";
            this.dataGrid_view_pd_std.ReadOnly = true;
            this.dataGrid_view_pd_std.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid_view_pd_std.RowHeadersVisible = false;
            this.dataGrid_view_pd_std.RowHeadersWidth = 51;
            this.dataGrid_view_pd_std.RowTemplate.Height = 24;
            this.dataGrid_view_pd_std.Size = new System.Drawing.Size(851, 354);
            this.dataGrid_view_pd_std.TabIndex = 105;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Student ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Student Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fee Type";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Payment Status";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amount";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Payment Date";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 104;
            this.label2.Text = "Student ID";
            // 
            // txt_view_stdid
            // 
            this.txt_view_stdid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_view_stdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_view_stdid.Location = new System.Drawing.Point(327, 12);
            this.txt_view_stdid.Name = "txt_view_stdid";
            this.txt_view_stdid.Size = new System.Drawing.Size(194, 28);
            this.txt_view_stdid.TabIndex = 103;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_mg_fesearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_view_stdid);
            this.groupBox1.Location = new System.Drawing.Point(24, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 56);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            // 
            // btn_mg_fesearch
            // 
            this.btn_mg_fesearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_mg_fesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mg_fesearch.Location = new System.Drawing.Point(527, 6);
            this.btn_mg_fesearch.Name = "btn_mg_fesearch";
            this.btn_mg_fesearch.Size = new System.Drawing.Size(118, 39);
            this.btn_mg_fesearch.TabIndex = 105;
            this.btn_mg_fesearch.Text = "Search";
            this.btn_mg_fesearch.UseVisualStyleBackColor = false;
            this.btn_mg_fesearch.Click += new System.EventHandler(this.btn_mg_fesearch_Click);
            // 
            // View_Paid_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid_view_pd_std);
            this.Name = "View_Paid_Students";
            this.Text = "View Paid Students";
            this.Load += new System.EventHandler(this.View_Paid_Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_view_pd_std)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_view_pd_std;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_view_stdid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_mg_fesearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}