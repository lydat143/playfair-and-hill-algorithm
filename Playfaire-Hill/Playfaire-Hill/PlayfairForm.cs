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
        int iChoseMatrix = 5; // == 5 là matrix 5x5; == 6 là matrix 6x6

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int iX = 50, iY = 30;//tọa độ textbox
            string strKey = txtKey.Text.ToUpper(); // chuỗi Key ban đầu
            int iNumchar = 0;// số thứ của tự ký tự trong chuỗi
            int iChar = 65; //A
            char[,] cKey = new char[6, 6]; // lưu các ký tự trong chuỗi key
            Console.WriteLine(strKey);
            for (int iHang = 0; iHang < iChoseMatrix; iHang++)
            {
                for (int iCot = 0; iCot < iChoseMatrix; iCot++)
                {
                    if (iNumchar < strKey.Length)
                    {
                        back1:
                        if (CheckKey(strKey[iNumchar], cKey) == 1)
                        {
                            cKey[iHang, iCot] = strKey[iNumchar];
                            CreateTextBox(iHang, iCot, iX, iY, cKey[iHang, iCot]);
                            iNumchar++;
                        }
                        else
                        {
                            iNumchar++;
                            goto back1;
                        }

                    }
                    else
                    {
                        back2:
                        if (CheckKey((char)iChar, cKey) == 1)
                        {

                            if (iChoseMatrix == 6 && iChar > 90) //90: Z
                            {
                                iChar = 48; //48: 0
                            }
                            cKey[iHang, iCot] = (char)iChar;
                            CreateTextBox(iHang, iCot, iX, iY, cKey[iHang, iCot]);
                            iChar++;
                        }
                        else
                        {
                            iChar++;
                            goto back2;
                        }
                        
                    }
                    iX += 35;
                    Console.WriteLine(cKey[iHang, iCot]);
                }
                iX = 50;
                iY += 35;
            }
        }

        private int CheckKey(char iChar, char[,] cKey) // kiểm tra trong ma trận đã có ký tự nào rồi
        {
            for (int iHang = 0; iHang < iChoseMatrix; iHang++)
            {
                for (int iCot = 0; iCot < iChoseMatrix; iCot++)
                {
                    if(iChoseMatrix == 5)
                    {
                        if ((cKey[iHang, iCot] == 'I' && iChar == 'J') || (cKey[iHang, iCot] == 'J' && iChar == 'I'))
                            return 0;
                    }

                    if (cKey[iHang, iCot] == iChar)
                        return 0; // bị trùng ký tự
                }
            }
            return 1; // không bị trùng ký tự
        }



        private void btnMatrix55_CheckedChanged(object sender, EventArgs e)
        {
            iChoseMatrix = 5;
           /* foreach (Control oControl in this.Controls)
            {
                if(oControl is TextBox)
                    this.Controls.Remove(oControl);
            }
            CreateMatrix(5);*/
        }

        private void btnMatrix66_CheckedChanged(object sender, EventArgs e)
        {
            iChoseMatrix = 6;
           /* foreach (Control oControl in this.Controls)
            {
                if (oControl is TextBox)
                    this.Controls.Remove(oControl);
            }
            CreateMatrix(6);*/
        }

       /* private void CreateMatrix(int iMatrixSize)
        {
            int iX = 50, iY = 30;
            int iASCII = 65; // mã ASCII của A
            for (int i = 0; i < iMatrixSize; i++)
            {
                for (int j = 0; j < iMatrixSize; j++)
                {
                    if(iMatrixSize == 5)
                    {
                        if (iASCII == 74) //bỏ qua chữ J
                            iASCII += 1;
                        
                    }
                    else
                    {
                        if (iASCII > 90) //90 là chữ Z
                            iASCII = 48; //48 là 0
                    }
                    
                    CreateTextBox(i, j, iX, iY, '5', iASCII);// '5' là matrix 5x5
                    iX += 35;
                    iASCII++;
                }
                iX = 50;
                iY += 35;
            }
        }
        */
        private void CreateTextBox (int iHang, int iCot, int iX, int iY, int iASCII )
        {
            TextBox txtMatrix = new TextBox();
            txtMatrix.Name = "txtMatrix" +iHang + "-" + iCot;
            txtMatrix.Multiline = true;
            txtMatrix.Size = new Size(30, 30);
            txtMatrix.Font = new Font("Microsoft Sans Serif", 14);
            txtMatrix.TextAlign = HorizontalAlignment.Center;
            txtMatrix.Location = new Point(iX, iY);
            txtMatrix.Enabled = false;
            txtMatrix.Text = new string((char)iASCII, 1);
            grbMatrixKey.Controls.Add(txtMatrix);
        }
    
        private void PlayfairForm_Load(object sender, EventArgs e)
        {
            //btnMatrix55_CheckedChanged(sender, e);
            //btnMatrix66_CheckedChanged(sender, e);
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
