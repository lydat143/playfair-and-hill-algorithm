namespace Playfaire
{
    partial class PlayfairForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbPlayfair = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbMatrixKey = new System.Windows.Forms.GroupBox();
            this.btnMatrix66 = new System.Windows.Forms.RadioButton();
            this.btnMatrix55 = new System.Windows.Forms.RadioButton();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.grbPlayfair.SuspendLayout();
            this.grbMatrixKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPlayfair
            // 
            this.grbPlayfair.Controls.Add(this.label1);
            this.grbPlayfair.Controls.Add(this.grbMatrixKey);
            this.grbPlayfair.Controls.Add(this.txtKey);
            this.grbPlayfair.Location = new System.Drawing.Point(13, 13);
            this.grbPlayfair.Name = "grbPlayfair";
            this.grbPlayfair.Size = new System.Drawing.Size(390, 325);
            this.grbPlayfair.TabIndex = 0;
            this.grbPlayfair.TabStop = false;
            this.grbPlayfair.Text = "Playfair Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key: ";
            // 
            // grbMatrixKey
            // 
            this.grbMatrixKey.Controls.Add(this.btnMatrix66);
            this.grbMatrixKey.Controls.Add(this.btnMatrix55);
            this.grbMatrixKey.Location = new System.Drawing.Point(7, 80);
            this.grbMatrixKey.Name = "grbMatrixKey";
            this.grbMatrixKey.Size = new System.Drawing.Size(377, 239);
            this.grbMatrixKey.TabIndex = 1;
            this.grbMatrixKey.TabStop = false;
            this.grbMatrixKey.Text = "Matrix Key";
            // 
            // btnMatrix66
            // 
            this.btnMatrix66.AutoSize = true;
            this.btnMatrix66.Location = new System.Drawing.Point(278, 62);
            this.btnMatrix66.Name = "btnMatrix66";
            this.btnMatrix66.Size = new System.Drawing.Size(72, 17);
            this.btnMatrix66.TabIndex = 1;
            this.btnMatrix66.TabStop = true;
            this.btnMatrix66.Text = "6x6 matrix";
            this.btnMatrix66.UseVisualStyleBackColor = true;
            // 
            // btnMatrix55
            // 
            this.btnMatrix55.AutoSize = true;
            this.btnMatrix55.Checked = true;
            this.btnMatrix55.Location = new System.Drawing.Point(278, 38);
            this.btnMatrix55.Name = "btnMatrix55";
            this.btnMatrix55.Size = new System.Drawing.Size(72, 17);
            this.btnMatrix55.TabIndex = 0;
            this.btnMatrix55.TabStop = true;
            this.btnMatrix55.Text = "5x5 matrix";
            this.btnMatrix55.UseVisualStyleBackColor = true;
            this.btnMatrix55.CheckedChanged += new System.EventHandler(this.btnMatrix55_CheckedChanged);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(26, 43);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(358, 20);
            this.txtKey.TabIndex = 0;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(56, 344);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(118, 33);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Encryt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(232, 344);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(118, 33);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // PlayfairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 389);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.grbPlayfair);
            this.Name = "PlayfairForm";
            this.Text = "Playfair";
            this.Load += new System.EventHandler(this.PlayfairForm_Load);
            this.grbPlayfair.ResumeLayout(false);
            this.grbPlayfair.PerformLayout();
            this.grbMatrixKey.ResumeLayout(false);
            this.grbMatrixKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPlayfair;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbMatrixKey;
        private System.Windows.Forms.RadioButton btnMatrix66;
        private System.Windows.Forms.RadioButton btnMatrix55;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

