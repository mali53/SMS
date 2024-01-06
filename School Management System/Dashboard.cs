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


namespace School_Management_System
{
    public partial class Dashboard : MaterialForm
    {
        public Dashboard()
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            btn_dash_Admin.Parent = pictureBox1;
            btn_dash_Admin.BackColor = Color.Transparent;

            btn_dash_lect.Parent = pictureBox1;
            btn_dash_lect.BackColor = Color.Transparent;

            btn_dash_student.Parent = pictureBox1;
            btn_dash_student.BackColor = Color.Transparent;


            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;


            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

        }
        private void OpenSignInForm(string userType)
        {
            // Create an instance of the SignInForm
            SignIn signInForm = new SignIn();

            // Set the user type in the sign-in form
            signInForm.UserType = userType;

            // Show the sign-in form
            signInForm.Show();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dash_Admin_Click(object sender, EventArgs e)
        {
            OpenSignInForm("Admin");
            
        }

        private void btn_dash_student_Click(object sender, EventArgs e)
        {
            OpenSignInForm("Student");
            
        }

        private void btn_dash_lect_Click(object sender, EventArgs e)
        {
            OpenSignInForm("Lecturer");
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
