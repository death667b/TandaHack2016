using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pushToExt
{
    public static class pushToExtClass
    {
        private static string dataFileLocation = @"..\\..\\..\\pushToExt\\dataBase.txt";
        
        public static void Main(string[] args)
        {
            // Nothing to see here..  Move along..
        }

        /// <summary>
        /// Write data to data file 
        /// </summary>
        /// <param name="newLine">String - New line to enter to text file</param>
        public static void writeToFile(string newLine)   
        {
            if (!File.Exists(dataFileLocation))
            {
                // Create a file to write to.
                using (StreamWriter writeToFile = File.CreateText(dataFileLocation))
                {
                    writeToFile.WriteLine(newLine);
                }
            }
            else
            {
                // Append file if exist
                using (StreamWriter writeToFile = File.AppendText(dataFileLocation))
                {
                    writeToFile.WriteLine(newLine);
                }
            }
        }

        /// <summary>
        /// Delete and create a new file then file with the List object
        /// </summary>
        /// <param name="list">List string object</param>
        public static void overrightFile(List<string> list)
        {
            File.Delete(dataFileLocation);

            using (StreamWriter writeToFile = File.CreateText(dataFileLocation))
            {
                foreach (string newLine in list)
                {
                    writeToFile.WriteLine(newLine);
                }
            }
        }

        /// <summary>
        /// Read all data from text file
        /// </summary>
        /// <returns>list of type string</string></returns>
        public static List<string> readFromFile()
        {
            List<string> list = new List<string>();            
            
            using (StreamReader readFromFile = File.OpenText(dataFileLocation))
            {
                string stringLine = "";
                while ((stringLine = readFromFile.ReadLine()) != null)
                {
                    list.Add(stringLine);
                }
            }

            return list;
        }
    }
}
