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
    public partial class M08_Mycalculator : Form
    {
        public M08_Mycalculator()
        {
            InitializeComponent();
        }

        

        private void btn_addition_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInput();

                PrintAnswer(double.Parse(textbox_num1.Text) + double.Parse(textbox_num2.Text));
            }
            catch (ListErrorException) { }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }           

        }

        private void btn_subtraction_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInput();

                PrintAnswer(double.Parse(textbox_num1.Text) - double.Parse(textbox_num2.Text));
            }
            catch (ListErrorException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInput();

                PrintAnswer(double.Parse(textbox_num1.Text) * double.Parse(textbox_num2.Text));
            }
            catch (ListErrorException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInput();

                PrintAnswer(double.Parse(textbox_num1.Text) / double.Parse(textbox_num2.Text));
            }
            catch (ListErrorException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CheckInput()
        {
            if(textbox_num1.Text=="")
            {
                throw new ListErrorException("請輸入Num1");
                return;
            }
            else if (textbox_num2.Text == "")
            {
                throw new ListErrorException("請輸入Num2");
                return;
            }
        }
        private class ListErrorException : Exception
        {
            public ListErrorException(string message) : base(message)
            {
                MessageBox.Show(message);
            }
        }


        private void PrintAnswer(double answer)
        {
            if (answer < 0.00001 && answer > 0)
            {
                textbox_answer.Text = "0.00000";
                return;
            }
            else if (answer > -0.00001 && answer < 0)
            {
                textbox_answer.Text = "-0.00000";
                return;
            }
            else
            {
                textbox_answer.Text = answer.ToString("0.#####");
            }
        }

    }
}
