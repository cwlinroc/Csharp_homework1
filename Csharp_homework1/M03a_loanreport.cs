using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_homework1
{
    public partial class M03a_loanreport : Form
    {
        
        public M03a_loanreport(int loan_amount, int loan_term_year, double lending_rate_year, int PMT)
        {
            InitializeComponent();

            text_loan_amount.Text = loan_amount.ToString();
            text_loan_term_yaer.Text = loan_term_year.ToString();
            text_lending_rate_year.Text = (lending_rate_year*100).ToString();
            text_PMT.Text = PMT.ToString();
            text_total_payment.Text = (PMT* loan_term_year*12).ToString();
        }

        
    }
}
