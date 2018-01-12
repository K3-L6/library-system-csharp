husing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryOneSystems_FINAL
{
    public partial class EDIT_book : Form
    {
        string oldID = "";
        List<string> newData = new List<string>();
        public EDIT_book(List<string> infos)
        {
            InitializeComponent();
            oldID = infos[0];
            numberFld.Text = infos[0];
            titleFld.Text = infos[1];
            authorFld.Text = infos[2];
            categoryFld.Text = infos[3];
            qtyFld.Text = infos[4];
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!InputValid()) { return; }
            getUpdatedData();
            DATABASE.book.update(newData);
            DESIGN.Trans.start(this, new BOARD_admin(), 2);
        }

        void getUpdatedData()
        {
            newData.Add(numberFld.Text);
            newData.Add(titleFld.Text.ToUpper());
            newData.Add(authorFld.Text.ToUpper());
            newData.Add(categoryFld.Text);
            newData.Add(qtyFld.Text);
            newData.Add(oldID);
        }

        Boolean InputValid()
        {
            if (numberFld.Text.Equals("") || titleFld.Text.Equals("") || authorFld.Text.Equals("") || categoryFld.Text.Equals("") || qtyFld.Text.Equals(""))
            {
                MessageBox.Show("Please Complete The Update Form", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (isIDedited == true)
            {
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
            }
            
            int x;
            if (!int.TryParse(qtyFld.Text, out x))
            {
                MessageBox.Show("Quantity Should Be A Number", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        Boolean isIDedited = false;
        private void editNumber_Click(object sender, EventArgs e)
        {
            isIDedited = true;
            numberFld.Enabled = true;
            editNumber.Enabled = false;
        }

        private void editTitle_Click(object sender, EventArgs e)
        {
            titleFld.Enabled = true;
            editTitle.Enabled = false;
        }

        private void editAuthor_Click(object sender, EventArgs e)
        {
            authorFld.Enabled = true;
            editAuthor.Enabled = false;
        }

        private void editCategory_Click(object sender, EventArgs e)
        {
            categoryFld.Enabled = true;
            editCategory.Enabled = false;
        }

        private void editQty_Click(object sender, EventArgs e)
        {
            qtyFld.Enabled = true;
            editQty.Enabled = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new BOARD_admin(), 2);
        }

    }
}
