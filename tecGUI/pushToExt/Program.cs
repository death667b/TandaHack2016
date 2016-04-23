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

        public static void test() // string formData  
        {

            string formData = getFormData(); // FOR TESTING ONLY!

            writeToFile(formData);
            
            
            
            
            
            /*List<string> list = null; 
            
            DateTime thisDate1 = new DateTime(2017, 6, 10);
            //writeToFile(77, "fgnuygtg", thisDate1);

            list = readFromFile();
            string testString = list[1];
            MessageBox.Show(testString);*/
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

        private static string getFormData()
        {
            string lastNameTextBox = "TESTlastNameTextBox";
            string givenNamesTextBox = "TESTgivenNamesTextBox";

            string[] AddressTextBox = new string[] { "Address line 1", "Address line 2", "Address line 3" }; //remove line
            string AddressTextBoxString = "";
            foreach (string line in AddressTextBox)
            {
                AddressTextBoxString += line + ", ";
            }
            string cityTextBox = "TESTcityTextBox";
            string postcodeTextBox = "TESTpostcodeTextBox";
            string genderComboBox = "TESTgenderComboBox";  //need to add .selected ??
            string dateOfBirthPicker = "TESTdate"; // might be a datatime type
            string bsbTextBox = "TESTbsbTextBox";
            string accoutnNumberTextBox = "TESTaccoutnNumberTextBox";
            string qualificationTextBox = "TESTqualificationTextBox";
            string expiresCheckBox = "false"; //type boolean
            string EmployeeIdTextBox = "TESTEmployeeIdTextBox";
            string phoneNumberTextBox = "TESTphoneNumberTextBox";
            string emailTextBox = "TESTemailTextBox";
            string empBasisComboBox = "TESTempBasisComboBox"; // dropdown box
            string employCatComboBox = "TESTemployCatComboBox"; // dropdown box
            string empStatusComboBox = "TESTempStatusComboBox"; // dropdown box
            string payslipComboBox = "TESTpayslipComboBox"; // dropdown box

            string returnString = lastNameTextBox + ", " + givenNamesTextBox + ", " + AddressTextBoxString;
            return returnString;
        }
    }
}
