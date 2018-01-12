using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryOneSystems_FINAL
{
    public partial class BOARD_librarian : Form
    {
        public BOARD_librarian()
        {
            InitializeComponent();
            DATABASE.librarianLog.login();
            DATABASE.student.display(studentView);
            DATABASE.studentLog.displayActiveUsers(activeStudView);
            DATABASE.studentLog.displayStudentLog(studLogView);
            DATABASE.book.display(bookView);
            DATABASE.bookLog.displayBorrowed(brView);
            DATABASE.bookLog.displayBorrowedHistory(historyView);
            librarianDutyLbl.Text = "Time IN : " + Convert.ToDateTime(INFO.librarian.StartTime).ToShortTimeString() + "          Time OUT : " + Convert.ToDateTime(INFO.librarian.EndTime).ToShortTimeString();
            nameLbl.Text = INFO.librarian.Firstname + " " + INFO.librarian.Lastname;
            activeUserLbl.Text = "Active Users : " + activeStudView.Items.Count.ToString();
        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToShortTimeString();
            dateLbl.Text = DateTime.Now.ToShortDateString();
        }

        private void dutyTimer_Tick(object sender, EventArgs e)
        {
            DateTime end = Convert.ToDateTime(INFO.librarian.EndTime);

            if (end < DateTime.Now.AddMinutes(-1))
            {
                DESIGN.Trans.start(this, new LOGIN_main(), 5);
                DATABASE.librarianLog.logout();
                dutyTimer.Dispose();
                return;
            }
        }

        void notify()
        {
        }

        private void TabView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabView.SelectedTab == TabView.TabPages["studentTab"])
            {
                toStudentViewMode();
            }
            else if (TabView.SelectedTab == TabView.TabPages["studentActiveTab"])
            {
                toStudentActiveViewMode();
            }
            else if (TabView.SelectedTab == TabView.TabPages["bookTab"])
            {
                toBookViewMode();
            }
            else if (TabView.SelectedTab == TabView.TabPages["brTab"])
            {
                toBRViewMode();
            }
            else if (TabView.SelectedTab == TabView.TabPages["studentLogTab"])
            {
                toStudentLogViewMode();
            }
            else if (TabView.SelectedTab == TabView.TabPages["bookLogTab"])
            {
                toBookLogViewMode();
            }
        }

        int tabViewSelected = 1;
        void toStudentViewMode()
        {
            searchKey.Text = "";
            DATABASE.student.display(studentView);

            printPanel.Visible = false;
            rightPanel.Visible = false;
            tabViewSelected = 1;
        }

        void toStudentActiveViewMode()
        {
            searchKey.Text = "";
            DATABASE.studentLog.displayActiveUsers(activeStudView);

            printPanel.Visible = false;
            rightPanel.Visible = false;
            tabViewSelected = 2;
        }

        void toBookViewMode()
        {
            searchKey.Text = "";
            DATABASE.book.display(bookView);

            printPanel.Visible = false;
            rightPanel.Visible = true;
            multiBtn.Image = Image.FromFile(@"C:\Users\kennlising\Desktop\LibraryOneSystems_FINAL\LibraryOneSystems_FINAL\Resources\borrowIcon.png");
            multiBtn.Text = "BORROW";
            tabViewSelected = 3;
        }

        void toBRViewMode()
        {
            searchKey.Text = "";
            DATABASE.bookLog.displayBorrowed(brView);

            printPanel.Visible = false;
            rightPanel.Visible = true;
            multiBtn.Image = Image.FromFile(@"C:\Users\kennlising\Desktop\LibraryOneSystems_FINAL\LibraryOneSystems_FINAL\Resources\returnIcon.png");
            multiBtn.Text = "RETURN";
            tabViewSelected = 4;
        }

        void toStudentLogViewMode()
        {
            searchKey.Text = "";
            DATABASE.studentLog.displayStudentLog(studLogView);

            printPanel.Visible = true;
            rightPanel.Visible = false;
            tabViewSelected = 5;
        }

        void toBookLogViewMode()
        {
            searchKey.Text = "";
            DATABASE.bookLog.displayBorrowedHistory(historyView);

            printPanel.Visible = true;
            rightPanel.Visible = false;
            tabViewSelected = 6;
        }

        private void multiBtn_Click(object sender, EventArgs e)
        {

            switch (tabViewSelected)
            {
                case 3:
                    if (bookView.SelectedItems.Count == 0) { MessageBox.Show("There's no selected book", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    if (bookView.SelectedItems[0].SubItems[4].Text == "0") { MessageBox.Show("This book is not available", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    DESIGN.Trans.start(this, new BOARD_borrow("librarian", selectedBook), 2);
                    break;
                case 4:
                    if (brView.SelectedItems.Count == 0) { MessageBox.Show("There's no selected book", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    DATABASE.bookLog.returnBook(selectedBorrowedBook);
                    DATABASE.bookLog.displayBorrowed(brView);
                    DATABASE.bookLog.displayBorrowedHistory(historyView);
                    DATABASE.book.display(bookView);
                    break;
            }

        }

        List<string> selectedBook = new List<string>();
        private void bookView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookView.SelectedItems.Count != 0)
            {
                selectedBook.Clear();
                selectedBook.Add(bookView.SelectedItems[0].Text);
                selectedBook.Add(bookView.SelectedItems[0].SubItems[1].Text);
                selectedBook.Add(bookView.SelectedItems[0].SubItems[2].Text);
                selectedBook.Add(bookView.SelectedItems[0].SubItems[3].Text);
                selectedBook.Add(bookView.SelectedItems[0].SubItems[4].Text);
            }
        }

        List<string> selectedBorrowedBook = new List<string>();
        private void brView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brView.SelectedItems.Count != 0)
            {
                selectedBorrowedBook.Clear();
                selectedBorrowedBook.Add(brView.SelectedItems[0].Text);
                selectedBorrowedBook.Add(brView.SelectedItems[0].SubItems[1].Text);
                selectedBorrowedBook.Add(brView.SelectedItems[0].SubItems[2].Text);
                selectedBorrowedBook.Add(brView.SelectedItems[0].SubItems[3].Text);
                selectedBorrowedBook.Add(brView.SelectedItems[0].SubItems[4].Text);
                selectedBorrowedBook.Add(brView.SelectedItems[0].SubItems[5].Text);
                selectedBorrowedBook.Add(brView.SelectedItems[0].SubItems[6].Text);
                selectedBorrowedBook.Add(brView.SelectedItems[0].SubItems[7].Text);
                selectedBorrowedBook.Add(brView.SelectedItems[0].SubItems[8].Text);
                selectedBorrowedBook.Add(brView.SelectedItems[0].SubItems[9].Text);
                selectedBorrowedBook.Add(brView.SelectedItems[0].SubItems[10].Text);
                selectedBorrowedBook.Add(brView.SelectedItems[0].SubItems[11].Text);
                selectedBorrowedBook.Add(brView.SelectedItems[0].SubItems[12].Text);
                selectedBorrowedBook.Add(nameLbl.Text);
                selectedBorrowedBook.Add(INFO.librarian.Username);
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DATABASE.librarianLog.logout();
            DESIGN.Trans.start(this, new LOGIN_main(), 2);
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new EDIT_librarian(), 2);
        }

        private void BOARD_librarian_FormClosing(object sender, FormClosingEventArgs e)
        {
            DATABASE.librarianLog.logout();
        }

        private void searchKey_TextChanged(object sender, EventArgs e)
        {
            switch (tabViewSelected)
            {
                case 1:
                    DATABASE.student.displaySearch(searchKey.Text, studentView);
                    if (searchKey.Equals("")) { DATABASE.student.display(studentView); }
                    break;
                case 2:
                    DATABASE.studentLog.displaySearchActive(searchKey.Text, activeStudView);
                    if (searchKey.Equals("")) { DATABASE.studentLog.displayActiveUsers(activeStudView); }
                    break;
                case 3:
                    DATABASE.book.displaySearch(searchKey.Text, bookView);
                    if (searchKey.Equals("")) { DATABASE.book.display(bookView); }
                    break;
                case 4:
                    DATABASE.bookLog.displaySearchBorrowed(searchKey.Text, brView);
                    if (searchKey.Equals("")) { DATABASE.bookLog.displayBorrowed(brView); }
                    break;
                case 5:
                    DATABASE.studentLog.displaySearchStudentLog(searchKey.Text, studLogView);
                    if (searchKey.Equals("")) { DATABASE.studentLog.displayStudentLog(studLogView); }
                    break;
                case 6:
                    DATABASE.bookLog.displaySearchBorrowedHistory(searchKey.Text, historyView);
                    if (searchKey.Equals("")) { DATABASE.bookLog.displayBorrowedHistory(historyView); }
                    break;

            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            switch (tabViewSelected)
            { 
                case 5:
                    DESIGN.Trans.start(this, new PRINT_userLog_form("librarian"), 3);
                    break;
                case 6:
                    DESIGN.Trans.start(this, new PRINT_bookLog_form("librarian"), 3);
                    break;
            }
        }



    }
}
