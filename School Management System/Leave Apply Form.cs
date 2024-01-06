using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class Leave_Apply_Form : MaterialForm
    {
        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";

        private TextBox txtLeaveId;
        private TextBox txtLecturerName;
        private DateTime dtLeaveDate;
        private TextBox txtReason;
        public Leave_Apply_Form()
        {
            InitializeComponent();


            datagrid_leave.CellContentClick += datagrid_leave_CellContentClick;




            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey700, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE
            );
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Leave_Apply_Form_Load(object sender, EventArgs e)
        {
            LoadLeaveDataIntoDataGridView();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (ValidateLeaveInputs())
            {
                // Create an instance of the Inventory class and populate its properties
                Leave newLeave = new Leave
                {
                    LecturerName = txt_lv_lecname.Text,
                    LeaveDate = dt_lv_lvdate.Value,
                    Reason = txt_lv_reason.Text

                };

                // Call a method to insert the student data into the database
                InsertLeaveData(newLeave);

                MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the form after adding the student
                ClearForm();
                LoadLeaveDataIntoDataGridView();
            }
        }

        private void ClearForm()
        {
            // Clear the textboxes, datetimepicker, and radio buttons
            txt_lv_lecname.Text = "";
            dt_lv_lvdate.Text = "";
            txt_lv_reason.Text = "";

        }

        private void InsertLeaveData(Leave leave)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "INSERT INTO leave (lecturer_name,date, reason) " +
                "VALUES (@LecturerName, @LeaveDate, @Reason)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LecturerName", leave.LecturerName);
                    command.Parameters.AddWithValue("@LeaveDate", leave.LeaveDate);
                    command.Parameters.AddWithValue("@Reason", leave.Reason);

                    command.ExecuteNonQuery();
                }
            }

        }



        private void LoadLeaveDataIntoDataGridView()
        {
            datagrid_leave.Rows.Clear(); // Clear existing rows

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "SELECT id, lecturer_name, date, reason FROM leave";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add a row to the DataGridView for each record in the 'inventory' table
                        datagrid_leave.Rows.Add(
                            reader["id"],
                            reader["lecturer_name"],
                            reader["date"],
                            reader["reason"]

                        );
                    }

                    reader.Close();
                }
            }
        }





        /*---------------------------------------VALIDATION----------------------------------------------*/
        private bool ValidateLeaveInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_lv_lecname.Text) || string.IsNullOrWhiteSpace(dt_lv_lvdate.Text) ||
                string.IsNullOrWhiteSpace(txt_lv_reason.Text))
            {
                MessageBox.Show("Please input/select all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        /*-------------------------------------------------------------------------------------------*/








        private void datagrid_leave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected row index
            int rowIndex = e.RowIndex;

            // Check if a valid row is clicked
            if (rowIndex >= 0 && rowIndex < datagrid_leave.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = datagrid_leave.Rows[rowIndex];

                // Extract data from the selected row
                string leaveID = selectedRow.Cells["Column1"].Value.ToString();
                string lecname = selectedRow.Cells["Column2"].Value.ToString();
                string leavedate = selectedRow.Cells["Column3"].Value.ToString();
                string reason = selectedRow.Cells["Column4"].Value.ToString();

                // Populate your textboxes and comboboxes with the extracted data
                txt_lv_lvid.Text = leaveID;
                txt_lv_lecname.Text = lecname;
                txt_lv_reason.Text = reason;
                dt_lv_lvdate.Text = leavedate;
            }
        }
    }
}
