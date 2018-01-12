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
    public partial class BOARD_borrow : Form
    {
        string operatorType = "";
        public BOARD_borrow(string operatorType, List<string> infos)
        {
            this.operatorType = operatorType;
            InitializeComponent();

            DATABASE.student.display(studentView);

            if (operatorType.Equals("admin"))
            {
                operatorLbl.Text = "Admin Info";
                nameLbl.Text = INFO.admin.Firstname + " " + INFO.admin.Lastname;
            }
            else if (operatorType.Equals("librarian"))
            {
                operatorLbl.Text = "Librarian Info";
                nameLbl.Text = INFO.librarian.Firstname + " " + INFO.librarian.Lastname;
            }
            numberFld.Text = infos[0];
            titleFld.Text = infos[1];
            authorFld.Text = infos[2];
            categoryFld.Text = infos[3];
            qtyFld.Text = infos[4];
        }

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

        List<string> infos = new List<string>();
        private void borrowBtn_Click(object sender, EventArgs e)
        {
            if (studentView.SelectedItems.Count == 0)
            {
                MessageBox.Show("There's no selected student", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            GetAllData();
            DATABASE.bookLog.borrowBook(infos);
            backToBoard();
        }

        void backToBoard()
        {
            if (operatorType.Equals("admin"))
            {
                DESIGN.Trans.start(this, new BOARD_admin(), 2);
            }
            else
            {
                DESIGN.Trans.start(this, new BOARD_librarian(), 2);
            }
        }

        void GetAllData()
        {
            string dateB = DateTime.Now.ToLongDateString();
            string dateR = DateTime.Now.AddDays((int)daysFld.Value).ToLongDateString();
            infos.Clear();
            infos.Add(selectedStudent[0]);
            infos.Add(selectedStudent[1]);
            infos.Add(selectedStudent[2]);
            infos.Add(selectedStudent[3]);
            infos.Add(selectedStudent[4]);
            infos.Add(selectedStudent[5]);
            infos.Add(selectedStudent[6]);
            infos.Add(numberFld.Text);
            infos.Add(titleFld.Text);
            infos.Add(authorFld.Text);
            infos.Add(categoryFld.Text);
            infos.Add(dateB);
            infos.Add(dateR);
            infos.Add(nameLbl.Text);
            if (operatorType.Equals("admin"))
            {
                infos.Add(INFO.admin.Username);
            }
            else
            {
                infos.Add(INFO.librarian.Username);
            }
        }

        private void searchKey_TextChanged(object sender, EventArgs e)
        {
            DATABASE.student.displaySearch(searchKey.Text, studentView);
            if (searchKey.Equals("")) { DATABASE.student.display(studentView); }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (operatorType.Equals("admin"))
            {
                DESIGN.Trans.start(this, new BOARD_admin(), 3);
            }
            else
            {
                DESIGN.Trans.start(this, new BOARD_librarian(), 3);
            }
        }
    }
}
