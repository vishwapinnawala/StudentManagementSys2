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
    public partial class stulibryreg : Form
    {
        public stulibryreg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        dbcon con = new dbcon();
        private void savebtn_Click(object sender, EventArgs e)
        {
            int bid = Int32.Parse(bookid.Text);
            int stid = Int32.Parse(stuid.Text);
            String st = con.addstubook(bid,stid,date.Text);
            MessageBox.Show(st);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int bid = Int32.Parse(bookid.Text);
            int stid = Int32.Parse(stuid.Text);
            String st = con.updatestubook(bid, stid, date.Text);
            MessageBox.Show(st);
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            int bid = Int32.Parse(bookid.Text);
            int stid = Int32.Parse(stuid.Text);
            String st = con.deletestubook(bid, stid);
            MessageBox.Show(st);
        }
    }
}
