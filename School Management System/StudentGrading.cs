using MaterialSkin;
using MaterialSkin.Controls;
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

namespace School_Management_System
{
    public partial class StudentGrading : MaterialForm
    {
       
        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";
        public StudentGrading()
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

        private void StudentGrading_Load(object sender, EventArgs e)
        {
            LoadStudentIDFromDatabase();
            comboBoxstuid.SelectedIndexChanged += comboBoxstuid_SelectedIndexChanged;
            textBox4grade.Enabled = false;
            textBox1namestu.Enabled = false;

        }


        private void LoadStudentIDFromDatabase()
        {
            try
            {
                comboBoxstuid.Items.Clear(); // Clear existing items

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT student_id FROM students";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxstuid.Items.Add(reader["student_id"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student ID from the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void comboBoxstuid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedStudentID = comboBoxstuid.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT student_name FROM students WHERE student_id = @StudentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", selectedStudentID);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            textBox1namestu.Text = result.ToString();
                        }
                        else
                        {
                            textBox1namestu.Text = "Student name not found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student name from the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1addgrading_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate fields
                if (string.IsNullOrWhiteSpace(comboBoxstuid.Text) || string.IsNullOrWhiteSpace(textBox1namestu.Text) ||
                    string.IsNullOrWhiteSpace(textBox2subject.Text) || string.IsNullOrWhiteSpace(textBoxmarks.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parse marks
                if (!int.TryParse(textBoxmarks.Text, out int marks))
                {
                    MessageBox.Show("Please enter a valid integer value for marks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert data into the grading table
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO grading (student_id, student_name, subject, marks, grade) VALUES (@StudentID, @StudentName, @Subject, @Marks, @Grade)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", comboBoxstuid.Text);
                        command.Parameters.AddWithValue("@StudentName", textBox1namestu.Text);
                        command.Parameters.AddWithValue("@Subject", textBox2subject.Text);
                        command.Parameters.AddWithValue("@Marks", marks);

                        // Calculate grade based on marks (you may need to customize this logic)
                        string grade = CalculateGrade(marks);

                        command.Parameters.AddWithValue("@Grade", grade);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Data added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding data to the grading table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string CalculateGrade(int marks)
        {
            // Add your logic to calculate the grade based on the marks.
            
            if (marks >= 90)
                return "A";
            else if (marks >= 80)
                return "B";
            else if (marks >= 70)
                return "C";
            else
                return "F";
        }

        private void textBoxmarks_TextChanged(object sender, EventArgs e)
        {
            // Validate if the marks field is not empty
            if (string.IsNullOrWhiteSpace(textBoxmarks.Text))
            {
                textBox4grade.Text = "N/A";
                return;
            }

            // Parse marks
            if (int.TryParse(textBoxmarks.Text, out int marks))
            {
                // Calculate grade based on marks (you may need to customize this logic)
                string grade = CalculateGrade(marks);
                textBox4grade.Text = grade;
            }
            else
            {
                textBox4grade.Text = "Invalid";
            }
        }
    }
}
