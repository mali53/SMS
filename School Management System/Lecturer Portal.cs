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
    public partial class Lecturer_Portal : MaterialForm
    {
        public Lecturer_Portal()
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

        private void Lecturer_Portal_Load(object sender, EventArgs e)
        {
            btn_exam.Parent = pictureBox1;
            btn_exam.BackColor = Color.Transparent;

            btn_holiday.Parent = pictureBox1;
            btn_holiday.BackColor = Color.Transparent;

            btn_profile.Parent = pictureBox1;
            btn_profile.BackColor = Color.Transparent;

            btn_ruby.Parent = pictureBox1;
            btn_ruby.BackColor = Color.Transparent;

            button1.Parent = pictureBox1;
            button1.BackColor = Color.Transparent;

            buttongrading.Parent = pictureBox1;
            buttongrading.BackColor = Color.Transparent;

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
            labelgrade.Parent = pictureBox1;
            labelgrade.BackColor = Color.Transparent;
            label6lecturepo.Parent = pictureBox1;
            label6lecturepo.BackColor = Color.Transparent;
        }

        private void btn_holiday_Click(object sender, EventArgs e)
        {
            Leave_Apply_Form leaveForm = new Leave_Apply_Form();
            leaveForm.Show();
        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            Exam_Management manageexamForm = new Exam_Management();
            manageexamForm.Show();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile_Lect lecprofile = new Profile_Lect();
            lecprofile.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ruby_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lecture_Scheduling lecshcedule = new Lecture_Scheduling();
            lecshcedule.Show();
        }
    }
}
