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
    public partial class lecregform : Form
    {
        public lecregform()
        {
            InitializeComponent();
        }
        dbcon con = new dbcon();
        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lecregform_Load(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
          
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void savebtn_Click_1(object sender, EventArgs e)
        {
            int sid = Int32.Parse(lecid.Text);
            int degid = Int32.Parse(deg.Text);
            int deppid = Int32.Parse(depid.Text);
            String st = con.lecreg(sid, fname.Text, dob.Text, conno.Text, gender.Text, degid, deppid);
            MessageBox.Show(st);
        }

        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            int sid = Int32.Parse(lecid.Text);
            int degid = Int32.Parse(deg.Text);
            int deppid = Int32.Parse(depid.Text);

            String st = con.lecregupdate(sid, fname.Text, dob.Text, conno.Text, gender.Text, degid, deppid);
            MessageBox.Show(st);
        }

        private void delbtn_Click_1(object sender, EventArgs e)
        {
            int sid = Int32.Parse(lecid.Text);
            String st = con.sturegdelete(sid);
            MessageBox.Show(st);

        }

        private void searchbtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\WUSC SRILANKA\Documents\stumanage.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {

                string searchqry = "Select * from lecturers where lecid='" + searchbox.Text + "' ";
                SqlCommand cmd = new SqlCommand(searchqry, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    lecid.Text = r[0].ToString();
                    fname.Text = r[1].ToString();
                    dob.Text = r[2].ToString();
                    conno.Text = r[3].ToString();
                    gender.Text = r[4].ToString();
                    deg.Text = r[5].ToString();
                    depid.Text = r[6].ToString();
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            lecgrid obj = new lecgrid();
            obj.Show();
        }
    }
}
