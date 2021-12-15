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
    public partial class studentpwds : Form
    {
        public studentpwds()
        {
            InitializeComponent();
        }
        dbcon con = new dbcon();

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            int stid = Int32.Parse(stuid.Text);

            String st = con.stupwddelete(stid);
            MessageBox.Show(st);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void stuid_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int stid = Int32.Parse(stuid.Text);

            String st = con.stupwdupdate(stid,pwd.Text);
            MessageBox.Show(st);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            int stid =Int32.Parse(stuid.Text);
            
            String st=con.stupwdreg(stid,pwd.Text);
            MessageBox.Show(st);
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            string qry = "SELECT stuid as StudentID, pwd as Password  FROM studentpassword";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\WUSC SRILANKA\Documents\stumanage.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Student");
                dgv1.DataSource = ds.Tables["Student"];
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("Error Occured" + Ex.ToString());
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\WUSC SRILANKA\Documents\stumanage.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {

                string searchqry = "Select * from studentpassword where stuid='" + stuid.Text + "' ";
                SqlCommand cmd = new SqlCommand(searchqry, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    stuid.Text = r[0].ToString();
                    pwd.Text = r[1].ToString();
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ITDiv.itdiv obj = new ITDiv.itdiv();
            this.Hide();
            obj.Show();
        }
    }
}
