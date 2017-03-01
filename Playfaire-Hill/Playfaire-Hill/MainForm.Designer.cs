namespace Playfaire
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptDecryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symmatricclassicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playfairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.encryptDecryptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(388, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // encryptDecryptToolStripMenuItem
            // 
            this.encryptDecryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.symmatricclassicToolStripMenuItem});
            this.encryptDecryptToolStripMenuItem.Name = "encryptDecryptToolStripMenuItem";
            this.encryptDecryptToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.encryptDecryptToolStripMenuItem.Text = "Encrypt/Decrypt";
            // 
            // symmatricclassicToolStripMenuItem
            // 
            this.symmatricclassicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playfairToolStripMenuItem,
            this.hillToolStripMenuItem});
            this.symmatricclassicToolStripMenuItem.Name = "symmatricclassicToolStripMenuItem";
            this.symmatricclassicToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.symmatricclassicToolStripMenuItem.Text = "Symmatric(classic)";
            // 
            // playfairToolStripMenuItem
            // 
            this.playfairToolStripMenuItem.Name = "playfairToolStripMenuItem";
            this.playfairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playfairToolStripMenuItem.Text = "Playfair";
            // 
            // hillToolStripMenuItem
            // 
            this.hillToolStripMenuItem.Name = "hillToolStripMenuItem";
            this.hillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hillToolStripMenuItem.Text = "Hill";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptDecryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem symmatricclassicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playfairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hillToolStripMenuItem;
    }
}