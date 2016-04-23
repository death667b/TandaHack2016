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

        

        /*
         public static DateTime(string list1){
            
             foreach (string line in list1){

             }

             return Date.parse(list);
            
        }

        */
    }
}
