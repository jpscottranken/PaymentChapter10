namespace PaymentOptions
{
    partial class frmPaymentOptions
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
            this.gbPaytmentType = new System.Windows.Forms.GroupBox();
            this.radCreditCard = new System.Windows.Forms.RadioButton();
            this.radBillCustomer = new System.Windows.Forms.RadioButton();
            this.lblCreditCartdType = new System.Windows.Forms.Label();
            this.lstCreditCardType = new System.Windows.Forms.ListBox();
            this.lblCarNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.chkSetAsDefault = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbPaytmentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPaytmentType
            // 
            this.gbPaytmentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbPaytmentType.Controls.Add(this.radBillCustomer);
            this.gbPaytmentType.Controls.Add(this.radCreditCard);
            this.gbPaytmentType.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaytmentType.Location = new System.Drawing.Point(119, 31);
            this.gbPaytmentType.Name = "gbPaytmentType";
            this.gbPaytmentType.Size = new System.Drawing.Size(475, 83);
            this.gbPaytmentType.TabIndex = 0;
            this.gbPaytmentType.TabStop = false;
            this.gbPaytmentType.Text = "PaymentType";
            // 
            // radCreditCard
            // 
            this.radCreditCard.AutoSize = true;
            this.radCreditCard.Checked = true;
            this.radCreditCard.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCreditCard.Location = new System.Drawing.Point(30, 32);
            this.radCreditCard.Name = "radCreditCard";
            this.radCreditCard.Size = new System.Drawing.Size(178, 41);
            this.radCreditCard.TabIndex = 0;
            this.radCreditCard.TabStop = true;
            this.radCreditCard.Text = "Credit Card";
            this.radCreditCard.UseVisualStyleBackColor = true;
            // 
            // radBillCustomer
            // 
            this.radBillCustomer.AutoSize = true;
            this.radBillCustomer.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBillCustomer.Location = new System.Drawing.Point(251, 32);
            this.radBillCustomer.Name = "radBillCustomer";
            this.radBillCustomer.Size = new System.Drawing.Size(205, 41);
            this.radBillCustomer.TabIndex = 1;
            this.radBillCustomer.Text = "Bill Customer";
            this.radBillCustomer.UseVisualStyleBackColor = true;
            // 
            // lblCreditCartdType
            // 
            this.lblCreditCartdType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblCreditCartdType.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCartdType.Location = new System.Drawing.Point(37, 231);
            this.lblCreditCartdType.Name = "lblCreditCartdType";
            this.lblCreditCartdType.Size = new System.Drawing.Size(273, 59);
            this.lblCreditCartdType.TabIndex = 1;
            this.lblCreditCartdType.Text = "Credit Cartd Type";
            this.lblCreditCartdType.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstCreditCardType
            // 
            this.lstCreditCardType.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCreditCardType.FormattingEnabled = true;
            this.lstCreditCardType.ItemHeight = 37;
            this.lstCreditCardType.Location = new System.Drawing.Point(332, 161);
            this.lstCreditCardType.Name = "lstCreditCardType";
            this.lstCreditCardType.Size = new System.Drawing.Size(262, 189);
            this.lstCreditCardType.Sorted = true;
            this.lstCreditCardType.TabIndex = 2;
            // 
            // lblCarNumber
            // 
            this.lblCarNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblCarNumber.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarNumber.Location = new System.Drawing.Point(52, 381);
            this.lblCarNumber.Name = "lblCarNumber";
            this.lblCarNumber.Size = new System.Drawing.Size(258, 47);
            this.lblCarNumber.TabIndex = 3;
            this.lblCarNumber.Text = "Card Number:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(332, 384);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(258, 44);
            this.txtCardNumber.TabIndex = 4;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblExpirationDate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(41, 467);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(269, 47);
            this.lblExpirationDate.TabIndex = 5;
            this.lblExpirationDate.Text = "Expiration Date:";
            // 
            // cboMonth
            // 
            this.cboMonth.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "Select A Month",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cboMonth.Location = new System.Drawing.Point(332, 464);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(220, 45);
            this.cboMonth.TabIndex = 6;
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(570, 464);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(210, 45);
            this.cboYear.TabIndex = 7;
            // 
            // chkSetAsDefault
            // 
            this.chkSetAsDefault.AutoSize = true;
            this.chkSetAsDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chkSetAsDefault.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSetAsDefault.Location = new System.Drawing.Point(44, 540);
            this.chkSetAsDefault.Name = "chkSetAsDefault";
            this.chkSetAsDefault.Size = new System.Drawing.Size(394, 41);
            this.chkSetAsDefault.TabIndex = 8;
            this.chkSetAsDefault.Text = "Set as default billing method";
            this.chkSetAsDefault.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(187, 598);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 53);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(353, 598);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 53);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmPaymentOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(852, 698);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkSetAsDefault);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCarNumber);
            this.Controls.Add(this.lstCreditCardType);
            this.Controls.Add(this.lblCreditCartdType);
            this.Controls.Add(this.gbPaytmentType);
            this.Name = "frmPaymentOptions";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPaymentOptions_Load);
            this.gbPaytmentType.ResumeLayout(false);
            this.gbPaytmentType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPaytmentType;
        private System.Windows.Forms.RadioButton radBillCustomer;
        private System.Windows.Forms.RadioButton radCreditCard;
        private System.Windows.Forms.Label lblCreditCartdType;
        private System.Windows.Forms.ListBox lstCreditCardType;
        private System.Windows.Forms.Label lblCarNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.CheckBox chkSetAsDefault;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}

