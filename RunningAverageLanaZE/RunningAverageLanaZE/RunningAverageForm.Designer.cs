namespace RunningAverageLanaZE
{
    partial class frmRunningAverage
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
            this.lblCalculations = new System.Windows.Forms.Label();
            this.nudNumbers = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(28, 30);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(731, 29);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "Enter a number between 0 and 100, enter -1 to reset the calculation.";
            // 
            // lblCalculations
            // 
            this.lblCalculations.AutoSize = true;
            this.lblCalculations.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculations.Location = new System.Drawing.Point(24, 331);
            this.lblCalculations.Name = "lblCalculations";
            this.lblCalculations.Size = new System.Drawing.Size(71, 52);
            this.lblCalculations.TabIndex = 1;
            this.lblCalculations.Text = "??";
            // 
            // nudNumbers
            // 
            this.nudNumbers.Location = new System.Drawing.Point(301, 83);
            this.nudNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudNumbers.Name = "nudNumbers";
            this.nudNumbers.Size = new System.Drawing.Size(156, 22);
            this.nudNumbers.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(276, 187);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(230, 59);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudNumbers);
            this.Controls.Add(this.lblCalculations);
            this.Controls.Add(this.lblQ);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average by Lana ZE";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblCalculations;
        private System.Windows.Forms.NumericUpDown nudNumbers;
        private System.Windows.Forms.Button btnCalculate;
    }
}

