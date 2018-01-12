using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
namespace DATABASE
{
    public static class student
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
                cmd.CommandText = @"INSERT INTO tbl_student (students_sNum, students_lastName, students_firstName, students_gender,students_course, students_cell, students_email)
                VALUES ('" + infos[0] + "','" + infos[1] + "','" + infos[2] + "','" + infos[3] + "','" + infos[4] + "','" + infos[5] + "','" + infos[6] + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                EMAIL.MailSystem.send(infos[6], "Registration Complete ! ! !", "Thank you for registering to Libraryone System.\n\nACCOUNT INFORMATION\n\nName : " + infos[2] + " " + infos[1] + "\nStudent Number : " + infos[0] + "\nGender : " + infos[3] + "\nCourse : " + infos[4] + "\nContact Number : " + infos[5] + "\n\nEnjoy your stay at LibraryOne :)\n\nNote : Please do not reply to this mail if you have any questions say it directly to the librarian");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void update(List<string> infos)
        {
            try
            {
                //update tbl_students
                connectDatabase();
                con.Open();
                cmd.CommandText = @"UPDATE tbl_student SET students_sNum = '" + infos[0] + "', students_lastName = '" + infos[1] + "', students_firstName = '" + infos[2] + "', students_gender = '" + infos[3] + "', students_course = '" + infos[4] + "', students_cell = '" + infos[5] + "', students_email = '" + infos[6] + "' WHERE students_sNum = '" + infos[7] + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                //update tbl_activeStudents
                connectDatabase();
                con.Open();
                cmd.CommandText = @"UPDATE tbl_studentActive SET studentActive_sNum = '" + infos[0] + "', studentActive_lastName = '" + infos[1] + "', studentActive_firstName = '" + infos[2] + "', studentActive_course = '" + infos[4] + "' WHERE studentActive_sNum = '" + infos[7] + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                //update tbl_studentLog
                connectDatabase();
                con.Open();
                cmd.CommandText = @"UPDATE tbl_studentLog SET studentLog_sNum = '" + infos[0] + "', studentLog_lastName = '" + infos[1] + "', studentLog_firstName = '" + infos[2] + "', studentLog_course = '" + infos[4] + "' WHERE studentLog_sNum = '" + infos[7] + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                //update tbl_br
                connectDatabase();
                con.Open();
                cmd.CommandText = "UPDATE tbl_br SET br_sNum = '" + infos[0] + "', br_lastName = '" + infos[1] + "', br_firstName = '" + infos[2] + "', br_gender = '" + infos[3] + "', br_course = '" + infos[4] + "', br_cell = '" + infos[5] + "', br_email = '" + infos[6] + "' WHERE br_sNum = '" + infos[7] + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                //update tbl_brLog
                connectDatabase();
                con.Open();
                cmd.CommandText = "UPDATE tbl_brLog SET brLog_sNum = '" + infos[0] + "', brLog_lastName = '" + infos[1] + "', brLog_firstName = '" + infos[2] + "', brLog_gender = '" + infos[3] + "', brLog_course = '" + infos[4] + "' WHERE brLog_sNum = '" + infos[7] + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                //Send Email
                EMAIL.MailSystem.send(infos[6], "Update of Records Complete ! ! !", "Your Account information is updated successfully.\n\nACCOUNT INFORMATION\n\nName : " + infos[2] + " " + infos[1] + "\nStudent Number : " + infos[0] + "\nGender : " + infos[3] + "\nCourse : " + infos[4] + "\nContact Number : " + infos[5] + "\n\nEnjoy your stay at LibraryOne :)\n\nNote : Please do not reply to this mail if you have any questions say it directly to the librarian");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void delete(string id)
        {
            try
            {
                //tbl_student
                connectDatabase();
                con.Open();
                cmd.CommandText = "DELETE * FROM tbl_student WHERE students_sNum = '"+id+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                //tbl_studentActive
                connectDatabase();
                con.Open();
                cmd.CommandText = "DELETE * FROM tbl_studentActive WHERE studentActive_sNum = '" + id + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                //tbl_studentLog
                connectDatabase();
                con.Open();
                cmd.CommandText = "DELETE * FROM tbl_studentLog WHERE studentLog_sNum = '"+id+"'";
                cmd.ExecuteNonQuery();
                con.Close();
               
                //tbl_br
                connectDatabase();
                con.Open();
                cmd.CommandText = "DELETE * FROM tbl_br WHERE br_sNum = '"+id+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                //tbl_brLog
                connectDatabase();
                con.Open();
                cmd.CommandText = "DELETE * FROM tbl_brLog WHERE brLog_sNum = '"+id+"'";
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
                cmd.CommandText = "SELECT * FROM tbl_student";
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

        public static void displaySearch(string key,ListView list)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_student  WHERE students_sNum LIKE '%" + key + "%' OR students_lastName LIKE '%" + key + "%' OR students_firstName LIKE '%" + key + "%' OR students_gender LIKE '%" + key + "%' OR students_course LIKE '%" + key + "%' OR students_cell LIKE '%" + key + "%' OR students_email LIKE '%" + key + "%'";
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
                    cmd.CommandText = "select * from tbl_student";
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
                    cmd.CommandText = "select * from tbl_student";
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
                    cmd.CommandText = "select * from tbl_student";
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

        public static class gender
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    data.Clear();
                    cmd.CommandText = "select * from tbl_student";
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
                    cmd.CommandText = "select * from tbl_student";
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

        public static class cell
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    data.Clear();
                    cmd.CommandText = "select * from tbl_student";
                    rdr = cmd.ExecuteReader();
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

        public static class email
        {
            public static List<string> getData()
            {
                List<string> data = new List<string>();
                try
                {
                    connectDatabase();
                    con.Open();
                    data.Clear();
                    cmd.CommandText = "select * from tbl_student";
                    rdr = cmd.ExecuteReader();
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
