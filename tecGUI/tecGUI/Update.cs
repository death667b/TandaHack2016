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
        }

        private void empNamelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string line in list)
            {
                empNamelistBox.Items.Add(line);
            }
        }

        public void pullTheListIn(List<string> list)
        {
            this.list = list;
        }
    }
}
