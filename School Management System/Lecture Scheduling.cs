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
using System.Net;
using System.Net.Mail;

namespace School_Management_System
{
    public partial class Lecture_Scheduling : MaterialForm
    {
        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";

        public Lecture_Scheduling()
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
            dt_lecsearchdate.ValueChanged += (sender, e) => LoadLectureDataIntoDataGridView();
        }

        private void Lecture_Scheduling_Load(object sender, EventArgs e)
        {
            LoadAllLecturesIntoDataGridView();
            PopulateLecturerNames();
        }

        private void PopulateLecturerNames()
        {
            // Clear existing items in the ComboBox
            cmb_lecturername.Items.Clear();

            // Database query to fetch lecturer names
            string query = "SELECT lecturer_name FROM lecturers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add each lecturer name to the ComboBox
                        cmb_lecturername.Items.Add(reader["lecturer_name"].ToString());
                    }

                    reader.Close();
                }
            }
        }

        private void LoadLectureDataIntoDataGridView()
        {
          
            dataGrid_Lecture.Rows.Clear(); // Clear existing rows

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Database query (assuming you have a SqlConnection named 'connection'):
                string query = "SELECT lecture_id, lecture_name, lecture_date, lecture_time, lecturer_name, grade " +
                               "FROM lectures " +
                               "WHERE lecture_date = @LectureDate"; // Add a WHERE clause to filter by lecture_date

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LectureDate", dt_lecsearchdate.Value.Date); // Use the selected date

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add a row to the DataGridView for each record in the 'lectures' table
                        dataGrid_Lecture.Rows.Add(
                            reader["lecture_id"],
                            reader["lecture_name"],
                            reader["lecture_date"],
                            reader["lecture_time"],
                            reader["lecturer_name"],
                            reader["grade"]
                        );
                    }

                    reader.Close();
                }
            }
        }

        private void LoadAllLecturesIntoDataGridView()
        {
            dataGrid_Lecture.Rows.Clear(); // Clear existing rows

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Database query (assuming you have a SqlConnection named 'connection'):
                string query = "SELECT lecture_id, lecture_name, lecture_date, lecture_time, lecturer_name, grade FROM lectures";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add a row to the DataGridView for each record in the 'lectures' table
                        dataGrid_Lecture.Rows.Add(
                            reader["lecture_id"],
                            reader["lecture_name"],
                            reader["lecture_date"],
                            reader["lecture_time"],
                            reader["lecturer_name"],
                            reader["grade"]
                        );
                    }

                    reader.Close();
                }
            }
        }
        /*-------------------------------------VALIDATION------------------------------------------*/
        private bool ValidateInputs()
        {
            if (
                string.IsNullOrWhiteSpace(txt_lecname.Text) ||
                string.IsNullOrWhiteSpace(cmb_lecturername.Text) ||
                string.IsNullOrWhiteSpace(cmb_grade.Text))
            {
                MessageBox.Show("Please input all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        /*----------------------------------------------------------------------------------------*/


        private void btn_mg_exsubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string selectedGrade = cmb_grade.SelectedItem?.ToString();
                // Create an instance of the Inventory class and populate its properties
                Lecture newLecture = new Lecture
                {
                    LectureName = txt_lecname.Text,
                    LectureDate = dt_lecdate.Value,
                    LectureTime = dt_lectime.Value,
                    LecturerName = cmb_lecturername.Text,
                    Grade = cmb_grade.Text,
                };

                // Call a method to insert the student data into the database
                InsertLectureData(newLecture);

                MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the form after adding the student
                ClearForm();
                LoadLectureDataIntoDataGridView();



                if (!string.IsNullOrEmpty(selectedGrade))
                {
                    // Get student emails for the selected grade
                    List<string> studentEmails = GetStudentEmailsFromDatabase(selectedGrade);

                    // Assuming you have an instance of the Lecturer class
                    Lecturer lecturer = new Lecturer
                    {
                        LecturerName = newLecture.LecturerName // Set the lecturer name
                    };

                    // Get lecturer ID based on the lecturer name
                    int lecturerId = GetLecturerIdFromDatabase(lecturer);

                    // Get lecturer email using the lecturer ID
                    string lecturerEmail = GetLecturerEmailFromDatabase(lecturerId);

                    // Add lecturer's email to the list of recipients
                    List<string> allEmails = new List<string>();
                    allEmails.Add(lecturerEmail);

                    // Add student emails to the list
                    List<string> studentEmailList = GetStudentEmailsFromDatabase(selectedGrade);
                    allEmails.AddRange(studentEmailList);

                    // Assuming you have a function to send emails
                    foreach (string recipientEmail in allEmails)
                    {
                        if (!string.IsNullOrEmpty(recipientEmail))
                        {
                            Dictionary<string, object> emailValues = new Dictionary<string, object>
            {
                { "LectureName", newLecture.LectureName },
                { "LectureDate", newLecture.LectureDate },
                { "LectureTime", newLecture.LectureTime },
                { "LecturerName", newLecture.LecturerName }
            };

                            SendEmail("omarseyyed926@gmail.com", allEmails, "Lecture Schedule", "The details of the Lecture scheduled are:\n\n Lecture Name:{LectureName},\n\n Lecture Date:{LectureDate},\n\n Lecture Time:{LectureTime},\n\n Lecturer Name:{LecturerName}", emailValues);
                        }
                        else
                        {
                            // Log or handle the case where recipientEmail is null or empty
                            MessageBox.Show("Recipient email is null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    MessageBox.Show("Lecture scheduled successfully, and emails sent to students.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a grade before scheduling the Lecture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

        }
        private int GetLecturerIdFromDatabase(Lecturer lecturer)
        {
            int lecturerId = 0; // Default value, assuming -1 is not a valid lecturer ID

            // Your code to retrieve the lecturer ID from the database goes here
            // Use your existing database connection and query to fetch the lecturer ID based on the lecturer name

            // Example query:
            string query = "SELECT lecturer_id FROM lecturers WHERE lecturer_name = @LecturerName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LecturerName", lecturer.LecturerName);

                    try
                    {
                        connection.Open();
                        lecturerId = (int)command.ExecuteScalar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return lecturerId;
        }

        private void SendEmail(string senderEmail, List<string> recipientEmails, string subject, string body, Dictionary<string, object> values)
        {
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "omarseyyed926@gmail.com";
            string smtpPassword = "skwn rkbg mqao eorw";

            SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(smtpUsername, smtpPassword),
                EnableSsl = true
            };

            Console.WriteLine($"Number of recipient emails: {recipientEmails.Count}");

            foreach (string recipientEmail in recipientEmails)
            {
                if (!string.IsNullOrEmpty(recipientEmail))
                {
                    MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail, subject, FormatEmailBody(body, values));

                    try
                    {
                        smtpClient.Send(mailMessage);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while sending the email to {recipientEmail}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Log or handle the case where recipientEmail is null or empty
                    MessageBox.Show("Recipient email is null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        }
        private string FormatEmailBody(string body, Dictionary<string, object> values)
        {
            foreach (var kvp in values)
            {
                if (kvp.Key == "LectureDate")
                {
                    // Format the date to only display the date part
                    body = body.Replace("{" + kvp.Key + "}", ((DateTime)kvp.Value).ToString("MM/dd/yyyy"));
                }
                else if (kvp.Key == "LectureTime")
                {
                    // Format the time to only display the time part
                    body = body.Replace("{" + kvp.Key + "}", ((DateTime)kvp.Value).ToString("hh:mm tt"));
                }
                else
                {
                    body = body.Replace("{" + kvp.Key + "}", kvp.Value.ToString());
                }
            }

            return body;
        }
        private string GetLecturerEmailFromDatabase(int lecturerId)
        {
            string lecturerEmail = string.Empty;

            // Your code to retrieve the lecturer's email from the database goes here
            // Use your existing database connection and query to fetch the lecturer's email

            // Example query:
            string query = "SELECT email FROM lecturers WHERE lecturer_id = @LecturerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LecturerID", lecturerId);

                    try
                    {
                        connection.Open();
                        lecturerEmail = command.ExecuteScalar()?.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return lecturerEmail;
        }


        private List<string> GetStudentEmailsFromDatabase(string selectedGrade)
        {
            List<string> studentEmails = new List<string>();

            // Your code to retrieve emails from the database goes here
            // Use your existing database connection and query to fetch student emails for the specified grade

            // Example query:
            string query = "SELECT email FROM students WHERE grade = @Grade";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Grade", selectedGrade);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            // Assuming the email column is named "email"
                            string studentEmail = reader["email"].ToString();
                            studentEmails.Add(studentEmail);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return studentEmails;
        }
        private void ClearForm()
        {
            // Clear the textboxes, datetimepicker, and radio buttons
            txt_lecname.Text = "";
            txt_lecid.Text = "";
            cmb_lecturername.Text = "";
            dt_lectime.Text = "";
            dt_lecdate.Text = "";
            cmb_grade.SelectedItem = null;
        }

        private void dataGrid_Exam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected row index
            int rowIndex = e.RowIndex;

            // Check if a valid row is clicked
            if (rowIndex >= 0 && rowIndex < dataGrid_Lecture.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGrid_Lecture.Rows[rowIndex];

                // Extract data from the selected row
                string lecId = selectedRow.Cells["Column1"].Value.ToString();
                string lecName = selectedRow.Cells["Column2"].Value.ToString();
                string lecDate = selectedRow.Cells["Column3"].Value.ToString();
                string lecTime = selectedRow.Cells["Column4"].Value.ToString();
                string lecturername = selectedRow.Cells["Column5"].Value.ToString();
                string grd = selectedRow.Cells["Column6"].Value.ToString();


                // Populate your textboxes and comboboxes with the extracted data
                txt_lecid.Text = lecId;
                txt_lecname.Text = lecName;
                dt_lecsearchdate.Text = lecDate;
                dt_lectime.Text = lecTime;
                cmb_lecturername.Text = lecturername;
                cmb_grade.Text = grd;
            }


        }

        private void InsertLectureData(Lecture lecture)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "INSERT INTO lectures (lecture_name,lecture_date, lecture_time, lecturer_name,grade) " +
                "VALUES (@LectureName, @LectureDate, @LectureTime, @LecturerName,@Grade)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LectureName", lecture.LectureName);
                    command.Parameters.AddWithValue("@LectureDate", lecture.LectureDate);
                    command.Parameters.AddWithValue("@LectureTime", lecture.LectureTime);
                    command.Parameters.AddWithValue("@LecturerName", lecture.LecturerName);
                    command.Parameters.AddWithValue("@Grade", lecture.Grade);

                    command.ExecuteNonQuery();
                }
            }


        }

        private void btn_mg_exupdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                // Check if a ExamID  is selected
                if (txt_lecid.Text == null)
                {
                    MessageBox.Show("Please select a Exam ID before updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Assuming ExamID is of type int
                int selectedExamID = int.Parse(txt_lecid.Text.ToString());

                // Create an instance of the Inventory class and populate its properties
                Lecture updatedlecture = new Lecture
                {
                    LectureId = selectedExamID, // Include the Class ID for updating
                    

                    LectureName = txt_lecname.Text,
                    LectureDate = dt_lecdate.Value,
                    LectureTime = dt_lectime.Value,
                    LecturerName = cmb_lecturername.Text,
                    Grade = cmb_grade.Text,




                };

                // Call a method to update the student data in the database
                UpdateLectureData(updatedlecture);

                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the form after updating the student
                ClearForm();
                LoadLectureDataIntoDataGridView();
            }
        }
        private void UpdateLectureData(Lecture lecture)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "UPDATE lectures SET lecture_name = @LectureName, lecture_date = @LectureDate, lecture_time = @LectureTime, " +
                               "lecturer_name = @LecturerName, grade = @Grade WHERE lecture_id = @LectureId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LectureId", lecture.LectureId);
                    command.Parameters.AddWithValue("@LectureName", lecture.LectureName);
                    command.Parameters.AddWithValue("@LectureDate", lecture.LectureDate);
                    command.Parameters.AddWithValue("@LectureTime", lecture.LectureTime);
                    command.Parameters.AddWithValue("@LecturerName", lecture.LecturerName);
                    command.Parameters.AddWithValue("@Grade", lecture.Grade);

                    command.ExecuteNonQuery();

                    LoadLectureDataIntoDataGridView();
                }

            }
        }

        private void DeleteLectureData(int lecid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "DELETE FROM lectures WHERE lecture_id = @LectureId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LectureId", lecid);

                    command.ExecuteNonQuery();
                }
            }

            // Optionally, clear the form after deleting the Record
            ClearForm();
            LoadLectureDataIntoDataGridView();

        }

        private void btn_mg_exdelete_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (txt_lecid.Text != null)
                {
                    // Assuming StudentID is of type int
                    int selectedExamID = int.Parse(txt_lecid.Text.ToString());

                    // Call the delete method with the selected student ID
                    DeleteLectureData(selectedExamID);

                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_lecid.Text = "";

                }
                else
                {
                    MessageBox.Show("Please select a Lecture ID before deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}