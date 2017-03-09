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
            this.mnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.nmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptDecryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symmatricclassicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPlayfair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHill = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNew,
            this.mnOpen,
            this.nmSave,
            this.mnSaveAs});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnNew
            // 
            this.mnNew.Name = "mnNew";
            this.mnNew.Size = new System.Drawing.Size(112, 22);
            this.mnNew.Text = "New";
            this.mnNew.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(112, 22);
            this.mnOpen.Text = "Open";
            // 
            // nmSave
            // 
            this.nmSave.Name = "nmSave";
            this.nmSave.Size = new System.Drawing.Size(112, 22);
            this.nmSave.Text = "Save";
            // 
            // mnSaveAs
            // 
            this.mnSaveAs.Name = "mnSaveAs";
            this.mnSaveAs.Size = new System.Drawing.Size(112, 22);
            this.mnSaveAs.Text = "Save as";
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
            this.mnPlayfair,
            this.mnHill});
            this.symmatricclassicToolStripMenuItem.Name = "symmatricclassicToolStripMenuItem";
            this.symmatricclassicToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.symmatricclassicToolStripMenuItem.Text = "Symmatric(classic)";
            // 
            // mnPlayfair
            // 
            this.mnPlayfair.Enabled = false;
            this.mnPlayfair.Name = "mnPlayfair";
            this.mnPlayfair.Size = new System.Drawing.Size(122, 22);
            this.mnPlayfair.Text = "Playfair...";
            this.mnPlayfair.Click += new System.EventHandler(this.playfairToolStripMenuItem_Click);
            // 
            // mnHill
            // 
            this.mnHill.Enabled = false;
            this.mnHill.Name = "mnHill";
            this.mnHill.Size = new System.Drawing.Size(122, 22);
            this.mnHill.Text = "Hill...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(714, 422);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
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
        private System.Windows.Forms.ToolStripMenuItem mnNew;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.ToolStripMenuItem nmSave;
        private System.Windows.Forms.ToolStripMenuItem mnSaveAs;
        private System.Windows.Forms.ToolStripMenuItem encryptDecryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem symmatricclassicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnPlayfair;
        private System.Windows.Forms.ToolStripMenuItem mnHill;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}