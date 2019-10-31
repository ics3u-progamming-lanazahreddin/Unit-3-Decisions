namespace RandomNumberLanaZE
{
    partial class frmRandomNumber
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
            this.lblAsk = new System.Windows.Forms.Label();
            this.btnGetNum = new System.Windows.Forms.Button();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAsk
            // 
            this.lblAsk.AutoSize = true;
            this.lblAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsk.ForeColor = System.Drawing.Color.Maroon;
            this.lblAsk.Location = new System.Drawing.Point(64, 57);
            this.lblAsk.Name = "lblAsk";
            this.lblAsk.Size = new System.Drawing.Size(667, 31);
            this.lblAsk.TabIndex = 1;
            this.lblAsk.Text = "Click the button to get a number between 1 and 10";
            // 
            // btnGetNum
            // 
            this.btnGetNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetNum.Location = new System.Drawing.Point(285, 183);
            this.btnGetNum.Name = "btnGetNum";
            this.btnGetNum.Size = new System.Drawing.Size(183, 57);
            this.btnGetNum.TabIndex = 2;
            this.btnGetNum.Text = "Get Number";
            this.btnGetNum.UseVisualStyleBackColor = false;
            this.btnGetNum.Click += new System.EventHandler(this.BtnGetNum_Click);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.ForeColor = System.Drawing.Color.Maroon;
            this.lblAnswer1.Location = new System.Drawing.Point(64, 350);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(208, 31);
            this.lblAnswer1.TabIndex = 3;
            this.lblAnswer1.Text = "The number is:";
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.ForeColor = System.Drawing.Color.Maroon;
            this.lblAnswer2.Location = new System.Drawing.Point(332, 350);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(0, 31);
            this.lblAnswer2.TabIndex = 4;
            // 
            // frmRandomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.btnGetNum);
            this.Controls.Add(this.lblAsk);
            this.Name = "frmRandomNumber";
            this.Text = "Random Number by Lana ZE";
            this.Load += new System.EventHandler(this.FrmRandomNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAsk;
        private System.Windows.Forms.Button btnGetNum;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
    }
}

