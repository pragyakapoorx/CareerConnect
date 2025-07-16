using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace WinFormsApp1
{
    public partial class JobModule : Form
    {
        public JobModule()
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

            conn = new OracleConnection("DATA SOURCE=127.0.0.1:1521/xe;USER ID=ict;PASSWORD=ict23");//PASSWORD CLAUSE REMEMBER

            try
            {

                conn.Open();

                //MessageBox.Show("Connected");

            }

            catch (Exception e1)
            {

            }

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();  // Connect to the database

            string CID;
            string JID;
            string des;
            string title;
            string maxp;
            string minp;

            // Get values from textboxes
            CID = textBox1.Text;
            JID = textBox2.Text;
            des = textBox6.Text;
            title = textBox4.Text;
            minp = textBox3.Text;
            maxp = textBox5.Text;

            // Create command
            OracleCommand command1 = conn.CreateCommand();
            command1.CommandType = CommandType.Text;
            command1.CommandText = "INSERT INTO Job (JobID, CompanyID, Title, Description, MinPay, MaxPay) " +
                                   "VALUES (:JID, :CID, :Title, :Description, :MinPay, :MaxPay)";

            // Add parameters to prevent SQL injection
            command1.Parameters.Add(":JID", OracleDbType.Varchar2).Value = JID;
            command1.Parameters.Add(":CID", OracleDbType.Varchar2).Value = CID;
            command1.Parameters.Add(":Title", OracleDbType.Varchar2).Value = title;
            command1.Parameters.Add(":Description", OracleDbType.Varchar2).Value = des;

            // Convert minp and maxp to integers safely
            int minPayValue, maxPayValue;
            if (!int.TryParse(minp, out minPayValue) || minPayValue <= 0)
            {
                MessageBox.Show("Invalid MinPay value. It must be a positive integer.");
                conn.Close();
                return;
            }

            if (!int.TryParse(maxp, out maxPayValue))
            {
                MessageBox.Show("Invalid MaxPay value.");
                conn.Close();
                return;
            }

            command1.Parameters.Add(":MinPay", OracleDbType.Int32).Value = minPayValue;
            command1.Parameters.Add(":MaxPay", OracleDbType.Int32).Value = maxPayValue;

            // Execute query
            try
            {
                command1.ExecuteNonQuery();
                MessageBox.Show("Insertion Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Clean up
            command1.Dispose();
            conn.Close();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create and show the new form
            CompanyModule form3 = new CompanyModule();
            form3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
