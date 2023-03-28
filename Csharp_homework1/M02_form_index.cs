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
    public partial class M02_form_index : Form
    {
        public M02_form_index()
        {
            InitializeComponent();
        }

        private void button_showhelloform_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            M01_form_hello m01 = new M01_form_hello();
            m01.Show();
        }

        private void btn_show_clicked_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            show_clicked_times();
        }

        

        private void show_clicked_times()
        {
            string message  = "一共按了" + Utility.TimesClicked() + "次";
            MessageBox.Show(message);
        }

        private void btn_show_date_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            MessageBox.Show( Utility.ShowDate() );
        }

        private void btn_showloanform_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            M03_form_loancounter m03 = new M03_form_loancounter();
            m03.Show();
        }

        private void btm_show_barapp_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            M04_barapp m04 = new M04_barapp();
            m04.Show();


        }
    }
}
