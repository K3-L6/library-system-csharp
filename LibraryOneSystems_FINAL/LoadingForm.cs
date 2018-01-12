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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        private void loadingTM_Tick(object sender, EventArgs e)
        {
            loadingLbl.Text += ".";
            if (loadingLbl.Text.Equals("Loading ........"))
            {
                loadingLbl.Text = "Loading .";
            }
        }

        private void animationTM_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;
        }
    }
}
