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
    public partial class SETTINGS_resetPassword : Form
    {
        List<string> adminEmails = DATABASE.admin.Email.getData();
        List<string> librarianEmails = DATABASE.librarian.Email.getData();
        List<string> adminUsername = DATABASE.admin.Username.getData();
        List<string> librarianUsername = DATABASE.librarian.Username.getData();
        public SETTINGS_resetPassword()
        {
            InitializeComponent();
            operatorFld.SelectedIndex = 0;
        }

        List<string> infos = new List<string>();
        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (!InputValid()) { return; }
            string validationCode = randomNumber();
            if (operatorFld.SelectedIndex == 0)
            {
                infos.Add(emailFld.Text);
                EMAIL.MailSystem.send(infos[1], "Library One Systems Email Validation", "Hi\n\nWe would like to validate this email\n\nValidation Code : " + validationCode);
                DESIGN.Trans.start(this, new VALIDATION_email("resetPasswordAdmin", validationCode, infos), 2);
            }
            else
            {
                infos.Add(emailFld.Text);
                EMAIL.MailSystem.send(infos[1], "Library One Systems Email Validation", "Hi\n\nWe would like to validate this email\n\nValidation Code : " + validationCode);
                DESIGN.Trans.start(this, new VALIDATION_email("resetPasswordLibrarian", validationCode, infos), 2);
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

        Boolean InputValid()
        {
            if (emailFld.Text.Equals(""))
            {
                MessageBox.Show("Please Complete The Form", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Boolean isValidEmail = false;
            switch (operatorFld.Text)
            { 
                case "ADMIN":
                    for (int x = 0; x < adminEmails.Count; x++)
                    {
                        if (emailFld.Text.Equals(adminEmails[x]))
                        {
                            isValidEmail = true;
                            infos.Add(adminUsername[x]);
                        }
                    }
                        break;
                case "LIBRARIAN":
                        for (int x = 0; x < librarianEmails.Count; x++)
                        {
                            if (emailFld.Text.Equals(librarianEmails[x]))
                            {
                                isValidEmail = true;
                                infos.Add(librarianUsername[x]);
                            }
                        }        
                    break;
            }
            if (isValidEmail == false) 
            {
                MessageBox.Show("The Email You Entered Is Not Registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            return true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new LOGIN_main(), 2);
        }

    }
}
