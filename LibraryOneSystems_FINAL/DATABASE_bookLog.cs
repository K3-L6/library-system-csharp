using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DATABASE
{
    public static class bookLog
    {
        static OleDbConnection con = new OleDbConnection();
        static OleDbCommand cmd = new OleDbCommand();
        static OleDbDataReader rdr;

        static void connectDatabase()
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kennlising\Desktop\LibraryOneSystems_FINAL\LibraryOneSystems_FINAL\LibraryData.accdb;Persist Security Info=True";
            cmd.Connection = con;
        }

        //BORROW BOOKS
        static List<string> infos = new List<string>();
        public static void borrowBook(List<string> infos)
        {
            DATABASE.bookLog.infos = infos;
            if (!validBorrow()) { return; }
            
            try
            {
                //done debugging
                //insert into tbl_br
                connectDatabase();    
                con.Open();
                cmd.CommandText = @"insert into tbl_br (br_sNum, br_lastName, br_firstName, br_gender, br_course, br_cell, br_email, br_bNum, br_title, br_author, br_category, br_dateB, br_dateR)
                values ('" + infos[0] + "','" + infos[1] + "','" + infos[2] + "','" + infos[3] + "','" + infos[4] + "','" + infos[5] + "','" + infos[6] + "','" + infos[7] + "','" + infos[8] + "','" + infos[9] + "','" + infos[10] + "','" + infos[11] + "','" + infos[12] + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                //insert partial parts of tbl_brLog and identifier username for updating later
                connectDatabase();
                con.Open();
                cmd.CommandText = @"insert into tbl_brLog (brLog_sNum, brLog_lastName, brLog_firstName, brLog_gender, brLog_course, brLog_bNum, brLog_title, brLog_author, brLog_category, brLog_dateB, brLog_fromWho, brLog_fromWho_user, brLog_dateR, brLog_returnTo, brLog_returnTo_user)
                values ('" + infos[0] + "', '" + infos[1] + "', '" + infos[2] + "', '" + infos[3] + "', '" + infos[4] + "', '" + infos[7] + "', '" + infos[8] + "', '" + infos[9] + "', '" + infos[10] + "', '" + infos[11] + "', '" + infos[13] + "', '" + infos[14] + "', '" + "NOT YET RETURNED" + "', '" + "NOT YET RETURNED" + "', '" + "NOT YET RETURNED" + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                //book quantity subtract by 1
                int qty = getQty() - 1;
                connectDatabase();
                con.Open();
                cmd.CommandText = "update tbl_book set book_qty = '"+qty.ToString()+"' where book_bNum = '"+infos[7]+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Library One Systems Operation Complete\n\nBorrowers Name : " + infos[2] + " " + infos[1] + "\nBook Borrowed : " + infos[8] + "\nReturn Date : " + infos[12], "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EMAIL.MailSystem.send(infos[6], "Library One Systems", "Thank you for using Library One Systems" + "\n\nBorrowers Name : " + infos[2] + " " + infos[1] + "\nBook Borrowed : " + infos[8] + "\nReturn Date : " + infos[12] + "");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private static Boolean validBorrow()
        {
            int bookBorrowed = UserBookBorrowed();
            int maxBorrow = 3;
            if (getDuplicate())
            {
                MessageBox.Show("One Copy Of Book Per Student Only", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (bookBorrowed >= maxBorrow)
            {
                MessageBox.Show("Please Return Some Books First", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        ////////////////////////////

        //RETURN BOOK
        public static void returnBook(List<string> infos)
        {  
            DATABASE.bookLog.infos = infos;
            DateTime borrowedDate = Convert.ToDateTime(infos[11]);
            DateTime returnDate = Convert.ToDateTime(infos[12]);
            string lateDay = (DateTime.Now.Date - returnDate).TotalDays.ToString();
            int result = DateTime.Compare(DateTime.Now, returnDate);
            int qty = getQty() + 1;
            try
            {
                //delete records in borrowed books
                connectDatabase();
                con.Open();
                cmd.CommandText = "delete * from tbl_br where br_sNum = '" + infos[0] + "' and br_bNum = '"+infos[7]+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                //book update add 1
                connectDatabase();
                con.Open();
                cmd.CommandText = "update tbl_book set book_qty = '"+qty.ToString()+"' where book_bNum = '"+infos[7]+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                //complete the brLog data
                connectDatabase();
                con.Open();
                cmd.CommandText = "update tbl_brLog set brLog_dateR = '" + DateTime.Now.ToLongDateString() + "', brLog_returnTo = '" + infos[13] + "', brLog_returnTo_user = '" + infos[14] + "' where brLog_sNum = '" + infos[0] + "' and brLog_bNum = '" + infos[7] + "' and brLog_dateB = '" + borrowedDate.ToLongDateString() + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                
                if (result < 0)
                {
                    MessageBox.Show("Date Borrowed : " + borrowedDate.ToLongDateString() + "\n" + "Date of Return : " + returnDate.ToLongDateString() + "\n\n" + "Date Returned : " + DateTime.Now.ToLongDateString() + "\n\n" + "NO PENALTIES", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Date Borrowed : " + borrowedDate.ToLongDateString() + "\n" + "Date of Return : " + returnDate.ToLongDateString() + "\n\n" + "Date Returned : " + DateTime.Now.ToLongDateString() + "\n\n" + "NO PENALTIES", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Date Borrowed : " + borrowedDate.ToLongDateString() + "\n" + "Date of Return : " + returnDate.ToLongDateString() + "\n\n" + "Date Returned : " + DateTime.Now.ToLongDateString() + "\n\n" + lateDay + " DAYS LATE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void displayBorrowed(ListView list)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_br";
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
                        items.SubItems.Add(rdr[7].ToString());
                        items.SubItems.Add(rdr[8].ToString());
                        items.SubItems.Add(rdr[9].ToString());
                        items.SubItems.Add(rdr[10].ToString());
                        items.SubItems.Add(rdr[11].ToString());
                        items.SubItems.Add(rdr[12].ToString());
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

        public static void displaySearchBorrowed(string key, ListView list)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_br WHERE br_sNum LIKE '%" + key + "%' OR br_lastName LIKE '%" + key + "%' OR br_firstName LIKE '%" + key + "%' OR br_gender LIKE '%" + key + "%' OR br_course LIKE '%" + key + "%' OR br_cell LIKE '%" + key + "%' OR br_email LIKE '%" + key + "%' OR br_bNum LIKE '%" + key + "%' OR br_title LIKE '%" + key + "%' OR br_author LIKE '%" + key + "%' OR br_category LIKE '%" + key + "%' OR br_dateB LIKE '%" + key + "%' OR br_dateR LIKE '%" + key + "%'";
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
                        items.SubItems.Add(rdr[7].ToString());
                        items.SubItems.Add(rdr[8].ToString());
                        items.SubItems.Add(rdr[9].ToString());
                        items.SubItems.Add(rdr[10].ToString());
                        items.SubItems.Add(rdr[11].ToString());
                        items.SubItems.Add(rdr[12].ToString());
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

        public static void displayBorrowedHistory(ListView list)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_brLog";
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
                        items.SubItems.Add(rdr[7].ToString());
                        items.SubItems.Add(rdr[8].ToString());
                        items.SubItems.Add(rdr[9].ToString());
                        items.SubItems.Add(rdr[10].ToString());
                        items.SubItems.Add(rdr[11].ToString());
                        items.SubItems.Add(rdr[12].ToString());
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

        public static void displaySearchBorrowedHistory(string key, ListView list)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_brLog WHERE brLog_sNum LIKE '%" + key + "%' OR brLog_lastName LIKE '%" + key + "%' OR brLog_firstName LIKE '%" + key + "%' OR  brLog_gender LIKE '%" + key + "%' OR brLog_course LIKE '%" + key + "%' OR brLog_bNum LIKE '%" + key + "%' OR brLog_title LIKE '%" + key + "%' OR brLog_author LIKE '%" + key + "%' OR brLog_category LIKE '%" + key + "%' OR brLog_dateB LIKE '%" + key + "%' OR brLog_fromWho LIKE '%" + key + "%' OR brLog_dateR LIKE '%" + key + "%' OR brLog_returnTo LIKE '%" + key + "%'";
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
                        items.SubItems.Add(rdr[7].ToString());
                        items.SubItems.Add(rdr[8].ToString());
                        items.SubItems.Add(rdr[9].ToString());
                        items.SubItems.Add(rdr[10].ToString());
                        items.SubItems.Add(rdr[11].ToString());
                        items.SubItems.Add(rdr[12].ToString());
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

        public static void displayBorrowedPerUser(string id, ListView list)
        {
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "select * from tbl_br where br_sNum = '"+id+"'";
                rdr = cmd.ExecuteReader();
                list.Items.Clear();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        ListViewItem items = new ListViewItem(rdr[8].ToString());
                        items.SubItems.Add(rdr[12].ToString());
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
                cmd.CommandText = "delete * from tbl_brLog";
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

        //FOR VALIDATION
        static Boolean getDuplicate()
        {
            Boolean duplicate = false;
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_br WHERE br_sNum = '" + infos[0] + "' AND br_bNum = '" + infos[7] + "'";
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        duplicate = true;
                    }
                }
                con.Close();
                rdr.Close();
                return duplicate;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
                return duplicate;
            }
        }

        static int UserBookBorrowed()
        {
            int borrowedBooks = 0;
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_br WHERE br_sNum = '" + infos[0] + "'";
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    borrowedBooks += 1;
                }
                con.Close();
                rdr.Close();
                return borrowedBooks;
            }
            catch (Exception ex)
            {
                con.Close();
                rdr.Close();
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }

        static int getQty()
        {
            int qty = 0;
            try
            {
                connectDatabase();
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_book WHERE book_bNum = '" + infos[7] + "'";
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        qty = int.Parse(rdr[4].ToString());
                    }
                }

                rdr.Close();
                con.Close();
                return qty;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }

        static string getDateBorrowed()
        {
            try
            {
                connectDatabase();
                string dateBorrowed = "";
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_br WHERE br_sNum = '" + infos[0] + "' AND brLog_bNum = '" + infos[7] + "'";
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        dateBorrowed = rdr[11].ToString();
                    }
                }
                con.Close();
                rdr.Close();
                return dateBorrowed;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
                return "X";
            }
        }

        static string getDateReturn()
        {
            try
            {
                connectDatabase();
                string dateReturned = "";
                con.Open();
                cmd.CommandText = "SELECT * FROM tbl_br WHERE br_sNum = '" + infos[0] + "' AND br_bNum = '" + infos[7] + "'";
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        dateReturned = rdr[12].ToString();
                    }
                }
                con.Close();
                rdr.Close();
                return dateReturned;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
                return "X";
            }
        }





    }
}
