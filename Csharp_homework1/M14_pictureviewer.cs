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
    public partial class form_M14_pictureviewer : Form
    {
        public form_M14_pictureviewer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            form_M14a_showimage m14a = new form_M14a_showimage(pictureBox1.Image);
            m14a.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            form_M14a_showimage m14a = new form_M14a_showimage(pictureBox2.Image);
            m14a.Show();
        }
                
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            form_M14a_showimage m14a = new form_M14a_showimage(pictureBox3.Image);
            m14a.Show();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            form_M14a_showimage m14a = new form_M14a_showimage(pictureBox4.Image);
            m14a.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            form_M14a_showimage m14a = new form_M14a_showimage(pictureBox5.Image);
            m14a.Show();
        }
    }
}
