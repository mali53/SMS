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
    public partial class View_Paid_Students : MaterialForm
    {

        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";

        public View_Paid_Students()
        {
            InitializeComponent();


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

        private void View_Paid_Students_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }


        private void LoadDataIntoDataGridView()
        {
            dataGrid_view_pd_std.Rows.Clear(); // Clear existing rows

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "SELECT student_id, student_name, fee_type, payment_status, amount,payment_date FROM payments";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add a row to the DataGridView for each record in the 'inventory' table
                        dataGrid_view_pd_std.Rows.Add(
                            reader["student_id"],
                            reader["student_name"],
                            reader["fee_type"],
                            reader["payment_status"],
                            reader["amount"],
                            reader["payment_date"]

                        );
                    }

                    reader.Close();
                }
            }
        }

        private void btn_mg_fesearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txt_view_stdid.Text.Trim(); // Assuming txt_view_stdid is the TextBox for entering the search term

            // Validate that the search term is not empty
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter text into the textbox to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Perform the database search
                SearchInDatabase(searchTerm);
            }
        }
       


        private void SearchInDatabase(string searchTerm)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT student_id, student_name, fee_type, payment_status, amount,payment_date FROM payments WHERE student_id LIKE '%' + @SearchTerm + '%'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a DataTable to hold the result set
                            DataTable dataTable = new DataTable();

                            // Fill the DataTable with the results
                            adapter.Fill(dataTable);

                            dataGrid_view_pd_std.Rows.Clear();
                            foreach (DataRow row in dataTable.Rows)
                            {
                                // Assuming the order of columns in the SELECT query matches the order of columns in AddColumnsToDataGridView
                                dataGrid_view_pd_std.Rows.Add(row["student_id"], row["student_name"], row["fee_type"], row["payment_status"], row["amount"],row["payment_date"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}
