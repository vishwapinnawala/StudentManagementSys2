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
    public partial class lecgrid : Form
    {
        public lecgrid()
        {
            InitializeComponent();
        }

        private void lecgrid_Load(object sender, EventArgs e)
        {
            string qry = "SELECT lecid as LecturerID, name as Name, dob as DOB,conno as ContactNo, gender as Gender,degid as Degid,depid as DepID  FROM lecturers";
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
    }
}
