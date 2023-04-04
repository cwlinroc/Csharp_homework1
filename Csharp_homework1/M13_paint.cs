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
    public partial class M13_paint : Form
    {
        
        private int x0, y0;
        private Color pencolor = Color.Black;
        private int pensize = 1; 

        
        
        public M13_paint()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(1000, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        

        private void trackBar_penwidth_ValueChanged(object sender, EventArgs e)
        {
            label_trackbarvalue.Text = trackBar_penwidth.Value.ToString();
            pensize = trackBar_penwidth.Value;
        }

        private void btn_changecolor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                btn_showcolor.BackColor = colorDialog.Color;
                pencolor = colorDialog.Color;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                
                Pen pen = new Pen(pencolor, pensize);
                g.DrawLine(pen, x0, y0, e.X, e.Y);
                
                x0 = e.X;
                y0 = e.Y;

                pictureBox1.Refresh();
            }
                        
        }
    }
}
