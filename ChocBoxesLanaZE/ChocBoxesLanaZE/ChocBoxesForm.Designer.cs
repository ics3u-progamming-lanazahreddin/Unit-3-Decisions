namespace ChocBoxesLanaZE
{
    partial class frmChocBoxes
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
            this.lblQ = new System.Windows.Forms.Label();
            this.txtNumberSold = new System.Windows.Forms.TextBox();
            this.btnPrize = new System.Windows.Forms.Button();
            this.lblPrize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(12, 122);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(422, 29);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "Enter the amount of boxes you\'ve sold:";
            // 
            // txtNumberSold
            // 
            this.txtNumberSold.Location = new System.Drawing.Point(467, 129);
            this.txtNumberSold.Name = "txtNumberSold";
            this.txtNumberSold.Size = new System.Drawing.Size(100, 22);
            this.txtNumberSold.TabIndex = 1;
            // 
            // btnPrize
            // 
            this.btnPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrize.Location = new System.Drawing.Point(694, 76);
            this.btnPrize.Name = "btnPrize";
            this.btnPrize.Size = new System.Drawing.Size(230, 116);
            this.btnPrize.TabIndex = 2;
            this.btnPrize.Text = "Get My PRIZE!";
            this.btnPrize.UseVisualStyleBackColor = true;
            this.btnPrize.Click += new System.EventHandler(this.BtnPrize_Click);
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.Location = new System.Drawing.Point(216, 348);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(47, 32);
            this.lblPrize.TabIndex = 3;
            this.lblPrize.Text = "??";
            // 
            // frmChocBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.btnPrize);
            this.Controls.Add(this.txtNumberSold);
            this.Controls.Add(this.lblQ);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChocBoxes";
            this.Text = "Chocolate Boxes By Lana ZE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.TextBox txtNumberSold;
        private System.Windows.Forms.Button btnPrize;
        private System.Windows.Forms.Label lblPrize;
    }
}

