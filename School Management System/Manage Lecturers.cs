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
    public partial class Manage_Lecturers : MaterialForm
    {
        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";

        private ComboBox comboBoxLecID;
        private TextBox txtLecName;
        private ComboBox comboBoxExperiance;
        private ComboBox comboBoxSubject;
        private TextBox txtTelephone;
        private TextBox txtAddress;
        private DateTimePicker dtDob;
        private TextBox txtEmail;
                
        public Manage_Lecturers()

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

        private void InitializeControls()
        {

            // Other initialization for comboBoxStudentID, e.g., set its location, size, etc.
            // Attach any event handlers if needed

            //-------------------------Populating Textboxes----------------------------//
            comboBoxLecID = new ComboBox();
            comboBoxExperiance = new ComboBox();
            comboBoxSubject = new ComboBox();
            txtLecName = new TextBox();
            txtTelephone = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();

        dtDob = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                CustomFormat = "MM/dd/yyyy",
                ShowCheckBox = true,
                Value = DateTime.Today // Set a default date (e.g., today's date)
            };

            dtDob.ShowCheckBox = true;
            dtDob.Format = DateTimePickerFormat.Short;

            // Set a custom format to display only the date portion
            dtDob.CustomFormat = "MM/dd/yyyy";

            this.Controls.Add(comboBoxLecID);
            this.Controls.Add(txtLecName);
            this.Controls.Add(comboBoxSubject);
            this.Controls.Add(comboBoxExperiance);
            this.Controls.Add(txtTelephone);
            this.Controls.Add(txtAddress);
            this.Controls.Add(dtDob);
            this.Controls.Add(txtEmail);

        }




        private void Manage_Lecturers_Load(object sender, EventArgs e)
        {
            LoadLecturerIDsIntoComboBox();
        }
        private void LoadLecturerIDsIntoComboBox()
        {
            cmb_lecid.Items.Clear();


            List<string> lecturerIDs = GetLecturerIDsFromDatabase();

            cmb_lecid.Items.AddRange(lecturerIDs.ToArray());
        }






        private List<string> GetLecturerIDsFromDatabase()
        {
            List<string> lecturerIDs = new List<string>();

            // Replace the following connection string with your actual database connection string
            string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";
            string query = "SELECT lecturer_id FROM lecturers";

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
                            string lecturerID = reader["lecturer_id"].ToString();
                            lecturerIDs.Add(lecturerID);
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

            return lecturerIDs;
        }

        private void btn_mg_lecadd_Click(object sender, EventArgs e)
        {
            if (ValidateLecturerInputs())
            {
                // Create an instance of the Lecturer class and populate its properties
                Lecturer newLecturer = new Lecturer
                {
                    LecturerName = txt_mg_lecname.Text,
                    Experiance = cmb_mg_lecexpe.Text,
                    Subject = cmb_mg_lecsubject.Text,
                    Telephone = txt_mg_lectele.Text,
                    Address = txt_mg_lecaddress.Text,
                    Dob = dt_mg_lecdob.Value,
                    Email = txt_mg_lecemail.Text,
                    Gender = rd_mg_lecMale.Checked ? "Male" : "Female",
                    Password = txt_password.Text,
                    Username = txt_username.Text
                };

                // Call a method to insert the lecturer data into the database
                InsertLecturerData(newLecturer);

                // Send email to the lecturer
                SendLecturerAccountEmail(newLecturer);

                MessageBox.Show("Record inserted successfully! Email sent to the lecturer.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLecturerIDsIntoComboBox();
                // Optionally, clear the form after adding the lecturer
                ClearForm();
            }
        }

        private void SendLecturerAccountEmail(Lecturer lecturer)
        {
            // Use your SMTP server details
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "omarseyyed926@gmail.com"; // Update with your email
            string smtpPassword = "skwn rkbg mqao eorw"; // Update with your email password

            // Lecturer's email address
            string lecturerEmail = lecturer.Email;

            // Subject and body of the email
            string subject = "Account Created Successfully";
            string body = $"Account details for {lecturer.LecturerName}:\n\nEmail: {lecturer.Email}\nPassword: {lecturer.Password}";

            // Create a list containing only the lecturer's email address
            List<string> recipientEmails = new List<string> { lecturerEmail };

            // Create a dictionary to pass additional values to the email body (if needed)
            Dictionary<string, object> values = new Dictionary<string, object>();

            // Send the email
            SendEmail(smtpUsername, recipientEmails, subject, body, values);
        }

        // Your existing SendEmail method
        

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
            txt_mg_lecname.Text = "";
            cmb_mg_lecexpe.SelectedIndex = -1;
            cmb_mg_lecsubject.SelectedIndex = -1;
            txt_mg_lecaddress.Text = "";
            dt_mg_lecdob.Value = DateTime.Today;
            txt_mg_lecemail.Text = "";
            rd_mg_lecfemale.Checked = false;
            rd_mg_lecMale.Checked = false;
            txt_mg_lectele.Text = "";
            txt_password.Text = "";
            txt_username.Text = "";

        }

        private void InsertLecturerData(Lecturer lecturer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "INSERT INTO lecturers (lecturer_name, experiance, subject_preferance, telephone, address, dob, email, gender,password) " +
                "VALUES (@LecturerName, @Experiance, @Subject, @Telephone, @Address, @Dob, @Email, @Gender,@Password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LecturerName", lecturer.LecturerName);
                    command.Parameters.AddWithValue("@Experiance", lecturer.Experiance);
                    command.Parameters.AddWithValue("@Subject", lecturer.Subject);
                    command.Parameters.AddWithValue("@Telephone", lecturer.Telephone);
                    command.Parameters.AddWithValue("@Address", lecturer.Address);
                    command.Parameters.AddWithValue("@Dob", lecturer.Dob);
                    command.Parameters.AddWithValue("@Email", lecturer.Email);
                    command.Parameters.AddWithValue("@Gender", lecturer.Gender);
                    command.Parameters.AddWithValue("@Password", lecturer.Password);
                    command.Parameters.AddWithValue("@Username", lecturer.Username);





                    command.ExecuteNonQuery();
                }
            }

        }

        private void btn_mg_lecsearch_Click(object sender, EventArgs e)
        {
            if (cmb_lecid.SelectedItem != null)
            {
                // Assuming StudentID is of type int
                int selectedLecturerID = int.Parse(cmb_lecid.SelectedItem.ToString());

                // Fetch data for the selected student ID
                Lecturer selectedLecturer = GetLecturerData(selectedLecturerID);

                // Display the data in the text fields
                DisplayLecturerData(selectedLecturer);
            }
            else
            {
                MessageBox.Show("Please select a Lecturer ID before searching.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Lecturer GetLecturerData(int lecturerID)
        {
            Lecturer lecturer = new Lecturer();

            string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";
            string query = "SELECT * FROM lecturers WHERE lecturer_id = @LecturerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlParameter param = new SqlParameter("@LecturerID", SqlDbType.Int);
                    param.Value = lecturerID;
                    command.Parameters.Add(param);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            lecturer.LecturerID = (int)reader["lecturer_id"];
                            lecturer.LecturerName = GetValueOrDefault<string>(reader, "lecturer_name");
                            lecturer.Experiance = GetValueOrDefault<string>(reader, "experiance");
                            lecturer.Subject = GetValueOrDefault<string>(reader, "subject_preferance");
                            lecturer.Telephone = GetValueOrDefault<string>(reader, "telephone");
                            lecturer.Address = GetValueOrDefault<string>(reader, "address");
                            lecturer.Password = GetValueOrDefault<string>(reader, "password");
                            lecturer.Username = GetValueOrDefault<string>(reader, "username");



                            // Handle DBNull for DateTime fields
                            object dobValue = reader["dob"];
                            lecturer.Dob = DBNull.Value.Equals(dobValue) ? DateTime.MinValue : (DateTime)dobValue;

                            lecturer.Email = GetValueOrDefault<string>(reader, "email");
                            lecturer.Gender = GetValueOrDefault<string>(reader, "gender");

                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}\nQuery: {query}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return lecturer;
        }

        private T GetValueOrDefault<T>(SqlDataReader reader, string columnName)
        {
            return reader[columnName] is T value ? value : default(T);
        }

        private void DisplayLecturerData(Lecturer lecturer)
        {
            // Display the student data in the text fields
            txt_mg_lecname.Text = lecturer.LecturerName;
            cmb_mg_lecexpe.Text = lecturer.Experiance;
            cmb_mg_lecsubject.Text = lecturer.Subject;
            txt_mg_lectele.Text = lecturer.Telephone;
            txt_mg_lecaddress.Text = lecturer.Address;
            if (lecturer.Dob != DateTime.MinValue)
            {
                dt_mg_lecdob.Value = lecturer.Dob;
            }
            txt_mg_lecemail.Text = lecturer.Email;
            txt_password.Text = lecturer.Password;
            txt_username.Text = lecturer.Username;




            if (string.Equals(lecturer.Gender, "Male", StringComparison.OrdinalIgnoreCase))
            {
                rd_mg_lecMale.Checked = true;
                rd_mg_lecfemale.Checked = false;
            }
            else if (string.Equals(lecturer.Gender, "Female", StringComparison.OrdinalIgnoreCase))
            {
                rd_mg_lecMale.Checked = false;
                rd_mg_lecfemale.Checked = true;
            }
            else
            {
                // Handle other cases if needed
                rd_mg_lecMale.Checked = false;
                rd_mg_lecfemale.Checked = false;
            }




        }

        private void btn_mg_lecupdate_Click(object sender, EventArgs e)
        {
            // Check if a Lecturer ID is selected
            if (cmb_lecid.SelectedItem == null)
            {
                MessageBox.Show("Please select a Lecturer ID before updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Assuming LecturerID is of type int
            int selectedLecturerID = int.Parse(cmb_lecid.SelectedItem.ToString());

            // Create an instance of the Student class and populate its properties
            Lecturer updatedLecturer = new Lecturer
            {
                // Include the Student ID for updating

                LecturerID = selectedLecturerID,
                LecturerName = txt_mg_lecname.Text,
                Experiance = cmb_mg_lecexpe.Text,
                Subject = cmb_mg_lecsubject.Text,
                Telephone = txt_mg_lectele.Text,
                Address = txt_mg_lecaddress.Text,
                Dob = dt_mg_lecdob.Value,
                Password = txt_password.Text,

                Email = txt_mg_lecemail.Text,
                Gender = rd_mg_lecMale.Checked ? "Male" : "Female",
                Username = txt_username.Text,




                // Include the Student ID for updating

            };

            // Call a method to update the student data in the database
            UpdateLecturerData(updatedLecturer);

            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally, clear the form after updating the Lecturer
            ClearForm();
        }

        private void UpdateLecturerData(Lecturer lecturer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "UPDATE lecturers SET lecturer_name = @LecturerName, experiance = @Experiance, subject_preferance = @Subject, " +
                               "telephone = @Telephone, address = @Address, dob = @Dob, " +
                               "email = @Email, gender = @Gender, password=@Password,username = @Username WHERE lecturer_id = @LecturerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                     {
                        command.Parameters.AddWithValue("@LecturerID", lecturer.LecturerID);
                        command.Parameters.AddWithValue("@LecturerName", lecturer.LecturerName);
                        command.Parameters.AddWithValue("@Experiance", lecturer.Experiance);
                        command.Parameters.AddWithValue("@Subject", lecturer.Subject);
                        command.Parameters.AddWithValue("@Telephone", lecturer.Telephone);
                        command.Parameters.AddWithValue("@Address", lecturer.Address);
                        command.Parameters.AddWithValue("@Dob", lecturer.Dob);
                        command.Parameters.AddWithValue("@Email", lecturer.Email);
                        command.Parameters.AddWithValue("@Gender", lecturer.Gender);
                    command.Parameters.AddWithValue("@Password", lecturer.Password);
                    command.Parameters.AddWithValue("@Username", lecturer.Username);



                    command.ExecuteNonQuery();
                     }
            }
        }
        /*-------------------------------------------------VALIDATION------------------------------------------------*/
        private bool ValidateLecturerInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_mg_lecname.Text) || string.IsNullOrWhiteSpace(cmb_mg_lecexpe.Text) ||
                string.IsNullOrWhiteSpace(cmb_mg_lecsubject.Text) || string.IsNullOrWhiteSpace(txt_mg_lectele.Text)|| string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text) ||
                string.IsNullOrWhiteSpace(txt_mg_lecaddress.Text) || string.IsNullOrWhiteSpace(txt_mg_lecemail.Text) ||
                (!rd_mg_lecMale.Checked && !rd_mg_lecfemale.Checked))
            {
                MessageBox.Show("Please input/select all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

           
        }
        /*--------------------------------------------------------------------------------------------*/
        private void DeleteLecturerData(int lecturerID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "DELETE FROM lecturers WHERE lecturer_id = @LecturerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LecturerID", lecturerID);

                    command.ExecuteNonQuery();
                }
            }

            // Load the updated student IDs into the combo box after deleting the record
            LoadLecturerIDsIntoComboBox();

            // Optionally, clear the form after deleting the student
            ClearForm();
        }

        private void btn_mg_lecdelete_Click(object sender, EventArgs e)
        {
            if (cmb_lecid.SelectedItem != null)
            {
                // Assuming LecturerID is of type int
                int selectedLecturerID = int.Parse(cmb_lecid.SelectedItem.ToString());

                // Call the delete method with the selected student ID
                DeleteLecturerData(selectedLecturerID);

                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLecturerIDsIntoComboBox();
                cmb_lecid.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Please select a Lecturer ID before deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }

}
