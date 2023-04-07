using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_homework1
{
    public partial class form_M15_guess : Form
    {
        private int answer = 0;
        private int upperbound = 100;
        private int lowerbound = 0;
        private form_M15a_inputbox guessform;
        
        
        public form_M15_guess()
        {
            InitializeComponent();
        }

        private void btn_guess_Click(object sender, EventArgs e)
        {
            guessform = new form_M15a_inputbox();

            guessform.portevent += this.GuessAnswer;

            RefreshAnswer();

            guessform.ShowDialog();
        }

        private void btn_showanswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Answer：{answer}");
        }

        private void RefreshAnswer()
        {
            Random rng = new Random(Guid.NewGuid().GetHashCode());
            answer = rng.Next() % 100;
            upperbound = 100;
            lowerbound = 0;
            label_resault.Text = "Please select a number between 0 and 100";
        }

        private void GuessAnswer(string portin)
        {
            try
            {
                int guess = Convert.ToInt32(portin);
                CheckValid(guess);

                if(guess == answer) 
                {
                    Congrats();
                }
                else 
                {
                    ShowHint(guess);
                }                
            }
            catch (Exception) 
            {
                MessageBox.Show($"請輸入{lowerbound}~{upperbound}之間的數字");
            } 
        }

        private void CheckValid(int guess) 
        {
            if (guess < lowerbound)  throw new Exception();
            if (guess > upperbound) throw new Exception();
        }

        private void Congrats()
        {
            MessageBox.Show($"Congradulations!!You got {answer}!!!");

            guessform.Close();
        }

        private void ShowHint(int guess)
        {
            if(guess > answer)
            {
                upperbound = guess;

                label_resault.Text = $"Too Large!! \n Between {lowerbound} and {upperbound}";
            }
            else
            {
                lowerbound = guess;

                label_resault.Text = $"Too Small!! \n Between {lowerbound} and {upperbound}";
            }

        }
    }
}
