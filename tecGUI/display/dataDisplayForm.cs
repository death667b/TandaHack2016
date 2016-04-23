using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pushToExt;

namespace display {
    public partial class dataDisplayForm : Form {
        static string info;
        string quals;
        string[] basicInfo;
        string demoData = "Jones, Indiana, a place, of gold, somewhere, 1111111, Male, 1980, 111111, 111111, 1, 12341121234, indy@fisnios, contract" +
            ", casual, part time, mail, 1234567890, 00,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        public dataDisplayForm() {
            InitializeComponent();
            basicInfo = info.Split(',');
            
            for(int j = 20; j < basicInfo.Length; j++) {
                quals += "Qualification " + (j-19) + ": " + basicInfo[j];

            }
            displayLabel.Text = "Employee Id: " + basicInfo[0] + "\nFirst Name: " + basicInfo[1] + "    Last Name: " + basicInfo[2] +
                "\nEmail: " + basicInfo[3] + "    Gender: " + basicInfo[4] + "\nTax File Number: " + basicInfo[5] +
                "    Tax Free Threshold: " + basicInfo[6] + "\nPhone Number: " + basicInfo[7] + "\nBSB: " + basicInfo[8] +
                "    Bank Account Number: " + basicInfo[9] + "\nAddress Line 1: " + basicInfo[10] + "\nAddress Line 2: " +
                basicInfo[11] + "\nAddress Line 3: " + basicInfo[12] + "\nCity: " + basicInfo[13] + "    State: "
                + basicInfo[14] + "    Postcode: " + basicInfo[15] + "\nStart Date: " + basicInfo[16] +
                "\nEmployment Basis: " + basicInfo[17] + "    Employment Status: " + basicInfo[18] + "\nPayslip: " + basicInfo[19];
        }
        
        private void displayLabel_Click(object sender, EventArgs e) {           
        }

        private void confirmLabel_Click(object sender, EventArgs e) {
        }

        private void confirm_Click(object sender, EventArgs e) {
            pushToExtClass.writeToFile(info);
            Application.Exit(); 
        }
        public static void updateString(string stuff) {
            info = stuff;
        }

        private void editButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
