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
    public partial class EDIT_student : Form
    {
        public EDIT_student(List<string> infos)
        {
            InitializeComponent();
            oldID = infos[0];
            idFld.Text = infos[0];
            lastNameFld.Text = infos[1];
            firstNameFld.Text = infos[2];
            genderFld.Text = infos[3];
            courseFld.Text = infos[4];
            cellNumberFld.Text = infos[5];
            emailFld.Text = infos[6];
        }

        string oldID = "";
        List<string> newData = new List<string>();
        
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!InputValid()) { return; }
            getUpdatedData();
            DATABASE.student.update(newData);
            DESIGN.Trans.start(this, new BOARD_admin(), 3);
        }


        void getUpdatedData()
        {
            newData.Add(idFld.Text);
            newData.Add(lastNameFld.Text.ToUpper());
            newData.Add(firstNameFld.Text.ToUpper());
            newData.Add(genderFld.Text);
            newData.Add(courseFld.Text);
            newData.Add(cellNumberFld.Text);
            newData.Add(emailFld.Text);
            newData.Add(oldID);
        }

        Boolean InputValid()
        {
            
            if (idFld.Text.Equals("") || lastNameFld.Text.Equals("") || firstNameFld.Text.Equals("") ||  genderFld.Text.Equals("") || courseFld.Text.Equals("") || cellNumberFld.Text.Equals("") || emailFld.Text.Equals(""))
            {
                MessageBox.Show("Please Complete The Update Form", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            //VALIDATE IF ID IS EDITED
            if (isIDedited == true)
            {
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

            //validating email if edited
            if (isMailEdited == true)
            {
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
            }
            return true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new BOARD_admin(), 3);
        }

        Boolean isIDedited = false;
        private void editID_Click(object sender, EventArgs e)
        {
            isIDedited = true;
            idFld.Enabled = true;
            editID.Enabled = false;
        }

        private void editLastName_Click(object sender, EventArgs e)
        {
            lastNameFld.Enabled = true;
            editLastName.Enabled = false;
        }

        private void editFirstName_Click(object sender, EventArgs e)
        {
            firstNameFld.Enabled = true;
            editFirstName.Enabled = false;
        }


        private void genderBtn_Click(object sender, EventArgs e)
        {
            genderFld.Enabled = true;
            editGenderBtn.Enabled = false;
        }

        private void editCourse_Click(object sender, EventArgs e)
        {
            courseFld.Enabled = true;
            editCourse.Enabled = false;
        }

        private void editCell_Click(object sender, EventArgs e)
        {
            cellNumberFld.Enabled = true;
            editCell.Enabled = false;
        }

        Boolean isMailEdited = false;
        private void editMail_Click(object sender, EventArgs e)
        {
            emailFld.Enabled = true;
            editMail.Enabled = false;
            isMailEdited = true;
        }

    }
}
