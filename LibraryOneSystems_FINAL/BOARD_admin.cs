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
    public partial class BOARD_admin : Form
    {
        //CONSTRUCTS
        public BOARD_admin()
        {
            InitializeComponent();
            nameLbl.Text = INFO.admin.Firstname + " " + INFO.admin.Lastname;
            
            DATABASE.student.display(studentView);
            DATABASE.studentLog.displayActiveUsers(activeStudView);
            DATABASE.studentLog.displayStudentLog(studLogView);
            DATABASE.book.display(bookView);
            DATABASE.bookLog.displayBorrowed(brView);
            DATABASE.bookLog.displayBorrowedHistory(historyView);
            activeUserLbl.Text = "Active Users : " + activeStudView.Items.Count.ToString();
        }

        //TIMERS
        private void currentTime_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToShortTimeString();
            dateLbl.Text = DateTime.Now.ToShortDateString();
        }

        //TAB VIEW CHANGE EVENT
        int tabViewSelected = 1;
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
        //////////////////////////////////////////////

        //VIEW MODES
        void toStudentViewMode()
        {
            searchKey.Text = "";
            DATABASE.student.display(studentView);

            aedPanel.Visible = true;
            printPanel.Visible = false;
            rightPanel.Visible = false;
            tabViewSelected = 1;

            

        }

        void toStudentActiveViewMode()
        {
            searchKey.Text = "";
            DATABASE.studentLog.displayActiveUsers(activeStudView);

            aedPanel.Visible = false;
            printPanel.Visible = false;
            rightPanel.Visible = false;
            tabViewSelected = 2;

        }

        void toBookViewMode()
        {
            searchKey.Text = "";
            DATABASE.book.display(bookView);

            aedPanel.Visible = true;
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

            aedPanel.Visible = false;
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

            aedPanel.Visible = false;
            printPanel.Visible = true;
            rightPanel.Visible = true;
            multiBtn.Image = Image.FromFile(@"C:\Users\kennlising\Desktop\LibraryOneSystems_FINAL\LibraryOneSystems_FINAL\Resources\allDeleteIcon.png");
            multiBtn.Text = "RESET HISTORY";
            tabViewSelected = 5;

        }

        void toBookLogViewMode()
        {
            searchKey.Text = "";
            DATABASE.bookLog.displayBorrowedHistory(historyView);

            aedPanel.Visible = false;
            printPanel.Visible = true;
            rightPanel.Visible = true;
            multiBtn.Image = Image.FromFile(@"C:\Users\kennlising\Desktop\LibraryOneSystems_FINAL\LibraryOneSystems_FINAL\Resources\allDeleteIcon.png");
            multiBtn.Text = "RESET HISTORY";
            tabViewSelected = 6;

        }
        /////////////////////////////////////////////

        //BUTTONS CLICK EVENTS
        private void addtn_Click(object sender, EventArgs e)
        {
            switch (tabViewSelected)
            { 
                case 1:
                    //Trans to Student Registration Form
                    DESIGN.Trans.start(this, new REGISTRATION_student(), 2);
                    break;
                case 3:
                    //Trans to Book Registration Form
                    DESIGN.Trans.start(this, new REGISTRATION_book(), 2);
                    break;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            switch (tabViewSelected)
            { 
                case 1:
                    if (studentView.SelectedItems.Count == 0){MessageBox.Show("There's no selected student", "", MessageBoxButtons.OK, MessageBoxIcon.Information);return;}
                    DESIGN.Trans.start(this, new EDIT_student(selectedStudent), 2);
                    break;
                case 3:
                    if (bookView.SelectedItems.Count == 0){MessageBox.Show("There's no selected book", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return;}
                    DESIGN.Trans.start(this, new EDIT_book(selectedBook), 2);        
                    break;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            switch (tabViewSelected)
            { 
                case 1:
                    if (studentView.SelectedItems.Count == 0) { MessageBox.Show("There's no selected student", "",MessageBoxButtons.OK, MessageBoxIcon.Information ); return; }
                    //delete everything about the student and redisplay all infos
                    
                    //ask the user
                    DialogResult drS = MessageBox.Show("Are you sure you want to delete this data and all its sub connections", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drS == DialogResult.No) { return; }
                    
                    DATABASE.student.delete(selectedStudent[0]);
                    DATABASE.student.display(studentView);
                    DATABASE.studentLog.displayActiveUsers(activeStudView);
                    DATABASE.bookLog.displayBorrowed(brView);
                    DATABASE.bookLog.displayBorrowedHistory(historyView);
                    activeUserLbl.Text = "Active Users : " + activeStudView.Items.Count.ToString();
                    break;
                case 3:
                    if (bookView.SelectedItems.Count == 0) { MessageBox.Show("There's no selected book", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    //delete everything about the book and redisplay all infos

                    //ask the user
                    DialogResult drB = MessageBox.Show("Are you sure you want to delete this data and all its sub connections", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drB == DialogResult.No) { return; }

                    DATABASE.book.delete(selectedBook[0]);
                    DATABASE.book.display(bookView);
                    DATABASE.bookLog.displayBorrowed(brView);
                    DATABASE.bookLog.displayBorrowedHistory(historyView);
                    break;
            }
        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            switch (tabViewSelected)
            {
                case 3:
                    if (bookView.SelectedItems.Count == 0) { MessageBox.Show("There's no selected book", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    if (bookView.SelectedItems[0].SubItems[4].Text == "0") { MessageBox.Show("This book is not available", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    DESIGN.Trans.start(this, new BOARD_borrow("admin", selectedBook), 2);
                    break;
                case 4:
                    if (brView.SelectedItems.Count == 0) { MessageBox.Show("There's no selected book", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    DATABASE.bookLog.returnBook(selectedBorrowedBook);
                    DATABASE.bookLog.displayBorrowed(brView);
                    DATABASE.bookLog.displayBorrowedHistory(historyView);
                    DATABASE.book.display(bookView);
                    break;
                case 5:
                    if (activeStudView.Items.Count != 0) { MessageBox.Show("Please Reset The History After All Students Is Logged Out", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    DATABASE.studentLog.deleteHistory();
                    DATABASE.studentLog.displayStudentLog(studLogView);
                    break;
                case 6:
                    if (brView.Items.Count != 0) { MessageBox.Show("Please Reset The History After All Books Is Returned", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    DATABASE.bookLog.deleteHistory();
                    DATABASE.bookLog.displayBorrowedHistory(historyView);
                    break;
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            switch (tabViewSelected)
            { 
                case 5:
                    DESIGN.Trans.start(this, new PRINT_userLog_form("admin"), 3);
                    break;
                case 6:
                    DESIGN.Trans.start(this, new PRINT_bookLog_form("admin"), 3);
                    break;
            }
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new SETTINGS_admin(), 2);
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new LOGIN_main(), 2);
        }
        ///////////////////////////////////////////////////////
        
        //LIST VIEW SELECTED EVENTS
        List<string> selectedStudent = new List<string>();
        private void studentView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentView.SelectedItems.Count != 0)
            { 
                selectedStudent.Clear();
                selectedStudent.Add(studentView.SelectedItems[0].Text);
                selectedStudent.Add(studentView.SelectedItems[0].SubItems[1].Text);
                selectedStudent.Add(studentView.SelectedItems[0].SubItems[2].Text);
                selectedStudent.Add(studentView.SelectedItems[0].SubItems[3].Text);
                selectedStudent.Add(studentView.SelectedItems[0].SubItems[4].Text);
                selectedStudent.Add(studentView.SelectedItems[0].SubItems[5].Text);
                selectedStudent.Add(studentView.SelectedItems[0].SubItems[6].Text);
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
                selectedBorrowedBook.Add(INFO.admin.Username);
            }
        }
        //////////////////////////////////////////

        //SEARCH ENGINE
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
      



    }
}
