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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;      // Allow resizing
            this.MaximizeBox = true;                             // Allow maximize
            this.MinimizeBox = true;
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
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = radioButton2.Checked;
            textBox2.Visible = radioButton2.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = false;
            textBox2.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();

            string userId = textBox1.Text;
            string name = textBox4.Text + " " + textBox3.Text;
            string gender = comboBox1.Text;
            DateTime dob = dateTimePicker1.Value.Date;
            string email = textBox6.Text;
            string password = textBox5.Text;

            //Insert into UserTable
            OracleCommand command1 = conn.CreateCommand();
            command1.CommandText = "INSERT INTO UserTable (UserId, Name, Gender, DOB, Email, Password) " +
                                   "VALUES (:userId, :name, :gender, :dob, :email, :password)";
            command1.CommandType = CommandType.Text;

            command1.Parameters.Add(new OracleParameter("userId", userId));
            command1.Parameters.Add(new OracleParameter("name", name));
            command1.Parameters.Add(new OracleParameter("gender", gender));
            command1.Parameters.Add(new OracleParameter("dob", dob));
            command1.Parameters.Add(new OracleParameter("email", email));
            command1.Parameters.Add(new OracleParameter("password", password));

            command1.ExecuteNonQuery();
            command1.Dispose();
            MessageBox.Show("UserTable successful");


            //Insert into UserRoles
            String role;
            bool isEmployer = false;
            if (radioButton1.Checked) {
                role = "Job Seeker";
            }
            else
            {
                role = "Employer";
                isEmployer = true;
            }

            OracleCommand command2 = conn.CreateCommand();
            command2.CommandText = "INSERT INTO UserRoles (UserId, Role) " +
                                   "VALUES (:userId, :role)";
            command2.CommandType = CommandType.Text;
            command2.Parameters.Add(new OracleParameter("userId", userId));
            command2.Parameters.Add(new OracleParameter("role", role));
            
            command2.ExecuteNonQuery();
            command2.Dispose();
            MessageBox.Show("UserRoles successful");

            //Insert into Employers
            if (isEmployer)
            {
                isEmployer = false;
                String companyId = textBox2.Text;
                OracleCommand command3 = conn.CreateCommand();
                command3.CommandText = "INSERT INTO Employers (UserId, CompanyId) " +
                                       "VALUES (:userId, :companyId)";
                command3.CommandType = CommandType.Text;
                command3.Parameters.Add(new OracleParameter("userId", userId));
                command3.Parameters.Add(new OracleParameter("companyId", companyId));

                command3.ExecuteNonQuery();
                command3.Dispose();
            }
            MessageBox.Show("Employers successful");


            conn.Close();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
