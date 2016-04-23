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
using display;

namespace tecGUI
{
    public partial class TEC : Form
    {
        private int i = 0;

        qualification[] q = new qualification[10];

        private class qualification
        {
            private string xqualificationTextBox;
            private string xexpDatePicker;
            private Boolean xexpiresCheckBox;
            private int xid;

            public qualification(TextBox qualificationTextBox, DateTimePicker expDatePicker, CheckBox expiresCheckBox, int id)
            {
                this.xqualificationTextBox = qualificationTextBox.Text.ToString();
                this.xexpDatePicker = expDatePicker.Text.ToString();
                this.xexpiresCheckBox = expiresCheckBox.Checked;
                this.xid = id;
            }

            public string getText()
            {
                return xqualificationTextBox;
            }

            public string getString()
            {
                if (xexpiresCheckBox)
                {

                    return xqualificationTextBox + " " + xexpDatePicker;
                }
                return xqualificationTextBox + " No Expiry.";
            }
        }
        public TEC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(empBasisComboBox.Text.ToString().Equals("") || employCatComboBox.Text.ToString().Equals("") || empStatusComboBox.Text.ToString().Equals("") 
                    || payslipComboBox.Text.ToString().Equals("") || taxTableComboBox.Text.ToString().Equals("") || genderComboBox.Text.ToString().Equals(""))
            {
                string message = "You are a muppet!";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    return;
                    // Closes the parent form.

                    //this.Close();

                }
            }
            string str = "";
            str += EmployeeIdTextBox.Text.ToString() + ", ";
            str += givenNamesTextBox.Text.ToString() + ", ";
            str += lastNameTextBox.Text.ToString() + ", ";
            str += emailTextBox.Text.ToString() + ", ";
            str += genderComboBox.SelectedItem.ToString() + ", ";
            str += dateOfBirthPicker.Text.ToString() + ", ";
            str += TaxFileTextBox.Text.ToString() + ", ";
            str += taxTableComboBox.SelectedItem.ToString() + ", ";
            str += phoneNumberTextBox.Text.ToString() + ", ";
            str += bsbTextBox.Text.ToString() + ", ";
            str += accoutnNumberTextBox.Text.ToString() + ", ";
            int fu = 0;
            foreach (string line in AddressTextBox.Lines)
            {
                str += line + ", ";
                fu++;
            }
            for (int k = fu; k < 3; k++)
            {
                str += ", ";
            }

            str += cityTextBox.Text.ToString() + ", ";
            str += stateTextBox.Text.ToString() + ", ";
            str += postcodeTextBox.Text.ToString() + ", ";
            str += startDatePicker.Text.ToString() + ", ";
            str += empBasisComboBox.SelectedItem.ToString() + ", ";
            str += empStatusComboBox.SelectedItem.ToString() + ", ";
            str += payslipComboBox.SelectedItem.ToString() + ", ";
            for (int j = 0; j < i; j++ )
            {
                str += q[j].getString() + ", ";
            }

            display.Program.runDisplay(str);
            //pushToExtClass.writeToFile(str);
        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void expiresCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(expiresCheckBox.Checked) {
                expDatePicker.Enabled = true;
            } else
            {
                expDatePicker.Enabled = false;
            }
        }

        private void qualAddButton_Click(object sender, EventArgs e)
        {
            if (qualificationTextBox.Text.ToString().Equals(""))
            {
                return; // error
            }
            else
            {
                q[i] = new qualification(qualificationTextBox, expDatePicker, expiresCheckBox, i);
                qualListBox.Items.Add(q[i].getString());
                i++;
                qualificationTextBox.Text = "";
                expiresCheckBox.Checked = false;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update form = new Update();
            form.Show();
        }

        private void checkQualificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            certWarning.Form1 form = new certWarning.Form1();
            form.Show();
        }
    }
}
