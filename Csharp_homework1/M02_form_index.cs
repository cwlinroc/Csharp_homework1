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
    public partial class M02_form_index : Form
    {
        public M02_form_index()
        {
            InitializeComponent();
        }

        private void button_showhelloform_Click(object sender, EventArgs e)
        {
            clicked_times++;
            M01_form_hello m01 = new M01_form_hello();
            m01.Show();
        }

        private void btn_show_clicked_Click(object sender, EventArgs e)
        {
            clicked_times++;
            show_clicked_times();
        }

        int clicked_times = 0;

        void show_clicked_times()
        {
            string message  = "一共按了" + clicked_times + "次";
            MessageBox.Show(message);
        }


    }
}
