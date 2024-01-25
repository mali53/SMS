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
    public partial class Exam_Management : MaterialForm
    {
        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";


        public Exam_Management()
        {
            InitializeComponent();
            InitializeControls();

            dataGrid_Exam.CellContentClick += dataGrid_Exam_CellContentClick;


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


        // Malinga Starts
        private void LoadExamDataIntoDataGridView()
        {
            dataGrid_Exam.Rows.Clear(); // Clear existing rows

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Database query (assuming you have a SqlConnection named 'connection'):
                string query = "SELECT exam_id, name, date, time, name_of_invigilator, grade FROM exam";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add a row to the DataGridView for each record in the 'exam' table
                        dataGrid_Exam.Rows.Add(
                            reader["exam_id"],
                            reader["name"],
                            reader["date"],
                            reader["time"],
                            reader["name_of_invigilator"],
                            reader["grade"]
                        );
                    }

                    reader.Close();
                }
            }
        }

        private void LoadFilteredExamDataIntoDataGridView(DateTime selectedDate)
        {
            dataGrid_Exam.Rows.Clear(); // Clear existing rows

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Database query to filter exams based on the selected date:
                string query = "SELECT exam_id, name, date, time, name_of_invigilator, grade " +
                               "FROM exam WHERE CONVERT(DATE, date) = @SelectedDate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add a row to the DataGridView for each record in the 'exam' table
                        dataGrid_Exam.Rows.Add(
                            reader["exam_id"],
                            reader["name"],
                            reader["date"],
                            reader["time"],
                            reader["name_of_invigilator"],
                            reader["grade"]
                        );
                    }

                    reader.Close();
                }
            }
        }


        private void dt_mg_extsearchdate_ValueChanged(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = dt_mg_extsearchdate.Value;

            // Call a method to filter and display exams for the selected date in the DataGridView
            LoadFilteredExamDataIntoDataGridView(selectedDate);
        }

        //Malinga Ends
        private void InitializeControls()
        {


        }
        /*-------------------------------------VALIDATION------------------------------------------*/
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_mg_exname.Text) ||
                string.IsNullOrWhiteSpace(dt_mg_exdate.Text) ||
                string.IsNullOrWhiteSpace(dt_mg_extime.Text) ||
                string.IsNullOrWhiteSpace(txt_mg_exninvigilatorname.Text))
            {
                MessageBox.Show("Please input all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        /*-----------------------------------------------------------------------------------------*/


        private void Exam_Management_Load(object sender, EventArgs e)
        {
            LoadExamDataIntoDataGridView();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_mg_exid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_Exam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected row index
            int rowIndex = e.RowIndex;

            // Check if a valid row is clicked
            if (rowIndex >= 0 && rowIndex < dataGrid_Exam.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGrid_Exam.Rows[rowIndex];

                // Extract data from the selected row
                string examId = selectedRow.Cells["Column1"].Value.ToString();
                string examName = selectedRow.Cells["Column2"].Value.ToString();
                string examDate = selectedRow.Cells["Column3"].Value.ToString();
                string examTime = selectedRow.Cells["Column4"].Value.ToString();
                string inviname = selectedRow.Cells["Column5"].Value.ToString();
                string grd = selectedRow.Cells["Column6"].Value.ToString();


                // Populate your textboxes and comboboxes with the extracted data
                txt_mg_exid.Text = examId;
                txt_mg_exname.Text = examName;
                dt_mg_exdate.Text = examDate;
                dt_mg_extime.Text = examTime;
                txt_mg_exninvigilatorname.Text = inviname;
                cmb_mg_std_grade.Text = grd;
            }
        }

        private void btn_mg_exsubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string selectedGrade = cmb_mg_std_grade.SelectedItem?.ToString();
                // Create an instance of the Inventory class and populate its properties
                Exam newExam = new Exam
                {
                    ExamName = txt_mg_exname.Text,
                    ExamDate = dt_mg_exdate.Value,
                    ExamTime = dt_mg_extime.Value,
                    SearchExamDate = dt_mg_extsearchdate.Value,
                    NameInvigilator = txt_mg_exninvigilatorname.Text,
                    Grade = cmb_mg_std_grade.Text,
                };

                // Call a method to insert the student data into the database
                InsertExamData(newExam);

                MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the form after adding the student
                ClearForm();
                LoadExamDataIntoDataGridView();

                

                if (!string.IsNullOrEmpty(selectedGrade))
                {
                    // Get student emails for the selected grade
                    List<string> studentEmails = GetStudentEmailsFromDatabase(selectedGrade);

                    // Assuming you have a function to send emails
                    foreach (string studentEmail in studentEmails)
                    {
                        Dictionary<string, object> emailValues = new Dictionary<string, object>
                     {
                       { "ExamName", newExam.ExamName },
                       { "ExamDate", newExam.ExamDate },
                       { "ExamTime", newExam.ExamTime },
                       { "NameInvigilator", newExam.NameInvigilator }
                     };

                        SendEmail("omarseyyed926@gmail.com", studentEmail, "TechCube Exam Schedule", "The details of the exam schedule are:\n\n Exam Name:{ExamName},\n\n Exam Date:{ExamDate},\n\n Exam Time:{ExamTime},\n\n Name of Invigilator:{NameInvigilator}", emailValues);


                    }

                    MessageBox.Show("Exam scheduled successfully, and emails sent to students.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a grade before scheduling the exam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void SendEmail(string senderEmail, string recipientEmail, string subject, string body, Dictionary<string, object> values)
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

            MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail, subject, FormatEmailBody(body, values));

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string FormatEmailBody(string body, Dictionary<string, object> values)
        {
            foreach (var kvp in values)
            {
                if (kvp.Key == "ExamDate")
                {
                    // Format the date to only display the date part
                    body = body.Replace("{" + kvp.Key + "}", ((DateTime)kvp.Value).ToString("MM/dd/yyyy"));
                }
                else if (kvp.Key == "ExamTime")
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
            txt_mg_exname.Text = "";
            dt_mg_exdate.Text = "";
            dt_mg_extime.Text = "";
            dt_mg_extsearchdate.Text = "";
            txt_mg_exninvigilatorname.Text = "";
            cmb_mg_std_grade.SelectedItem = null;
        }

        private void InsertExamData(Exam exam)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "INSERT INTO exam (name,date, time, name_of_invigilator,grade) " +
                "VALUES (@ExamName, @ExamDate, @ExamTime, @NameInvigilator,@Grade)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    command.Parameters.AddWithValue("@ExamDate", exam.ExamDate);
                    command.Parameters.AddWithValue("@ExamTime", exam.ExamTime);
                    command.Parameters.AddWithValue("@NameInvigilator", exam.NameInvigilator);
                    command.Parameters.AddWithValue("@Grade", exam.Grade);

                    command.ExecuteNonQuery();
                }
            }

        }

        private void btn_mg_exupdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                // Check if a ExamID  is selected
                if (txt_mg_exid.Text == null)
                {
                    MessageBox.Show("Please select a Exam ID before updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Assuming ExamID is of type int
                int selectedExamID = int.Parse(txt_mg_exid.Text.ToString());

                // Create an instance of the Inventory class and populate its properties
                Exam updatedExam = new Exam
                {
                    ExamId = selectedExamID, // Include the Class ID for updating
                    ExamName = txt_mg_exname.Text,
                    ExamDate = dt_mg_exdate.Value,
                    ExamTime = dt_mg_extime.Value,
                    NameInvigilator = txt_mg_exninvigilatorname.Text,
                    Grade = cmb_mg_std_grade.Text,


                };

                // Call a method to update the student data in the database
                UpdateExamData(updatedExam);

                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the form after updating the student
                ClearForm();
                LoadExamDataIntoDataGridView();
            }
           
        }

        private void UpdateExamData(Exam exam)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "UPDATE exam SET name = @ExamName, date = @ExamDate, time = @ExamTime, " +
                               "name_of_invigilator = @NameInvigilator, grade = @Grade WHERE exam_id = @ExamId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ExamId", exam.ExamId);
                    command.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    command.Parameters.AddWithValue("@ExamDate", exam.ExamDate);
                    command.Parameters.AddWithValue("@ExamTime", exam.ExamTime);
                    command.Parameters.AddWithValue("@NameInvigilator", exam.NameInvigilator);
                    command.Parameters.AddWithValue("@Grade", exam.Grade);

                    command.ExecuteNonQuery();
                    SendUpdateNotificationEmail(exam.ExamId, exam.Grade, exam.ExamName, exam.ExamDate, exam.ExamTime, exam.NameInvigilator);
                
                LoadExamDataIntoDataGridView();
                }

            }
        }
        private void DeleteExamData(int examid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "DELETE FROM exam WHERE exam_id = @ExamId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ExamId", examid);

                    command.ExecuteNonQuery();
                }
            }

            // Optionally, clear the form after deleting the Record
            ClearForm();
            LoadExamDataIntoDataGridView();

        }

        private void btn_mg_exdelete_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (txt_mg_exid.Text != null)
                {
                    // Assuming StudentID is of type int
                    int selectedExamID = int.Parse(txt_mg_exid.Text.ToString());

                    // Call the delete method with the selected student ID
                    DeleteExamData(selectedExamID);

                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_mg_exid.Text = "";

                }
                else
                {
                    MessageBox.Show("Please select a Exam ID before deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void SendUpdateNotificationEmail(int examId, string grade, string examName, DateTime examDate, DateTime examTime, string invigilatorName)
        {
            try
            {
                // Get student emails for the specified grade
                List<string> studentEmails = GetStudentEmailsFromDatabase(grade);

                // SMTP server details (replace with your actual values)
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

                foreach (string studentEmail in studentEmails)
                {
                    string subject = "TechCube Exam Update Notification";
                    string body = $"Dear Student,\n\nThe details of your exam have been updated:\n\n" +
                                  $"Exam ID: {examId}\n" +
                                  $"Exam Name: {examName}\n" +
                                  $"Exam Date: {examDate.ToShortDateString()}\n" +
                                  $"Exam Time: {examTime.ToShortTimeString()}\n" +
                                  $"Invigilator: {invigilatorName}\n\n" +
                                  "Please check your portal for the latest information.";

                    MailMessage mailMessage = new MailMessage("omarseyyed926@gmail.com", studentEmail, subject, body);

                    // Send the email
                    smtpClient.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void reportExambtn_Click(object sender, EventArgs e)
        {
            ExamReportForm report1 = new ExamReportForm();
            report1.Show();
        }
    }


}
