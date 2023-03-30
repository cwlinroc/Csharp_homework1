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
    public partial class M06_sutdents_grade : Form
    {

        public M06_sutdents_grade()
        {
            InitializeComponent();
            InitialListView();
            ReFreshSeed();
        }


        private void InitialListView()
        {
            listview_scoreboard.View = View.Details;
            listview_scoreboard.GridLines = true;
            listview_scoreboard.LabelEdit = false;
            listview_scoreboard.FullRowSelect = true;
            listview_scoreboard.Columns.Add("姓名", 60, HorizontalAlignment.Right);
            listview_scoreboard.Columns.Add("國文", 40, HorizontalAlignment.Right);
            listview_scoreboard.Columns.Add("英文", 40, HorizontalAlignment.Right);
            listview_scoreboard.Columns.Add("數學", 40, HorizontalAlignment.Right);
            listview_scoreboard.Columns.Add("總分", 40, HorizontalAlignment.Right);
            listview_scoreboard.Columns.Add("平均", 40, HorizontalAlignment.Right);
            listview_scoreboard.Columns.Add("最低", 40, HorizontalAlignment.Left);
            listview_scoreboard.Columns.Add("最高", 40, HorizontalAlignment.Left);
            for (int i = 0; i < 20; i++)
            {
                var item = new ListViewItem($"No.{i}");
                item.SubItems.Add($"{i}");
                listview_scoreboard.Items.Add(item);
            }
        }



        private void ReFreshSeed()
        {
            Random rng = new Random();
            Utility.RandSeed=rng.Next();
        }



        private class Students
        {
            public string Name;
            public int ChineseScore;
            public int EnglishScore;
            public int MathScore;

            public Students()
            {
                Random rng = new Random(Utility.RandSeed);
                Name = rng.Next().ToString();
                ChineseScore = rng.Next() % 100;
                EnglishScore = rng.Next() % 100;
                MathScore = rng.Next() % 100;
                Utility.RandSeed = rng.Next();
            }

            public Students(string name,int chinesescore,int englishscore,int mathscore)
            {
                Name = name;
                ChineseScore = chinesescore;
                EnglishScore = englishscore;
                MathScore = mathscore;
            }
            

        }




    }


}

