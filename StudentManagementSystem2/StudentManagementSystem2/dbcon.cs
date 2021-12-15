using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentManagementSystem2
{
    class dbcon
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\WUSC SRILANKA\Documents\stumanage.mdf;Integrated Security=True;Connect Timeout=30");
        String st = "none";
        public String stureg(int stuid, String name, String dob, String conno, String gender, int DegID, int DepID)
        {
            string insertqry = "INSERT INTO students VALUES(" + stuid + ",'" + name + "','" + dob + "','" + conno + "','" + gender + "','" + DegID + "','" + DepID + "') ";
            SqlCommand cmd = new SqlCommand(insertqry, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Inserted Successfully!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String sturegupdate(int stuid, String name, String dob, String conno, String gender, int DegID, int DepID)
        {
            string updateqry = "update students set stuid=" + stuid + ",name='" + name + "',dob='" + dob + "',conno='" + conno + "',gender='" + gender + "',degid='" + DegID + "',depid='" + DepID + "' where stuid=" + stuid + " ";
            SqlCommand cmd = new SqlCommand(updateqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Update Successful!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String sturegdelete(int stuid)
        {
            string deleteqry = "DELETE FROM Students WHERE stuid=(" + stuid + ")";
            SqlCommand cmd = new SqlCommand(deleteqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Deletion Successful!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String subreg(int subid, String name, int degid, int lecid)
        {
            string insertqry = "INSERT INTO subjects VALUES(" + subid + ",'" + name + "'," + lecid + "," + degid + ") ";
            SqlCommand cmd = new SqlCommand(insertqry, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Inserted Successfully!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String subupdate(int subid, String name, int degid, int lecid)
        {
            string updateqry = "update subjects set subid=" + subid + ",subname='" + name + "',lecid='" + lecid + "',degid='" + degid + "' where subid=" + subid + " ";
            SqlCommand cmd = new SqlCommand(updateqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Update Successful!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String subdelete(int subid)
        {
            string deleteqry = "DELETE FROM subjects WHERE subid=(" + subid + ")";
            SqlCommand cmd = new SqlCommand(deleteqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Deletion Successful!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String stusubreg(int subid, int stuid)
        {
            string insertqry = "INSERT INTO studentsubject VALUES(" + stuid + "," + subid + ") ";
            SqlCommand cmd = new SqlCommand(insertqry, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Inserted Successfully!");
            }
            catch (SqlException ex)
            {
                // st = ("Error Occured" + ex.ToString());
                if (ex.Number == 547)
                {
                    st = "StudentID or SubjectID not found!";
                }
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String stusubupdate(int subid, int stuid, int newsubid, int newstuid)
        {
            string updateqry = "update studentsubject set subid=" + newsubid + ",stuid='" + newstuid + "' where subid=" + subid + " and stuid=" + stuid + " ";
            SqlCommand cmd = new SqlCommand(updateqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Update Successful!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    st = "StudentID or SubjectID not found!";
                }
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String stusubdelete(int subid, int stuid)
        {
            string deleteqry = "DELETE FROM studentsubject WHERE subid=(" + subid + ") and stuid=(" + stuid + ")";
            SqlCommand cmd = new SqlCommand(deleteqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Deletion Successful!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String stupwdreg(int stuid, String pwd)
        {
            string insertqry = "INSERT INTO studentpassword VALUES(" + stuid + ",'" + pwd + "') ";
            SqlCommand cmd = new SqlCommand(insertqry, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Inserted Successfully!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
                if (ex.Number == 547)
                {
                    st = "StudentID not found!";
                }
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String stupwddelete(int stuid)
        {
            string deleteqry = "DELETE FROM studentpassword WHERE stuid=(" + stuid + ")";
            SqlCommand cmd = new SqlCommand(deleteqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Deletion Successful!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String stupwdupdate(int stuid, String pwd)
        {
            string updateqry = "update studentpassword set stuid=" + stuid + ",pwd='" + pwd + "' where stuid=" + stuid + "";
            SqlCommand cmd = new SqlCommand(updateqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Update Successful!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    st = "StudentID or SubjectID not found!";
                }
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String addresult(int stuid, int subid, String result)
        {
            string insertqry = "INSERT INTO sturesults VALUES(" + stuid + "," + subid + ",'"+result+"') ";
            SqlCommand cmd = new SqlCommand(insertqry, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Inserted Successfully!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
                if (ex.Number == 547)
                {
                    st = "StudentID or SubjectID not found!";
                }
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String updateresult(int stuid,int subid ,String result)
        {
            string updateqry = "update sturesults set stuid=" + stuid + ",result='" + result + "' where stuid=" + stuid + " and subid="+subid+"";
            SqlCommand cmd = new SqlCommand(updateqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Update Successful!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    st = "StudentID or SubjectID not found!";
                }
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String deleteresult(int stuid,int subid)
        {
            string deleteqry = "DELETE FROM sturesults WHERE stuid=(" + stuid + ") and subid=("+subid+")";
            SqlCommand cmd = new SqlCommand(deleteqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Deletion Successful!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String addbook(int bookid, String bookname, String booktype)
        {
            string insertqry = "INSERT INTO books VALUES(" + bookid + ",'" + bookname + "','" + booktype + "') ";
            SqlCommand cmd = new SqlCommand(insertqry, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Inserted Successfully!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String updatebook(int bookid, String bookname, String booktype)
        {
            string updateqry = "update books set bookid=" + bookid + ",bookname='" + bookname + "',booktype='" + booktype + "' where bookid=" + bookid + " ";
            SqlCommand cmd = new SqlCommand(updateqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Update Successful!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String deletebook(int bookid)
        {
            string deleteqry = "DELETE FROM books WHERE bookid=(" + bookid + ")";
            SqlCommand cmd = new SqlCommand(deleteqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Deletion Successful!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String addstubook(int bookid, int stuid, String date)
        {
            string insertqry = "INSERT INTO givebooks VALUES(" + stuid + "," +bookid + ",'" + date + "') ";
            SqlCommand cmd = new SqlCommand(insertqry, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Inserted Successfully!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String updatestubook(int bookid, int stuid, String date)
        {
            string updateqry = "update givebooks set bookid=" + bookid + ",stuid=" + stuid + ",date='" + date + "' where bookid=" + bookid + " and stuid="+stuid+" ";
            SqlCommand cmd = new SqlCommand(updateqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Update Successful!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String deletestubook(int bookid,int stuid)
        {
            string deleteqry = "DELETE FROM givebooks WHERE bookid=(" + bookid + ") and stuid=("+stuid+")";
            SqlCommand cmd = new SqlCommand(deleteqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Deletion Successful!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String lecreg(int lecid, String name, String dob, String conno, String gender, int DegID, int DepID)
        {
            string insertqry = "INSERT INTO lecturers VALUES(" + lecid + ",'" + name + "','" + dob + "','" + conno + "','" + gender + "','" + DegID + "','" + DepID + "') ";
            SqlCommand cmd = new SqlCommand(insertqry, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Inserted Successfully!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String lecregupdate(int lecid, String name, String dob, String conno, String gender, int DegID, int DepID)
        {
            string updateqry = "update lecturers set lecid=" + lecid + ",name='" + name + "',dob='" + dob + "',conno='" + conno + "',gender='" + gender + "',degid='" + DegID + "',depid='" + DepID + "' where lecid=" + lecid + " ";
            SqlCommand cmd = new SqlCommand(updateqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Update Successful!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }

        public String lecregdelete(int lecid)
        {
            string deleteqry = "DELETE FROM lecturers WHERE lecid=(" + lecid + ")";
            SqlCommand cmd = new SqlCommand(deleteqry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                st = ("Data Deletion Successful!");
            }
            catch (SqlException ex)
            {
                st = ("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return st;
        }


    }
}


