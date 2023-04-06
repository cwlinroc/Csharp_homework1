using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_homework1
{
    public partial class M02_form_loancounter : Form
    {
        public M02_form_loancounter()
        {
            InitializeComponent();
        }

        private int loan_term_month = 0;
        private int loan_term_year = 0;
        private decimal lending_rate_month = 0;
        private decimal lending_rate_year=0;

        private int loan_amount = 0;
        private int down_payment = 0;

        private int PMT = 0;

       
         

        private void btn_PMT_Click(object sender, EventArgs e)
        {
            Initialize();
            Calculate();
            MessageBox.Show("月付貸款為"+PMT+"元");
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            Initialize();
            Calculate();
            int total = PMT * loan_term_month;
            MessageBox.Show("總付貸款為" + total + "元");
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Initialize();
            Calculate();

            M02a_loanreport m03a = new M02a_loanreport(loan_amount, loan_term_year, lending_rate_year, PMT);
            m03a.Show();

        }

        private void Initialize()
        {
            loan_term_year = Convert.ToInt32(text_loan_term_year.Text);
            loan_term_month = loan_term_year * 12;

            lending_rate_year = ((decimal)Convert.ToInt32(text_lending_rate_year.Text)) / 100;
            lending_rate_month = lending_rate_year / 12;

            loan_amount = Convert.ToInt32(text_loan_amount.Text);
            down_payment = Convert.ToInt32(text_down_payment.Text);
        }

        private void Calculate()
        {
            

            double average_amortization_rate = (Math.Pow(1 + (double)lending_rate_month, loan_term_month) * (double)lending_rate_month)
                / (Math.Pow((1 + (double)lending_rate_month), loan_term_month) - 1);

            PMT = (int)(average_amortization_rate * (loan_amount - down_payment));

        }

        
    }
}
