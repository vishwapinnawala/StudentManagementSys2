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

namespace StudentManagementSystem2
{
    public partial class subjectregform : Form
    {
        public subjectregform()
        {
            InitializeComponent();
        }
        dbcon con = new dbcon();
        private void savebtn_Click(object sender, EventArgs e)
        {
            int sid = Int32.Parse(subid.Text);
            int degid = Int32.Parse(deg.Text);
            int lec = Int32.Parse(lecid.Text);
            String st = con.subreg(sid, sname.Text, degid, lec);
            MessageBox.Show(st);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int sid = Int32.Parse(subid.Text);
            int degid = Int32.Parse(deg.Text);
            int lec = Int32.Parse(lecid.Text);
            String st = con.subupdate(sid, sname.Text, degid, lec);
            MessageBox.Show(st);
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            int sid = Int32.Parse(subid.Text);
            String st = con.subdelete(sid);
            MessageBox.Show(st);
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\WUSC SRILANKA\Documents\stumanage.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {

                string searchqry = "Select * from subjects where subid='" + searchbox.Text + "' ";
                SqlCommand cmd = new SqlCommand(searchqry, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    subid.Text = r[0].ToString();
                    sname.Text = r[1].ToString();
                    lecid.Text = r[2].ToString();
                    deg.Text = r[3].ToString();
                   
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            studentreg obj = new studentreg();
            this.Hide();
            obj.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            subgrid obj = new subgrid();
            obj.Show();
        }
    }
}
