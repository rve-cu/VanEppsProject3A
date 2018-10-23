namespace VanEppsProject3A
{
    partial class frmRateCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRateCalculator));
            this.txtCreditScore = new System.Windows.Forms.TextBox();
            this.btnCalculateRate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExitRate = new System.Windows.Forms.Button();
            this.btnCopyRate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCreditScore
            // 
            this.txtCreditScore.BackColor = System.Drawing.Color.GhostWhite;
            this.txtCreditScore.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCreditScore.Location = new System.Drawing.Point(214, 72);
            this.txtCreditScore.Name = "txtCreditScore";
            this.txtCreditScore.Size = new System.Drawing.Size(75, 27);
            this.txtCreditScore.TabIndex = 1;
            this.txtCreditScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculateRate
            // 
            this.btnCalculateRate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCalculateRate.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCalculateRate.Location = new System.Drawing.Point(90, 158);
            this.btnCalculateRate.Name = "btnCalculateRate";
            this.btnCalculateRate.Size = new System.Drawing.Size(149, 32);
            this.btnCalculateRate.TabIndex = 2;
            this.btnCalculateRate.Text = "&Calculate Rate";
            this.btnCalculateRate.UseVisualStyleBackColor = false;
            this.btnCalculateRate.Click += new System.EventHandler(this.btnCalculateRate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(60, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 46);
            this.label6.TabIndex = 10;
            this.label6.Text = "Calculate Interest Rate\r\nBased on Credit Score";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Credit &Score:";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtInterestRate.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtInterestRate.Location = new System.Drawing.Point(214, 112);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.ReadOnly = true;
            this.txtInterestRate.Size = new System.Drawing.Size(75, 27);
            this.txtInterestRate.TabIndex = 14;
            this.txtInterestRate.TabStop = false;
            this.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(40, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Interest Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(289, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "%";
            // 
            // btnExitRate
            // 
            this.btnExitRate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnExitRate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitRate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitRate.ForeColor = System.Drawing.Color.Maroon;
            this.btnExitRate.Location = new System.Drawing.Point(214, 282);
            this.btnExitRate.Name = "btnExitRate";
            this.btnExitRate.Size = new System.Drawing.Size(104, 30);
            this.btnExitRate.TabIndex = 4;
            this.btnExitRate.Text = "Close Window";
            this.btnExitRate.UseVisualStyleBackColor = false;
            this.btnExitRate.Click += new System.EventHandler(this.btnExitRate_Click);
            // 
            // btnCopyRate
            // 
            this.btnCopyRate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCopyRate.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCopyRate.Location = new System.Drawing.Point(47, 200);
            this.btnCopyRate.Name = "btnCopyRate";
            this.btnCopyRate.Size = new System.Drawing.Size(235, 55);
            this.btnCopyRate.TabIndex = 31;
            this.btnCopyRate.Text = "Copy Rate to Fixed-Rate Mortgage Calculator";
            this.btnCopyRate.UseVisualStyleBackColor = false;
            this.btnCopyRate.Click += new System.EventHandler(this.btnCopyRate_Click);
            // 
            // frmRateCalculator
            // 
            this.AcceptButton = this.btnCalculateRate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExitRate;
            this.ClientSize = new System.Drawing.Size(328, 324);
            this.Controls.Add(this.btnCopyRate);
            this.Controls.Add(this.btnExitRate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCreditScore);
            this.Controls.Add(this.btnCalculateRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "frmRateCalculator";
            this.Text = "Interest Rate Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCreditScore;
        private System.Windows.Forms.Button btnCalculateRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExitRate;
        private System.Windows.Forms.Button btnCopyRate;
    }
}