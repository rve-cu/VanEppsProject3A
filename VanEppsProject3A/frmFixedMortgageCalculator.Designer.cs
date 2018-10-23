namespace VanEppsProject3A
{
    partial class frmFixedMortgageCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFixedMortgageCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExitMortgage = new System.Windows.Forms.Button();
            this.btnCalculateMortgage = new System.Windows.Forms.Button();
            this.txtTotalOwed = new System.Windows.Forms.TextBox();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.txtPrincipalAmount = new System.Windows.Forms.TextBox();
            this.txtTermLength = new System.Windows.Forms.TextBox();
            this.txtAnnualRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalInterest = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(57, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Principal (Amount Borrowed):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(57, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Term (Length of Mortgage in years):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(57, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interest &Rate (Annual Percentage):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(57, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monthly Payment:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(57, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Amount Owed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(83, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(422, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Simple fixed-rate mortgage calculator";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(171, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 54);
            this.label7.TabIndex = 6;
            this.label7.Text = "(For simplicity, this calculator ignores\r\ncompound interest, property taxes,\r\npro" +
    "perty and mortgage insurance.)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExitMortgage
            // 
            this.btnExitMortgage.BackColor = System.Drawing.Color.GhostWhite;
            this.btnExitMortgage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitMortgage.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMortgage.ForeColor = System.Drawing.Color.Maroon;
            this.btnExitMortgage.Location = new System.Drawing.Point(483, 366);
            this.btnExitMortgage.Name = "btnExitMortgage";
            this.btnExitMortgage.Size = new System.Drawing.Size(93, 30);
            this.btnExitMortgage.TabIndex = 7;
            this.btnExitMortgage.Text = "E&xit";
            this.btnExitMortgage.UseVisualStyleBackColor = false;
            this.btnExitMortgage.Click += new System.EventHandler(this.btnExitMortgage_Click);
            // 
            // btnCalculateMortgage
            // 
            this.btnCalculateMortgage.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCalculateMortgage.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateMortgage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCalculateMortgage.Location = new System.Drawing.Point(193, 365);
            this.btnCalculateMortgage.Name = "btnCalculateMortgage";
            this.btnCalculateMortgage.Size = new System.Drawing.Size(212, 32);
            this.btnCalculateMortgage.TabIndex = 6;
            this.btnCalculateMortgage.Text = "&Calculate";
            this.btnCalculateMortgage.UseVisualStyleBackColor = false;
            this.btnCalculateMortgage.Click += new System.EventHandler(this.btnCalculateMortgage_Click);
            // 
            // txtTotalOwed
            // 
            this.txtTotalOwed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalOwed.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOwed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTotalOwed.Location = new System.Drawing.Point(344, 276);
            this.txtTotalOwed.Name = "txtTotalOwed";
            this.txtTotalOwed.ReadOnly = true;
            this.txtTotalOwed.Size = new System.Drawing.Size(111, 27);
            this.txtTotalOwed.TabIndex = 22;
            this.txtTotalOwed.TabStop = false;
            this.txtTotalOwed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMonthlyPayment.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMonthlyPayment.Location = new System.Drawing.Point(344, 238);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.ReadOnly = true;
            this.txtMonthlyPayment.Size = new System.Drawing.Size(111, 27);
            this.txtMonthlyPayment.TabIndex = 12;
            this.txtMonthlyPayment.TabStop = false;
            this.txtMonthlyPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrincipalAmount
            // 
            this.txtPrincipalAmount.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPrincipalAmount.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPrincipalAmount.Location = new System.Drawing.Point(344, 124);
            this.txtPrincipalAmount.Name = "txtPrincipalAmount";
            this.txtPrincipalAmount.Size = new System.Drawing.Size(111, 27);
            this.txtPrincipalAmount.TabIndex = 1;
            this.txtPrincipalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTermLength
            // 
            this.txtTermLength.BackColor = System.Drawing.Color.GhostWhite;
            this.txtTermLength.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTermLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTermLength.Location = new System.Drawing.Point(344, 162);
            this.txtTermLength.Name = "txtTermLength";
            this.txtTermLength.Size = new System.Drawing.Size(111, 27);
            this.txtTermLength.TabIndex = 3;
            this.txtTermLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnnualRate
            // 
            this.txtAnnualRate.BackColor = System.Drawing.Color.GhostWhite;
            this.txtAnnualRate.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnualRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAnnualRate.Location = new System.Drawing.Point(344, 200);
            this.txtAnnualRate.Name = "txtAnnualRate";
            this.txtAnnualRate.Size = new System.Drawing.Size(111, 27);
            this.txtAnnualRate.TabIndex = 5;
            this.txtAnnualRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(326, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(455, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 21);
            this.label11.TabIndex = 29;
            this.label11.Text = "%";
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalInterest.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalInterest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTotalInterest.Location = new System.Drawing.Point(344, 314);
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.ReadOnly = true;
            this.txtTotalInterest.Size = new System.Drawing.Size(111, 27);
            this.txtTotalInterest.TabIndex = 31;
            this.txtTotalInterest.TabStop = false;
            this.txtTotalInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(57, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "Total Interest Paid:";
            // 
            // btnRate
            // 
            this.btnRate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRate.Location = new System.Drawing.Point(483, 188);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(93, 52);
            this.btnRate.TabIndex = 33;
            this.btnRate.Text = "Calculate &Interest Rate";
            this.btnRate.UseVisualStyleBackColor = false;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // frmFixedMortgageCalculator
            // 
            this.AcceptButton = this.btnCalculateMortgage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExitMortgage;
            this.ClientSize = new System.Drawing.Size(588, 408);
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.txtTotalInterest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAnnualRate);
            this.Controls.Add(this.txtTermLength);
            this.Controls.Add(this.txtPrincipalAmount);
            this.Controls.Add(this.txtTotalOwed);
            this.Controls.Add(this.txtMonthlyPayment);
            this.Controls.Add(this.btnCalculateMortgage);
            this.Controls.Add(this.btnExitMortgage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFixedMortgageCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fixed-Rate Mortgage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExitMortgage;
        private System.Windows.Forms.Button btnCalculateMortgage;
        private System.Windows.Forms.TextBox txtTotalOwed;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.TextBox txtPrincipalAmount;
        private System.Windows.Forms.TextBox txtTermLength;
        private System.Windows.Forms.TextBox txtAnnualRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalInterest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRate;
    }
}