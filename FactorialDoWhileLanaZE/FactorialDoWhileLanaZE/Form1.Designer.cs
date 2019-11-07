namespace FactorialDoWhileLanaZE
{
    partial class Form1
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
            this.lblFactorialAnswer = new System.Windows.Forms.Label();
            this.txtFactorialNumber = new System.Windows.Forms.TextBox();
            this.btnFactorialize = new System.Windows.Forms.Button();
            this.lstFactorialMultipliers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(3, 38);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(562, 36);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "Enter the number you want to factorialize:";
            // 
            // lblFactorialAnswer
            // 
            this.lblFactorialAnswer.AutoSize = true;
            this.lblFactorialAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactorialAnswer.Location = new System.Drawing.Point(553, 262);
            this.lblFactorialAnswer.Name = "lblFactorialAnswer";
            this.lblFactorialAnswer.Size = new System.Drawing.Size(47, 32);
            this.lblFactorialAnswer.TabIndex = 1;
            this.lblFactorialAnswer.Text = "??";
            // 
            // txtFactorialNumber
            // 
            this.txtFactorialNumber.Location = new System.Drawing.Point(615, 52);
            this.txtFactorialNumber.Name = "txtFactorialNumber";
            this.txtFactorialNumber.Size = new System.Drawing.Size(100, 22);
            this.txtFactorialNumber.TabIndex = 2;
            // 
            // btnFactorialize
            // 
            this.btnFactorialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorialize.Location = new System.Drawing.Point(309, 101);
            this.btnFactorialize.Name = "btnFactorialize";
            this.btnFactorialize.Size = new System.Drawing.Size(197, 63);
            this.btnFactorialize.TabIndex = 3;
            this.btnFactorialize.Text = "Factorialize!";
            this.btnFactorialize.UseVisualStyleBackColor = true;
            this.btnFactorialize.Click += new System.EventHandler(this.BtnFactorialize_Click);
            // 
            // lstFactorialMultipliers
            // 
            this.lstFactorialMultipliers.FormattingEnabled = true;
            this.lstFactorialMultipliers.ItemHeight = 16;
            this.lstFactorialMultipliers.Location = new System.Drawing.Point(79, 205);
            this.lstFactorialMultipliers.Name = "lstFactorialMultipliers";
            this.lstFactorialMultipliers.Size = new System.Drawing.Size(286, 196);
            this.lstFactorialMultipliers.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFactorialMultipliers);
            this.Controls.Add(this.btnFactorialize);
            this.Controls.Add(this.txtFactorialNumber);
            this.Controls.Add(this.lblFactorialAnswer);
            this.Controls.Add(this.lblQ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblFactorialAnswer;
        private System.Windows.Forms.TextBox txtFactorialNumber;
        private System.Windows.Forms.Button btnFactorialize;
        private System.Windows.Forms.ListBox lstFactorialMultipliers;
    }
}

