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
    public partial class Manage_Students : MaterialForm
    {
        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";

        



        public Manage_Students()
        {
            InitializeComponent();
            InitializeControls();
            

            this.Load += Manage_Students_Load;
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

        private void InitializeControls()
        {
            

        }


        /*--------------------------------VALIDATION-------------------------------------------------------------*/
        private bool ValidateStudentInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_mg_stdname.Text) || string.IsNullOrWhiteSpace(cmb_mg_std_grade.Text) ||
                string.IsNullOrWhiteSpace(txt_mg_stdclass.Text) || string.IsNullOrWhiteSpace(txt_mg_stdtele.Text) ||
                string.IsNullOrWhiteSpace(txt_mg_stdaddress.Text) || string.IsNullOrWhiteSpace(txt_mg_stdguardian.Text)|| string.IsNullOrWhiteSpace(txt_password.Text) ||
                string.IsNullOrWhiteSpace(txt_mg_stdemail.Text) || (!rd_mg_Male.Checked && !rd_mg_female.Checked))
            {
                MessageBox.Show("Please input/select all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_mg_stdtele.Text))
            {
                MessageBox.Show("Telephone field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate email field to ensure it contains '@'
            if (!txt_mg_stdemail.Text.Contains("@"))
            {
                MessageBox.Show("Email field should contain '@'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        /*------------------------------------------------------------------------------------------------*/

        private void Manage_Students_Load(object sender, EventArgs e)
        {
            LoadStudentIDsIntoComboBox();
        }

        private void LoadStudentIDsIntoComboBox()
        {
            cmb_stdid.Items.Clear();
            

            List<string> studentIDs = GetStudentIDsFromDatabase();

            cmb_stdid.Items.AddRange(studentIDs.ToArray());
        }




        private List<string> GetStudentIDsFromDatabase()
        {
            List<string> studentIDs = new List<string>();

            // Replace the following connection string with your actual database connection string
            string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";
            string query = "SELECT student_id FROM students";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            // Assuming the student_id column is of type string
                            string studentID = reader["student_id"].ToString();
                            studentIDs.Add(studentID);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return studentIDs;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool IsEmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM students WHERE email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        // If count is greater than 0, the email already exists
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        MessageBox.Show($"An error occurred while checking if the email exists: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Return false in case of an exception
                    }
                }
            }
        }

        private void btn_mg_stdadd_Click(object sender, EventArgs e)
        {
            if (ValidateStudentInputs())
            {
                if (IsEmailExists(txt_mg_stdemail.Text))
                {
                    MessageBox.Show("Email already exists. Please use a different email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Create an instance of the Student class and populate its properties
                Student newStudent = new Student
                {
                    StudentName = txt_mg_stdname.Text,
                    Grade = cmb_mg_std_grade.Text,
                    ClassName = txt_mg_stdclass.Text,
                    Telephone = txt_mg_stdtele.Text,
                    Address = txt_mg_stdaddress.Text,
                    Guardian = txt_mg_stdguardian.Text,
                    Dob = dt_mg_stddob.Value,
                    Email = txt_mg_stdemail.Text,
                    Gender = rd_mg_Male.Checked ? "Male" : "Female",
                    Password = txt_password.Text,
                    Username = txt_username.Text

                };

                // Call a method to insert the student data into the database
                InsertStudentData(newStudent);

               

                MessageBox.Show("Record inserted successfully and email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadStudentIDsIntoComboBox();
                // Optionally, clear the form after adding the student
                ClearForm();
            }
        }

       

        private void SendEmail(string senderEmail, List<string> recipientEmails, string subject, string body, Dictionary<string, object> values)
        {
            try
            {
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;
                string smtpUsername = "omarseyyed926@gmail.com"; // Update with your email
                string smtpPassword = "skwn rkbg mqao eorw";

                // Create an instance of the SmtpClient
                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort)
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(smtpUsername, smtpPassword),
                    EnableSsl = true
                };

               


                // Loop through each recipient email
                foreach (string recipientEmail in recipientEmails)
                {
                    // Create a MailMessage
                    MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail, subject, FormatEmailBody(body, values));

                    // Attempt to send the email
                    try
                    {
                        smtpClient.Send(mailMessage);
                    }
                    catch (Exception ex)
                    {
                        // Log the exception details
                        LogException($"An error occurred while sending the email to {recipientEmail}", ex);
                        MessageBox.Show($"An error occurred while sending the email to {recipientEmail}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception details
                LogException("An error occurred in the SendEmail method", ex);
                MessageBox.Show($"An error occurred in the SendEmail method: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string FormatEmailBody(string body, Dictionary<string, object> values)
        {
            // Replace placeholders in the body with actual values from the dictionary
            foreach (var entry in values)
            {
                body = body.Replace($"{{{entry.Key}}}", entry.Value.ToString());
            }

            return body;
        }

        private void LogException(string message, Exception ex)
        {
            // Implement your logging mechanism here
            // Example: log the exception to a file, database, or other logging service
            Console.WriteLine($"{message}\nException: {ex.Message}\nStackTrace: {ex.StackTrace}");
        }

        private void ClearForm()
        {
            // Clear the textboxes, datetimepicker, and radio buttons
            txt_mg_stdname.Text = "";
            cmb_mg_std_grade.Text = "";
            txt_mg_stdclass.Text = "";
            txt_mg_stdtele.Text = "";
            txt_mg_stdaddress.Text = "";
            txt_mg_stdguardian.Text = "";
            dt_mg_stddob.Value = DateTime.Today;
            txt_mg_stdemail.Text = "";
            rd_mg_Male.Checked = false;
            rd_mg_female.Checked = false;
            txt_password.Text = "";
            txt_username.Text = "";

        }
        private void InsertStudentData(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "INSERT INTO students (student_name, grade, çlass_name, Telephone, address, guardian, dob, email, gender,password,username) " +
                "VALUES (@StudentName, @Grade, @ClassName, @Telephone, @Address, @Guardian, @Dob, @Email, @Gender,@Password,@Username)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentName", student.StudentName);
                    command.Parameters.AddWithValue("@Grade", student.Grade);
                    command.Parameters.AddWithValue("@ClassName", student.ClassName);
                    command.Parameters.AddWithValue("@Telephone", student.Telephone);
                    command.Parameters.AddWithValue("@Address", student.Address);
                    command.Parameters.AddWithValue("@Guardian", student.Guardian);
                    command.Parameters.AddWithValue("@Dob", student.Dob);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@Gender", student.Gender);
                    command.Parameters.AddWithValue("@Password", student.Password);
                    command.Parameters.AddWithValue("@Username", student.Username);


                    int insertedStudentID = Convert.ToInt32(command.ExecuteScalar());

                    SendStudentEmail(student.Email, student.Password);


                }
            }
        
        }

        private void SendStudentEmail(string toEmail, string password)
        {
            try
            {

                if (!IsValidEmail(toEmail))
                {
                    // Log or display an error message indicating an invalid email address
                    Console.WriteLine("Invalid email address: " + toEmail);
                    return;
                }


                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;
                string smtpUsername = "omarseyyed926@gmail.com"; // Update with your email
                string smtpPassword = "skwn rkbg mqao eorw";




                using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
                {
                    smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                    smtpClient.EnableSsl = true;

                    using (MailMessage mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress("omarseyyed926@gmail.com"); // Replace with your sender email
                        mailMessage.To.Add(toEmail);
                        mailMessage.Subject = "Account Created Successfully";
                        mailMessage.Body = $"Dear student,\n\nYour account has been successfully created.\nEmail: {toEmail}\nPassword: {password}\n\nRegards,\nTechCube";

                        smtpClient.Send(mailMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle email sending error, log it, or display a message to the user
                Console.WriteLine($"An error occurred while sending the email: {ex.Message}");
            }
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void btn_mg_lecsearch_Click(object sender, EventArgs e)
        {
            if (cmb_stdid.SelectedItem != null)
            {
                // Assuming StudentID is of type int
                int selectedStudentID = int.Parse(cmb_stdid.SelectedItem.ToString());

                // Fetch data for the selected student ID
                Student selectedStudent = GetStudentData(selectedStudentID);

                // Display the data in the text fields
                DisplayStudentData(selectedStudent);
            }
            else
            {
                MessageBox.Show("Please select a Student ID before searching.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Student GetStudentData(int studentID)
        {
            Student student = new Student();

            string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";
            string query = "SELECT * FROM students WHERE student_id = @StudentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlParameter param = new SqlParameter("@StudentID", SqlDbType.Int);
                    param.Value = studentID;
                    command.Parameters.Add(param);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            student.StudentID = (int)reader["student_id"];
                            student.StudentName = GetValueOrDefault<string>(reader, "student_name");
                            student.Grade = GetValueOrDefault<string>(reader, "grade");
                            student.ClassName = GetValueOrDefault<string>(reader, "çlass_name");
                            student.Telephone = GetValueOrDefault<string>(reader, "Telephone");
                            student.Address = GetValueOrDefault<string>(reader, "address");
                            student.Guardian = GetValueOrDefault<string>(reader, "guardian");
                            student.Password = GetValueOrDefault<string>(reader, "password");
                            student.Username = GetValueOrDefault<string>(reader, "username");



                            // Handle DBNull for DateTime fields
                            object dobValue = reader["dob"];
                            student.Dob = DBNull.Value.Equals(dobValue) ? DateTime.MinValue : (DateTime)dobValue;

                            student.Email = GetValueOrDefault<string>(reader, "email");
                            student.Gender = GetValueOrDefault<string>(reader, "gender");

                            // Add debug messages
                            Console.WriteLine($"StudentID: {student.StudentID}");
                            Console.WriteLine($"StudentName: {student.StudentName}");
                            Console.WriteLine($"Grade: {student.Grade}");
                            Console.WriteLine($"ClassName: {student.ClassName}");
                            Console.WriteLine($"Telephone: {student.Telephone}");
                            Console.WriteLine($"Address: {student.Address}");
                            Console.WriteLine($"Guardian: {student.Guardian}");
                            Console.WriteLine($"Dob: {student.Dob}");
                            Console.WriteLine($"Email: {student.Email}");
                            Console.WriteLine($"Gender: {student.Gender}");
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}\nQuery: {query}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return student;
        }


        private T GetValueOrDefault<T>(SqlDataReader reader, string columnName)
{
    return reader[columnName] is T value ? value : default(T);
}



        private void DisplayStudentData(Student student)
        {
            // Display the student data in the text fields
            txt_mg_stdname.Text = student.StudentName;
            cmb_mg_std_grade.Text = student.Grade;
            txt_mg_stdclass.Text = student.ClassName;
            txt_mg_stdtele.Text = student.Telephone;
            txt_mg_stdaddress.Text = student.Address;
            txt_password.Text = student.Password;
            txt_username.Text = student.Username;


            txt_mg_stdguardian.Text = student.Guardian;
            if (student.Dob != DateTime.MinValue)
            {
                dt_mg_stddob.Value = student.Dob;
            }
            txt_mg_stdemail.Text = student.Email;


            if (string.Equals(student.Gender, "Male", StringComparison.OrdinalIgnoreCase))
            {
                rd_mg_Male.Checked = true;
                rd_mg_female.Checked = false;
            }
            else if (string.Equals(student.Gender, "Female", StringComparison.OrdinalIgnoreCase))
            {
                rd_mg_Male.Checked = false;
                rd_mg_female.Checked = true;
            }
            else
            {
                // Handle other cases if needed
                rd_mg_Male.Checked = false;
                rd_mg_female.Checked = false;
            }




        }

        private bool IsEmailExists(string email, int currentStudentID)
        {
            string query = "SELECT COUNT(*) FROM students WHERE email = @Email AND student_id != @CurrentStudentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@CurrentStudentID", currentStudentID);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        // If count is greater than 0, the email already exists
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        MessageBox.Show($"An error occurred while checking if the email exists: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Return false in case of an exception
                    }
                }
            }
        }


        private void btn_mg_stdupdate_Click(object sender, EventArgs e)
        {
            // Check if a Student ID is selected
            if (cmb_stdid.SelectedItem == null)
            {
                MessageBox.Show("Please select a Student ID before updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Assuming StudentID is of type int
            int selectedStudentID = int.Parse(cmb_stdid.SelectedItem.ToString());

            // Create an instance of the Student class and populate its properties
            Student updatedStudent = new Student
            {
                StudentID = selectedStudentID, // Include the Student ID for updating
                StudentName = txt_mg_stdname.Text,
                Grade = cmb_mg_std_grade.Text,
                ClassName = txt_mg_stdclass.Text,
                Telephone = txt_mg_stdtele.Text,
                Address = txt_mg_stdaddress.Text,
                Guardian = txt_mg_stdguardian.Text,
                Dob = dt_mg_stddob.Value,
                Email = txt_mg_stdemail.Text,
                Gender = rd_mg_Male.Checked ? "Male" : "Female",
                Password = txt_password.Text,
                Username = txt_username.Text

            };

            if (IsEmailExists(updatedStudent.Email, selectedStudentID))
            {
                MessageBox.Show("Email already exists. Please use a different email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call a method to update the student data in the database
            UpdateStudentData(updatedStudent);

            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally, clear the form after updating the student
            ClearForm();
        }




        private void UpdateStudentData(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "UPDATE students SET student_name = @StudentName, grade = @Grade, çlass_name = @ClassName, " +
                               "Telephone = @Telephone, address = @Address, guardian = @Guardian, dob = @Dob, " +
                               "email = @Email, gender = @Gender, password = @Password,username=@Username WHERE student_id = @StudentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", student.StudentID);
                    command.Parameters.AddWithValue("@StudentName", student.StudentName);
                    command.Parameters.AddWithValue("@Grade", student.Grade);
                    command.Parameters.AddWithValue("@ClassName", student.ClassName);
                    command.Parameters.AddWithValue("@Telephone", student.Telephone);
                    command.Parameters.AddWithValue("@Address", student.Address);
                    command.Parameters.AddWithValue("@Guardian", student.Guardian);
                    command.Parameters.AddWithValue("@Dob", student.Dob);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@Gender", student.Gender);
                    command.Parameters.AddWithValue("@Password", student.Password);
                    command.Parameters.AddWithValue("@Username", student.Username);



                    command.ExecuteNonQuery();
                }
            }
        }


        private void DeleteStudentData(int studentID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "DELETE FROM students WHERE student_id = @StudentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    command.ExecuteNonQuery();
                }
            }

            // Load the updated student IDs into the combo box after deleting the record
            LoadStudentIDsIntoComboBox();

            // Optionally, clear the form after deleting the student
            ClearForm();
        }

        private void btn_mg_stddelete_Click(object sender, EventArgs e)
        {
            if (cmb_stdid.SelectedItem != null)
            {
                // Assuming StudentID is of type int
                int selectedStudentID = int.Parse(cmb_stdid.SelectedItem.ToString());

                // Call the delete method with the selected student ID
                DeleteStudentData(selectedStudentID);

                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadStudentIDsIntoComboBox();
                 cmb_stdid.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Please select a Student ID before deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
