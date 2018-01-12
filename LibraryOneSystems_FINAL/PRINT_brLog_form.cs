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
    public partial class PRINT_brLog_form : Form
    {
        public PRINT_brLog_form()
        {
            InitializeComponent();
        }

        private void PRINT_brLog_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PRINT_brLog_dataset.tbl_brLog' table. You can move, or remove it, as needed.
            this.tbl_brLogTableAdapter.Fill(this.PRINT_brLog_dataset.tbl_brLog);

            this.rpView.RefreshReport();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DESIGN.Trans.start(this, new BOARD_admin(), 3);
        }
    }
}
