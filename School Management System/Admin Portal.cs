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
    public partial class Admin_Portal : MaterialForm
    {
        public Admin_Portal()
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

        private void Admin_Portal_Load(object sender, EventArgs e)
        {
            btn_exam.Parent = pictureBox1;
            btn_exam.BackColor = Color.Transparent;

            btn_inventory.Parent = pictureBox1;
            btn_inventory.BackColor = Color.Transparent;

            btn_leaves.Parent = pictureBox1;
            btn_leaves.BackColor = Color.Transparent;

            btn_lecturers.Parent = pictureBox1;
            btn_lecturers.BackColor = Color.Transparent;

            btn_students.Parent = pictureBox1;
            btn_students.BackColor = Color.Transparent;

            button1.Parent = pictureBox1;
            button1.BackColor = Color.Transparent;

            button2.Parent = pictureBox1;
            button2.BackColor = Color.Transparent;


            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;

            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;

            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;

            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();

                // Close or hide the current form (assuming it's your current dashboard form)
                this.Close(); // or this.Hide();
            }
        }

        private void btn_students_Click(object sender, EventArgs e)
        {
            Manage_Students managestudentForm = new Manage_Students();
            managestudentForm.Show();
            
        }

        private void btn_lecturers_Click(object sender, EventArgs e)
        {
            Manage_Lecturers managelecsForm = new Manage_Lecturers();
            managelecsForm.Show();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            Inventory_Management manageinventoryForm = new Inventory_Management();
            manageinventoryForm.Show();
        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            Exam_Management manageexamForm = new Exam_Management();
            manageexamForm.Show();
        }

        private void btn_leaves_Click(object sender, EventArgs e)
        {
            Leave_Apply_Form leaveForm = new Leave_Apply_Form();
            leaveForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fee_Management feeManagement = new Fee_Management();
            feeManagement.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lecture_Scheduling lectureScheduling = new Lecture_Scheduling();
            lectureScheduling.Show();
        }
    }
}
