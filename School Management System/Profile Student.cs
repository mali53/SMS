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
    public partial class Profile : MaterialForm
    {
        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";

        public Profile()
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

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadStudentDataIntoForm();
        }

        private void materialSingleLineTextField10_Click(object sender, EventArgs e)
        {

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
                string query = "SELECT * FROM students WHERE email = @LoggedInUserEmail";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LoggedInUserEmail", loggedInUserEmail);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming the student_id column is of type int
                        int studentID = (int)reader["student_id"];

                        // Create a Student object and populate its properties
                        Student student = new Student
                        {
                            StudentID = studentID,
                            StudentName = GetValueOrDefault<string>(reader, "student_name"),
                            Grade = GetValueOrDefault<string>(reader, "grade"),
                            ClassName = GetValueOrDefault<string>(reader, "çlass_name"),
                            Telephone = GetValueOrDefault<string>(reader, "Telephone"),
                            Address = GetValueOrDefault<string>(reader, "address"),
                            Guardian = GetValueOrDefault<string>(reader, "guardian"),
                            Dob = reader.IsDBNull(reader.GetOrdinal("dob")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("dob")),
                            Email = GetValueOrDefault<string>(reader, "email"),
                            Gender = GetValueOrDefault<string>(reader, "gender")
                        };

                        // Display the data in the form
                        DisplayStudentData(student);
                    }

                    reader.Close();
                }
            }
        }

        private void DisplayStudentData(Student student)
        {
            // Display the student data in the text boxes
            txt_pr_st_id.Text = student.StudentID.ToString();
            txt_pr_st_name.Text = student.StudentName;
            txt_pr_st_grade.Text = student.Grade;
            txt_pr_st_classname.Text = student.ClassName;
            txt_pr_st_telephone.Text = student.Telephone;
            txt_pr_st_address.Text = student.Address;
            txt_pr_st_guardian.Text = student.Guardian;
            txt_pr_st_dob.Text = student.Dob.ToString("yyyy-MM-dd");
            txt_pr_st_email.Text = student.Email;

            txt_pr_st_gender.Text= student.Gender;
        }


        private T GetValueOrDefault<T>(SqlDataReader reader, string columnName)
        {
            return reader[columnName] is T value ? value : default(T);
        }

        private void btn_pr_st_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
