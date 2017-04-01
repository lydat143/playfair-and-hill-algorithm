using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playfaire
{
    public partial class NewForm : Form
    {
        private string strData = "";
        List<string> lsData = new List<string>();
        private bool bEnableButton = false;

        public NewForm()
        {
            InitializeComponent();
            
        }
        
        private void ShowText()
        {
            foreach(string str in lsData)
            {
                strData += str + " ";
            }
            txtText.Text = strData;
        }

        public void SenDataToMainForm(ref string strData1)
        {
            strData1 = this.strData;
        }

        public void GetListDataFromMainForm(List<string> lsString)
        {
            lsData = lsString;
            foreach (string str in lsData)
            {
                strData += str + " ";
            }
            txtText.Text = strData;
        }

        public void GetDataFromMainForm(string str)
        {
            txtText.Text = str;
            bEnableButton = true;
        }

        public bool GetEnableButton()
        {
            return bEnableButton;
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            strData = txtText.Text;
            if (strData.Length >= 2)
                bEnableButton = true;
            else
                bEnableButton = false;
        }
    }
}
