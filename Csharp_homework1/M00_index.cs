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
    public partial class form_M00_index : Form
    {

        private Form current_form;
        
        public form_M00_index()
        {
            InitializeComponent();
            panel_left.BackColor = Color.FromArgb(0, Color.Black);
            panel_up.BackColor = Color.FromArgb(0, Color.White);
            panel_right.BackColor = Color.FromArgb(0, Color.White);
        }

        

        private void button_showhelloform_Click(object sender, EventArgs e)
        {
            form_M01_hello m01 = new form_M01_hello();
            OpenFromInLabel(m01);
        }

        private void btn_showloanform_Click(object sender, EventArgs e)
        {
            form_M02_loancounter m02 = new form_M02_loancounter();
            OpenFromInLabel(m02);
        }

        private void btm_show_barapp_Click(object sender, EventArgs e)
        {
            form_M03_barapp m03 = new form_M03_barapp();
            OpenFromInLabel(m03);
        }

        private void btn_show_student_structform_Click(object sender, EventArgs e)
        {
            form_M04_student_structform m04 = new form_M04_student_structform();
            OpenFromInLabel(m04);
        }

        private void btn_show_students_grade_Click(object sender, EventArgs e)
        {
            form_M05_sutdents_grade m05 = new form_M05_sutdents_grade();
            OpenFromInLabel(m05);
        }

        private void btn_show_gradelist_Click(object sender, EventArgs e)
        {
            form_M06_students_gradelist m06 = new form_M06_students_gradelist();
            OpenFromInLabel(m06);
        }

        private void btn_show_method_Click(object sender, EventArgs e)
        {
            form_M07_method m07 = new form_M07_method();
            OpenFromInLabel(m07);
        }

        private void btn_show_mycalculator_Click(object sender, EventArgs e)
        {
            form_M08_Mycalculator m08 = new form_M08_Mycalculator();
            OpenFromInLabel(m08);
        }

        private void btn_show_methodmk2_Click(object sender, EventArgs e)
        {
            form_M09_methodmk2 m09 = new form_M09_methodmk2();
            OpenFromInLabel(m09);
        }

        private void btn_show_tictactoe_Click(object sender, EventArgs e)
        {
            form_M10_tictactoe m10 = new form_M10_tictactoe();
            OpenFromInLabel(m10);
        }

        private void btn_show_screensaver_Click(object sender, EventArgs e)
        {
            form_M11_screensaver m11 = new form_M11_screensaver();
            OpenForm(m11);
        }

        private void btn_show_notepad_Click(object sender, EventArgs e)
        {
            form_M12_notepad m12 = new form_M12_notepad();
            OpenForm(m12);
        }

        private void btn_show_paint_Click(object sender, EventArgs e)
        {
            form_M13_paint m13 = new form_M13_paint();
            OpenForm(m13);
        }

        private void btn_show_pictureviewer_Click(object sender, EventArgs e)
        {
            form_M14_pictureviewer m14 = new form_M14_pictureviewer();
            OpenForm(m14);
        }

        private void btn_show_guess_Click(object sender, EventArgs e)
        {
            form_M15_guess m15 = new form_M15_guess();
            OpenFromInLabel(m15);
        }

        private void btn_show_alarm_Click(object sender, EventArgs e)
        {
            form_M16_alarmclock m16 = new form_M16_alarmclock();
            OpenFromInLabel(m16);
        }


        private void OpenFromInLabel(Form newform)
        {
            if(current_form!=null)current_form.Close();
            current_form = newform;

            newform.TopLevel = false;
            panel_right.Controls.Add(newform);
            newform.Show();
        }

        private void OpenForm(Form newform)
        {
            if (current_form != null) current_form.Close();
            current_form = newform;
            newform.Show();
        }

        
    }
}
