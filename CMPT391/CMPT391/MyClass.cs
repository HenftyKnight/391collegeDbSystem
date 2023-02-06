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
    public partial class MyClass : Form
    {
        public MyClass()
        {   
            InitializeComponent();
            stuID.Text = Login.username;
            
        }
    }
}
