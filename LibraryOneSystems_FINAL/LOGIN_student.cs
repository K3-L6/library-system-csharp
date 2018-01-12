using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LibraryOneSystems_FINAL
{
    public partial class LOGIN_student : Form
    {
        
        public LOGIN_student()
        {
            //readyFile();
            loadStoredData();
            InitializeComponent();
        }

       /* void readyFile()
        {
            string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\LibraryOneSystems";
            //string cdPath = Environment.GetFolderPath(Environment.)
            if (!Directory.Exists(targetPath))
            {
                MessageBox.Show("Create " + targetPath);
                Directory.CreateDirectory(targetPath);
            }
            else
            {
                MessageBox.Show("Already Existing");
            }
        }*/

        //TIMERS
        private void currentTime_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToShortTimeString();
            dateLbl.Text = DateTime.Now.ToShortDateString();
        }

        private void titleLbl_DoubleClick(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new LOGIN_main(), 3);
        }


        List<string> idData = new List<string>();
        List<string> firstNameData = new List<string>();
        List<string> lastNameData = new List<string>();
        List<string> courseData = new List<string>();
        void loadStoredData()
        {
            idData = DATABASE.student.sNum.getData();
            firstNameData = DATABASE.student.firstName.getData();
            lastNameData = DATABASE.student.lastName.getData();
            courseData = DATABASE.student.course.getData();
        }

        List<string> idActiveData = new List<string>();
        List<string> firstNameActiveData = new List<string>();
        List<string> lastNameActiveData = new List<string>();
        List<string> courseActiveData = new List<string>();
        void loadActiveData()
        {
            idActiveData.Clear(); firstNameActiveData.Clear();
            lastNameActiveData.Clear(); courseActiveData.Clear();

            idActiveData = DATABASE.studentLog.sNum.getData();
            firstNameActiveData = DATABASE.studentLog.firstName.getData();
            lastNameActiveData = DATABASE.studentLog.lastName.getData();
            courseActiveData = DATABASE.studentLog.course.getData();
        }
        
        private void logBtn_Click(object sender, EventArgs e)
        {
            if (idFld.Text.Equals("")) { MessageBox.Show("Field is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            loadActiveData();
            validateDatas();
        }

        List<string> infos = new List<string>();
        void validateDatas()
        {
            infos.Clear();
            for (int x = 0; x < idActiveData.Count; x++)
            {
                if (idFld.Text.Equals(idActiveData[x]))
                {
                    if (idFld.Text.Equals(idActiveData[x]))
                    {
                        infos.Add(idActiveData[x]);
                        infos.Add(lastNameActiveData[x]);
                        infos.Add(firstNameActiveData[x]);
                        infos.Add(courseActiveData[x]);
                        DATABASE.studentLog.exit(infos);
                        DESIGN.Trans.start(this, new BOARD_student("logout", infos), 2);
                        return;
                    }
                }
            }

                for (int x = 0; x < idData.Count; x++)
                {
                    if (idFld.Text.Equals(idData[x]))
                    {
                        infos.Add(idData[x]);
                        infos.Add(lastNameData[x]);
                        infos.Add(firstNameData[x]);
                        infos.Add(courseData[x]);
                        infos.Add(DateTime.Now.ToLongTimeString());
                        DATABASE.studentLog.enter(infos);
                        DESIGN.Trans.start(this, new BOARD_student("login", infos), 2);
                        return;
                    }
                }

                MessageBox.Show("This ID number is not registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }




    }
}
