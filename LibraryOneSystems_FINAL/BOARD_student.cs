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
    public partial class BOARD_student : Form
    {
        public BOARD_student(string typeOfLog, List<string> infos)
        {
            InitializeComponent();

            DATABASE.bookLog.displayBorrowedPerUser(infos[0], bookView);

            if (typeOfLog.Equals("login"))
            {
                titleLbl.Text = "Welcome to Library One";
                nameFld.Text = infos[2] + " " + infos[1];
                idFld.Text = infos[0];
                courseFld.Text = infos[3];
            }
            else if(typeOfLog.Equals("logout"))
            {
                DATABASE.studentLog.exit(infos);
                titleLbl.Text = "Thank You For Using Library One";
                nameFld.Text =  infos[2] + " " + infos[1];
                idFld.Text = infos[0];
                courseFld.Text = infos[3];
            }



        }

        int sec = 10;
        private void backToMain_Tick(object sender, EventArgs e)
        {
            sec --;
            secLbl.Text = sec.ToString();
            if (sec == 0)
            {
                backToMain.Dispose() ;
                sec = 5;
                DESIGN.Trans.start(this, new LOGIN_student(), 2);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            backToMain.Dispose();
            sec = 10;
            DESIGN.Trans.start(this, new LOGIN_student(), 2);
        }


    }
}
