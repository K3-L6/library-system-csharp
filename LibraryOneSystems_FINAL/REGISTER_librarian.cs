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
    public partial class REGISTER_librarian : Form
    {
        public REGISTER_librarian()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (!InputValid()) { return; }

            string timeIn = hrsIN.Value.ToString() + ":" + minIN.Value.ToString();
            string timeOut = hrsOUT.Value.ToString() + ":" + minOUT.Value.ToString();
            string validationCode = randomNumber();
            
            List<string> infos = new List<string>();
            infos.Clear();
            infos.Add(userFld.Text);
            infos.Add(passFld.Text);
            infos.Add(lastFld.Text.ToUpper());
            infos.Add(firstFld.Text.ToUpper());
            infos.Add(timeIn);
            infos.Add(timeOut);
            infos.Add(emailFld.Text);

            EMAIL.MailSystem.send(infos[6], "Library One Systems Email Validation", "Hi " + infos[3] + "\n\nWe would like to validate this email\n\nValidation Code : " + validationCode);
            DESIGN.Trans.start(this, new VALIDATION_email("addLibrarian", validationCode, infos), 2);
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
            if (lastFld.Text.Equals("") || firstFld.Text.Equals("") || userFld.Text.Equals("") || passFld.Text.Equals("") || rpassFld.Text.Equals("") || emailFld.Text.Equals(""))
            {
                MessageBox.Show("Please Complete The  Registration Form", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (userFld.Text.Length <= 7 || userFld.Text.Length >= 15)
            {
                MessageBox.Show("Username Should be 8 to 16 characters long", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (passFld.Text.Length <= 7 || passFld.Text.Length >= 15)
            {
                MessageBox.Show("Password Should be 8 to 16 characters long", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!passFld.Text.Equals(rpassFld.Text))
            {
                MessageBox.Show("Passwords does not match", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            List<string> existingMails = DATABASE.librarian.Email.getData();
            Boolean isMailRegistered = false;
            foreach (string x in existingMails)
            {
                if (x.Equals(emailFld.Text))
                {
                    isMailRegistered = true;
                }
            }
            if (isMailRegistered)
            {
                MessageBox.Show("This Email Is Already Registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if ((hrsIN.Value.ToString() + ":" + minIN.Value.ToString()) == (hrsOUT.Value.ToString() + ":" + minOUT.Value.ToString()))
            {
                MessageBox.Show("You cant have the same Time IN value and Time Out value", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            //string startStr = hrsIN.Value.ToString() + ":" + minIN.Value.ToString();
            //string endStr = hrsOUT.Value.ToString() + ":" + minOUT.Value.ToString();
            //DateTime start = Convert.ToDateTime(startStr);
            //DateTime end = Convert.ToDateTime(endStr);

            //if (start.AddHours(1) > end)
            //{
              //  MessageBox.Show("Lowest Time of duty is 1 hr");
                //return false;
            //}
            return true;
        }

        private void hrsIN_ValueChanged(object sender, EventArgs e)
        {
            if (hrsIN.Value == 23)
            {
                minIN.Maximum = 59;
            }
            else
            {
                minIN.Maximum = 60;
            }
        }

        private void minIN_ValueChanged(object sender, EventArgs e)
        {
            if (minIN.Value == 60)
            {
                hrsIN.Value += 1;
                minIN.Value = 0;
            }
        }

        private void hrsOUT_ValueChanged(object sender, EventArgs e)
        {
            if (hrsOUT.Value == 23)
            {
                minOUT.Maximum = 59;
            }
            else
            {
                minOUT.Maximum = 60;
            }
        }

        private void minOUT_ValueChanged(object sender, EventArgs e)
        {
            if (minOUT.Value == 60)
            {
                hrsOUT.Value += 1;
                minOUT.Value = 0;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new SETTINGS_admin(), 2);
        }






    }
}
