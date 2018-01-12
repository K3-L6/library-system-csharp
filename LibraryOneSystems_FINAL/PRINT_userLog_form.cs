using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LibraryOneSystems_FINAL
{
    public partial class PRINT_userLog_form : Form
    {
        string operatorType = "";
        public PRINT_userLog_form(string operatorType)
        {
            this.operatorType = operatorType;
            InitializeComponent();
        }

        private void PRINT_userLog_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LibraryDataDataSet1.tbl_studentLog' table. You can move, or remove it, as needed.
            //this.reportViewer1.Reset();
            tbl_studentLogTableAdapter.Fill(this.LibraryDataDataSet1.tbl_studentLog);
            reportViewer1.RefreshReport();
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
