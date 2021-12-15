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
    public partial class subassing : Form
    {
        public subassing()
        {
            InitializeComponent();
        }
        dbcon con = new dbcon();
        private void savebtn_Click(object sender, EventArgs e)
        {
            int sub = Int32.Parse(subid.Text);
            int stu = Int32.Parse(stuid.Text);
            
            String st = con.stusubreg(sub,stu);
            MessageBox.Show(st);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int sub = Int32.Parse(subid.Text);
            int stu = Int32.Parse(stuid.Text);
            int newsub = Int32.Parse(newsubid.Text);
            int newstu = Int32.Parse(newstuid.Text);

            String st = con.stusubupdate(sub, stu, newsub, newstu);
            MessageBox.Show(st);
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            int sub = Int32.Parse(subid.Text);
            int stu = Int32.Parse(stuid.Text);

            String st = con.stusubdelete(sub, stu);
            MessageBox.Show(st);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            studentreg obj = new studentreg();
            this.Hide();
            obj.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            subassinggrid obj = new subassinggrid();
            obj.Show();
        }
    }
}
