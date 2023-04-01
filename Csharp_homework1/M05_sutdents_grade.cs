using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Csharp_homework1
{
    public partial class M05_sutdents_grade : Form
    {
        const int subjectnumbers = 3;
        string[] subjectname = { "國文", "英文", "數學" };

        List<Students> studentslist = new List<Students>();

        public M05_sutdents_grade()
        {
            InitializeComponent();
            InitialListView();
            ReFreshSeed();
        }


        private void InitialListView()
        {

            listview_scoreboard.Columns.Add("姓名", 80, HorizontalAlignment.Right);
            listview_scoreboard.Columns.Add("國文", 50, HorizontalAlignment.Right);
            listview_scoreboard.Columns.Add("英文", 50, HorizontalAlignment.Right);
            listview_scoreboard.Columns.Add("數學", 50, HorizontalAlignment.Right);
            listview_scoreboard.Columns.Add("總分", 50, HorizontalAlignment.Right);
            listview_scoreboard.Columns.Add("平均", 60, HorizontalAlignment.Right);
            listview_scoreboard.Columns.Add("最低", 70, HorizontalAlignment.Left);
            listview_scoreboard.Columns.Add("最高", 70, HorizontalAlignment.Left);

            

            //listview_scoreboard.Columns[0]
        }

        private void ReFreshSeed()
        {
            Random rng = new Random();
            Utility.RandSeed = rng.Next();
        }


        private void btn_add_studentsdata_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInput();

                string name = textBox_name.Text;
                int chinesescore = int.Parse(textBox_chinesescore.Text);
                int englishscore = int.Parse(textBox_englishscore.Text);
                int mathscore = int.Parse(textBox_mathscore.Text);

                AddStudent(name, chinesescore, englishscore, mathscore);
            }
            catch (ListErrorException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_add_randomdata_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void btn_add_20randomdata_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++) AddStudent();
        }

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            studentslist.Clear();
            listview_scoreboard.Items.Clear();
            listview_statistic.Items.Clear();

            btn_statistic.Enabled = true;
            btn_add_randomdata.Enabled = true;
            btn_add_20randomdata.Enabled = true;
            btn_add_studentsdata.Enabled = true;

        }

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            int[] sum = new int[subjectnumbers];
            double[] average = new double[subjectnumbers];
            int[] highestscore = new int[subjectnumbers];
            int[] lowestscore = new int[subjectnumbers];

            listview_statistic.Items.Clear();

            ScanAllStudents(sum, average, highestscore, lowestscore);

            PrintResault(sum, average, highestscore, lowestscore);

            btn_statistic.Enabled = false;
            btn_add_randomdata.Enabled = false;
            btn_add_20randomdata.Enabled = false;
            btn_add_studentsdata.Enabled = false;

        }


        private class Students
        {
            public string name;
            public int[] score;

            public int highestsubjectpointer;
            public int lowestsubjectpointer;

            public Students()
            {
                Random rng = new Random(Utility.RandSeed);

                name = "";
                name += (char)('A' + (rng.Next() % 26)); ;

                for (int i = 0; i < 3; i++)
                {
                    name += (char)('a' + (rng.Next() % 26));
                }

                score = new int[subjectnumbers];

                for (int i = 0; i < subjectnumbers; i++)
                {
                    score[i] = rng.Next() % 100;
                }

                Utility.RandSeed = rng.Next();
            }

            public Students(string name, params int[] score)
            {
                this.name = name;

                this.score = new int[subjectnumbers];
                
                for(int i=0; i <subjectnumbers; i++)
                {
                    this.score[i] = score[i];
                }
            }

            public void FindMinMax()
            {
                highestsubjectpointer = 0;
                lowestsubjectpointer = 0;

                if (subjectnumbers < 2) return;

                for (int i = 1; i < subjectnumbers; i++)
                {
                    if (score[i] > score[highestsubjectpointer])
                    {
                        highestsubjectpointer = i;
                    }
                    if (score[i] < score[lowestsubjectpointer])
                    {
                        lowestsubjectpointer = i;
                    }
                }

            }


        }

        private void CheckInput()
        {
            if (textBox_name.Text == "")
            {
                throw new ListErrorException("請輸入姓名");
                return;
            }

            if (textBox_chinesescore.Text == "")
            {
                throw new ListErrorException("請輸入國文成績");
                return;
            }

            if (textBox_englishscore.Text == "")
            {
                throw new ListErrorException("請輸入英文成績");
                return;
            }
            if (textBox_mathscore.Text == "")
            {
                throw new ListErrorException("請輸入數學成績");
                return;
            }

            if(int.Parse(textBox_chinesescore.Text)<0 || int.Parse(textBox_englishscore.Text) < 0
                || int.Parse(textBox_mathscore.Text) < 0)
            {
                throw new ListErrorException("你跟這位同學有仇嗎");
                return;
            }

            if (int.Parse(textBox_chinesescore.Text) > 100 || int.Parse(textBox_englishscore.Text) > 100
                || int.Parse(textBox_mathscore.Text) > 100 )
            {
                throw new ListErrorException("滿分是100，謝大哥");
                return;
            }


        }

        public class ListErrorException : Exception 
        {
            public ListErrorException(string message) : base(message)
            {
                MessageBox.Show(message);
            }
        }
        private void AddStudent()
        {
            Students student = new Students();
            studentslist.Add(student);

            AddStudentToList(student);         

        }

        private void AddStudent(string name, int score1, int score2, int score3)
        {
            Students student = new Students(name,score1,score2,score3);
            studentslist.Add(student);

            AddStudentToList(student);

        }

        private void AddStudentToList(Students student)
        {
            var item = new ListViewItem(student.name);

            int sum = 0 ;

            for (int i = 0; i < subjectnumbers; i++)
            {
                item.SubItems.Add(student.score[i].ToString());
                sum += student.score[i];
            }//各科

            item.SubItems.Add(sum.ToString());//總分
            item.SubItems.Add(((double)sum/subjectnumbers).ToString("0.0"));//平均

            student.FindMinMax();

            item.SubItems.Add(subjectname[student.lowestsubjectpointer]
                + student.score[student.lowestsubjectpointer].ToString());//最低

            item.SubItems.Add(subjectname[student.highestsubjectpointer] 
                + student.score[student.highestsubjectpointer].ToString());//最高
            

            listview_scoreboard.Items.Add(item);
        }

        private void ScanAllStudents(int[] sum, double[] average, int[] highestscore, int[] lowestscore)
        {
            for (int i = 0; i < subjectnumbers; i++)
            {
                sum[i] = 0;
                highestscore[i] = 0;
                lowestscore[i] = 100;

                foreach (Students student in studentslist)
                {
                    sum[i] += student.score[i];
                    if (student.score[i] > highestscore[i]) highestscore[i] = student.score[i];
                    if (student.score[i] < lowestscore[i]) lowestscore[i] = student.score[i];
                }

                average[i] = (double)sum[i] / (double)studentslist.Count;
            }
        }

        private void PrintResault(int[] sum, double[] average, int[] highestscore, int[] lowestscore)
        {
            var item_sum = new ListViewItem("總分");

            foreach(int score in sum)
            {
                item_sum.SubItems.Add(score.ToString());
            }

            listview_statistic.Items.Add(item_sum);

            var item_average = new ListViewItem("平均");

            foreach (double score in average)
            {
                item_average.SubItems.Add(score.ToString("0.0"));
            }

            listview_statistic.Items.Add(item_average);

            var item_high = new ListViewItem("最高分");

            foreach (int score in highestscore)
            {
                item_high.SubItems.Add(score.ToString());
            }

            listview_statistic.Items.Add(item_high);

            var item_low = new ListViewItem("最低分");

            foreach (int score in lowestscore)
            {
                item_low.SubItems.Add(score.ToString());
            }

            listview_statistic.Items.Add(item_low);

        }

        
    }


}

