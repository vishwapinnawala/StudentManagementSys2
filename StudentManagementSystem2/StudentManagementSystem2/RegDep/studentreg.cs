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
    public partial class studentreg : Form
    {
        public studentreg()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            subjectregform obj = new subjectregform();
            this.Hide();
            obj.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sturegform obj = new sturegform();
            this.Hide();
            obj.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            subassing obj = new subassing();
            this.Hide();
            obj.Show();
        }

        private void studentreg_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            lecregform obj = new lecregform();
            this.Hide();
            obj.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

    }
}
