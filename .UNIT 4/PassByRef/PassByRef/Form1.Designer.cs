namespace PassByRef
{
    partial class frmPassByRef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPassByRef));
            this.picRandom = new System.Windows.Forms.PictureBox();
            this.lblQ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // picRandom
            // 
            this.picRandom.Image = ((System.Drawing.Image)(resources.GetObject("picRandom.Image")));
            this.picRandom.Location = new System.Drawing.Point(261, 58);
            this.picRandom.Name = "picRandom";
            this.picRandom.Size = new System.Drawing.Size(268, 380);
            this.picRandom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRandom.TabIndex = 0;
            this.picRandom.TabStop = false;
            this.picRandom.Click += new System.EventHandler(this.PicRandom_Click);
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(159, 9);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(451, 29);
            this.lblQ.TabIndex = 1;
            this.lblQ.Text = "Click on the image to change it randomly ";
            this.lblQ.Click += new System.EventHandler(this.LblQ_Click);
            // 
            // frmPassByRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.picRandom);
            this.Name = "frmPassByRef";
            this.Text = "Pass By Reference By Lana ZE";
            ((System.ComponentModel.ISupportInitialize)(this.picRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRandom;
        private System.Windows.Forms.Label lblQ;
    }
}

