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
    public partial class M01_form_hello : Form
    {
        public M01_form_hello()
        {
            InitializeComponent();
        }

        private void btn_say_hi_Click(object sender, EventArgs e)
        {
            string name = text_name.Text;
            string english_name = text_english_name.Text;
            string gender = text_gender.Text;
            string constellation=text_constellation.Text;
            string combined_message = "Hi," + constellation + "的" + name + "\n" + english_name + "的性別設定為" + gender;

            MessageBox.Show(combined_message);


        }

        private void btn_say_hello_Click(object sender, EventArgs e)
        {
            string name = text_name.Text;
            string english_name = text_english_name.Text;
            string gender = text_gender.Text;
            string constellation = text_constellation.Text;
            string combined_message = "Hello," + constellation + "s" + name + "\n" + english_name + "s gender is set as" + gender;

            MessageBox.Show(combined_message);
        }
    }
}
