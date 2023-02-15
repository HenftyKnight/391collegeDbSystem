using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPT391
{
    public partial class MyClass : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public MyClass()
        {
            InitializeComponent();

            stuID.Text = Login.username;
            Int32 sid = int.Parse(Login.username);
            String connectionString = "Server = DESKTOP-N0EUKH9; Database = REGISTRATION; Trusted_Connection = yes;";

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



            try
            {
                myCommand.CommandText = "select * from courses, student_courses where courses.course_id=student_courses.course_id and student_courses.student_id = " + sid;
                myReader = myCommand.ExecuteReader();

                dataGridView1.Rows.Clear();
                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["course_id"].ToString(), myReader["course_name"].ToString(), myReader["section"].ToString(), myReader["start_time"].ToString(), myReader["end_time"].ToString(), myReader["Day_of_the_week"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MyClass_Load(object sender, EventArgs e)
        {

        }
    }

}