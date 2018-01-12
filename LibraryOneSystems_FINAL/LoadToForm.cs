using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DESIGN
{
    public static class LoadToForm
    {
        static Form currentForm, gotoForm;
        static int interval;
        public static void start(Form currentForm, Form gotoForm, int loadingSec)
        {
            LoadToForm.currentForm = currentForm;
            LoadToForm.gotoForm = gotoForm;
            interval = loadingSec * 1000;
            gotoForm.Opacity = 0;
            gotoForm.Show();
            
            Thread work = new Thread(() => splashScreen());
            currentForm.Hide();
            work.Start();
            if (gotoForm.CanFocus)
            {
                Thread.Sleep(interval);
                work.Abort();
                gotoForm.Opacity = 1;
            }
        }

        static void splashScreen()
        {
            Application.Run(new LibraryOneSystems_FINAL.LoadingForm());
        }


    }
}
