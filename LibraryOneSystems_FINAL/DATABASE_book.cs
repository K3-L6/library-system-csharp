using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DATABASE
{
    public static class book
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
                cmd.CommandText = "insert into tbl_book (book_bNum, book_title, book_author, book_category, book_qty ) values ('" + infos[0] + "','" + infos[1] + "','" + infos[2] + "','" + infos[3] + "','" + infos[4] + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Database Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                //update tbl_book
                connectDatabase();
                con.Open();
                cmd.CommandText = "update tbl_book set book_bNum = '" + infos[0] + "', book_title = '" + infos[1] + "', book_author = '" + infos[2] + "', book_category = '" + infos[3] + "', book_qty = '" + infos[4] + "' where book_bNum = '"+infos[5]+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                //update tbl_br
                connectDatabase();
                con.Open();
                cmd.CommandText = "update tbl_br set br_bNum = '" + infos[0] + "', br_title = '" + infos[1] + "', br_author = '" + infos[2] + "', br_category = '"+infos[3]+"' where br_bNum = '"+infos[5]+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                //update tbl_brLog
                connectDatabase();
                con.Open();
                cmd.CommandText = "update tbl_brLog set brLog_bNUm = '" + infos[0] + "', brLog_title = '" + infos[1] + "', brLog_author = '" + infos[2] + "', brLog_category = '" + infos[3] + "' where brLog_bNum = '"+infos[5]+"'";
                cmd.ExecuteNonQuery();
                con.Close();
              
                MessageBox.Show("Database Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);  
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
                //tbl_book
                connectDatabase();
                con.Open();
                cmd.CommandText = "delete * from tbl_book where book_bNum = '"+id+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                //tbl_br
                connectDatabase();
                con.Open();
                cmd.CommandText = "delete * from tbl_br where br_bNum = '"+id+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                //tbl_brLog
                connectDatabase();
                con.Open();
                cmd.CommandText = "delete * from tbl_brLog where brLog_bNum = '" + id + "'";
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
                cmd.CommandText = "select * from tbl_book";
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
                cmd.CommandText = "SELECT * FROM tbl_book WHERE book_bNum LIKE '%" + key + "%' OR book_title LIKE '%" + key + "%' OR book_author LIKE '%" + key + "%' OR book_category LIKE '%" + key + "%'";
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

        public static class bNum
        {
            public static List<string> getData()
            { 
                List<string> data = new List<string>();

                connectDatabase();
                con.Open();
                cmd.CommandText = "select * from tbl_book";
                data.Clear();
                rdr = cmd.ExecuteReader();
                if(rdr.HasRows)
                {
                    while(rdr.Read())
                    {
                        data.Add(rdr[0].ToString());
                    }
                }
                con.Close();
                rdr.Close();
                return data;
            }
        }

    }
}
