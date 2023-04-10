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
    
    public partial class form_M11_screensaver : Form
    {

        private readonly int screenWidth;
        private readonly int screenHeight;
       
        Bitmap[] bitmapgroup;

        private int bitmap_x = 0;
        private int bitmap_y = 0;
        private int mouse_last_x;
        private int mouse_last_y;

        private int rotation = 0;

        public form_M11_screensaver()
        {
            InitializeComponent();

            Rectangle rect = Screen.PrimaryScreen.Bounds;
            screenWidth = rect.Width;
            screenHeight = rect.Height;
            
            bitmapgroup = new Bitmap[7];

            bitmapgroup[0] = Properties.Resources.punch0a;
            bitmapgroup[1] = Properties.Resources.punch0b;
            bitmapgroup[2] = Properties.Resources.punch1;
            bitmapgroup[3] = Properties.Resources.punch2;
            bitmapgroup[4] = Properties.Resources.punch3;
            bitmapgroup[5] = Properties.Resources.punch4;
            bitmapgroup[6] = Properties.Resources.punch5;

            bitmap_y = screenHeight - bitmapgroup[0].Height;

            mouse_last_x = Cursor.Position.X;
            mouse_last_y = Cursor.Position.Y;

        }

        private void M11_screensaver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void M11_screensaver_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeRotation();
            ChangePosition(bitmapgroup[rotation]);

            this.Invalidate();
            
        }

        private void M11_screensaver_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmapgroup[rotation], bitmap_x, bitmap_y, bitmapgroup[rotation].Width, bitmapgroup[rotation].Height);
        }


        private void ChangeRotation()
        {
            rotation = rotation>=6 ?  2 : rotation+1 ;            
        }
        private void ChangePosition(Bitmap bitmap)
        {
            bitmap_x += 50;
            bitmap_y -= 100;

            if (bitmap_x  > screenWidth)
            {
                bitmap_x = -bitmap.Width;
            }
            if (bitmap_y  < - bitmap.Height )
            {
                bitmap_y = screenHeight ;
            }
        }

        private void M11_screensaver_MouseMove(object sender, MouseEventArgs e)
        {
            if(  Math.Abs(mouse_last_x-e.X)>10 || Math.Abs(mouse_last_y-e.Y)>10)
            {
                this.Close ();
            }
        }
    }
}
