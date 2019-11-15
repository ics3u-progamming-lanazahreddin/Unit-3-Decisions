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
            this.picRandom = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // picRandom
            // 
            this.picRandom.Image = global::PassByRef.Properties.Resources.QS;
            this.picRandom.Location = new System.Drawing.Point(348, 71);
            this.picRandom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picRandom.Name = "picRandom";
            this.picRandom.Size = new System.Drawing.Size(357, 468);
            this.picRandom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRandom.TabIndex = 0;
            this.picRandom.TabStop = false;
            this.picRandom.Click += new System.EventHandler(this.PicRandom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click on the image to change it randomly ";
            // 
            // frmPassByRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picRandom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPassByRef";
            this.Text = "Pass By Reference By Lana ZE";
            ((System.ComponentModel.ISupportInitialize)(this.picRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRandom;
        private System.Windows.Forms.Label label1;
    }
}

