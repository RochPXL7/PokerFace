namespace PokerFace {
    partial class Custom {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtBet = new System.Windows.Forms.TextBox();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(12, 26);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(127, 22);
            this.txtBet.TabIndex = 0;
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Location = new System.Drawing.Point(12, 3);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(29, 17);
            this.lblBet.TabIndex = 1;
            this.lblBet.Text = "Bet";
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(12, 55);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(123, 17);
            this.lblInvalid.TabIndex = 2;
            this.lblInvalid.Text = "Invalid bet amount";
            this.lblInvalid.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(145, 25);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 24);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(296, 77);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.txtBet);
            this.Name = "Custom";
            this.Text = "Custom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.Button btnApply;
    }
}