namespace retoxikalo
{
    partial class GaleriaForm
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
            this.btnJobb = new System.Windows.Forms.Button();
            this.btnBal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJobb
            // 
            this.btnJobb.BackColor = System.Drawing.Color.Transparent;
            this.btnJobb.BackgroundImage = global::retoxikalo.Properties.Resources.right;
            this.btnJobb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJobb.FlatAppearance.BorderSize = 0;
            this.btnJobb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobb.Location = new System.Drawing.Point(359, 419);
            this.btnJobb.Name = "btnJobb";
            this.btnJobb.Size = new System.Drawing.Size(45, 30);
            this.btnJobb.TabIndex = 2;
            this.btnJobb.UseVisualStyleBackColor = false;
            this.btnJobb.Click += new System.EventHandler(this.btnJobb_Click);
            // 
            // btnBal
            // 
            this.btnBal.BackColor = System.Drawing.Color.Transparent;
            this.btnBal.BackgroundImage = global::retoxikalo.Properties.Resources.left;
            this.btnBal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBal.FlatAppearance.BorderSize = 0;
            this.btnBal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBal.Location = new System.Drawing.Point(261, 419);
            this.btnBal.Name = "btnBal";
            this.btnBal.Size = new System.Drawing.Size(45, 30);
            this.btnBal.TabIndex = 1;
            this.btnBal.UseVisualStyleBackColor = false;
            this.btnBal.Click += new System.EventHandler(this.btnBal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 383);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GaleriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 477);
            this.Controls.Add(this.btnJobb);
            this.Controls.Add(this.btnBal);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GaleriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GaleriaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBal;
        private System.Windows.Forms.Button btnJobb;
    }
}