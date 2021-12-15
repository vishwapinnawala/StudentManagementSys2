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
    public partial class subview : Form
    {
        public subview()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            examform obj = new examform();
            this.Hide();
            obj.Show();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            String qry = "";
            if (searchbox.Text == "")
            {
                qry = "select s.subid as SubjectID,s.subname as Subjectname,l.name as LecturerName from subjects s,lecturers l where s.lecid=l.lecid;";
            }
            else
            {
                qry = "select s.subid as SubjectID,s.subname as Subjectname,l.name as LecturerName from subjects s,lecturers l where s.lecid=l.lecid;";
            }
        }
    }
}
