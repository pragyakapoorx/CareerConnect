using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ApplicantHomePage : Form
    {
        private String userID;
        public ApplicantHomePage(string userIDFromForm1)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;      // Allow resizing
            this.MaximizeBox = true;                             // Allow maximize
            this.MinimizeBox = true;
            userID = userIDFromForm1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show a message box with the text "No new notifications"
            Notifs form9 = new Notifs();
            form9.Show();
            //MessageBox.Show("No new notifications", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            JobListings form6 = new JobListings(userID);
            form6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Interview Scheduled", "Interviews", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
