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

namespace tecGUI
{
    public partial class Update : Form
    {
        private List<string> employees = new List<string>();
        private int selectedInt;
        private string[] selectedEmpList;
        private List<string> quaList = new List<string>();
        private int selectedQuaInt;

        public Update()
        {
            InitializeComponent();
            pullTheListIn(pushToExtClass.readFromFile());
            fullTheEmpNameListBox();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string newString = " " + quatextBox.Text + " " + expiretextBox.Text;

            int newEle = 21 + selectedQuaInt;
            selectedEmpList[newEle] = newString;

            string oneString = "";
            foreach (string data in selectedEmpList)
            {
                oneString += data + ",";
            }

            employees[selectedInt] = oneString;

            pushToExtClass.overWriteFile(employees);

            empNamelistBox.Items.Clear();
            qualistBox.Items.Clear();

            pullTheListIn(pushToExtClass.readFromFile());
            fullTheEmpNameListBox();


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string newString = " " + quatextBox.Text + " " + expiretextBox.Text;

            string oneString = "";
            foreach (string data in selectedEmpList)
            {
                oneString += data + ",";
            }

            oneString += newString + ",";

            employees[selectedInt] = oneString;

            pushToExtClass.overWriteFile(employees);

            empNamelistBox.Items.Clear();
            qualistBox.Items.Clear();

            pullTheListIn(pushToExtClass.readFromFile());
            fullTheEmpNameListBox();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int newEle = 21 + selectedQuaInt;
            string oneString = "";
            foreach (string data in selectedEmpList)
            {
                if (counter != newEle)
                {
                    oneString += data + ",";
                }

                counter++;
            }

            employees[selectedInt] = oneString;

            pushToExtClass.overWriteFile(employees);

            empNamelistBox.Items.Clear();
            qualistBox.Items.Clear();

            pullTheListIn(pushToExtClass.readFromFile());
            fullTheEmpNameListBox();
        }

        private void qualistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quatextBox.Clear();
            expiretextBox.Clear();
            selectedQuaInt = qualistBox.SelectedIndices[0];
            string[] splitText = new string[3];
            splitText = quaList[selectedQuaInt].Trim().Split(' ');
            quatextBox.Text = splitText[0];
            int itsAHack = 0;
            string getItDone = "";
            foreach (string errorOrNot in splitText)
            {
                if (itsAHack != 0)
                {
                    getItDone += errorOrNot + " ";
                }
                itsAHack++;
            }
            expiretextBox.Text = getItDone;
        }

        private void empNamelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            qualistBox.Items.Clear();
            quaList.Clear();
            selectedInt = empNamelistBox.SelectedIndices[0];

            qualistBox.BeginUpdate();
            selectedEmpList = employees[selectedInt].Split(',');
            for (int i = 21; i < selectedEmpList.Length; i++)
            {
                qualistBox.Items.Add(selectedEmpList[i]);
                quaList.Add(selectedEmpList[i]);
            }
            qualistBox.EndUpdate();
        }

        private void fullTheEmpNameListBox()
        {
            if (employees[0] != "No Data")
            {
                empNamelistBox.BeginUpdate();
                foreach (string element in employees)
                {
                    string[] data = element.Split(',');
                    empNamelistBox.Items.Add(data[2] + ", " + data[1]);
                }
                empNamelistBox.EndUpdate();
            }
            else
            {
                empNamelistBox.Items.Add("No Data");
                empNamelistBox.Items.Add("Go and add some!");
                empNamelistBox.Enabled = false;
                qualistBox.Enabled = false;
                quatextBox.Enabled = false;
                expiretextBox.Enabled = false;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void pullTheListIn(List<string> list)
        {
            this.employees = list;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }




    }
}
