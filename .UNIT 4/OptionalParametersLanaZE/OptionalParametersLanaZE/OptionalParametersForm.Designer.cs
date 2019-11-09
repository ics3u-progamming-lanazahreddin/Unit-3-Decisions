namespace OptionalParametersLanaZE
{
    partial class frmOptionalParameters
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
            this.txtApartmentNum = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblEnterInfo = new System.Windows.Forms.Label();
            this.lblExitInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApartmentNum
            // 
            this.txtApartmentNum.Location = new System.Drawing.Point(59, 72);
            this.txtApartmentNum.Name = "txtApartmentNum";
            this.txtApartmentNum.Size = new System.Drawing.Size(266, 22);
            this.txtApartmentNum.TabIndex = 0;
            this.txtApartmentNum.Text = "Appartment/Unit (optional)";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(59, 201);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(266, 22);
            this.txtProvince.TabIndex = 1;
            this.txtProvince.Text = "Province";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(59, 157);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(266, 22);
            this.txtCity.TabIndex = 2;
            this.txtCity.Text = "City";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(59, 115);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(266, 22);
            this.txtStreet.TabIndex = 3;
            this.txtStreet.Text = "Street";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(59, 248);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(266, 22);
            this.txtPostalCode.TabIndex = 4;
            this.txtPostalCode.Text = "PostalCode";
            // 
            // lblEnterInfo
            // 
            this.lblEnterInfo.AutoSize = true;
            this.lblEnterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterInfo.Location = new System.Drawing.Point(56, 26);
            this.lblEnterInfo.Name = "lblEnterInfo";
            this.lblEnterInfo.Size = new System.Drawing.Size(64, 25);
            this.lblEnterInfo.TabIndex = 5;
            this.lblEnterInfo.Text = "label1";
            // 
            // lblExitInfo
            // 
            this.lblExitInfo.AutoSize = true;
            this.lblExitInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitInfo.Location = new System.Drawing.Point(12, 370);
            this.lblExitInfo.Name = "lblExitInfo";
            this.lblExitInfo.Size = new System.Drawing.Size(142, 25);
            this.lblExitInfo.TabIndex = 6;
            this.lblExitInfo.Text = "Your adress is:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(512, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmOptionalParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblExitInfo);
            this.Controls.Add(this.lblEnterInfo);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtApartmentNum);
            this.Name = "frmOptionalParameters";
            this.Text = "Optional Parameters by Lana ZE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApartmentNum;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblEnterInfo;
        private System.Windows.Forms.Label lblExitInfo;
        private System.Windows.Forms.Button button1;
    }
}

