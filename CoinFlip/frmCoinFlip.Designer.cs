namespace CoinFlip
{
    partial class frmCoinFlip
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
            this.btnFlipCoin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbHeadsOrTails = new System.Windows.Forms.PictureBox();
            this.lblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadsOrTails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFlipCoin
            // 
            this.btnFlipCoin.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlipCoin.Location = new System.Drawing.Point(64, 361);
            this.btnFlipCoin.Name = "btnFlipCoin";
            this.btnFlipCoin.Size = new System.Drawing.Size(175, 59);
            this.btnFlipCoin.TabIndex = 0;
            this.btnFlipCoin.Text = "Flip Coin";
            this.btnFlipCoin.UseVisualStyleBackColor = true;
            this.btnFlipCoin.Click += new System.EventHandler(this.btnFlipCoin_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(308, 361);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 59);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(539, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 59);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbHeadsOrTails
            // 
            this.pbHeadsOrTails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pbHeadsOrTails.Location = new System.Drawing.Point(308, 26);
            this.pbHeadsOrTails.Name = "pbHeadsOrTails";
            this.pbHeadsOrTails.Size = new System.Drawing.Size(249, 220);
            this.pbHeadsOrTails.TabIndex = 3;
            this.pbHeadsOrTails.TabStop = false;
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblResults.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(203, 275);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(382, 53);
            this.lblResults.TabIndex = 3;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCoinFlip
            // 
            this.AcceptButton = this.btnFlipCoin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.pbHeadsOrTails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFlipCoin);
            this.Name = "frmCoinFlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 10 - Coin Flip WIth PictureBox Control";
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadsOrTails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFlipCoin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbHeadsOrTails;
        private System.Windows.Forms.Label lblResults;
    }
}

