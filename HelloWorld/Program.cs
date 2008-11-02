using System;

using System.Collections.Generic;
using System.Windows.Forms;
using Neonode.Forms;

namespace HelloWorld
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            string windowCaption = "C71F25F8-ECFF-3d90-92DF-D6D977CDDA72";    // IMPORTANT -> create a new guid and insert it here
            using (SingleInstance instance = new SingleInstance(windowCaption))
            {
                if (instance.AlreadyRunning)
                {
                    instance.TryActivatePreviousInstance(windowCaption);
                }
                else
                {
                    MainView mainView = new MainView();
                    mainView.Text = windowCaption;

                    mainView.ShowDialog();
                }
            }
        }
    }
}