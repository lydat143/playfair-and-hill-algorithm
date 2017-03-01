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
    public partial class PlayfairForm : Form
    {
        public PlayfairForm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string strKey = txtKey.ToString(); // chuỗi Key ban đầu
            char[] cKey; // lưu các ký tự trong chuỗi key
            for (int i = 1; i < strKey.Length; i++)
            {
                
            }               
        }

        private void btnMatrix55_CheckedChanged(object sender, EventArgs e)
        {
            int iX = 50, iY = 30;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    CreateTextBox(j, i, iX, iY);
                    iX += 35;
                }
                iX = 50;
                iY += 30;
            }
        }

        
        private void CreateTextBox (int iCot, int iHang, int iX, int iY)
        {
            TextBox txtMatrix = new TextBox();
            txtMatrix.Name = "txtMatrix" +iHang + "-" + iCot;
            txtMatrix.Size = new Size(30, 40);
            txtMatrix.Location = new Point(iX, iY);
            txtMatrix.Enabled = false;
            grbMatrixKey.Controls.Add(txtMatrix);
        }

        private void PlayfairForm_Load(object sender, EventArgs e)
        {
            btnMatrix55_CheckedChanged(sender, e);
        }
    }
}
