using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace LibraryOneSystems_FINAL
{
    public partial class REGISTRATION_student : Form
    {
        public REGISTRATION_student()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new BOARD_admin(), 3);
        }

        List<string> infos = new List<string>();
        private void regBtn_Click(object sender, EventArgs e)
        {
            if (!InputValid()) { return; }

            infos.Clear();
            infos.Add(idFld.Text);
            infos.Add(lastNameFld.Text.ToUpper());
            infos.Add(firstNameFld.Text.ToUpper());
            infos.Add(genderFld.Text);
            infos.Add(courseFld.Text);
            infos.Add(cellNumberFld.Text);
            infos.Add(emailFld.Text);
            DATABASE.student.add(infos);
            DESIGN.Trans.start(this, new BOARD_admin(), 2);
        }

        Boolean InputValid()
        {
            if (idFld.Text.Equals("") || lastNameFld.Text.Equals("") || firstNameFld.Text.Equals("") || genderFld.Text.Equals("") || courseFld.Text.Equals("") || cellNumberFld.Text.Equals("") || emailFld.Text.Equals(""))
            {
                MessageBox.Show("Please Complete The Registration Form", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            float temp;
            if (float.TryParse(idFld.Text, out temp) == false)
            {
                MessageBox.Show("ID Format is not valid", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (idFld.Text.Length != 11)
            {
                MessageBox.Show("Student ID should be 11 characters long", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            List<string> registeredID = DATABASE.student.sNum.getData();
            Boolean isIDregistered = false;
            foreach (string x in registeredID)
            {
                if (x.Equals(idFld.Text))
                {
                    isIDregistered = true;
                }
            }
            if (isIDregistered == true)
            {
                MessageBox.Show("This ID number is already registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            float temp2;
            if (float.TryParse(cellNumberFld.Text, out temp2) == false)
            {
                MessageBox.Show("Invalid Cell Number Format", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (cellNumberFld.Text.Length != 11)
            {
                MessageBox.Show("Cell Number should be 11 characters long", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            List<string> existingMails = DATABASE.student.email.getData();
            Boolean isMailDuplicate = false;
            foreach (string x in existingMails)
            {
                if (x.Equals(emailFld.Text))
                {
                    isMailDuplicate = true;
                }
            }
            if (isMailDuplicate)
            {
                MessageBox.Show("This Email Is Already Registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            return true;
        }

    }
}
