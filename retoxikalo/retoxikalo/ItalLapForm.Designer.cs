namespace retoxikalo
{
    partial class ItalLapForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlValasztek = new System.Windows.Forms.Panel();
            this.btnRendel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.szamlatKerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fizetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlValasztek
            // 
            this.pnlValasztek.AutoScroll = true;
            this.pnlValasztek.Location = new System.Drawing.Point(67, 57);
            this.pnlValasztek.Name = "pnlValasztek";
            this.pnlValasztek.Size = new System.Drawing.Size(365, 321);
            this.pnlValasztek.TabIndex = 0;
            // 
            // btnRendel
            // 
            this.btnRendel.ContextMenuStrip = this.contextMenuStrip1;
            this.btnRendel.Location = new System.Drawing.Point(213, 403);
            this.btnRendel.Name = "btnRendel";
            this.btnRendel.Size = new System.Drawing.Size(75, 23);
            this.btnRendel.TabIndex = 1;
            this.btnRendel.Text = "Rendel";
            this.btnRendel.UseVisualStyleBackColor = true;
            this.btnRendel.Click += new System.EventHandler(this.btnRendel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szamlatKerMenuItem,
            this.fizetMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // szamlatKerMenuItem
            // 
            this.szamlatKerMenuItem.Name = "szamlatKerMenuItem";
            this.szamlatKerMenuItem.Size = new System.Drawing.Size(134, 22);
            this.szamlatKerMenuItem.Text = "Számlát kér";
            this.szamlatKerMenuItem.Click += new System.EventHandler(this.szamlatKerMenuItem_Click);
            // 
            // fizetMenuItem
            // 
            this.fizetMenuItem.Name = "fizetMenuItem";
            this.fizetMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fizetMenuItem.Text = "Fizet";
            this.fizetMenuItem.Click += new System.EventHandler(this.fizetMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(208, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Árlista";
            // 
            // ItalLapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRendel);
            this.Controls.Add(this.pnlValasztek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ItalLapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItalLapForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlValasztek;
        private System.Windows.Forms.Button btnRendel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem szamlatKerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fizetMenuItem;
    }
}