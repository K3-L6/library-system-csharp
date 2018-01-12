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
    public partial class LOGIN_main : Form
    {
        public LOGIN_main()
        {
            loadAllData();
            InitializeComponent();
        }

        //TIMERS
        private void currentTime_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToShortTimeString();
            dateLbl.Text = DateTime.Now.ToShortDateString();
        }

        int goBackTime = 30;
        private void backToMainTM_Tick(object sender, EventArgs e)
        {
            goBackTime--;
            if (goBackTime == 0)
            {
                backToMainTM.Enabled = false;
                DESIGN.Trans.start(this, new LOGIN_student(), 2);
            }
        }

        private void MainLogin_MouseMove(object sender, MouseEventArgs e)
        {
            goBackTime = 30;
        }

        List<string> adminUser = new List<string>();
        List<string> adminPass = new List<string>();
        List<string> adminLastname = new List<string>();
        List<string> adminFirstname = new List<string>();
        List<string> adminEmail = new List<string>();

        List<string> librarianUser = new List<string>();
        List<string> librarianPass = new List<string>();
        List<string> librarianLastName = new List<string>();
        List<string> librarianFirstName = new List<string>();
        List<string> librarianStart = new List<string>();
        List<string> librarianEnd = new List<string>();
        List<string> librarianEmail = new List<string>();

        void loadAllData()
        {
            adminUser = DATABASE.admin.Username.getData();
            adminPass = DATABASE.admin.Password.getData();
            adminLastname = DATABASE.admin.LastName.getData();
            adminFirstname = DATABASE.admin.FirstName.getData();
            adminEmail = DATABASE.admin.Email.getData();

            librarianUser = DATABASE.librarian.Username.getData();
            librarianPass = DATABASE.librarian.Password.getData();
            librarianLastName = DATABASE.librarian.LastName.getData();
            librarianFirstName = DATABASE.librarian.FirstName.getData();
            librarianStart = DATABASE.librarian.TimeIn.getData();
            librarianEnd = DATABASE.librarian.TimeOut.getData();
            librarianEmail = DATABASE.librarian.Email.getData();
        }

        void validateAllData()
        {
            goBackTime = 30;
            string userInput = userFld.Text;
            string passInput = passFld.Text;
            
            //ADMIN CHECK
            for (int x = 0; x < adminUser.Count; x++)
            {
                if (userInput.Equals(adminUser[x]) && passInput.Equals(adminPass[x]))
                {
                    //INSERT INFO INTO GLOBAL
                    INFO.admin.Username = adminUser[x];
                    INFO.admin.Password = adminPass[x];
                    INFO.admin.Lastname = adminLastname[x];
                    INFO.admin.Firstname = adminFirstname[x];
                    INFO.admin.Email = adminEmail[x];
                    userType = 1;
                    backToMainTM.Dispose();
                }
            }

            //LIBRARIAN CHECK
            for (int x = 0; x < librarianUser.Count; x++)
            {
                if (userInput.Equals(librarianUser[x]) && passInput.Equals(librarianPass[x]))
                {
                    //INSERT INFO INTO GLOBAL
                    INFO.librarian.Username = librarianUser[x];
                    INFO.librarian.Password = librarianPass[x];
                    INFO.librarian.Lastname = librarianLastName[x];
                    INFO.librarian.Firstname = librarianFirstName[x];
                    INFO.librarian.StartTime = librarianStart[x];
                    INFO.librarian.EndTime = librarianEnd[x];
                    INFO.librarian.Email = librarianEmail[x];
                    DateTime start = Convert.ToDateTime(INFO.librarian.StartTime);
                    DateTime end = Convert.ToDateTime(INFO.librarian.EndTime);
                    if (start <= DateTime.Now && DateTime.Now < end) { userType = 2; backToMainTM.Dispose(); } else { userType = 3; }
                }
            }
        
        }

        int logInAttemp = 0;
        int userType = 0;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (InputValid())
            {
                validateAllData();
                switch (userType)
                { 
                    case 1:
                        //DESIGN.Trans.start(this, new BOARD_admin(), 3);
                        MessageBox.Show("Welcome Admin", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DESIGN.LoadToForm.start(this, new BOARD_admin(), 3);
                        break;
                    case 2:
                        //DESIGN.Trans.start(this, new BOARD_librarian(), 3);
                        MessageBox.Show("Welcome Librarian\n\nThis system will be automatically shutdown\nafter your duty time is expired\n\n\tTime Start : " + Convert.ToDateTime(INFO.librarian.StartTime).ToShortTimeString() + "\n\tTime End  : " + Convert.ToDateTime(INFO.librarian.EndTime).ToShortTimeString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DESIGN.LoadToForm.start(this, new BOARD_librarian(), 3);
                        break;
                    case 3:
                        MessageBox.Show("You're not allowed to Log in right now... \n\nTime Start : " + Convert.ToDateTime(INFO.librarian.StartTime).ToShortTimeString() + "\nTime End  : " + Convert.ToDateTime(INFO.librarian.EndTime).ToShortTimeString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        logInAttemp++;
                        MessageBox.Show("Wrong Username or Password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                if (logInAttemp == 3)
                {
                    resetPassBtn.Show();
                }
                else if (logInAttemp == 10) { Application.Exit(); }
            }
        }

        Boolean InputValid()
        {
            if (userFld.Text.Equals("") || passFld.Text.Equals(""))
            {
                MessageBox.Show("Please complete the form", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void titleLbl_DoubleClick(object sender, EventArgs e)
        {
            backToMainTM.Dispose();
            DESIGN.Trans.start(this, new LOGIN_student(), 3);
        }

        private void resetPassBtn_Click(object sender, EventArgs e)
        {
            backToMainTM.Dispose();
            DESIGN.Trans.start(this, new SETTINGS_resetPassword(), 2);
        }


        
    }
}
