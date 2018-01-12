using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DATABASE
{
    public static class librarianLog
    {
        static OleDbConnection con = new OleDbConnection();
        static OleDbCommand cmd = new OleDbCommand();
        static OleDbDataReader rdr;

        static void connectDatabase()
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kennlising\Desktop\LibraryOneSystems_FINAL\LibraryOneSystems_FINAL\LibraryData.accdb;Persist Security Info=True";
            cmd.Connection = con;
        }

        public static void login()
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = @"insert into tbl_librarianLog (librarianLog_username, librarianLog_lastName, librarianLog_firstName, librarianLog_TimeIn, librarianLog_TimeOut)
                values ('" + INFO.librarian.Username + "', '" + INFO.librarian.Lastname + "', '" + INFO.librarian.Firstname + "', '" + DateTime.Now.ToShortDateString() +" "+ DateTime.Now.ToShortTimeString()  + "', '"+"ACTIVE"+"')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }

        }

        public static void logout()
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "update tbl_librarianLog set librarianLog_TimeOut = '" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "' where librarianLog_username = '" + INFO.librarian.Username + "' and librarianLog_TimeOut = '" + "ACTIVE" + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void display(ListView list)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_librarianLog";
                rdr = cmd.ExecuteReader();
                list.Items.Clear();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        ListViewItem items = new ListViewItem(rdr[0].ToString());
                        items.SubItems.Add(rdr[1].ToString());
                        items.SubItems.Add(rdr[2].ToString());
                        items.SubItems.Add(rdr[3].ToString());
                        items.SubItems.Add(rdr[4].ToString());
                        list.Items.Add(items);
                    }
                }
                con.Close();
                rdr.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void deleteHistory()
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "delete * from tbl_librarianLog";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("History Successfully Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
