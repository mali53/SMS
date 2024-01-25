using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;

namespace School_Management_System
{
    public partial class ResultsForm : MaterialForm
    {

        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";
        public ResultsForm()
        {
            InitializeComponent();

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

        private void ResultsForm_Load(object sender, EventArgs e)
        {

   

            guna2DataGridView1.DataSource = new DataTable();
           
        }

        

        private void LoadDataByStudentID(string studentID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT student_id, student_name, subject, marks, grade FROM grading WHERE student_id = @StudentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a DataTable to hold the data
                            DataTable dataTable = new DataTable();

                            // Fill the DataTable with the data from the grading table
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            guna2DataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data to the DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       


        private void button1serachresults_Click(object sender, EventArgs e)
        {
            string studentID = textBox1results.Text.Trim();

            // Validate the input (you may need more validation)
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Please enter a valid student ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadDataByStudentID(studentID);
        }

        private void textBox1results_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1results.Text))
            {
                guna2DataGridView1.DataSource = new DataTable();
            }
        }

        private void ExportToCSV(DataGridView dataGridView)
        {
            try
            {
                // Display a SaveFileDialog to get the destination path for the CSV file
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                    saveFileDialog.Title = "Save CSV File";
                    saveFileDialog.FileName = "TechCube Results Sheet.csv";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Create a StreamWriter to write data to the CSV file
                        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                        {
                            // Add a custom header
                            sw.WriteLine("TechCube Exam Portal");

                            // Write an empty line to separate the header and the data
                            sw.WriteLine();

                            // Write the column headers to the file
                            foreach (DataGridViewColumn column in dataGridView.Columns)
                            {
                                sw.Write(column.HeaderText + ",");
                            }
                            sw.WriteLine();

                            // Write each row of data to the file
                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    sw.Write(cell.Value + ",");
                                }
                                sw.WriteLine();
                            }
                        }

                        MessageBox.Show("Data exported successfully!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting data to CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1download_Click(object sender, EventArgs e)
        {
            ExportToCSV(guna2DataGridView1);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
