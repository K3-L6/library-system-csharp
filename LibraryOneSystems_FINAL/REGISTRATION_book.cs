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
    public partial class REGISTRATION_book : Form
    {
        public REGISTRATION_book()
        {
            InitializeComponent();
        }

        List<string> infos = new List<string>();
        private void regBtn_Click(object sender, EventArgs e)
        {
            if (!InputValid()) { return; }
            
            infos.Clear();  
            infos.Add(numberFld.Text);
            infos.Add(titleFld.Text.ToUpper());
            infos.Add(authorFld.Text.ToUpper());
            infos.Add(categoryFld.Text);
            infos.Add(qtyFld.Text);
            DATABASE.book.add(infos);
            DESIGN.Trans.start(this, new BOARD_admin(), 3);
        }

        Boolean InputValid()
        {
            if (numberFld.Text.Equals("") || titleFld.Text.Equals("") || authorFld.Text.Equals("") || categoryFld.Text.Equals("") || qtyFld.Text.Equals(""))
            {
                MessageBox.Show("Please Complete The Form", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            float temp;
            if (float.TryParse(numberFld.Text, out temp) == false)
            {
                MessageBox.Show("Book ID Invalid Format", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            List<string> bookIDregistered = DATABASE.book.bNum.getData();
            Boolean isIDregistered = false;
            foreach (string z in bookIDregistered)
            {
                if (z.Equals(numberFld.Text))
                {
                    isIDregistered = true;
                }
            }
            if (isIDregistered == true)
            {
                MessageBox.Show("This Book ID is already registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            int x;
            if (!int.TryParse(qtyFld.Text, out x))
            {
                MessageBox.Show("Quantity Should Be A Number", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new BOARD_admin(), 2);
        }
    }
}
