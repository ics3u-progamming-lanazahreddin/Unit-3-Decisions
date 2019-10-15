﻿namespace GuessNumberLanaZE
{
    partial class frmGuessNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuessNumber));
            this.lblQ = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtNumGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.picWrong = new System.Windows.Forms.PictureBox();
            this.picRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(59, 104);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(487, 51);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "Guess a number from 1-10 :";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(59, 445);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(56, 51);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "??";
            // 
            // txtNumGuess
            // 
            this.txtNumGuess.Location = new System.Drawing.Point(632, 119);
            this.txtNumGuess.Name = "txtNumGuess";
            this.txtNumGuess.Size = new System.Drawing.Size(233, 22);
            this.txtNumGuess.TabIndex = 2;
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.Fuchsia;
            this.btnGuess.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(322, 224);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(386, 113);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            // 
            // picWrong
            // 
            this.picWrong.Image = ((System.Drawing.Image)(resources.GetObject("picWrong.Image")));
            this.picWrong.Location = new System.Drawing.Point(834, 378);
            this.picWrong.Name = "picWrong";
            this.picWrong.Size = new System.Drawing.Size(179, 148);
            this.picWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWrong.TabIndex = 5;
            this.picWrong.TabStop = false;
            // 
            // picRight
            // 
            this.picRight.Image = ((System.Drawing.Image)(resources.GetObject("picRight.Image")));
            this.picRight.Location = new System.Drawing.Point(728, 378);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(169, 148);
            this.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRight.TabIndex = 6;
            this.picRight.TabStop = false;
            // 
            // frmGuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.picWrong);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtNumGuess);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblQ);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGuessNumber";
            this.Text = "Guess the number by Lana ZE";
            this.Load += new System.EventHandler(this.FrmGuessNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtNumGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.PictureBox picWrong;
        private System.Windows.Forms.PictureBox picRight;
    }
}

