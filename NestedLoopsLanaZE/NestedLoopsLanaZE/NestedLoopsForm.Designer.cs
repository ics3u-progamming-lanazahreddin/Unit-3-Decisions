namespace NestedLoopsLanaZE
{
    partial class frmNestedLoops
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
            this.lstUnicode = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUnicode
            // 
            this.lstUnicode.FormattingEnabled = true;
            this.lstUnicode.ItemHeight = 16;
            this.lstUnicode.Location = new System.Drawing.Point(413, 22);
            this.lstUnicode.Name = "lstUnicode";
            this.lstUnicode.Size = new System.Drawing.Size(330, 404);
            this.lstUnicode.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(60, 164);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(229, 76);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List!";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // frmNestedLoops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lstUnicode);
            this.Name = "frmNestedLoops";
            this.Text = "Nested Loops by Lana ZE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUnicode;
        private System.Windows.Forms.Button btnList;
    }
}

