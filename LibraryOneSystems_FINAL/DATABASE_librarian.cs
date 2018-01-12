using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DATABASE
{
    public static class librarian
    {
        static OleDbConnection con = new OleDbConnection();
        static OleDbCommand cmd = new OleDbCommand();
        static OleDbDataReader rdr;

        static void connectDatabase()
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kennlising\Desktop\LibraryOneSystems_FINAL\LibraryOneSystems_FINAL\LibraryData.accdb;Persist Security Info=True";
            cmd.Connection = con;
        }

        public static void add(List<string> infos)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = @"INSERT INTO tbl_librarian (librarian_username, librarian_password, librarian_lastName, librarian_firstName, librarian_timeIn, librarian_timeOut, librarian_email)
                VALUES ('"+infos[0]+"','"+infos[1]+"','"+infos[2]+"','"+infos[3]+"','"+infos[4]+"','"+infos[5]+"','"+infos[6]+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                EMAIL.MailSystem.send(infos[6], "Registration Complete ! ! !", "Thank you for registering to Libraryone System.\n\nACCOUNT INFORMATION\n\nName : " + infos[3] + " " + infos[2] + "\nUsername : " + infos[0] + "\nPassword : " + infos[1] + "\nTime IN : " + Convert.ToDateTime(infos[4]).ToShortTimeString() + "\nTime OUT : " + Convert.ToDateTime(infos[5]).ToShortTimeString());
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void update(List<string> infos)
        {
            try
            {
                //update tbl_librarian
                connectDatabase();
                con.Open();
                cmd.CommandText = @"UPDATE tbl_librarian SET librarian_username = '"+infos[0]+"',librarian_password = '"+infos[1]+"',librarian_lastName = '"+infos[2]+"',librarian_firstName = '"+infos[3]+"',librarian_email = '"+infos[4]+"' WHERE librarian_username = '"+infos[5]+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                //update tbl_librarianLog
                connectDatabase();
                con.Open();
                cmd.CommandText = "update tbl_librarianLog set librarianLog_username = '" + infos[0] + "', librarianLog_lastName = '" + infos[2] + "', librarianLog_firstName = '" + infos[3] + "' where librarianLog_username = '"+infos[5]+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                //update tbl_brLog
                connectDatabase();
                con.Open();
                cmd.CommandText = "update tbl_brLog set brLog_fromWho_user = '" + infos[0] + "' where brLog_fromWho_user = '" + infos[5] + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update tbl_brLog set brLog_returnTo_user = '" + infos[0] + "' where brLog_returnTo_user = '" + infos[5] + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update tbl_brLog set brLog_fromWho = '" + infos[3] + " " + infos[2] + "' where brLog_fromWho_user = '" + infos[0] + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update tbl_brLog set brLog_returnTo = '" + infos[3] + " " + infos[2] + "' where brLog_returnTo_user = '" + infos[0] + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Librarian Info Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EMAIL.MailSystem.send(infos[4], "Update Complete", "Thank you for using Libraryone System.\n\nACCOUNT INFORMATION\n\nName : " + infos[3] + " " + infos[2] + "\nUsername : " + infos[0] + "\nPassword : " + infos[1]);
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void delete(string user)
        {
            try
            {
                //tbl_librarian
                connectDatabase();
                con.Open();
                cmd.CommandText = "DELETE * FROM tbl_librarian WHERE librarian_username = '" + user + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                //tbl_librarianLog
                connectDatabase();
                con.Open();
                cmd.CommandText = "DELETE * FROM tbl_librarianLog WHERE librarianLog_username = '"+user+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Successfully Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void updateTime(List<string> infos)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "UPDATE tbl_librarian SET librarian_timeIn = '" + infos[3] + "' , librarian_timeOut = '" + infos[4] + "' WHERE librarian_username = '" + infos[0] + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EMAIL.MailSystem.send(infos[5], "Time Update", "The Admin Decided to change your schedule .\n\nNEW TIME SCHEDULE\n\nTime IN : " + Convert.ToDateTime(infos[3]).ToShortTimeString() + "\nTime OUT : " + Convert.ToDateTime(infos[4]).ToShortTimeString());
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
                cmd.CommandText = "SELECT * FROM tbl_librarian";
                rdr = cmd.ExecuteReader();
                list.Items.Clear();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        ListViewItem items = new ListViewItem(rdr[0].ToString());
                        items.SubItems.Add(rdr[2].ToString());
                        items.SubItems.Add(rdr[3].ToString());
                        items.SubItems.Add(Convert.ToDateTime(rdr[4].ToString()).ToShortTimeString());
                        items.SubItems.Add(Convert.ToDateTime(rdr[5].ToString()).ToShortTimeString());
                        items.SubItems.Add(rdr[6].ToString());
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

        public static void displaySearch(string key, ListView list)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "select * from tbl_librarian where librarian_username like '%" + key + "%' OR librarian_lastName like '%" + key + "%' OR librarian_firstName like '%" + key + "%' OR librarian_timeIn like '%" + key + "%' OR librarian_timeOut like '%" + key + "%'OR librarian_email like '%" + key + "%'";
                rdr = cmd.ExecuteReader();
                list.Items.Clear();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        ListViewItem items = new ListViewItem(rdr[0].ToString());
                        items.SubItems.Add(rdr[2].ToString());
                        items.SubItems.Add(rdr[3].ToString());
                        items.SubItems.Add(Convert.ToDateTime(rdr[4].ToString()).ToShortTimeString());
                        items.SubItems.Add(Convert.ToDateTime(rdr[5].ToString()).ToShortTimeString());
                        items.SubItems.Add(rdr[6].ToString());
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



        public static void displayHistory(ListView list)
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
                        items.SubItems.Add(Convert.ToDateTime(rdr[3].ToString()).ToShortTimeString());
                        items.SubItems.Add(Convert.ToDateTime(rdr[4].ToString()).ToShortTimeString());
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

        public static void displaySearchHistory(string key, ListView list)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "select * from tbl_librarianLog where librarianLog_username like '%" + key + "%' OR librarianLog_lastName like '%" + key + "%' OR librarianLog_firstName like '%" + key + "%' OR librarianLog_TimeIn like '%" + key + "%' OR librarianLog_TimeOut like '%" + key + "%'";
                rdr = cmd.ExecuteReader();
                list.Items.Clear();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        ListViewItem items = new ListViewItem(rdr[0].ToString());
                        items.SubItems.Add(rdr[1].ToString());
                        items.SubItems.Add(rdr[2].ToString());
                        items.SubItems.Add(Convert.ToDateTime(rdr[3].ToString()).ToShortTimeString());
                        items.SubItems.Add(Convert.ToDateTime(rdr[4].ToString()).ToShortTimeString());
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

        public static void resetPassword(List<string> infos)
        {
            string randomPassword = "";
            string allVar = "1234567890qwertyuiopasdfghjklzxcvbnm";
            char[] collections = allVar.ToCharArray();
            Random r = new Random();
            for (int x = 0; x <= 7; x++)
            {
                randomPassword += collections[r.Next(0, collections.Length)].ToString();
            }

            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "update tbl_librarian set librarian_password = '" + randomPassword + "' where librarian_email = '" + infos[1] + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                EMAIL.MailSystem.send(infos[1], "Reset Password Complete", "Hello\n\n\nPlease Dont forget your password next time\n\nUsername : "+ infos[0] +"\nNew Password : " + randomPassword);
                MessageBox.Show("Please Check Your Mail For Your New Password", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static class Username
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    cmd.CommandText = "SELECT * FROM tbl_librarian";
                    rdr = cmd.ExecuteReader();
                    data.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            data.Add(rdr[0].ToString());
                        }
                    }
                    con.Close();
                    rdr.Close();
                    return data;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message.ToString());
                    return data;
                }
            }
        }

        public static class Password
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    cmd.CommandText = "SELECT * FROM tbl_librarian";
                    rdr = cmd.ExecuteReader();
                    data.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            data.Add(rdr[1].ToString());
                        }
                    }
                    con.Close();
                    rdr.Close();
                    return data;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message.ToString());
                    return data;
                }
            }
        }

        public static class LastName
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    cmd.CommandText = "SELECT * FROM tbl_librarian";
                    rdr = cmd.ExecuteReader();
                    data.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            data.Add(rdr[2].ToString());
                        }
                    }
                    con.Close();
                    rdr.Close();
                    return data;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message.ToString());
                    return data;
                }
            }
        }

        public static class FirstName
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    cmd.CommandText = "SELECT * FROM tbl_librarian";
                    rdr = cmd.ExecuteReader();
                    data.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            data.Add(rdr[3].ToString());
                        }
                    }
                    con.Close();
                    rdr.Close();
                    return data;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message.ToString());
                    return data;
                }
            }
        }

        public static class TimeIn
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    cmd.CommandText = "SELECT * FROM tbl_librarian";
                    rdr = cmd.ExecuteReader();
                    data.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            data.Add(rdr[4].ToString());
                        }
                    }
                    con.Close();
                    rdr.Close();
                    return data;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message.ToString());
                    return data;
                }
            }
        }

        public static class TimeOut
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    cmd.CommandText = "SELECT * FROM tbl_librarian";
                    rdr = cmd.ExecuteReader();
                    data.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            data.Add(rdr[5].ToString());
                        }
                    }
                    con.Close();
                    rdr.Close();
                    return data;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message.ToString());
                    return data;
                }
            }
        }

        public static class Email
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    cmd.CommandText = "SELECT * FROM tbl_librarian";
                    rdr = cmd.ExecuteReader();
                    data.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            data.Add(rdr[6].ToString());
                        }
                    }
                    con.Close();
                    rdr.Close();
                    return data;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message.ToString());
                    return data;
                }
            }
        }
    }
}
