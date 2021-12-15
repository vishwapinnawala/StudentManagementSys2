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
    public partial class addbooks : Form
    {
        public addbooks()
        {
            InitializeComponent();
        }
        dbcon con = new dbcon();
        
        private void savebtn_Click(object sender, EventArgs e)
        {
            int bid = Int32.Parse(bookid.Text);
            String st = con.addbook(bid,bname.Text,btype.Text);
            MessageBox.Show(st);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int bid = Int32.Parse(bookid.Text);
            String st = con.updatebook(bid, bname.Text, btype.Text);
            MessageBox.Show(st);
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            int bid = Int32.Parse(bookid.Text);
            String st = con.deletebook(bid);
            MessageBox.Show(st);
        }
    }
}
