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
    public partial class Inventory_Management : MaterialForm
    {
        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";



        private TextBox txtClassroomID;
        private TextBox txtGrade;
        private ComboBox comboBoxEquipmentType;
        private TextBox txtClassName;
        private TextBox txtQuantity;



        public Inventory_Management()
        {
            InitializeComponent();




            dataGrid_inventory.CellContentClick += dataGrid_inventory_CellContentClick;







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


        private void LoadInventoryDataIntoDataGridView()
        {
            dataGrid_inventory.Rows.Clear(); // Clear existing rows

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "SELECT class_id, grade, equipment_type, class_name, quantity FROM inventory";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add a row to the DataGridView for each record in the 'inventory' table
                        dataGrid_inventory.Rows.Add(
                            reader["class_id"],
                            reader["grade"],
                            reader["equipment_type"],
                            reader["class_name"],
                            reader["quantity"]
                        );
                    }

                    reader.Close();
                }
            }
        }

        private void InitializeControls()
        {
            //-------------------------Populating Textboxes----------------------------//

            comboBoxEquipmentType = new ComboBox();
            txtClassroomID = new TextBox();
            txtGrade = new TextBox();
            txtClassName = new TextBox();
            txtQuantity = new TextBox();


            this.Controls.Add(comboBoxEquipmentType);
            this.Controls.Add(txtClassroomID);
            this.Controls.Add(txtQuantity);
            this.Controls.Add(txtGrade);
            this.Controls.Add(txtClassName);

        }



        private void Inventory_Management_Load(object sender, EventArgs e)
        {
            LoadInventoryDataIntoDataGridView();

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_mg_invtadd_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                // Create an instance of the Inventory class and populate its properties
                Inventory newInventory = new Inventory
                {
                    ClassName = txt_mg_invtclsname.Text,
                    Grade = txt_mg_invtgrade.Text,
                    Quantity = int.Parse(txt_mg_invtqty.Text),
                    Equipment = cmb_mg_invtequiptype.Text,
                };

                // Call a method to insert the student data into the database
                InsertInventoryData(newInventory);

                MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the form after adding the student
                ClearForm();
            }
            

        }

        private void ClearForm()
        {
            // Clear the textboxes, datetimepicker, and radio buttons
            txt_mg_invtclsname.Text = "";
            txt_mg_invtgrade.Text = "";
            txt_mg_invtqty.Text = "";
            cmb_mg_invtequiptype.SelectedIndex = -1;
            txt_mg_invtclsid.Text = "";
        }

        private void InsertInventoryData(Inventory inventory)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "INSERT INTO inventory (grade,equipment_type, class_name, quantity) " +
                "VALUES (@Grade, @Equipment, @ClassName, @Quantity)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Grade", inventory.Grade);
                    command.Parameters.AddWithValue("@Equipment", inventory.Equipment);
                    command.Parameters.AddWithValue("@ClassName", inventory.ClassName);
                    command.Parameters.AddWithValue("@Quantity", inventory.Quantity);

                    command.ExecuteNonQuery();
                }
            }

        }

        private void btn_mg_invtupdate_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                // Check if a class ID is selected
                if (txt_mg_invtclsid.Text == null)
                {
                    MessageBox.Show("Please select a Class ID before updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Assuming InventoryID is of type int
                int selectedClassID = int.Parse(txt_mg_invtclsid.Text.ToString());

                // Create an instance of the Inventory class and populate its properties
                Inventory updatedInventory = new Inventory
                {
                    ClassroomID = selectedClassID, // Include the Class ID for updating
                    ClassName = txt_mg_invtclsname.Text,
                    Grade = txt_mg_invtgrade.Text,
                    Quantity = int.Parse(txt_mg_invtqty.Text),
                    Equipment = cmb_mg_invtequiptype.Text,

                };

                // Call a method to update the student data in the database
                UpdateInventoryData(updatedInventory);

                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the form after updating the student
                ClearForm();
            }

           
        }
        /*---------------------------------VALIDATION-----------------------------------------------------------------*/
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_mg_invtclsname.Text) || string.IsNullOrWhiteSpace(txt_mg_invtgrade.Text) ||
                string.IsNullOrWhiteSpace(cmb_mg_invtequiptype.Text) || string.IsNullOrWhiteSpace(txt_mg_invtqty.Text))
            {
                MessageBox.Show("Please input/select all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        /*---------------------------------------------------------------------------------------------*/
        private void UpdateInventoryData(Inventory inventory)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "UPDATE inventory SET grade = @Grade, equipment_type = @Equipment, class_name = @ClassName, " +
                               "quantity = @Quantity WHERE class_id = @ClassroomID";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassroomID", inventory.ClassroomID);
                    command.Parameters.AddWithValue("@Grade", inventory.Grade);
                    command.Parameters.AddWithValue("@Equipment", inventory.Equipment);
                    command.Parameters.AddWithValue("@ClassName", inventory.ClassName);
                    command.Parameters.AddWithValue("@Quantity", inventory.Quantity);

                    command.ExecuteNonQuery();

                    LoadInventoryDataIntoDataGridView();

                }
            }
        }
        private void DeleteInventoryData(int classID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "DELETE FROM inventory WHERE class_id = @ClassroomID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassroomID", classID);

                    command.ExecuteNonQuery();
                }
            }

            // Optionally, clear the form after deleting the Record
            ClearForm();
            LoadInventoryDataIntoDataGridView();

        }

        private void btn_mg_invtdelete_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {

                if (txt_mg_invtclsid.Text != null)
                {
                    // Assuming StudentID is of type int
                    int selectedClassID = int.Parse(txt_mg_invtclsid.Text.ToString());

                    // Call the delete method with the selected student ID
                    DeleteInventoryData(selectedClassID);

                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_mg_invtclsid.Text = "";

                }
                else
                {
                    MessageBox.Show("Please select a Class ID before deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dataGrid_inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected row index
            int rowIndex = e.RowIndex;

            // Check if a valid row is clicked
            if (rowIndex >= 0 && rowIndex < dataGrid_inventory.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGrid_inventory.Rows[rowIndex];

                // Extract data from the selected row
                string classID = selectedRow.Cells["Column1"].Value.ToString();
                string grade = selectedRow.Cells["Column2"].Value.ToString();
                string equipmentType = selectedRow.Cells["Column3"].Value.ToString();
                string className = selectedRow.Cells["Column4"].Value.ToString();
                string quantity = selectedRow.Cells["Column5"].Value.ToString();

                // Populate your textboxes and comboboxes with the extracted data
                txt_mg_invtclsid.Text = classID;
                txt_mg_invtgrade.Text = grade;
                cmb_mg_invtequiptype.Text = equipmentType;
                txt_mg_invtclsname.Text = className;
                txt_mg_invtqty.Text = quantity;
            }
        }

        private void inReport_Click(object sender, EventArgs e)
        {
            // Report for inventory
            reportViewer report = new reportViewer();
            report.Show();
        }
    }
}
