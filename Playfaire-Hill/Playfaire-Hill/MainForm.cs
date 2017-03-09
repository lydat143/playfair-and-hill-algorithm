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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewForm frmNew = new NewForm();
            frmNew.Text = "Unnamed";
            frmNew.MdiParent = this;
            frmNew.Show();
            mnHill.Enabled = true;
            mnPlayfair.Enabled = true;
        }

        private void playfairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayfairForm frmPlayFair = new PlayfairForm();
            frmPlayFair.Text = "Play Fair";
            frmPlayFair.MdiParent = this;
            frmPlayFair.Show();
        }

        
    }
}
