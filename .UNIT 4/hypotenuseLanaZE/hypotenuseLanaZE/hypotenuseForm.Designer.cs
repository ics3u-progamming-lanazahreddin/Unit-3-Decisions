namespace hypotenuseLanaZE
{
    partial class frmhypotenuse
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
            this.lblOpp = new System.Windows.Forms.Label();
            this.lblAdj = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtOpposite = new System.Windows.Forms.TextBox();
            this.txtAdjacent = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOpp
            // 
            this.lblOpp.AutoSize = true;
            this.lblOpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpp.Location = new System.Drawing.Point(138, 85);
            this.lblOpp.Name = "lblOpp";
            this.lblOpp.Size = new System.Drawing.Size(220, 29);
            this.lblOpp.TabIndex = 3;
            this.lblOpp.Text = "Enter the Opposite:";
            // 
            // lblAdj
            // 
            this.lblAdj.AutoSize = true;
            this.lblAdj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdj.Location = new System.Drawing.Point(138, 165);
            this.lblAdj.Name = "lblAdj";
            this.lblAdj.Size = new System.Drawing.Size(214, 29);
            this.lblAdj.TabIndex = 4;
            this.lblAdj.Text = "Enter the Adjacent:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(138, 368);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(316, 29);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "Your hypotenuse is equal to:";
            // 
            // txtOpposite
            // 
            this.txtOpposite.Location = new System.Drawing.Point(436, 92);
            this.txtOpposite.Name = "txtOpposite";
            this.txtOpposite.Size = new System.Drawing.Size(100, 22);
            this.txtOpposite.TabIndex = 6;
            // 
            // txtAdjacent
            // 
            this.txtAdjacent.Location = new System.Drawing.Point(436, 172);
            this.txtAdjacent.Name = "txtAdjacent";
            this.txtAdjacent.Size = new System.Drawing.Size(100, 22);
            this.txtAdjacent.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(251, 244);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(235, 92);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // frmhypotenuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAdjacent);
            this.Controls.Add(this.txtOpposite);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblAdj);
            this.Controls.Add(this.lblOpp);
            this.Name = "frmhypotenuse";
            this.Text = "hypotenuse by Lana ZE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpp;
        private System.Windows.Forms.Label lblAdj;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtOpposite;
        private System.Windows.Forms.TextBox txtAdjacent;
        private System.Windows.Forms.Button btnCalculate;
    }
}

