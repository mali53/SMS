using MaterialSkin;
using MaterialSkin.Controls;
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


namespace School_Management_System
{
    public partial class SocialMedia : MaterialForm
    {
        public SocialMedia()
        {
            InitializeComponent();

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

        private void SocialMedia_Load(object sender, EventArgs e)
        {
            buttonfacebook.Parent = pictureBoxsocial;
            buttonfacebook.BackColor = Color.Transparent;

            buttoninsta.Parent = pictureBoxsocial;
            buttoninsta.BackColor = Color.Transparent;

            buttonx.Parent = pictureBoxsocial;
            buttonx.BackColor = Color.Transparent;

            buttonwhatsapp.Parent = pictureBoxsocial;
            buttonwhatsapp.BackColor = Color.Transparent;
        }

        private void buttonfacebook_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.facebook.com/";

            // Open the default web browser with the specified URL.
            Process.Start(websiteUrl);
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://twitter.com/?lang=en";

            // Open the default web browser with the specified URL.
            Process.Start(websiteUrl);
        }

        private void buttoninsta_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.instagram.com/";

            // Open the default web browser with the specified URL.
            Process.Start(websiteUrl);
        }

        private void buttonwhatsapp_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://web.whatsapp.com/";

            // Open the default web browser with the specified URL.
            Process.Start(websiteUrl);
        }
    }
}
