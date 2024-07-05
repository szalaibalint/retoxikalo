namespace retoxikalo
{
    partial class mainForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KilepesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItallapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GaleriaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SugoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NevjegyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.SaveMenuItem,
            this.KilepesMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Image = global::retoxikalo.Properties.Resources.folder_icon;
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openMenuItem.Text = "Megnyitás";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveMenuItem.Text = "Mentés";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // KilepesMenuItem
            // 
            this.KilepesMenuItem.Name = "KilepesMenuItem";
            this.KilepesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.KilepesMenuItem.Text = "Kilépés";
            this.KilepesMenuItem.Click += new System.EventHandler(this.KilepesMenuItem_Click);
            // 
            // ItallapMenuItem
            // 
            this.ItallapMenuItem.Name = "ItallapMenuItem";
            this.ItallapMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ItallapMenuItem.Text = "Itallap";
            this.ItallapMenuItem.Click += new System.EventHandler(this.ItallapMenuItem_Click);
            // 
            // GaleriaMenuItem
            // 
            this.GaleriaMenuItem.Name = "GaleriaMenuItem";
            this.GaleriaMenuItem.Size = new System.Drawing.Size(55, 20);
            this.GaleriaMenuItem.Text = "Galéria";
            this.GaleriaMenuItem.Click += new System.EventHandler(this.GaleriaMenuItem_Click);
            // 
            // SugoMenuItem
            // 
            this.SugoMenuItem.Name = "SugoMenuItem";
            this.SugoMenuItem.Size = new System.Drawing.Size(46, 20);
            this.SugoMenuItem.Text = "Súgó";
            this.SugoMenuItem.Click += new System.EventHandler(this.SugoMenuItem_Click);
            // 
            // NevjegyMenuItem
            // 
            this.NevjegyMenuItem.Name = "NevjegyMenuItem";
            this.NevjegyMenuItem.Size = new System.Drawing.Size(62, 20);
            this.NevjegyMenuItem.Text = "Névjegy";
            this.NevjegyMenuItem.Click += new System.EventHandler(this.NevjegyMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.ItallapMenuItem,
            this.GaleriaMenuItem,
            this.SugoMenuItem,
            this.NevjegyMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::retoxikalo.Properties.Resources.retoxikalo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nyertes kocsma";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItallapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GaleriaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SugoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NevjegyMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KilepesMenuItem;
    }
}

