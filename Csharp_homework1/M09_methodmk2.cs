using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_homework1
{
    public partial class form_M09_methodmk2: Form
    {
        public form_M09_methodmk2()
        {
            InitializeComponent();
        }

        private int[] arr0711 = {1,5,6,8,7,97,54,887,65,578};
        private string[] arr0711str = { "mother張","emma","迪克蕭","J40","Candy","Cindy","Coconut","Motherfacker"};


        #region -- buttons --
        private void btn_oddoreven_Click(object sender, EventArgs e)
        {
            try
            {

                int number = int.Parse(textbox_oddoreven.Text);

                if (number % 2 == 1)
                {
                    textbox_resault.Text = $"輸入的數{number}為奇數";
                }
                else
                {
                    textbox_resault.Text = $"輸入的數{number}為偶數";
                }

            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }

        }

        private void btn_arrayfindminmax_Click(object sender, EventArgs e)
        {
            int maxnumber = arr0711[0];
            int minnumber = arr0711[0];

            for (int i = 1; i < arr0711.Length; i++)
            {
                if (arr0711[i] > maxnumber) maxnumber = arr0711[i];
                if (arr0711[i] < minnumber) minnumber = arr0711[i];
            }
            textbox_resault.Text = $"int陣列arr0711{{1,5,6,8,7,97,54,887,65,548}} \r\n" +
                $"最大值為{maxnumber}\r\n最小值為{minnumber}";

        }


        private void btn_findhowmanywithc_Click(object sender, EventArgs e)
        {
            int totalnumber = 0;

            foreach (string str in arr0711str)
            {
                if (str.Contains('c') || str.Contains('C'))
                {
                    totalnumber++;
                }
            }

            textbox_resault.Text = $"string陣列arr0711str{{\"mother張\",\"emma\",\"迪克蕭\",\"J40\",\"Candy\",\"Cindy\",\"Coconut\",\"Motherfacker\"}}\r\n"
                + $"有C及c的名字總共有{totalnumber}個";
        }

        private void btn_numberofoddandeven_Click(object sender, EventArgs e)
        {
            int numberofodds = 0;
            int numberofevens = 0;

            for (int i = 0; i < arr0711.Length; i++)
            {
                if ((arr0711[i] % 2) == 0)
                {
                    numberofevens++;
                }
                else
                {
                    numberofodds++;
                }
            }

            textbox_resault.Text = $"int陣列arr0711{{1,5,6,8,7,97,54,887,65,578}} \r\n" +
                $"偶數的數量為{numberofevens}\r\n奇數的數量為{numberofodds}";
        }

        private void btn_findlongestname_Click(object sender, EventArgs e)
        {
            string longestname = "";

            foreach (string str in arr0711str)
            {
                if (str.Length > longestname.Length)
                {
                    longestname = str;
                }
            }

            textbox_resault.Text = $"string陣列arr0711str{{\"mother張\",\"emma\",\"迪克蕭\",\"J40\",\"Candy\",\"Cindy\",\"Coconut\",\"Motherfacker\"}}\r\n"
                + $"最長的名字是{longestname}";
        }

        private void btn_array1surround0_Click(object sender, EventArgs e)
        {
            string resault = "";

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (x == 0 || y == 0 || x == 9 || y == 9)
                    {
                        resault += "1 ";
                    }
                    else
                    {
                        resault += "0 ";
                    }
                }
                resault += "\r\n";
            }

            textbox_resault.Text = resault;
        }

        private void btn_array0surround1_Click(object sender, EventArgs e)
        {
            string resault = "";

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (x == 0 || y == 0 || x == 9 || y == 9)
                    {
                        resault += "0 ";
                    }
                    else
                    {
                        resault += "1 ";
                    }
                }
                resault += "\r\n";
            }

            textbox_resault.Text = resault;
        }

        private void btn_01alternate_Click(object sender, EventArgs e)
        {
            string resault = "";

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    resault += (x + y + 1) % 2 + " ";
                }
                resault += "\r\n";
            }

            textbox_resault.Text = resault;
        }

        private void btn_swap_Click(object sender, EventArgs e)
        {
            int n1 = 100;
            int n2 = 9487;

            textbox_resault.Text = $"換位前 n1 = {n1}, n2 = {n2} \r\n";

            n1 ^= n2;
            n2 ^= n1;
            n1 ^= n2;

            textbox_resault.Text += $"換位後 n1 = {n1}, n2 = {n2} ";
        }

        private void btn_arraysum_Click(object sender, EventArgs e)
        {
            textbox_resault.Text = $"int陣列arr0711{{1,5,6,8,7,97,54,887,65,578}} \r\n" +
                $"陣列總和為{arr0711.Sum()}";
        }

        private void btn_arraymax_Click(object sender, EventArgs e)
        {
            textbox_resault.Text = "int陣列arr0711{{1,5,6,8,7,97,54,887,65,578}} \r\n" +
                $"陣列最大為{arr0711.Max()}";
        }

        private void btn_arraymin_Click(object sender, EventArgs e)
        {
            textbox_resault.Text = "int陣列arr0711{{1,5,6,8,7,97,54,887,65,578}} \r\n" +
                $"陣列最小為{arr0711.Min()}";
        }

        private void btn_clearresualt_Click(object sender, EventArgs e)
        {
            textbox_resault.Text = "結果";
        }

        private void btn_rightangletree_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = Convert.ToInt32(textbox_rightangletreerow.Text);
                string resault = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        resault += "* ";
                    }
                    resault += "\r\n";
                }

                textbox_resault.Text = resault;
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }

        }

        private void btn_nineninemultiplicationtable_Click(object sender, EventArgs e)
        {
            string resault = "九九乘法表：\r\n";

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    resault += $"{PrintNum(i)}x{PrintNum(j)}={PrintNum(i * j)}|";
                }
                resault += "\r\n";
            }

            textbox_resault.Text = resault;

            string PrintNum(int n)
            {
                if (n < 10)
                {
                    return "  " + n;
                }
                else
                {
                    return n.ToString();
                }
            }
        }

        private void btn_decimaltobinary_Click(object sender, EventArgs e)
        {
            textbox_resault.Text = Convert.ToString(100, 2);
        }

        private void btn_notrepeating_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[6];
            Random rng = new Random(Guid.NewGuid().GetHashCode());
            string resault = "樂透號碼：\r\n";

            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    numbers[i] = rng.Next() % 49 + 1;
                }
                while (Repeated(i));

                resault += " " + numbers[i];
            }

            textbox_resault.Text = resault;

            bool Repeated(int n)
            {
                if (n == 0) return false;

                for (int i = 0; i < n; i++)
                {
                    if (numbers[i] == numbers[n]) return true;
                }

                return false;
            }

        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            try
            {
                int from = int.Parse(textbox_from.Text);
                int to = int.Parse(textbox_to.Text);
                int step = int.Parse(textbox_step.Text);
                int total = 0;

                for (int i = from; i <= to; i += step) total += i;

                textbox_resault.Text = $"{from} 到 {to} 相隔 {step - 1}\r\n加總為 {total}";
            }
            catch
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btn_while_Click(object sender, EventArgs e)
        {
            try
            {
                int from = int.Parse(textbox_from.Text);
                int to = int.Parse(textbox_to.Text);
                int step = int.Parse(textbox_step.Text);
                int total = 0;

                while (from <= to)
                {
                    total += from;
                    from += step;
                }

                textbox_resault.Text = $"{textbox_from.Text} 到 {to} 相隔 {step - 1}\r\n加總為 {total}";
            }
            catch
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btn_do_Click(object sender, EventArgs e)
        {
            try
            {
                int from = int.Parse(textbox_from.Text);
                int to = int.Parse(textbox_to.Text);
                int step = int.Parse(textbox_step.Text);
                int total = 0;

                do
                {
                    total += from;
                    from += step;
                }
                while (from <= to);

                textbox_resault.Text = $"{textbox_from.Text} 到 {to} 相隔 {step - 1}\r\n加總為 {total}";
            }
            catch
            {
                MessageBox.Show("請輸入數值");
            }
        } 

        #endregion
    }
}
