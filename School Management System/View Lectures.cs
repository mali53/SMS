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
    public partial class View_Lectures : MaterialForm
    {
        private DataTable lectureDataTable;
        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";

        public View_Lectures()
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

        private void View_Lectures_Load(object sender, EventArgs e)
        {
            LoadLectureDataIntoDataGridView();
        }





        private void LoadLectureDataIntoDataGridView()
        {
            lectureDataTable = new DataTable(); // Create a new DataTable

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve the grade associated with the logged-in user's email
                string loggedInUserEmail = SessionInfo.LoggedInUserEmail;
                string getGradeQuery = "SELECT grade FROM students WHERE email = @LoggedInUserEmail";

                using (SqlCommand getGradeCommand = new SqlCommand(getGradeQuery, connection))
                {
                    getGradeCommand.Parameters.AddWithValue("@LoggedInUserEmail", loggedInUserEmail);

                    string userGrade = getGradeCommand.ExecuteScalar()?.ToString();

                    if (userGrade != null)
                    {
                        // Database query with grade filter
                        string query = "SELECT lecture_name, lecture_date, lecture_time, lecturer_name, grade FROM lectures WHERE grade = @UserGrade";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserGrade", userGrade);

                            SqlDataReader reader = command.ExecuteReader();

                            // Load data into DataTable
                            lectureDataTable.Load(reader);

                            reader.Close();
                        }
                    }
                }
            }

            // Bind the DataTable to the DataGridView
            dataGrid1.DataSource = lectureDataTable;
        }


        private void dataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
