namespace School_Management_System
{
    partial class Inventory_Management
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
            this.dataGrid_inventory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_mg_invtdelete = new System.Windows.Forms.Button();
            this.btn_mg_invtupdate = new System.Windows.Forms.Button();
            this.btn_mg_invtadd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mg_invtqty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mg_invtgrade = new System.Windows.Forms.TextBox();
            this.txt_mg_invtclsid = new System.Windows.Forms.TextBox();
            this.cmb_mg_invtequiptype = new System.Windows.Forms.ComboBox();
            this.txt_mg_invtclsname = new System.Windows.Forms.TextBox();
            this.inReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_inventory
            // 
            this.dataGrid_inventory.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.dataGrid_inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGrid_inventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGrid_inventory.Location = new System.Drawing.Point(29, 282);
            this.dataGrid_inventory.Name = "dataGrid_inventory";
            this.dataGrid_inventory.ReadOnly = true;
            this.dataGrid_inventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid_inventory.RowHeadersVisible = false;
            this.dataGrid_inventory.RowHeadersWidth = 51;
            this.dataGrid_inventory.RowTemplate.Height = 24;
            this.dataGrid_inventory.Size = new System.Drawing.Size(743, 351);
            this.dataGrid_inventory.TabIndex = 102;
            this.dataGrid_inventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_inventory_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Classroom ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Grade";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Equipment Type";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Class Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantity";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btn_mg_invtdelete
            // 
            this.btn_mg_invtdelete.BackColor = System.Drawing.Color.Red;
            this.btn_mg_invtdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mg_invtdelete.ForeColor = System.Drawing.Color.White;
            this.btn_mg_invtdelete.Location = new System.Drawing.Point(660, 183);
            this.btn_mg_invtdelete.Name = "btn_mg_invtdelete";
            this.btn_mg_invtdelete.Size = new System.Drawing.Size(96, 39);
            this.btn_mg_invtdelete.TabIndex = 98;
            this.btn_mg_invtdelete.Text = "Delete";
            this.btn_mg_invtdelete.UseVisualStyleBackColor = false;
            this.btn_mg_invtdelete.Click += new System.EventHandler(this.btn_mg_invtdelete_Click);
            // 
            // btn_mg_invtupdate
            // 
            this.btn_mg_invtupdate.BackColor = System.Drawing.Color.Orange;
            this.btn_mg_invtupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mg_invtupdate.Location = new System.Drawing.Point(537, 183);
            this.btn_mg_invtupdate.Name = "btn_mg_invtupdate";
            this.btn_mg_invtupdate.Size = new System.Drawing.Size(96, 39);
            this.btn_mg_invtupdate.TabIndex = 97;
            this.btn_mg_invtupdate.Text = "Update";
            this.btn_mg_invtupdate.UseVisualStyleBackColor = false;
            this.btn_mg_invtupdate.Click += new System.EventHandler(this.btn_mg_invtupdate_Click);
            // 
            // btn_mg_invtadd
            // 
            this.btn_mg_invtadd.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_mg_invtadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mg_invtadd.ForeColor = System.Drawing.Color.White;
            this.btn_mg_invtadd.Location = new System.Drawing.Point(414, 183);
            this.btn_mg_invtadd.Name = "btn_mg_invtadd";
            this.btn_mg_invtadd.Size = new System.Drawing.Size(96, 39);
            this.btn_mg_invtadd.TabIndex = 96;
            this.btn_mg_invtadd.Text = "Add";
            this.btn_mg_invtadd.UseVisualStyleBackColor = false;
            this.btn_mg_invtadd.Click += new System.EventHandler(this.btn_mg_invtadd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 94;
            this.label5.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(419, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 93;
            this.label7.Text = "Class Name";
            // 
            // txt_mg_invtqty
            // 
            this.txt_mg_invtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mg_invtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mg_invtqty.Location = new System.Drawing.Point(583, 142);
            this.txt_mg_invtqty.Name = "txt_mg_invtqty";
            this.txt_mg_invtqty.Size = new System.Drawing.Size(173, 28);
            this.txt_mg_invtqty.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 22);
            this.label4.TabIndex = 91;
            this.label4.Text = "Equipment Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 90;
            this.label3.Text = "Grade";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 89;
            this.label2.Text = "Classroom ID";
            // 
            // txt_mg_invtgrade
            // 
            this.txt_mg_invtgrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mg_invtgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mg_invtgrade.Location = new System.Drawing.Point(160, 154);
            this.txt_mg_invtgrade.Name = "txt_mg_invtgrade";
            this.txt_mg_invtgrade.Size = new System.Drawing.Size(202, 28);
            this.txt_mg_invtgrade.TabIndex = 88;
            // 
            // txt_mg_invtclsid
            // 
            this.txt_mg_invtclsid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mg_invtclsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mg_invtclsid.Location = new System.Drawing.Point(160, 93);
            this.txt_mg_invtclsid.Name = "txt_mg_invtclsid";
            this.txt_mg_invtclsid.ReadOnly = true;
            this.txt_mg_invtclsid.Size = new System.Drawing.Size(202, 28);
            this.txt_mg_invtclsid.TabIndex = 87;
            // 
            // cmb_mg_invtequiptype
            // 
            this.cmb_mg_invtequiptype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mg_invtequiptype.FormattingEnabled = true;
            this.cmb_mg_invtequiptype.Items.AddRange(new object[] {
            "PC",
            "Laptop",
            "Fan",
            "Chairs",
            "Cup"});
            this.cmb_mg_invtequiptype.Location = new System.Drawing.Point(187, 213);
            this.cmb_mg_invtequiptype.Name = "cmb_mg_invtequiptype";
            this.cmb_mg_invtequiptype.Size = new System.Drawing.Size(175, 30);
            this.cmb_mg_invtequiptype.TabIndex = 103;
            // 
            // txt_mg_invtclsname
            // 
            this.txt_mg_invtclsname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mg_invtclsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mg_invtclsname.Location = new System.Drawing.Point(583, 93);
            this.txt_mg_invtclsname.Name = "txt_mg_invtclsname";
            this.txt_mg_invtclsname.Size = new System.Drawing.Size(173, 28);
            this.txt_mg_invtclsname.TabIndex = 104;
            // 
            // inReport
            // 
            this.inReport.BackColor = System.Drawing.Color.Navy;
            this.inReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inReport.Location = new System.Drawing.Point(537, 228);
            this.inReport.Name = "inReport";
            this.inReport.Size = new System.Drawing.Size(96, 39);
            this.inReport.TabIndex = 105;
            this.inReport.Text = "Report";
            this.inReport.UseVisualStyleBackColor = false;
            this.inReport.Click += new System.EventHandler(this.inReport_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(414, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 39);
            this.button1.TabIndex = 96;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_mg_invtadd_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(537, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 39);
            this.button2.TabIndex = 97;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_mg_invtupdate_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(660, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 39);
            this.button3.TabIndex = 98;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_mg_invtdelete_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(537, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 39);
            this.button4.TabIndex = 105;
            this.button4.Text = "Report";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.inReport_Click);
            // 
            // Inventory_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 655);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.inReport);
            this.Controls.Add(this.txt_mg_invtclsname);
            this.Controls.Add(this.cmb_mg_invtequiptype);
            this.Controls.Add(this.dataGrid_inventory);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_mg_invtdelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_mg_invtupdate);
            this.Controls.Add(this.btn_mg_invtadd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_mg_invtqty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mg_invtgrade);
            this.Controls.Add(this.txt_mg_invtclsid);
            this.Name = "Inventory_Management";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.Inventory_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_inventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_inventory;
        private System.Windows.Forms.Button btn_mg_invtdelete;
        private System.Windows.Forms.Button btn_mg_invtupdate;
        private System.Windows.Forms.Button btn_mg_invtadd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mg_invtqty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mg_invtgrade;
        private System.Windows.Forms.TextBox txt_mg_invtclsid;
        private System.Windows.Forms.ComboBox cmb_mg_invtequiptype;
        private System.Windows.Forms.TextBox txt_mg_invtclsname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button inReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}