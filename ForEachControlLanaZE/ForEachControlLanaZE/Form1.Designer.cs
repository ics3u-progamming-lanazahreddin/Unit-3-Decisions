namespace ForEachControlLanaZE
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
            this.lblHi = new System.Windows.Forms.Label();
            this.lblHAU = new System.Windows.Forms.Label();
            this.btnChangeC = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.Location = new System.Drawing.Point(43, 188);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(64, 36);
            this.lblHi.TabIndex = 1;
            this.lblHi.Text = "Hiiii";
            // 
            // lblHAU
            // 
            this.lblHAU.AutoSize = true;
            this.lblHAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHAU.Location = new System.Drawing.Point(370, 188);
            this.lblHAU.Name = "lblHAU";
            this.lblHAU.Size = new System.Drawing.Size(232, 36);
            this.lblHAU.TabIndex = 2;
            this.lblHAU.Text = "How are you??!!";
            // 
            // btnChangeC
            // 
            this.btnChangeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeC.Location = new System.Drawing.Point(138, 44);
            this.btnChangeC.Name = "btnChangeC";
            this.btnChangeC.Size = new System.Drawing.Size(481, 75);
            this.btnChangeC.TabIndex = 3;
            this.btnChangeC.Text = "Click on me to change colors!";
            this.btnChangeC.UseVisualStyleBackColor = true;
            this.btnChangeC.Click += new System.EventHandler(this.BtnChangeC_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(148, 258);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 180);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnChangeC);
            this.Controls.Add(this.lblHAU);
            this.Controls.Add(this.lblHi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Label lblHAU;
        private System.Windows.Forms.Button btnChangeC;
        private System.Windows.Forms.ListBox listBox1;
    }
}

