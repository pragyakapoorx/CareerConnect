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
    public partial class Notifs : Form
    {
        public Notifs()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            ConnectDB();

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Notifications";
            cmd.CommandType = CommandType.Text;

            OracleDataAdapter da = new OracleDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Notifications");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
