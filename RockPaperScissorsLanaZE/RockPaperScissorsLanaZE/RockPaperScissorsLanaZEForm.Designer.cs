namespace RockPaperScissorsLanaZE
{
    partial class frmRockPaperScissors
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
            this.radScissorsC = new System.Windows.Forms.RadioButton();
            this.radPaperC = new System.Windows.Forms.RadioButton();
            this.radRockC = new System.Windows.Forms.RadioButton();
            this.grbComputerChoice = new System.Windows.Forms.GroupBox();
            this.grbUserChoice = new System.Windows.Forms.GroupBox();
            this.radRockU = new System.Windows.Forms.RadioButton();
            this.radPaperU = new System.Windows.Forms.RadioButton();
            this.radScissorsU = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grbComputerChoice.SuspendLayout();
            this.grbUserChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // radScissorsC
            // 
            this.radScissorsC.AutoSize = true;
            this.radScissorsC.Location = new System.Drawing.Point(35, 282);
            this.radScissorsC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radScissorsC.Name = "radScissorsC";
            this.radScissorsC.Size = new System.Drawing.Size(82, 21);
            this.radScissorsC.TabIndex = 3;
            this.radScissorsC.TabStop = true;
            this.radScissorsC.Text = "Scissors";
            this.radScissorsC.UseVisualStyleBackColor = true;
            // 
            // radPaperC
            // 
            this.radPaperC.AutoSize = true;
            this.radPaperC.Location = new System.Drawing.Point(35, 167);
            this.radPaperC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radPaperC.Name = "radPaperC";
            this.radPaperC.Size = new System.Drawing.Size(67, 21);
            this.radPaperC.TabIndex = 4;
            this.radPaperC.TabStop = true;
            this.radPaperC.Text = "Paper";
            this.radPaperC.UseVisualStyleBackColor = true;
            // 
            // radRockC
            // 
            this.radRockC.AutoSize = true;
            this.radRockC.Location = new System.Drawing.Point(35, 60);
            this.radRockC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radRockC.Name = "radRockC";
            this.radRockC.Size = new System.Drawing.Size(61, 21);
            this.radRockC.TabIndex = 5;
            this.radRockC.TabStop = true;
            this.radRockC.Text = "Rock";
            this.radRockC.UseVisualStyleBackColor = true;
            // 
            // grbComputerChoice
            // 
            this.grbComputerChoice.Controls.Add(this.radRockC);
            this.grbComputerChoice.Controls.Add(this.radPaperC);
            this.grbComputerChoice.Controls.Add(this.radScissorsC);
            this.grbComputerChoice.Location = new System.Drawing.Point(681, 69);
            this.grbComputerChoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbComputerChoice.Name = "grbComputerChoice";
            this.grbComputerChoice.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbComputerChoice.Size = new System.Drawing.Size(268, 366);
            this.grbComputerChoice.TabIndex = 6;
            this.grbComputerChoice.TabStop = false;
            this.grbComputerChoice.Text = "Computer\'s choice";
            // 
            // grbUserChoice
            // 
            this.grbUserChoice.Controls.Add(this.radRockU);
            this.grbUserChoice.Controls.Add(this.radPaperU);
            this.grbUserChoice.Controls.Add(this.radScissorsU);
            this.grbUserChoice.Location = new System.Drawing.Point(88, 69);
            this.grbUserChoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbUserChoice.Name = "grbUserChoice";
            this.grbUserChoice.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbUserChoice.Size = new System.Drawing.Size(268, 366);
            this.grbUserChoice.TabIndex = 7;
            this.grbUserChoice.TabStop = false;
            this.grbUserChoice.Text = "User\'s choice";
            // 
            // radRockU
            // 
            this.radRockU.AutoSize = true;
            this.radRockU.Location = new System.Drawing.Point(35, 60);
            this.radRockU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radRockU.Name = "radRockU";
            this.radRockU.Size = new System.Drawing.Size(61, 21);
            this.radRockU.TabIndex = 5;
            this.radRockU.TabStop = true;
            this.radRockU.Text = "Rock";
            this.radRockU.UseVisualStyleBackColor = true;
            // 
            // radPaperU
            // 
            this.radPaperU.AutoSize = true;
            this.radPaperU.Location = new System.Drawing.Point(35, 167);
            this.radPaperU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radPaperU.Name = "radPaperU";
            this.radPaperU.Size = new System.Drawing.Size(67, 21);
            this.radPaperU.TabIndex = 4;
            this.radPaperU.TabStop = true;
            this.radPaperU.Text = "Paper";
            this.radPaperU.UseVisualStyleBackColor = true;
            // 
            // radScissorsU
            // 
            this.radScissorsU.AutoSize = true;
            this.radScissorsU.Location = new System.Drawing.Point(35, 282);
            this.radScissorsU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radScissorsU.Name = "radScissorsU";
            this.radScissorsU.Size = new System.Drawing.Size(82, 21);
            this.radScissorsU.TabIndex = 3;
            this.radScissorsU.TabStop = true;
            this.radScissorsU.Text = "Scissors";
            this.radScissorsU.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(83, 503);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(139, 25);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "The winner is: ";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(410, 209);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(212, 96);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grbUserChoice);
            this.Controls.Add(this.grbComputerChoice);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock, Paper, Scissors by Lana ZE";
            this.Load += new System.EventHandler(this.FrmRockPaperScissors_Load);
            this.grbComputerChoice.ResumeLayout(false);
            this.grbComputerChoice.PerformLayout();
            this.grbUserChoice.ResumeLayout(false);
            this.grbUserChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radScissorsC;
        private System.Windows.Forms.RadioButton radPaperC;
        private System.Windows.Forms.RadioButton radRockC;
        private System.Windows.Forms.GroupBox grbComputerChoice;
        private System.Windows.Forms.GroupBox grbUserChoice;
        private System.Windows.Forms.RadioButton radRockU;
        private System.Windows.Forms.RadioButton radPaperU;
        private System.Windows.Forms.RadioButton radScissorsU;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnPlay;
    }
}

