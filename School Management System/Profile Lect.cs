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
    public partial class Profile_Lect : MaterialForm
    {
        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";

        public Profile_Lect()
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

        private void Profile_Lect_Load(object sender, EventArgs e)
        {
            LoadStudentDataIntoForm();

        }

        private void LoadStudentDataIntoForm()
        {
            // Clear existing data


            // Retrieve the logged-in user's email
            string loggedInUserEmail = SessionInfo.LoggedInUserEmail;

            // Use the email to fetch data from the students table
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Database query
                string query = "SELECT * FROM lecturers WHERE email = @LoggedInUserEmail";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LoggedInUserEmail", loggedInUserEmail);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming the student_id column is of type int
                        int lecturerID = (int)reader["lecturer_id"];

                        // Create a Student object and populate its properties
                        Lecturer lecturer = new Lecturer
                        {
                            LecturerID = lecturerID,
                            LecturerName = GetValueOrDefault<string>(reader, "lecturer_name"),
                            Experiance = GetValueOrDefault<string>(reader, "experiance"),
                            Subject = GetValueOrDefault<string>(reader, "subject_preferance"),
                            Telephone = GetValueOrDefault<string>(reader, "telephone"),
                            Address = GetValueOrDefault<string>(reader, "address"),
                            Dob = reader.IsDBNull(reader.GetOrdinal("dob")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("dob")),
                            Email = GetValueOrDefault<string>(reader, "email"),
                            Gender = GetValueOrDefault<string>(reader, "gender")



    };

                        // Display the data in the form
                        DisplayLecturerData(lecturer);
                    }

                    reader.Close();
                }
            }
        }

        private void DisplayLecturerData(Lecturer lecturer)
        {
            // Display the student data in the text boxes
            txt_pr_lec_id.Text = lecturer.LecturerID.ToString();
            txt_pr_lec_name.Text = lecturer.LecturerName;
            txt_pr_lec_experiance.Text = lecturer.Experiance;
            txt_pr_lec_subject.Text = lecturer.Subject;
            txt_pr_lec_telephone.Text = lecturer.Telephone;
            txt_pr_lec_address.Text = lecturer.Address;
            txt_pr_lec_dob.Text = lecturer.Dob.ToString("yyyy-MM-dd");
            txt_pr_lec_email.Text = lecturer.Email;

            txt_pr_lec_gender.Text = lecturer.Gender;
        }


        private T GetValueOrDefault<T>(SqlDataReader reader, string columnName)
        {
            return reader[columnName] is T value ? value : default(T);
        }

        private void btn_pr_lec_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
