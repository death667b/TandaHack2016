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
        private List<string> list = new List<string>(); 

        public Update()
        {
            InitializeComponent();
            pullTheListIn(pushToExtClass.readFromFile());
            fullTheEmpNameListBox();
        }

        private void empNamelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            MessageBox.Show("ss");
        }

        private void fullTheEmpNameListBox()
        {
            if (list[0] != "No Data")
            {
                foreach (string line in list)
                {
                    string[] data = line.Split(',');
                    empNamelistBox.Items.Add(data[2] + ", " + data[1]);
                }
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
            this.list = list;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
