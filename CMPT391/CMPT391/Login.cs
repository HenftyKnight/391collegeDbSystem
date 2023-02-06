using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPT391
{
    public partial class Login : Form
    {

        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public string connectionString;


        public Login()
        {
            InitializeComponent();
            String connectionString = "Server = WAKA; Database = SCHOOL; Trusted_Connection = yes;";


            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

        }

        public static string username = "";


        private void button2_Click(object sender, EventArgs e)
        {
            username = UsernameBox.Text;
            SqlConnection con = new SqlConnection(@"Data Source=WAKA;Initial Catalog=SCHOOL;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from dbo.students where username=@ANum and passwd=@Pass", con);
            cmd.Parameters.AddWithValue("@ANum", UsernameBox.Text);
            cmd.Parameters.AddWithValue("@Pass", passwordBox.Text);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            sda.Fill(dt);


            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            int count = dt.Tables[0].Rows.Count;

            if (count == 1)
            {
                MessageBox.Show("Logged in!");
                this.Hide();
                Registration a1 = new Registration();
                a1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect account number or password!");
            }
        }

    }
}