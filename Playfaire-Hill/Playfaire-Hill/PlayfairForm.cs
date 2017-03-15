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
        string strPlainText;

        public PlayfairForm()
        {
            InitializeComponent();
        }

        public void GetDataFromMainForm (string strData)
        {
             strPlainText = strData.ToUpper();
        }

        private void PlayfairForm_Load(object sender, EventArgs e)
        {
            //btnMatrix55_CheckedChanged(sender, e);
            //btnMatrix66_CheckedChanged(sender, e);
        }

        int iChoseMatrix = 0; // == 5 là matrix 5x5; == 6 là matrix 6x6
        
        private void btnEncrypt_Click(object sender, EventArgs e)
        {            
            char [,] cMatrix = new char[6,6]; // ma trận mã
            CreateMatrix(cMatrix); //tạo ma trận mã
            Encrypt(cMatrix);
        }

        // Hàm kiểm tra các ký tự trong ma trận
        private int CheckMatrix(char iChar, char[,] cKey) 
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

                    if(cKey[iHang, iCot] == '\0')
                        return 1; // không bị trùng ký tự hoặc chưa có ký tự nào trong ma trận
                }
            }
            return 1;
        }

        private void btnMatrix66_CheckedChanged(object sender, EventArgs e)
        {
            iChoseMatrix = 6;
            btnEncrypt.Enabled = true;
            
        }

        private void btnMatrix55_CheckedChanged_1(object sender, EventArgs e)
        {
            iChoseMatrix = 5;
            btnEncrypt.Enabled = true;
        }

        // Hàm tạo ma trận mã, với key nhập vào ban đầu
        private void CreateMatrix(char[,] cMatrix)
        {
            string strKey = txtKey.Text.ToUpper(); // chuỗi Key ban đầu
            int iNumchar = 0;// số thứ của tự ký tự trong chuỗi
            int iChar = 65; //A
            Console.WriteLine(strKey);
            for (int iHang = 0; iHang < iChoseMatrix; iHang++)
            {
                for (int iCot = 0; iCot < iChoseMatrix; iCot++)
                {
                    end:
                    if (iNumchar < strKey.Length)
                    {
                        while (CheckMatrix(strKey[iNumchar], cMatrix) == 0)// nếu ký tự đã có trong ma trận
                        {
                              //thì bỏ qua ký tự đó
                            iNumchar++;
                            if (iNumchar >= strKey.Length)
                                goto end;
                        }
                        cMatrix[iHang, iCot] = strKey[iNumchar];
                        iNumchar++;
                    }
                    else
                    {
                        while (CheckMatrix((char)iChar, cMatrix) == 0)
                        {
                            iChar++;
                        }
                        if (iChoseMatrix == 6 && iChar > 90) //90: Z
                        {
                            iChar = 48; //48: 0
                        }
                        cMatrix[iHang, iCot] = (char)iChar;
                        iChar++;
                    }
                    Console.WriteLine(cMatrix[iHang, iCot]);
                }
            }
        }

        // Hàm tạo các textbox để hiển thị ma trận
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
    
        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            
        }

        //hàm xử lý chuỗi ban đầu (tách chuỗi ban đầu thành từng cặp ký tự );
        private void XuLyChuoi (string strPlainText, ref List<string> lsString)
        {
            string [] strPlainText1 = strPlainText.Split(' ');
            string strNewPlainText = "";
            foreach(string str in strPlainText1)
            {
                strNewPlainText += str;
            }

            int iLength = strNewPlainText.Length; // chiều dài plaintext khi không có space
            lsString = new List<string>();
            int i = 0, j =0;
            while (iLength != 0)
            {
                string str = strNewPlainText.Substring(i, 2);
                if( str.Substring(0,1) == str.Substring(1,1))
                {
                    strNewPlainText = strNewPlainText.Substring(0, i + 1) + "X" + strNewPlainText.Substring(i + 1);
                    str = strNewPlainText.Substring(i, 2);
                }

                lsString.Add(str);
               
                i += 2;
                iLength = strNewPlainText.Substring(i).Length;
                if (iLength == 1)
                    strNewPlainText += "X";
                Console.WriteLine(lsString[j]);
                j++;
            }            
        }

        private void Encrypt(char [,] cMatrix)
        {
            List<string> lsPlainString = new List<string>(); // list plaintext đã tách
            List<string> lsCipherString = new List<string>(); // list plaintext đã tách
            XuLyChuoi(strPlainText, ref lsPlainString); //tách chuỗi Plaintext
            int[] iLoc1 = new int[2]; //lưu tọa độ của ký tự trong ma trận iLoc[0]: vị trí hàng, iLoc[1]: vị trí cột
            int[] iLoc2 = new int[2];
            foreach (string str in lsPlainString)
            {
                string str1 = str.Substring(0, 1) ;
                ViTri(Convert.ToChar(str1), cMatrix, ref iLoc1 );
                string str2 = str.Substring(1, 1);
                ViTri(Convert.ToChar(str2), cMatrix, ref iLoc2);
                if(iLoc1[0] == iLoc2[0]) // Nếu plainchar cùng 1 hàng
                {
                    iLoc1[1] = ( iLoc1[1] + 1 ) % iChoseMatrix;
                    iLoc2[1] = ( iLoc2[1] + 1 ) % iChoseMatrix;
                }
                else
                {
                    if (iLoc1[1] == iLoc2[1]) //Nếu PlainChar cùng 1 cột
                    {
                        iLoc1[0] = (iLoc1[0] + 1) % iChoseMatrix;
                        iLoc2[0] = (iLoc2[0] + 1) % iChoseMatrix;
                    }
                    else
                    {
                        int iTemp = iLoc1[1];
                        iLoc1[1] = iLoc2[1];
                        iLoc2[1] = iTemp;
                    }
                }
                

                str1 = cMatrix[iLoc1[0], iLoc1[1]].ToString();
                str2 = cMatrix[iLoc2[0], iLoc2[1]].ToString();
                lsCipherString.Add(str1 + str2);
                Console.WriteLine(str1 + str2);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            char[,] cMatrix = new char[6, 6]; // ma trận mã
            CreateMatrix(cMatrix); //tạo ma trận mã
            Decrypt(cMatrix);
        }

        private int ViTri( char cPlainChar, char[,] cMatrix, ref int[] iLoc) 
        { // hàm tìm vị trí của ký tự trong ma trận
            
            for(int iHang = 0; iHang < iChoseMatrix; iHang++)
            {
                for(int iCot = 0; iCot < iChoseMatrix; iCot++)
                {
                    if(cPlainChar == cMatrix[iHang, iCot])
                    {
                        iLoc[0] = iHang;
                        iLoc[1] = iCot;
                        return 0;
                    }
                }
            }
            return 1;
        }

        private void Decrypt(char[,] cMatrix)
        {
            List<string> lsPlainString = new List<string>(); // list plaintext đã tách
            List<string> lsCipherString = new List<string>(); // list plaintext đã tách
            XuLyChuoi(strPlainText, ref lsPlainString); //tách chuỗi Plaintext
            int[] iLoc1 = new int[2]; //lưu tọa độ của ký tự trong ma trận iLoc[0]: vị trí hàng, iLoc[1]: vị trí cột
            int[] iLoc2 = new int[2];
            foreach (string str in lsCipherString)
            {
                string str1 = str.Substring(0, 1);
                ViTri(Convert.ToChar(str1), cMatrix, ref iLoc1);
                string str2 = str.Substring(1, 1);
                ViTri(Convert.ToChar(str2), cMatrix, ref iLoc2);
                if (iLoc1[0] == iLoc2[0]) // Nếu plainchar cùng 1 hàng
                {
                    iLoc1[1] = (iLoc1[1] - 1) % iChoseMatrix;
                    iLoc2[1] = (iLoc2[1] - 1) % iChoseMatrix;
                }
                else
                {
                    if (iLoc1[1] == iLoc2[1]) //Nếu PlainChar cùng 1 cột
                    {
                        iLoc1[0] = (iLoc1[0] - 1) % iChoseMatrix;
                        iLoc2[0] = (iLoc2[0] - 1) % iChoseMatrix;
                    }
                    else
                    {
                        int iTemp = iLoc1[1];
                        iLoc1[1] = iLoc2[1];
                        iLoc2[1] = iTemp;
                    }
                }
                
                str1 = cMatrix[iLoc1[0], iLoc1[1]].ToString();
                str2 = cMatrix[iLoc2[0], iLoc2[1]].ToString();
              //  lsPlainString.Add(str1 + str2);
                Console.WriteLine(str1 + str2);
            }
        }
    }
}
