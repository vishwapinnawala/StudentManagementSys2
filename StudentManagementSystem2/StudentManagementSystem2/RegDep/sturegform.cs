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
    public partial class sturegform : Form
    {
        public sturegform()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        dbcon con = new dbcon();

        private void savebtn_Click(object sender, EventArgs e)
        {
            int sid = Int32.Parse(stuid.Text);
            int degid = Int32.Parse(deg.Text);
            int deppid = Int32.Parse(depid.Text);
            String st=con.stureg(sid,fname.Text,dob.Text,conno.Text,gender.Text,degid,deppid);
            MessageBox.Show(st);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int sid = Int32.Parse(stuid.Text);
            int degid = Int32.Parse(deg.Text);
            int deppid = Int32.Parse(depid.Text);
            
            String st = con.sturegupdate(sid, fname.Text, dob.Text, conno.Text, gender.Text, degid, deppid);
            MessageBox.Show(st);
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            int sid = Int32.Parse(stuid.Text);
            String st = con.sturegdelete(sid);
            MessageBox.Show(st);
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\WUSC SRILANKA\Documents\stumanage.mdf;Integrated Security=True;Connect Timeout=30");
                     try
                {

                    string searchqry = "Select * from students where stuid='" + searchbox.Text + "' ";
                    SqlCommand cmd = new SqlCommand(searchqry, con);
                    con.Open();
                    SqlDataReader r = cmd.ExecuteReader();

                    while (r.Read())
                    {
                        stuid.Text = r[0].ToString();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            studentgrid obj = new studentgrid();
            obj.Show();
        }

        private void sturegform_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            studentreg obj=new studentreg();
            this.Hide();
            obj.Show();
        }
       
    }
}
