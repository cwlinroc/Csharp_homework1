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
    public partial class M00_form_index : Form
    {
        public M00_form_index()
        {
            InitializeComponent();
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

        private void button_showhelloform_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            M01_form_hello m01 = new M01_form_hello();
            m01.Show();
        }

        private void btn_showloanform_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            M02_form_loancounter m02 = new M02_form_loancounter();
            m02.Show();
        }

        private void btm_show_barapp_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            M03_barapp m03 = new M03_barapp();
            m03.Show();
        }

        private void btn_show_student_structform_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            M04_student_structform m04 = new M04_student_structform();
            m04.Show();
        }

        private void btn_show_students_grade_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            M05_sutdents_grade m05 = new M05_sutdents_grade();
            m05.Show();
        }

        private void btn_show_gradelist_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            M06_students_gradelist m06 = new M06_students_gradelist();
            m06.Show();
        }

        private void btn_show_method_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            M07_method m07 = new M07_method();
            m07.Show();
        }

        private void btn_show_mycalculator_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            M08_Mycalculator m08 = new M08_Mycalculator();
            m08.Show();
        }

        private void btn_show_tictactoe_Click(object sender, EventArgs e)
        {
            Utility.CountClicked();
            M10_tictactoe m10 = new M10_tictactoe();
            m10.Show();
        }
    }
}
