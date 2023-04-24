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

        private int X, Y;
        private bool isLoaded = false;

        public form_M00_index()
        {
            InitializeComponent();

            splitContainer_all.BackColor = Color.Transparent;
            splitContainer_bottom.BackColor = Color.Transparent;
        }

        #region -- buttons --

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

        #endregion

        private void OpenFromInLabel(Form newform)
        {
            if (current_form != null) current_form.Close();
            current_form = newform;

            newform.TopLevel = false;
            splitContainer_bottom.Panel2.Controls.Add(newform);
            newform.Show();
        }

       

        private void OpenForm(Form newform)
        {
            if (current_form != null) current_form.Close();
            current_form = newform;
            newform.Show();
        }


        #region -- resize UI(forbidden) --

        /*
        private void form_M00_index_Load(object sender, EventArgs e)
        {
            X = this.Width;
            Y = this.Height;
            isLoaded = true;
            SetTag(this);
            this.WindowState = FormWindowState.Maximized;
        }
       
        private void form_M00_index_Resize(object sender, EventArgs e)
        {
            ResizeAll();
        }
        
        private void ResizeAll()
        {
            if (isLoaded)
            {
                double newx, newy;
                GetNewXY(out newx, out newy);
                SetControls(newx, newy, this);
            }
        }

        private void GetNewXY(out double newx, out double newy)
        {
            newx = (double)this.Width / (double)X;
            newy = (double)this.Height / (double)Y;

        }

        private void SetTag(Control inputcon)
        {
            foreach (Control con in inputcon.Controls)
            {
                con.Tag += ":" + con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top;

                if (con.Controls.Count > 0)
                {
                    SetTag(con);
                }
            }
        }

        private void SetControls(double newx, double newy, Control inputcon)
        {

            foreach (Control con in inputcon.Controls)
            {

                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });

                if (mytag[0] == "all")
                {
                    int width = (int)(int.Parse(mytag[1]) * newx);
                    con.Width = width;

                    int height = (int)(int.Parse(mytag[2]) * newx);
                    con.Height = height;

                    int left = (int)(int.Parse(mytag[3]) * newx);
                    con.Left = left;

                    int top = (int)(int.Parse(mytag[4]) * newx);
                    con.Top = top;
                }
                else if (mytag[0] == "width")
                {
                    int width = (int)(int.Parse(mytag[1]) * newx);
                    con.Width = width;

                    int left = (int)(int.Parse(mytag[3]) * newx);
                    con.Left = left;
                }

                if (con.Controls.Count > 0)
                {
                    SetControls(newx, newy, con);

                }
            }
        } 

        */

        #endregion

    }
}
