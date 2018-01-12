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
    public partial class EDIT_librarian : Form
    {
        string oldUser = "";
        public EDIT_librarian()
        {
            InitializeComponent();
            oldUser = INFO.librarian.Username;
            lastFld.Text = INFO.librarian.Lastname;
            firstFld.Text = INFO.librarian.Firstname;
            emailFld.Text = INFO.librarian.Email;
            userFld.Text = INFO.librarian.Username;
            OpasswordFld.Text = INFO.librarian.Password;
            NpasswordFld.Text = INFO.librarian.Password;
            RpasswordFld.Text = INFO.librarian.Password;
        }

        private void lastNameBtn_Click(object sender, EventArgs e)
        {
            lastFld.Enabled = true;
            lastNameBtn.Enabled = false;
        }

        private void firstNameBtn_Click(object sender, EventArgs e)
        {
            firstFld.Enabled = true;
            firstNameBtn.Enabled = false;
        }

        Boolean isMailEdited = false;
        private void emailBtn_Click(object sender, EventArgs e)
        {
            isMailEdited = true;
            emailFld.Enabled = true;
            emailBtn.Enabled = false;
        }

        Boolean isUserEdited = false;
        private void userBtn_Click(object sender, EventArgs e)
        {
            isUserEdited = true;
            userFld.Enabled = true;
            userBtn.Enabled = false;
        }

        private void passBtn_Click(object sender, EventArgs e)
        {
            OpasswordFld.Enabled = true; OpasswordFld.Text = "";
            NpasswordFld.Enabled = true; NpasswordFld.Text = "";
            RpasswordFld.Enabled = true; RpasswordFld.Text = "";
            passBtn.Enabled = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!InputValid()) { return; }
            
            switch (isMailEdited)
            {
                case true:
                    
            infos.Clear();
            infos.Add(userFld.Text);
            infos.Add(NpasswordFld.Text);
            infos.Add(lastFld.Text.ToUpper());
            infos.Add(firstFld.Text.ToUpper());
            infos.Add(emailFld.Text);
            infos.Add(oldUser);
                    
                    string validationCode = randomNumber();
                    EMAIL.MailSystem.send(infos[4], "Library One Systems Email Validation", "Hi " + infos[3] + "\n\nWe would like to validate this email\n\nValidation Code : " + validationCode);
                    DESIGN.Trans.start(this, new VALIDATION_email("updateLibrarian", validationCode, infos), 2);
                    break;
                case false:
                    
            infos.Clear();
            infos.Add(userFld.Text);
            infos.Add(NpasswordFld.Text);
            infos.Add(lastFld.Text.ToUpper());
            infos.Add(firstFld.Text.ToUpper());
            infos.Add(emailFld.Text);
            infos.Add(oldUser);
                    
                    
                    DATABASE.librarian.update(infos);
                    INFO.librarian.Username = infos[0];
                    INFO.librarian.Password = infos[1];
                    INFO.librarian.Lastname = infos[2];
                    INFO.librarian.Firstname = infos[3];
                    INFO.librarian.Email = infos[4];
                    DESIGN.Trans.start(this, new BOARD_librarian(), 2);
                    break;
            }
        }

        string randomNumber()
        {
            string randomNum = "";
            char[] collections = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            Random r = new Random();
            for (int x = 0; x <= 3; x++)
            {
                randomNum += collections[r.Next(0, 9)].ToString();
            }
            return randomNum;
        }


        List<string> infos = new List<string>();
        void getAllData()
        {
        }

        Boolean InputValid()
        {
            if (lastFld.Text.Equals("") || firstFld.Text.Equals("") || userFld.Text.Equals("") || OpasswordFld.Text.Equals("") || NpasswordFld.Text.Equals("") || RpasswordFld.Text.Equals(""))
            {
                MessageBox.Show("Please complete the form", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (isMailEdited == true)
            {
                List<string> registeredEmail = DATABASE.librarian.Email.getData();
                Boolean isRegistered = false;
                foreach (string x in registeredEmail)
                {
                    if (x.Equals(emailFld.Text))
                    {
                        isRegistered = true;
                    }
                }
                if (isRegistered == true)
                {
                    MessageBox.Show("This Email is already taken", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            if (isUserEdited == true)
            {
                if (userFld.Text.Length <= 7 || userFld.Text.Length >= 15)
                {
                    MessageBox.Show("Username length should be 8 to 16 characters long", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                List<string> userRegistered = DATABASE.librarian.Username.getData();
                List<string> adminReserv = DATABASE.admin.Username.getData();
                Boolean isUserRegistered = false;
                foreach (string x in userRegistered)
                {
                    if (x.Equals(userFld.Text))
                    {
                        isUserRegistered = true;
                    }
                }
                foreach (string x in adminReserv)
                {
                    if (x.Equals(userFld.Text))
                    {
                        isUserRegistered = true;
                    }
                }
                if (isUserRegistered)
                {
                    MessageBox.Show("This Username is already taken", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            

            if (!OpasswordFld.Text.Equals(INFO.librarian.Password))
            {
                MessageBox.Show("Old password is not correct", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!NpasswordFld.Text.Equals(RpasswordFld.Text))
            {
                MessageBox.Show("Password doesnt match", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (NpasswordFld.Text.Length <= 7 || NpasswordFld.Text.Length >= 15)
            {
                MessageBox.Show("Password length should 8 to 16 characters long", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new BOARD_librarian(), 2);
        }

        private void EDIT_librarian_FormClosing(object sender, FormClosingEventArgs e)
        {
            DATABASE.librarianLog.logout();
        }






    }
}
