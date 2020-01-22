namespace StringEqualityLanaZE
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
            System.Windows.Forms.Button btnCheck;
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.txtString1 = new System.Windows.Forms.TextBox();
            btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(201, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(360, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Insert two strings to check if they are equal!";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(298, 38);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(169, 16);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "( Case does not matter)";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(94, 128);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(75, 24);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "string 1:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(94, 214);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(75, 24);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "string 2:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(93, 371);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(36, 25);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "??";
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(270, 214);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(100, 20);
            this.txtString2.TabIndex = 5;
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(270, 133);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(100, 20);
            this.txtString1.TabIndex = 6;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCheck.ForeColor = System.Drawing.Color.Coral;
            btnCheck.Location = new System.Drawing.Point(437, 295);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new System.Drawing.Size(137, 53);
            btnCheck.TabIndex = 7;
            btnCheck.TabStop = false;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnCheck);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.TextBox txtString1;
    }
}

