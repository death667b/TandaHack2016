using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tecGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Some more comments
        /// less comments
        /// lessor comments
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
