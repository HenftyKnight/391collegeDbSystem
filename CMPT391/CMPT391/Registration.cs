using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT391
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();


        }




        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchClass form = new() {Dock = DockStyle.Fill  ,TopLevel = false, TopMost = true };
            form.FormBorderStyle= FormBorderStyle.None;
            this.panel1.Controls.Add(form);
            form.BringToFront();
           
            form.Show();
        }

        private void classBtn_Click(object sender, EventArgs e)
        {

            MyClass form = new() { TopLevel = false, TopMost = true };
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(form);
            form.BringToFront();
            form.Refresh();
            form.Show();

        }
    }
}
