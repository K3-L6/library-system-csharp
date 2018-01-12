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
    public partial class EDIT_admin : Form
    {
        string oldUser = "";
        public EDIT_admin()
        {
            InitializeComponent();
            oldUser = INFO.admin.Username;
            lastFld.Text = INFO.admin.Lastname;
            firstFld.Text = INFO.admin.Firstname;
            emailFld.Text = INFO.admin.Email;
            userFld.Text = INFO.admin.Username;
            OpasswordFld.Text = INFO.admin.Password;
            NpasswordFld.Text = INFO.admin.Password;
            RpasswordFld.Text = INFO.admin.Password;
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new SETTINGS_admin(), 2);
        }

        List<string> infos = new List<string>();
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
                    DESIGN.Trans.start(this, new VALIDATION_email("updateAdmin", validationCode, infos), 2);
                    break;
                case false:
                infos.Clear();
            infos.Add(userFld.Text);
            infos.Add(NpasswordFld.Text);
            infos.Add(lastFld.Text.ToUpper());
            infos.Add(firstFld.Text.ToUpper());
            infos.Add(emailFld.Text);
            infos.Add(oldUser);
                    DATABASE.admin.update(infos);
                    INFO.admin.Username = infos[0];
                    INFO.admin.Password = infos[1];
                    INFO.admin.Lastname = infos[2];
                    INFO.admin.Firstname = infos[3];
                    INFO.admin.Email = infos[4];
                    DESIGN.Trans.start(this, new SETTINGS_admin(), 2);
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

        

        Boolean InputValid()
        {
            if (lastFld.Text.Equals("") || firstFld.Text.Equals("") || userFld.Text.Equals("") || OpasswordFld.Text.Equals("") || NpasswordFld.Text.Equals("") || RpasswordFld.Text.Equals(""))
            {
                MessageBox.Show("Please complete the form", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (isMailEdited)
            {
                List<string> registeredMail = DATABASE.admin.Email.getData();
                Boolean isMailRegistered = false;
                foreach (string x in registeredMail)
                {
                    if (x.Equals(emailFld.Text))
                    {
                        isMailRegistered = true;
                    }
                }
                if (isMailRegistered)
                {
                    MessageBox.Show("This Email is already registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            

            if (!OpasswordFld.Text.Equals(INFO.admin.Password))
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


    }
}
