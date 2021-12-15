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
    public partial class examform : Form
    {
        public examform()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addresults obj = new addresults();
            this.Hide();
            obj.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            subview obj = new subview();
            this.Hide();
            obj.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            allexamresults obj = new allexamresults();
            this.Hide();
            obj.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }
    }
}
