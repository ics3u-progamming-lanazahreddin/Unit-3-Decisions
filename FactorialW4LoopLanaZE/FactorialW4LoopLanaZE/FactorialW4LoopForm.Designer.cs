namespace FactorialW4LoopLanaZE
{
    partial class frmFactorialWLoop
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Vineta BT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(12, 86);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(417, 39);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter the number";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(477, 99);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(296, 219);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(181, 131);
            this.txtAnswer.TabIndex = 2;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(85, 372);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(36, 25);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "??";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Location = new System.Drawing.Point(296, 165);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(181, 32);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // frmFactorialWLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmFactorialWLoop";
            this.Text = "Factorial with for loop by Lana ZE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnStart;
    }
}

