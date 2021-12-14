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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            regdeplogin onj = new regdeplogin();
            this.Hide();
            onj.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            examlogin obj = new examlogin();
            this.Hide();
            obj.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            librylogin obj = new librylogin();
            this.Hide();
            obj.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            itdivlogin obj = new itdivlogin();
            this.Hide();
            obj.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            adminlogin onj = new adminlogin();
            this.Hide();
            onj.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            studentlogin obj = new studentlogin();
            this.Hide();
            obj.Show();

        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            partieslogin obj = new partieslogin();
            this.Hide();
            obj.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
