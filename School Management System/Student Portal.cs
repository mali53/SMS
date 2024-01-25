using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace School_Management_System
{
    public partial class Student_Portal : MaterialForm
    {
        public Student_Portal()
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

        private void Student_Portal_Load(object sender, EventArgs e)
        {
            btn_std_profile.Parent = pictureBox1;
            btn_std_profile.BackColor = Color.Transparent;

            button1results.Parent = pictureBox1;
            button1results.BackColor = Color.Transparent;

            btn_std_ruby.Parent = pictureBox1;
            btn_std_ruby.BackColor = Color.Transparent;

            btn_view_lecs.Parent = pictureBox1;
            btn_view_lecs.BackColor = Color.Transparent;

            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label3studentportal.Parent = pictureBox1;
            label3studentportal.BackColor = Color.Transparent;

            label3checkresults.Parent = pictureBox1;
            label3checkresults.BackColor = Color.Transparent;
        }

        private void btn_std_profile_Click(object sender, EventArgs e)
        {
            Profile stdprofile = new Profile();
            stdprofile.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_view_lecs_Click(object sender, EventArgs e)
        {
            View_Lectures viewlecs = new View_Lectures();
            viewlecs.Show();
        }

        private void button1results_Click(object sender, EventArgs e)
        {
            ResultsForm formres = new ResultsForm();
            formres.Show();
        }

        private void btn_std_ruby_Click(object sender, EventArgs e)
        {
            string websiteUrl = "http://localhost/ROBY%20Chatbot/ROBY%20Chatbot/index.html";

            // Open the default web browser with the specified URL.
            Process.Start(websiteUrl);
        }
    }

}
