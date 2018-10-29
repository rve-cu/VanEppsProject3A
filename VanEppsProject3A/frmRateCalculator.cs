using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanEppsProject3A
{
    public partial class frmRateCalculator : Form
    {
        Form formFixedMortgageCalculator;

        public frmRateCalculator(frmFixedMortgageCalculator _form)
        {
            InitializeComponent();
            this.formFixedMortgageCalculator = _form; // pull in current instance of fixed-rate mortgage calculator form
        }

        private void btnCalculateRate_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert input
                int creditScore = Convert.ToInt32(txtCreditScore.Text);

                // Only allow credit scores between 300 and 850
                if (creditScore > 0 && (creditScore < 300 || creditScore > 850))
                {
                    throw new Exception("Invalid credit score. Please enter a value between 300 and 850.");
                }

                // Determine interest rate based on credit score
                decimal interestRate = 0; // Initialize interest rate var
                // Arbitrarily determine interest rate by dividing 3000 by credit score
                interestRate = 3000.0m / creditScore;

                // Format and display calculated value
                txtInterestRate.Text = interestRate.ToString("f3");
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid input format. Please enter only numeric values and don't leave any fields blank.",
                    "Format Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "Please enter a smaller numeric value.",
                    "Overflow Error");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show(
                    "Cannot divide by zero. Please enter a value greater than zero.",
                    "Division By Zero Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    ex.GetType().ToString()
                    );
            }
        }

        private void btnExitRate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopyRate_Click(object sender, EventArgs e)
        {
            // Copy current value for interest rate to corresponding input on fixed-rate mortgage calculator form
            formFixedMortgageCalculator.Controls.Find("txtAnnualRate", true).First().Text = txtInterestRate.Text;
        }
    }
}
