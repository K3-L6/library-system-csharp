using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DESIGN
{
    public static class Trans
    {
        static Timer TMout = new Timer();
        static Timer TMin = new Timer();
        static Form currentForm;
        static Form gotoForm;
        static int speed;
        
        //TRANS OUT
        public static void start(Form x, Form y, int z)
        {
            currentForm = x; gotoForm = y; speed = z;
            goTransOut();
        }

        private static void goTransOut()
        {
            TMout.Interval = 10;
            TMout.Tick +=new EventHandler(TMout_Tick);
            TMout.Start();
        }

        private static void TMout_Tick(object sender, EventArgs e)
        {
            if (currentForm.Height >= 40)
            {
                currentForm.Opacity -= 0.03;
                currentForm.Height -= speed;
            }
            else
            {
                TMout.Stop();
                goTransForm();
            }
        }

        private static void goTransForm()
        {
            currentForm.Hide();
            gotoForm.Opacity = 0;
            gotoForm.Show();
            TMin.Interval = 10;
            TMin.Tick += new EventHandler(TMin_Tick);
            TMin.Start();
        }

        static void TMin_Tick(object sender, EventArgs e)
        {
            if (gotoForm.Opacity <= 100)
            {
                gotoForm.Opacity += 0.04;
            }
            else
            {
                TMin.Stop();
                TMout.Dispose();
                TMin.Dispose();
            }
        }

       

    }
}
