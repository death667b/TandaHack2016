﻿using System;
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
            private TextBox qualificationTextBox;
            private DateTimePicker expDatePicker;
            private CheckBox expiresCheckBox;
            private int id;

            public qualification(TextBox qualificationTextBox, DateTimePicker expDatePicker, CheckBox expiresCheckBox, int id)
            {
                this.qualificationTextBox = qualificationTextBox;
                this.expDatePicker = expDatePicker;
                this.expiresCheckBox = expiresCheckBox;
                this.id = id;
            }

            public TextBox getText()
            {
                return qualificationTextBox;
            }

            public string getString()
            {
                return this.qualificationTextBox.Text + " " + expDatePicker.Text;
            }
        }
        public TEC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            str += EmployeeIdTextBox.Text.ToString() + ", ";
            str += givenNamesTextBox.Text.ToString() + ", ";
            str += lastNameTextBox.Text.ToString() + ", ";
            str += emailTextBox.Text.ToString() + ", ";
            str += genderComboBox.SelectedItem.ToString() + ", ";
            str += TaxFileTextBox.Text.ToString() + ", ";
            str += taxTableComboBox.SelectedItem.ToString() + ", ";
            str += phoneNumberTextBox.Text.ToString() + ", ";
            str += bsbTextBox.Text.ToString() + ", ";
            str += accoutnNumberTextBox.Text.ToString() + ", ";
            foreach (string line in AddressTextBox.Lines)
            {
                str += line + ", ";
            }
            str += cityTextBox.Text.ToString() + ", ";
            str += stateTextBox.Text.ToString() + ", ";
            str += postcodeTextBox.Text.ToString() + ", ";
            str += startDatePicker.Text.ToString() + ", ";
            str += empBasisComboBox.SelectedItem.ToString() + ", ";
            str += empStatusComboBox.SelectedItem.ToString() + ", ";
            str += payslipComboBox.SelectedItem.ToString() + ", ";
            //str += expDatePicker.Text.ToString() + ", ";
            //str += expiresCheckBox.Checked.ToString() + ", ";
           // str += qualListBox.Text.ToString() + ", ";
            for (int j = 0; j < i; j++ )
            {
                str += q[j].getString() + ", ";
                //str += line + ", ";
            }


            pushToExtClass.writeToFile(str);
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
            if(qualificationTextBox.Equals(""))
            {
                return; // error
            }
            q[i] = new qualification(qualificationTextBox, expDatePicker, expiresCheckBox, i);
            qualListBox.Items.Add(q[i].getString());
            i++;
            qualificationTextBox.Text = "";
            expiresCheckBox.Checked = false;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e) {

        }
    }
}
