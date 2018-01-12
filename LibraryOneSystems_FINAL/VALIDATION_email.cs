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
    public partial class VALIDATION_email : Form
    {
        List<string> infos = new List<string>();
        string operation = "";
        string validationCode = "";
        
        public VALIDATION_email(string operation, string validationCode, List<string> infos)
        {
            InitializeComponent();

            this.operation = operation;
            this.validationCode = validationCode;
            this.infos = infos;
            
            if (operation.Equals("addLibrarian"))
            {
                emailLbl.Text = "EMAIL : " + infos[6];
            }
            else if (operation.Equals("updateAdmin"))
            {
                emailLbl.Text = "EMAIL : " + infos[4];
            }
            else if (operation.Equals("updateLibrarian"))
            {
                emailLbl.Text = "EMAIL : " + infos[4];
            }
            else if (operation.Equals("resetPasswordAdmin"))
            {
                emailLbl.Text = "EMAIL : " + infos[1];
            }
            else if (operation.Equals("resetPasswordLibrarian"))
            {
                emailLbl.Text = "EMAIL : " + infos[1];
            }
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(validationCode);//delete this for final
            if (!InputValid()) { return; }
            switch (operation)
            { 
                case "addLibrarian":
                    DATABASE.librarian.add(infos);
                    DESIGN.Trans.start(this, new SETTINGS_admin(), 2);
                    break;
                case "updateAdmin":
                    DATABASE.admin.update(infos);
                    distributeNewData();
                    DESIGN.Trans.start(this, new SETTINGS_admin(), 2);
                    break;
                case "updateLibrarian":
                    DATABASE.librarian.update(infos);
                    distributeNewData();
                    DESIGN.Trans.start(this, new BOARD_librarian(), 2);
                    break;
                case "resetPasswordAdmin":
                    DATABASE.admin.resetPassword(infos);
                    DESIGN.Trans.start(this, new LOGIN_main(), 2);
                    break;
                case "resetPasswordLibrarian":
                    DATABASE.librarian.resetPassword(infos);
                    DESIGN.Trans.start(this, new LOGIN_main(), 2);
                    break;
            }
        }

        void distributeNewData()
        {
            switch (operation)
            { 
                case "updateAdmin":
                    INFO.admin.Username = infos[0];
                    INFO.admin.Password = infos[1];
                    INFO.admin.Lastname = infos[2];
                    INFO.admin.Firstname = infos[3];
                    INFO.admin.Email = infos[4];
                    break;
                case "updateLibrarian":
                    INFO.librarian.Username = infos[0];
                    INFO.librarian.Password = infos[1];
                    INFO.librarian.Lastname = infos[2];
                    INFO.librarian.Firstname = infos[3];
                    INFO.librarian.Email = infos[4];
                    break;
            }
        }

        Boolean InputValid()
        {
            if (codeFld.Text.Equals(""))
            {
                MessageBox.Show("Code Field Empty", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!codeFld.Text.Equals(validationCode))
            {
                MessageBox.Show("Validation Code Is Not Correct", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "addLibrarian":
                    DESIGN.Trans.start(this, new SETTINGS_admin(), 2);
                    break;
                case "updateAdmin":
                    DESIGN.Trans.start(this, new SETTINGS_admin(), 2);
                    break;
                case "updateLibrarian":
                    DESIGN.Trans.start(this, new BOARD_librarian() , 2);
                    break;
                case "resetPasswordAdmin":
                    DESIGN.Trans.start(this, new LOGIN_main(), 2);
                    break;
                case "resetPasswordLibrarian":
                    DESIGN.Trans.start(this, new LOGIN_main(), 2);
                    break;
            }
        }
    }
}
