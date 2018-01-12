using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DATABASE
{
    public static class admin
    {
        static OleDbConnection con = new OleDbConnection();
        static OleDbCommand cmd = new OleDbCommand();
        static OleDbDataReader rdr;

        static void connectDatabase()
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kennlising\Desktop\LibraryOneSystems_FINAL\LibraryOneSystems_FINAL\LibraryData.accdb;Persist Security Info=True";
            cmd.Connection = con;
        }

        public static void update(List<string> infos)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "update tbl_admin set admin_username = '" + infos[0] + "', admin_password = '" + infos[1] + "', admin_lastName = '" + infos[2] + "', admin_firstName = '" + infos[3] + "', admin_email = '" + infos[4] + "' where admin_username = '"+infos[5]+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                connectDatabase();
                con.Open();
                cmd.CommandText = "update tbl_brLog set brLog_fromWho_user = '"+infos[0]+"' where brLog_fromWho_user = '"+infos[5]+"'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update tbl_brLog set brLog_returnTo_user = '" + infos[0] + "' where brLog_returnTo_user = '" + infos[5] + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update tbl_brLog set brLog_fromWho = '" + infos[3] + " " + infos[2] + "' where brLog_fromWho_user = '" + infos[0] +"'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update tbl_brLog set brLog_returnTo = '" + infos[3] + " " + infos[2] + "' where brLog_returnTo_user = '" + infos[0] + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Admin Info Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmd.CommandText = "update tbl_admin set admin_password = '"+randomPassword+"' where admin_email = '"+infos[1]+"'";
                cmd.ExecuteNonQuery();
                con.Close();
                EMAIL.MailSystem.send(infos[1], "Reset Password Complete", "Hello\n\n\nPlease Dont forget your password next time\n\nUsername : " + infos[0] + "\nNew Password : " + randomPassword);
                MessageBox.Show("Please Check Your Mail For Your New Password", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //USERNAME
        public static class Username
        { 
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    cmd.CommandText = @"SELECT * FROM tbl_admin";
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

        //PASSWORD
        public static class Password
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();

                    //tbl_admin SELECT *
                    cmd.CommandText = "SELECT * FROM tbl_admin";
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
                    cmd.CommandText = "SELECT * FROM tbl_admin";
                    rdr = cmd.ExecuteReader();
                    data.Clear();
                    if(rdr.HasRows)
                    {
                        while(rdr.Read())
                        {
                            data.Add(rdr[2].ToString());
                        }
                    }
                    con.Close();
                    rdr.Close();
                    return data;
                }
                catch(Exception ex)
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
                    cmd.CommandText = "SELECT * FROM tbl_admin";
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

        public static class Email
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    cmd.CommandText = "SELECT * FROM tbl_admin";
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
    







    }
}
