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
        string[] basicInfo;
        string demoData = "Jones, Indiana, a place, of gold, somewhere, 1111111, Male, 1980, 111111, 111111, 1, 12341121234, indy@fisnios, contract" +
            ", casual, part time, mail, 1234567890, 0";
        public dataDisplayForm() {
            InitializeComponent();
            basicInfo = demoData.Split(',');
            displayLabel.Text = "Employee Id: " + basicInfo[0] + "\nGiven Names: " + basicInfo[1] + "    Last Name: " + basicInfo[2] + "\nAddress: " +
                basicInfo[2] + "\nCity: " + basicInfo[3] + "    State: " + basicInfo[4] + "    Postcode: " + basicInfo[5] +
                "\nGender: " + basicInfo[6] + "    Date of Birth: " + basicInfo[7] + "\nBSB: " + basicInfo[8] +
                "    Bank Account Number: " + basicInfo[9] + "\nEmployee Id: " + basicInfo[10] + "\nPhone Number: " +
                basicInfo[11] + "    Email: " + basicInfo[12] + "\nEmployment Basis: " + basicInfo[13] + "    Employment Category: "
                + basicInfo[14] + "    Employment Status: " + basicInfo[15] + "\nPayslip Delivery: " + basicInfo[16] +
                "\nTax File Number: " + basicInfo[17] + "    Tax Table: " + basicInfo[18];
        }
        
        private void displayLabel_Click(object sender, EventArgs e) {           
        }

        private void confirmLabel_Click(object sender, EventArgs e) {
        }

        private void confirm_Click(object sender, EventArgs e) {
            pushToExtClass.writeToFile(info); 
        }
        public static void updateString(string stuff) {
            info = stuff;
        }

        private void editButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
