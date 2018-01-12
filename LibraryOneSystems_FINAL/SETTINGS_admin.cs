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
    public partial class SETTINGS_admin : Form
    {
        public SETTINGS_admin()
        {
            InitializeComponent();
            nameLbl.Text = INFO.admin.Firstname + " " + INFO.admin.Lastname;
            DATABASE.librarian.display(libView);
            DATABASE.librarianLog.display(logView);
        }

        private void deleteRecordsBtn_Click(object sender, EventArgs e)
        {
            DATABASE.librarianLog.deleteHistory();
            DATABASE.librarianLog.display(logView);
        }

        private void updateTimeBtn_Click(object sender, EventArgs e)
        {
            if (libView.SelectedItems.Count == 0) { MessageBox.Show("There's no selected user", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            DESIGN.Trans.start(this, new EDIT_librarianTime(selectedLibrarian), 2);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (libView.SelectedItems.Count == 0) { MessageBox.Show("There's no selected user"); return; }

            //ask the users
            DialogResult drB = MessageBox.Show("Are you sure you want to delete this data and all its sub connections", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drB == DialogResult.No) { return; }

            DATABASE.librarian.delete(selectedLibrarian[0]);
            DATABASE.librarian.display(libView);
        }

        private void addtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new REGISTER_librarian(), 2);
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new EDIT_admin(), 2);
        }

        int selectedTabIndex = 1;
        private void TabView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabView.SelectedTab == TabView.TabPages["librarianTab"])
            {
                selectedTabIndex = 1;
                searchKey.Text = "";
                aedPanel.Visible = true;
                deleteRecordsPnl.Visible = false;
            }
            else if (TabView.SelectedTab == TabView.TabPages["historyTab"])
            {
                selectedTabIndex = 2;
                aedPanel.Visible = false;
                deleteRecordsPnl.Visible = true;
            }
        }

        //LIST VIEW EVENTS
        List<string> selectedLibrarian = new List<string>();
        private void libView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (libView.SelectedItems.Count != 0)
            {
                selectedLibrarian.Clear();
                selectedLibrarian.Add(libView.SelectedItems[0].Text);
                selectedLibrarian.Add(libView.SelectedItems[0].SubItems[1].Text);
                selectedLibrarian.Add(libView.SelectedItems[0].SubItems[2].Text);
                selectedLibrarian.Add(libView.SelectedItems[0].SubItems[3].Text);
                selectedLibrarian.Add(libView.SelectedItems[0].SubItems[4].Text);
                selectedLibrarian.Add(libView.SelectedItems[0].SubItems[5].Text);
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new LOGIN_main(), 2);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new BOARD_admin(), 3);
        }

        private void searchKey_TextChanged(object sender, EventArgs e)
        {
            switch (selectedTabIndex)
            { 
                case 1:
                    DATABASE.librarian.displaySearch(searchKey.Text, libView);
                    if (searchKey.Text.Equals("")) { DATABASE.librarian.display(libView); }
                    break;
                case 2:
                    DATABASE.librarian.displaySearchHistory(searchKey.Text, logView);
                    if (searchKey.Text.Equals("")) { DATABASE.librarian.displayHistory(logView); }
                    break;
            }
        }




    }
}
