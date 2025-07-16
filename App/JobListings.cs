using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WinFormsApp1
{
    public partial class JobListings : Form
    {
        private String userID;
        public JobListings(string userIDFromForm5)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;      // Allow resizing
            this.MaximizeBox = true;                             // Allow maximize
            this.MinimizeBox = true;
            userID = userIDFromForm5;
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

        private void Form6_Load(object sender, EventArgs e)
        {
            ConnectDB();

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Job";
            cmd.CommandType = CommandType.Text;

            OracleDataAdapter da = new OracleDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Job");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Form6_Shown(object sender, EventArgs e)
        {
            ConnectDB();

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Job";
            cmd.CommandType = CommandType.Text;

            OracleDataAdapter da = new OracleDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Job");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Job";
            cmd.CommandType = CommandType.Text;

            OracleDataAdapter da = new OracleDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Job");
            dataGridView1.DataSource = ds.Tables[0];
            
        }
        private string GenerateApplicationId()
        {
            // Simple placeholder: A + random 4 digits
            Random rnd = new Random();
            return "A" + rnd.Next(1000, 9999).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDB();
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a job first.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            string jobId = selectedRow.Cells["Column1"].Value.ToString();
            string companyId = selectedRow.Cells["Column2"].Value.ToString();
            string userId = this.userID; // Assuming you're passing userID into Form5 as shown earlier

            // Generate a new application ID (e.g., "A001", "A002", etc.)
            string applicationId = GenerateApplicationId(); // You can implement your own logic here

            string status = "Pending";
            DateTime appDate = DateTime.Now;

            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"
            INSERT INTO Applications (APPLICATIONID, USERID, COMPANYID, JOBID, APPLICATIONDATE, STATUS) 
            VALUES (:applicationId, :userId, :companyId, :jobId, :appDate, :status)";

                cmd.Parameters.Add(new OracleParameter("applicationId", applicationId));
                cmd.Parameters.Add(new OracleParameter("userId", userId));
                cmd.Parameters.Add(new OracleParameter("companyId", companyId));
                cmd.Parameters.Add(new OracleParameter("jobId", jobId));
                cmd.Parameters.Add(new OracleParameter("appDate", appDate));
                cmd.Parameters.Add(new OracleParameter("status", status));

                cmd.ExecuteNonQuery();
                OracleTransaction transaction = conn.BeginTransaction();
                // Insert into Applications
                // Insert into Interview
                transaction.Commit();


                MessageBox.Show("Application submitted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying for job: " + ex.Message);
            }
        }
    }

    public class Job
    {
        public int JobID { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Industry { get; set; }
        public string Location { get; set; }
        public string PayRange { get; set; }

        public Job(int jobId, string companyName, string title, string industry, string location, string payRange)
        {
            JobID = jobId;
            CompanyName = companyName;
            Title = title;
            Industry = industry;
            Location = location;
            PayRange = payRange;
        }
    }
}
