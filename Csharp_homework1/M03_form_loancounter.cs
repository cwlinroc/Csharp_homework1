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
    public partial class M03_form_loancounter : Form
    {
        public M03_form_loancounter()
        {
            InitializeComponent();
        }

        private int loan_term_month = 0;
        private int loan_term_year = 0;
        private double lending_rate_month = 0;
        private double lending_rate_year=0;

        private int loan_amount = 0;
        private int down_payment = 0;

        private int PMT = 0;

       
         

        private void btn_PMT_Click(object sender, EventArgs e)
        {
            initialize();
            calculate();
            MessageBox.Show("月付貸款為"+PMT+"元");
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            initialize();
            calculate();
            int total = PMT * loan_term_month;
            MessageBox.Show("總付貸款為" + total + "元");
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            initialize();
            calculate();

            M03a_loanreport m03a = new M03a_loanreport(loan_amount, loan_term_year, lending_rate_year, PMT);
            m03a.Show();

        }

        private void initialize()
        {
            loan_term_year = Convert.ToInt32(text_loan_term_year.Text);
            loan_term_month = loan_term_year * 12;

            lending_rate_year = ((double)Convert.ToInt32(text_lending_rate_year.Text)) / 100;
            lending_rate_month = lending_rate_year / 12;

            loan_amount = Convert.ToInt32(text_loan_amount.Text);
            down_payment = Convert.ToInt32(text_down_payment.Text);
        }

        private void calculate()
        {
            double average_amortization_rate = (Math.Pow((1 + lending_rate_month), loan_term_month) * lending_rate_month)
                / (Math.Pow((1 + lending_rate_month), loan_term_month) - 1);

            PMT = (int)(average_amortization_rate * (loan_amount - down_payment));

        }

        
    }
}
