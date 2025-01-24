using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Roboping
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        static Mutex mutexx = new Mutex(true, "{Roboping}");
        [STAThread]

        static void Main()
        {
            if (mutexx.WaitOne(TimeSpan.Zero, true))
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
                mutexx.ReleaseMutex();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ROBOPING IS RUNING, PELASE CLOSE IT FIRST", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
