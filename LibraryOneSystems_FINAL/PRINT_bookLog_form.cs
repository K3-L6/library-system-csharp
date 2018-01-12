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
    public partial class PRINT_bookLog_form : Form
    {
        string operatorType = "";
        public PRINT_bookLog_form(string operatorType)
        {
            this.operatorType = operatorType;
            InitializeComponent();
        }

        private void PRINT_bookLog_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LibraryDataDataSet.tbl_brLog' table. You can move, or remove it, as needed.
            this.tbl_brLogTableAdapter.Fill(this.LibraryDataDataSet.tbl_brLog);

            this.rpView.RefreshReport();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            switch (operatorType)
            { 
                case "admin":
                    DESIGN.Trans.start(this, new BOARD_admin(), 3);
                    break;
                case "librarian":
                    DESIGN.Trans.start(this, new BOARD_librarian(), 3);
                    break;
            }
        }
    }
}
