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
    public partial class frmFixedMortgageCalculator : Form
    {
        public frmFixedMortgageCalculator()
        {
            InitializeComponent();
        }

        frmRateCalculator formRateCalculator;

        private void btnCalculateMortgage_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert input
                double principalAmount = Convert.ToDouble(txtPrincipalAmount.Text);
                int termLength = Convert.ToInt32(txtTermLength.Text);
                double annualRate = Convert.ToDouble(txtAnnualRate.Text);

                // Only allow principals of $1,000,000 or less
                if (principalAmount >= 1000000)
                {
                    throw new Exception("Please enter a value less than 1,000,000 for Principal.");
                }

                // Only allow terms lengths between 5 and 30 years
                if (termLength < 5 || termLength > 30)
                {
                    throw new Exception("Invalid term length. Please enter a value of at least 5 years and no more than 30 years.");
                }

                // Only allow positive values for interest rate
                if (annualRate <= 0)
                {
                    throw new ArithmeticException("Interest rate cannot be zero or negative. Please enter a positive value or use the Interest Rate Calculator form.");
                }

                // Only allow positive values for principal
                if (principalAmount <= 0)
                {
                    throw new ArithmeticException("Principal cannot be zero or negative. Please enter a positive value.");
                }

                // Convert interest rate and term length to monthly amounts
                double monthlyRate = annualRate / 12 / 100; // Divide annualRate by 12 (months in year) then divide by 100 to get decimal rate value
                int termLengthMonths = termLength * 12;

                // Calculate monthly payment
                double monthlyPayment = (monthlyRate * principalAmount) / (1 - Math.Pow(1 + monthlyRate, -termLengthMonths));
                // Calculate total amount owed
                double totalOwed = monthlyPayment * termLengthMonths;
                // Calculate interest paid
                double totalInterest = totalOwed - principalAmount;

                // Format and display calculated values
                txtMonthlyPayment.Text = monthlyPayment.ToString("c");
                txtTotalOwed.Text = totalOwed.ToString("c");
                txtTotalInterest.Text = totalInterest.ToString("c");
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
            catch (ArithmeticException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Arithmetic Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    ex.GetType().ToString()
                    );
            }
        }

        private void btnExitMortgage_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            // Display Interest Rate Calculator form
            formRateCalculator = new frmRateCalculator(this);
            formRateCalculator.Show();
        }
    }
}
