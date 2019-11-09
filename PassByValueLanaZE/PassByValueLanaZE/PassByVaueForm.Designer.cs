namespace PassByValueLanaZE
{
    partial class frmPassByVaue
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
            this.lblA = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(12, 36);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(742, 32);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "Enter the degree in Celsius to be converted to Fahrenheit.";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(14, 352);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(448, 20);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Here is your degree converted from Celsius to Fahrenheit: ";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(266, 101);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(252, 22);
            this.txtTemp.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(279, 195);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(224, 43);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // frmPassByVaue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblQ);
            this.Name = "frmPassByVaue";
            this.Text = "Pass By Value by Lana ZE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnConvert;
    }
}

