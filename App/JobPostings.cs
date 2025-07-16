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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class JobPostings : Form
    {
        public JobPostings()
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
        private void Form7_Load(object sender, EventArgs e)
        {
            ConnectDB();

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Applications";
            cmd.CommandType = CommandType.Text;

            OracleDataAdapter da = new OracleDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Applications");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private string GenerateInterviewId()
        {
            // Simple placeholder: A + random 4 digits
            Random rnd = new Random();
            return "I" + rnd.Next(1000, 9999).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an application first.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            string interviewId = GenerateInterviewId();
            string applicationId = selectedRow.Cells["Column1"].Value.ToString();
            string userId = selectedRow.Cells["Column2"].Value.ToString();
            string companyId = selectedRow.Cells["Column3"].Value.ToString();
            string jobId = selectedRow.Cells["Column4"].Value.ToString();

            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"
            INSERT INTO Interview (INTERVIEWID, APPLICATIONID, USERID, COMPANYID, JOBID) 
            VALUES (:interviewId, :applicationId, :userId, :companyId, :jobId)";

                cmd.Parameters.Add(new OracleParameter("interviewId", interviewId));
                cmd.Parameters.Add(new OracleParameter("applicationId", applicationId));
                cmd.Parameters.Add(new OracleParameter("userId", userId));
                cmd.Parameters.Add(new OracleParameter("companyId", companyId));
                cmd.Parameters.Add(new OracleParameter("jobId", jobId));


                cmd.ExecuteNonQuery();
                MessageBox.Show("Interview scheduled successfully!");


                OracleCommand cmd1 = conn.CreateCommand();
                cmd1.CommandText = @"
        UPDATE Applications
        SET Status = 'Accepted'
        WHERE ApplicationID = :applicationId
          AND UserID = :userId
          AND CompanyID = :companyId
          AND JobID = :jobId";

                cmd1.Parameters.Add(new OracleParameter("applicationId", applicationId));
                cmd1.Parameters.Add(new OracleParameter("userId", userId));
                cmd1.Parameters.Add(new OracleParameter("companyId", companyId));
                cmd1.Parameters.Add(new OracleParameter("jobId", jobId));


                cmd1.ExecuteNonQuery();
                MessageBox.Show("Application updated successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error scheduling interview for: " + ex.Message);
            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB();

                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"
                SELECT * FROM Job
                WHERE (JobID, CompanyID) NOT IN (
                SELECT JobID, CompanyID FROM Applications
            )";

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching unapplied jobs: " + ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnectDB();

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Applications";
            cmd.CommandType = CommandType.Text;

            OracleDataAdapter da = new OracleDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Applications");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
