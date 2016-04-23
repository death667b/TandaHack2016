using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace certWarning
{
    static class Program
    {

        //public static string employeeName = "brendan";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //readFile();
            Application.Run(new Form1());

           
        }

        public static void runWarning(string[] info)
        {
            Form1.updateString(info);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new dataDisplayForm());
            Form1 form = new Form1();
            form.Show();
        }

        

        /*
         public static DateTime(string list1){
            
             foreach (string line in list1){

             }

             return Date.parse(list);
            
        }

        */
    }
}
