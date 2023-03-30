using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Csharp_homework1
{
    public partial class M05_student_structform : Form
    {
        public M05_student_structform()
        {
            InitializeComponent();
        }


        private string name;
        private int chinesescore;
        private int englishscore;
        private int mathscore;

        private void btn_save_Click(object sender, EventArgs e)
        {
            name = textbox_name.Text;
            chinesescore = int.Parse(textbox_chinesescore.Text);
            englishscore = int.Parse(textbox_englishscore.Text);
            mathscore = int.Parse(textbox_mathscore.Text);
        }

        private void btn_show_saved_Click(object sender, EventArgs e)
        {
            string message = "姓名：" + name + "\r\n國文成績："
                + chinesescore + "\r\n英文成績：" + englishscore + "\r\n數學成績：" + mathscore ;
            textbox_showdata.Text = message;
        }

        private void btn_show_minmax_Click(object sender, EventArgs e)
        {
            string[] subject = { "國文","英文","數學" };
            int[] score = { chinesescore, englishscore, mathscore };

            SortByScore(subject, score);            

            textbox_minmax.Text = CreateMinMaxMessage(subject, score);

        }

        private void SortByScore( string[] subject, int[] score) 
        {
            for (int i = 1; i < subject.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (score[j - 1] < score[j])
                    {
                        break;
                    }
                    else
                    {
                        (score[j - 1], score[j]) = (score[j], score[j - 1]);
                        (subject[j - 1], subject[j]) = (subject[j], subject[j - 1]);
                    }
                }
            }
        }

        private string CreateMinMaxMessage(string[] subject, int[] score)
        {
            string message = "最低成績為" + subject[0] + score[0] + "分";

            int k = 0;
            while (score[k] == score[k + 1])
            {
                message += "與" + subject[k + 1] + score[k + 1] + "分";
                k++;
                if (k > subject.Length - 2) break;
            }

            message += "\r\n最高成績為" + subject[subject.Length - 1] + score[score.Length - 1] + "分";

            k = score.Length - 1;

            while (score[k] == score[k - 1])
            {
                message += "與" + subject[k - 1] + score[k - 1] + "分";
                k--;
                if (k < 1) break;
            }

            return message;
        }

        
    }
}
