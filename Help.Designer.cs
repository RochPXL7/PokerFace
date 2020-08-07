namespace PokerFace {
    partial class Help {
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.lblPrevNum = new System.Windows.Forms.Label();
            this.lblNextNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(13, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(70, 20);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Header";
            // 
            // lblBody
            // 
            this.lblBody.Location = new System.Drawing.Point(17, 37);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(397, 322);
            this.lblBody.TabIndex = 1;
            this.lblBody.Text = "Body";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(376, 362);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(17, 362);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(38, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(368, 16);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(53, 17);
            this.lblPageNumber.TabIndex = 4;
            this.lblPageNumber.Text = "Page 1";
            // 
            // lblPrevNum
            // 
            this.lblPrevNum.Location = new System.Drawing.Point(61, 365);
            this.lblPrevNum.Name = "lblPrevNum";
            this.lblPrevNum.Size = new System.Drawing.Size(100, 23);
            this.lblPrevNum.TabIndex = 5;
            this.lblPrevNum.Text = "Page x";
            this.lblPrevNum.Visible = false;
            // 
            // lblNextNum
            // 
            this.lblNextNum.Location = new System.Drawing.Point(308, 365);
            this.lblNextNum.Name = "lblNextNum";
            this.lblNextNum.Size = new System.Drawing.Size(62, 18);
            this.lblNextNum.TabIndex = 6;
            this.lblNextNum.Text = "Page y";
            this.lblNextNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(430, 388);
            this.Controls.Add(this.lblNextNum);
            this.Controls.Add(this.lblPrevNum);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblHeader);
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Label lblPrevNum;
        private System.Windows.Forms.Label lblNextNum;
    }
}