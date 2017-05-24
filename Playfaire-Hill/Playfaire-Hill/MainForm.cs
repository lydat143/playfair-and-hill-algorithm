using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Playfair
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string strPlainText="";
        
        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewForm frmNewForm = new NewForm();//plaintext ban đầu
            frmNewForm.Text = "Unnamed";
            frmNewForm.MdiParent = this;
            frmNewForm.SenDataToMainForm(ref strPlainText);
            mnPlayfair.Enabled = frmNewForm.GetEnableButton();
            mnHill.Enabled = frmNewForm.GetEnableButton();
            frmNewForm.Show();

            // menuStrip1_ItemClicked(sender, e, frmNewForm);
        }

        private void playfairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayfairForm frmPlayFair = new PlayfairForm();
            List<string> lsPlainText = new List<string>();
            List<string> lsCipherText = new List<string>();
            frmPlayFair.Text = "Play Fair";
            //  frmPlayFair.MdiParent = this;


            frmPlayFair.GetDataFromMainForm(strPlainText);
            frmPlayFair.ShowDialog();

            lsPlainText = frmPlayFair.SendPlainTextToMainForm();
            ShowPlainTextForm(lsPlainText);

            lsCipherText = frmPlayFair.SendCipherTextToMainForm();
            ShowCipherTextForm(lsCipherText);
           
        }

        private void ShowPlainTextForm(List<string> lsPlainText)
        {
            NewForm frmPlainText = new NewForm();//plaintext đã xử lý
            frmPlainText.GetListDataFromMainForm(lsPlainText);
            frmPlainText.MdiParent = this;
            frmPlainText.Show();
        }

        private void ShowCipherTextForm(List<string> lsCipherText)
        {
            NewForm frmCipherText = new NewForm();//CipherText
            frmCipherText.GetListDataFromMainForm( lsCipherText );
            frmCipherText.MdiParent = this;
            frmCipherText.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //nếu trong frmNew có chuỗi ký tự thì mới cho phép chọn thuật mã hóa
           
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            string text = File.ReadAllText(openFileDialog1.FileName);
                            NewForm frmNewForm1 = new NewForm();
                            frmNewForm1.Text = "Unnamed";
                            frmNewForm1.MdiParent = this;
                            frmNewForm1.GetDataFromMainForm(text);
                            frmNewForm1.SenDataToMainForm(ref strPlainText);
                            mnPlayfair.Enabled = frmNewForm1.GetEnableButton();
                            mnHill.Enabled = frmNewForm1.GetEnableButton();
                            frmNewForm1.Show();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
