using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prak_6_2_Forrat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculator2 : ContentPage
    {
        public Calculator2()
        {
            InitializeComponent();
        }
        private void OnCalculateButtonClicked(object sender, EventArgs e)
        {
            if (LoanAmountEntry.Text != null && LoanTermEntry.Text != null && PaymentTypePicker.SelectedItem != null)
            {
                double loanAmount = double.Parse(LoanAmountEntry.Text);
                int loanTerm = int.Parse(LoanTermEntry.Text);
                double interestRate = InterestRateSlider.Value;
                string paymentType = PaymentTypePicker.SelectedItem.ToString();

                if (loanAmount > 0 && loanTerm > 0)
                {
                    double monthlyPayment = 0;
                    double totalAmount = 0;
                    double overpayment = 0;

                    if (paymentType == "Аннуитетный")
                    {

                        double monthlyRate = interestRate / 100 / 12;
                        monthlyPayment = loanAmount * (monthlyRate * Math.Pow(1 + monthlyRate, loanTerm)) / (Math.Pow(1 + monthlyRate, loanTerm) - 1);
                        totalAmount = monthlyPayment * loanTerm;
                        overpayment = totalAmount - loanAmount;
                    }
                    else if (paymentType == "Дифференцированный")
                    {

                        double monthlyRate = interestRate / 100 / 12;
                        double principalPayment = loanAmount / loanTerm;
                        double firstPayment = principalPayment + (loanAmount * monthlyRate);
                        monthlyPayment = firstPayment;

                        totalAmount = 0;
                        for (int i = 0; i < loanTerm; i++)
                        {
                            double interestPayment = (loanAmount - (principalPayment * i)) * monthlyRate;
                            totalAmount += principalPayment + interestPayment;
                        }
                        overpayment = totalAmount - loanAmount;
                    }


                    MonthlyPaymentLabel.Text = $"{monthlyPayment:F2} руб.";
                    TotalAmountLabel.Text = $"{totalAmount:F2} руб.";
                    OverpaymentLabel.Text = $"{overpayment:F2} руб.";
                }
            }




        }
    }
}