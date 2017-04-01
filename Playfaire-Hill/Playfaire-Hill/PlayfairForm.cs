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

namespace Playfaire
{
    public partial class PlayfairForm : Form
    {
        string strPlainText;
        string strKey = "";
        List<string> lsPlainString, lsCipherString;
        char[,] cMatrix; // ma trận mã

        public PlayfairForm()
        {
            InitializeComponent();
        }

        //hàm lấy plaintext từ MainForm
        public void GetDataFromMainForm (string strData)
        {
             strPlainText = strData.ToUpper();
        }

        //hàm gửi plaintext đã xử lý cho MainForm
        public List<string> SendPlainTextToMainForm ()
        {
            return lsPlainString;
        }

        //hàm gửi ciphertext đã xử lý cho MainForm
        public List<string> SendCipherTextToMainForm()
        {
            return lsCipherString;
        }

        private void PlayfairForm_Load(object sender, EventArgs e)
        {
            btnMatrix55.Checked = true;           
            //btnMatrix55_CheckedChanged(sender, e);
            //btnMatrix66_CheckedChanged(sender, e);
        }

        int iChoseMatrix = 0; // == 5 là matrix 5x5; == 6 là matrix 6x6

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

        // Hàm tạo ma trận mã, với key nhập vào ban đầu
        private void CreateMatrix()
        {
            cMatrix = new char[6, 6]; // ma trận mã
            int iNumchar = 0;// số thứ của tự ký tự trong chuỗi
            int iChar = 65; //A
            flptxt.Controls.Clear();
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

                    flptxt.Controls.Add(CreateTextBox(cMatrix[iHang, iCot]));
                    Console.WriteLine(cMatrix[iHang, iCot]);
                }
            }
        }

        // Hàm tạo các textbox để hiển thị ma trận
        private TextBox CreateTextBox (char cASCII )
        {
            TextBox txtMatrix = new TextBox();
            txtMatrix.Name = "txtMatrix" + cASCII;
            //txtMatrix.Multiline = true;
            int width = 0, height = 0;
            if (iChoseMatrix == 5)
            {
                txtMatrix.Size = new Size(40, 40);
            }else
            {
                txtMatrix.Size = new Size(35,35);
            }
            txtMatrix.Font = new Font("Microsoft Sans Serif", 14);
            txtMatrix.TextAlign = HorizontalAlignment.Center;
            txtMatrix.Enabled = false;
            txtMatrix.Text = cASCII.ToString();
            //grbMatrixKey.Controls.Add(txtMatrix);
            return txtMatrix;
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

        //hàm hiện thực mã hóa
        private void Encrypt(char [,] cMatrix)
        {
            lsPlainString = new List<string>(); // list plaintext đã tách
            lsCipherString = new List<string>(); // list ciphertext
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

        // hàm tìm vị trí của ký tự trong ma trận
        private int ViTri( char cPlainChar, char[,] cMatrix, ref int[] iLoc) 
        { 
            
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

        //hàm hiện thực giải mã
        private void Decrypt(char[,] cMatrix)
        {
            lsPlainString = new List<string>(); // list plaintext đã tách
            lsCipherString = new List<string>(); // list ciphertext 
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

        private void btnMatrix66_CheckedChanged(object sender, EventArgs e)
        {
            iChoseMatrix = 6;
            btnEncrypt.Enabled = true;
            btnDecrypt.Enabled = true;
            CreateMatrix();
        }

        private void btnMatrix55_CheckedChanged_1(object sender, EventArgs e)
        {
            iChoseMatrix = 5;
            btnEncrypt.Enabled = true;
            btnDecrypt.Enabled = true;
            CreateMatrix();
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            strKey = txtKey.Text.ToUpper();
            CreateMatrix();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Encrypt(cMatrix);
            this.Close();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Decrypt(cMatrix);
            this.Close();
        }

        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra ký tự nhập vào có phải là số hay không
            //do ma trận mã 5x5 không mã hóa được ký tự số
            if (Char.IsDigit(e.KeyChar) && btnMatrix55.Checked)
                e.Handled = true;
        }
    }
}
