using System.Data;
using System.Data.SqlClient;

namespace collegeRegistrationSystem
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=ANDROMEDA;Initial Catalog=REGISTRATION;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Get the user's input
            string username = userName.Text;
            string password = passwordTextBox.Text;

            // Connect to the database
            using (SqlConnection connection = new SqlConnection("Data Source=ANDROMEDA;Initial Catalog=REGISTRATION;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("usp_Login", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@isSuccessful";
                    outputParameter.SqlDbType = SqlDbType.Bit;
                    outputParameter.Direction = ParameterDirection.Output;

                    command.Parameters.Add(outputParameter);

                    command.ExecuteNonQuery();

                    bool isSuccessful = (bool)outputParameter.Value;

                    if (isSuccessful)
                    {
                        // Login was successful
                        MessageBox.Show("Login SucessFull");
                        this.Hide()
                    }
                    else
                    {
                        // Login was unsuccessful
                        MessageBox.Show("Login failed. Please check your username and password and try again.");
                    }
                }
            }
        }
    }
}