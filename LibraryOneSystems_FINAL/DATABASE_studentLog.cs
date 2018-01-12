using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DATABASE
{
    public static class studentLog
    {
        static OleDbConnection con = new OleDbConnection();
        static OleDbCommand cmd = new OleDbCommand();
        static OleDbDataReader rdr;

        static void connectDatabase()
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kennlising\Desktop\LibraryOneSystems_FINAL\LibraryOneSystems_FINAL\LibraryData.accdb;Persist Security Info=True";
            cmd.Connection = con;
        }

        public static void enter(List<string> infos)
        {
            string timeIn = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToShortDateString();
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "insert into tbl_studentActive (studentActive_sNum, studentActive_lastName, studentActive_firstName, studentActive_course) values ('" + infos[0] + "','" + infos[1] + "','" + infos[2] + "','" + infos[3] + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                connectDatabase();
                con.Open();
                cmd.CommandText = "insert into tbl_studentLog (studentLog_sNum, studentLog_lastName, studentLog_firstName, studentLog_course, studentLog_timeIn, studentLog_timeOut) values ('" + infos[0] + "','" + infos[1] + "','" + infos[2] + "','" + infos[3] + "','" + timeIn + "','" + "STILL LOGGED IN" + "')";
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void exit(List<string> infos)
        {
            string timeOut = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToShortDateString();
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "delete * from tbl_studentActive where studentActive_sNum = '"+infos[0]+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                connectDatabase();
                con.Open();
                cmd.CommandText = "UPDATE tbl_studentLog SET studentLog_timeOut = '" + timeOut + "' WHERE studentLog_sNum = '" + infos[0] + "' AND studentLog_timeOut = '" + "STILL LOGGED IN" + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void displayActiveUsers(ListView list)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_studentActive";
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

        public static void displayStudentLog(ListView list)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_studentLog";
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
                        items.SubItems.Add(rdr[5].ToString());
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

        public static void displaySearchActive(string key,  ListView list)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_studentActive WHERE studentActive_sNum LIKE '%" + key + "%' OR studentActive_lastName LIKE '%" + key + "%' OR studentActive_firstName LIKE '%" + key + "%' OR studentActive_course LIKE '%" + key + "%'";
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

        public static void displaySearchStudentLog(string key, ListView list)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_studentLog WHERE studentLog_sNum LIKE '%" + key + "%' OR studentLog_lastName LIKE '%" + key + "%' OR studentLog_firstName LIKE '%" + key + "%' OR studentLog_course LIKE '%" + key + "%' OR studentLog_timeIn LIKE '%" + key + "%' OR studentLog_timeOut LIKE '%" + key + "%'";
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
                        items.SubItems.Add(rdr[5].ToString());
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
                cmd.CommandText = "delete * from tbl_studentLog";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("History Successfully Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static class sNum
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    data.Clear();
                    cmd.CommandText = "select * from tbl_studentActive";
                    rdr = cmd.ExecuteReader();
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

        public static class lastName
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    data.Clear();
                    cmd.CommandText = "select * from tbl_studentActive";
                    rdr = cmd.ExecuteReader();
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

        public static class firstName
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    data.Clear();
                    cmd.CommandText = "select * from tbl_studentActive";
                    rdr = cmd.ExecuteReader();
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

        public static class course
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    data.Clear();
                    cmd.CommandText = "select * from tbl_studentActive";
                    rdr = cmd.ExecuteReader();
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

        public static class timeIn
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    data.Clear();
                    cmd.CommandText = "select * from tbl_studentLog";
                    rdr = cmd.ExecuteReader();
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
