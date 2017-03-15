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
        public NewForm()
        {
            InitializeComponent();
        }

        private string strData = "";
        private bool bEnableButton = false;

        public void SenDataToMainForm(ref string strData1)
        {
            strData1 = this.strData;
        }

        private void txtPlainText_TextChanged(object sender, EventArgs e)
        {
            strData = txtPlainText.Text;
            if (strData.Length >= 2)
                bEnableButton = true;
            else
                bEnableButton = false;
        }

        public bool GetEnableButton()
        {
            return bEnableButton;
        }
        
    }
}
