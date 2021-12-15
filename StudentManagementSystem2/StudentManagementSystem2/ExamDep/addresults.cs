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
    public partial class addresults : Form
    {
        public addresults()
        {
            InitializeComponent();
        }
        dbcon con = new dbcon();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stuid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            int stuidd=  Int32.Parse(stuid.Text);
            int subidd = Int32.Parse(fname.Text);
                    
            String st = con.addresult(stuidd,subidd,guna2TextBox1.Text);
            MessageBox.Show(st);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int stuidd = Int32.Parse(stuid.Text);
            int subidd = Int32.Parse(fname.Text);

            String st = con.updateresult(stuidd, subidd, guna2TextBox1.Text);
            MessageBox.Show(st);
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            int stuidd = Int32.Parse(stuid.Text);
            int subidd = Int32.Parse(fname.Text);

            String st = con.deleteresult(stuidd, subidd);
            MessageBox.Show(st);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int stuidd = Int32.Parse(tbox.Text);
            string qry = "SELECT stuid as StudentID, subid as SubjectID,result as Result FROM sturesults where stuid="+stuidd+"";
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
            examform obj = new examform();
            this.Hide();
            obj.Show();
        }
    }
}
