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
    public partial class SignIn : MaterialForm
    {
        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";
        public string UserType { get; set; }
        public SignIn()
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

        private void Signin_Load(object sender, EventArgs e)
        {
           cmb_usertype.SelectedItem = UserType;



            

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            



        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string usertype = cmb_usertype.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "";
                string tableName = "";

                switch (usertype.ToLower())
                {
                    case "admin":
                        tableName = "users";
                        break;
                    case "student":
                        tableName = "students";
                        break;
                    case "lecturer":
                        tableName = "lecturers";
                        break;
                    default:
                        MessageBox.Show("Unknown user type.");
                        return;
                }

                query = $"SELECT COUNT(*) FROM {tableName} WHERE email = @username AND password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show($"Sign-in successful! User type: {usertype}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        string userEmail = txt_username.Text;
                        SessionInfo.SetLoggedInUserEmail(userEmail);


                        // Open the corresponding dashboard based on user type
                        OpenDashboard(usertype);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or password. Please try again.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }


        private void OpenDashboard(string userType)
        {
            switch (userType.ToLower())
            {
                case "admin":
                    OpenAdminDashboard();
                    break;
                case "student":
                    OpenStudentDashboard();
                    break;
                case "lecturer":
                    OpenLecturerDashboard();
                    break;
                default:
                    MessageBox.Show("Unknown user type.");
                    break;
            }
        }

        private void OpenAdminDashboard()
        {
            Admin_Portal adminDashboardForm = new Admin_Portal();
            adminDashboardForm.Show();
            this.Hide(); // Optionally hide the sign-in form
        }

        private void OpenStudentDashboard()
        {
            Student_Portal studentDashboardForm = new Student_Portal();
            studentDashboardForm.Show();
            this.Hide(); // Optionally hide the sign-in form
        }

        private void OpenLecturerDashboard()
        {
            Lecturer_Portal lecturerDashboardForm = new Lecturer_Portal();
            lecturerDashboardForm.Show();
            this.Hide(); // Optionally hide the sign-in form
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_username.Text = string.Empty;
        }

        private void txt_password_MouseClick(object sender, MouseEventArgs e)
        {
            txt_password.Text = string.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}
