using System.Data;
using Oracle.ManagedDataAccess.Client;
namespace WinFormsApp1
{
    public partial class SignIn : Form
    {
        public SignIn()
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
        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();

            // Create and show the new form
            SignUp form2 = new SignUp();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim(); // Get input and remove extra spaces
            ConnectDB();
            OracleCommand command1 = conn.CreateCommand();
            command1.CommandText = "SELECT password FROM UserTable WHERE UserID = '" + input + "'";
            command1.CommandType = CommandType.Text;

            OracleDataReader dr = command1.ExecuteReader();
            dr.Read();
            String userPassword = dr.GetString(0);        //retrieve first attribute from table

            //MessageBox.Show("Password: " + userPassword);
            //Extract numeric part from the string (assuming format is always 'U' followed by a number)
            if (input.StartsWith("U") && int.TryParse(input.Substring(1), out int value))
            {

                if (userPassword.Equals(textBox2.Text)) //Correct Password
                {

                    if (value < 1000)
                    {
                        // Open Form5 if value is less than 1000
                        ApplicantHomePage form5 = new ApplicantHomePage(input);
                        form5.Show();
                    }
                    else
                    {
                        // Open if value is 1000 or more
                        EmployerHomePage form8 = new EmployerHomePage(input);
                        form8.Show();
                        /*Form4 form4 = new Form4();
                        form4.Show(); */
                    }
                    // Optional: Hide the current form
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect password. Please try again.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                // Show an error message if input is not in the correct format
                MessageBox.Show("Invalid input. Please enter a valid ID in the format 'Uxxxx'.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
