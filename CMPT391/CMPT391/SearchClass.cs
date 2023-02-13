using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT391
{
    public partial class SearchClass : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public string connectionString;

        public SearchClass()
        {
            InitializeComponent();

            //String connectionString = "Server = WAKA; Database = SCHOOL; Trusted_Connection = yes;";
            String connectionString = "Server = LAPTOP-Q9IE4QUU; Database = REGISTRATION; Trusted_Connection = yes;";


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



            }
        }

        private void SearchClass_Load(object sender, EventArgs e)
        {
            courseList.FullRowSelect = true;
            courseList.Items.Clear();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-Q9IE4QUU;Initial Catalog=REGISTRATION;Integrated Security=True");

            courseList.Items.Clear();
            String searchCourse = searchBox.Text;

            using (SqlCommand cmd = new SqlCommand("select * from dbo.courses where course_name like '%" + searchCourse +"%';", con))
            {
                //cmd.Parameters.AddWithValue("@ACourse", searchBox.Text);
                con.Open();

                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["course_name"].ToString());
                        item.SubItems.Add(row["section"].ToString());
                        item.SubItems.Add(row["start_time"].ToString());
                        item.SubItems.Add(row["end_time"].ToString());
                        item.SubItems.Add(row["day_of_the_week"].ToString());
                        item.SubItems.Add(row["max_capacity"].ToString());
                        item.SubItems.Add(row["seats_available"].ToString());
                        //add instructor
                        courseList.Items.Add(item);

                    }
                }

                con.Close();
            }
        }
    
    }
}
