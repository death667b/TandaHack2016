﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace display
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dataDisplayForm());
        }
        
        public static void runDisplay (string info) {
            dataDisplayForm.updateString(info);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new dataDisplayForm());
            dataDisplayForm form = new dataDisplayForm();
            form.Show();
        }
    }
}
