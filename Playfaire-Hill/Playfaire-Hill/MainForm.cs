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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string strPlainText="";
        NewForm frmNew = new NewForm();        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNew.Text = "Unnamed";
            frmNew.MdiParent = this;
            frmNew.Show();
        }

        private void playfairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayfairForm frmPlayFair = new PlayfairForm();
            frmPlayFair.Text = "Play Fair";
            //  frmPlayFair.MdiParent = this;
            frmNew.SenDataToMainForm(ref strPlainText);
            frmPlayFair.GetDataFromMainForm(strPlainText);
            frmPlayFair.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            mnPlayfair.Enabled = frmNew.GetEnableButton();
            mnHill.Enabled = frmNew.GetEnableButton();
        }
    }
}
