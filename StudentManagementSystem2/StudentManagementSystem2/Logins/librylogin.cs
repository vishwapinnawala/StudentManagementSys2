using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem2
{
    public partial class librylogin : Form
    {
        public librylogin()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (userid.Text == "vishwa" && password.Text == "vishwa") {
                libry obj = new libry();
                this.Hide();
                obj.Show();
            }
        }
    }
}
