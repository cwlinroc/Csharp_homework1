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
    public partial class M02a_loanreport : Form
    {
        
        public M02a_loanreport(int loan_amount, int loan_term_year, double lending_rate_year, int PMT)
        {
            InitializeComponent();

            textbox_loan_amount.Text = loan_amount.ToString();
            textbox_loan_term_yaer.Text = loan_term_year.ToString();
            textbox_lending_rate_year.Text = (lending_rate_year*100).ToString();
            textbox_PMT.Text = PMT.ToString();
            textbox_total_payment.Text = (PMT* loan_term_year*12).ToString();
        }

        
    }
}
