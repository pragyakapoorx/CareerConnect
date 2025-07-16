using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WinFormsApp1
{
    public partial class EmployerHomePage : Form
    {
        String userID;
        public EmployerHomePage(String input)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;      // Allow resizing
            this.MaximizeBox = true;                             // Allow maximize
            this.MinimizeBox = true;
            userID = input;
        }
        OracleConnection conn;
        public void ConnectDB()
        {
            conn = new OracleConnection("Data Source=127.0.0.1;User ID=ict;PASSWORD=ict23");
            try
            {
                conn.Open();
                //MessageBox.Show("Connected");
            }
            catch (Exception e1)
            {
            }
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            ConnectDB();
            OracleCommand command1 = conn.CreateCommand();
            command1.CommandText = "SELECT name FROM UserTable WHERE UserID = '" + userID + "'";
            command1.CommandType = CommandType.Text;

            OracleDataReader dr = command1.ExecuteReader();
            dr.Read();
            String username = dr.GetString(0);

            label1.Text = "Welcome, " + username.ToString() + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JobModule form4 = new JobModule();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JobPostings form7 = new JobPostings();
            form7.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
