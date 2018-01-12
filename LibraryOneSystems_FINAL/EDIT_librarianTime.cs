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
    public partial class EDIT_librarianTime : Form
    {
        List<string> infos = new List<string>();
        public EDIT_librarianTime(List<string> infos)
        {
            this.infos = infos;
            InitializeComponent();
            nameLbl.Text = infos[2] + " " + infos[1];
            oldTimeIN.Text = infos[3];
            oldTImeOut.Text = infos[4];
        }

        List<string> newData = new List<string>();
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!InputValid()) { return; }
            newData.Add(infos[0]);
            newData.Add(infos[1]);
            newData.Add(infos[2]);
            newData.Add(hrsIN.Value.ToString() + ":" + minIN.Value.ToString());
            newData.Add(hrsOUT.Value.ToString() + ":" + minOUT.Value.ToString());
            newData.Add(infos[5]);
            DATABASE.librarian.updateTime(newData);
            DESIGN.Trans.start(this, new SETTINGS_admin(), 2);
        }

        Boolean InputValid()
        {
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new SETTINGS_admin(), 2);
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

    }
}
