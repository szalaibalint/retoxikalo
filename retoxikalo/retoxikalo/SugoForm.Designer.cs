namespace retoxikalo
{
    partial class SugoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SugoForm));
            this.rchTxtSugo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchTxtSugo
            // 
            this.rchTxtSugo.Location = new System.Drawing.Point(21, 27);
            this.rchTxtSugo.Name = "rchTxtSugo";
            this.rchTxtSugo.ReadOnly = true;
            this.rchTxtSugo.Size = new System.Drawing.Size(243, 205);
            this.rchTxtSugo.TabIndex = 1;
            this.rchTxtSugo.Text = resources.GetString("rchTxtSugo.Text");
            // 
            // SugoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 258);
            this.Controls.Add(this.rchTxtSugo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SugoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Súgó";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtSugo;
    }
}