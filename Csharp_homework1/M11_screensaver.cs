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
    
    public partial class M11_screensaver : Form
    {

        private readonly int screenWidth;
        private readonly int screenHeight;
       
        Bitmap[] bitmapgroup;

        private int x = 0;
        private int y = 0;
        private int last_x;
        private int last_y;

        private int rotation = 0;

        public M11_screensaver()
        {
            InitializeComponent();

            Rectangle rect = Screen.PrimaryScreen.Bounds;
            screenWidth = rect.Width;
            screenHeight = rect.Height;

            
            bitmapgroup = new Bitmap[7];
            
            string[] filepaths = { @"resource\punch0a.jpg" , @"resource\punch0b.jpg" , @"resource\punch1.jpg",
            @"resource\punch2.jpg",@"resource\punch3.jpg",@"resource\punch4.jpg",@"resource\punch5.jpg"};
            
            for(int i = 0; i < filepaths.Length; i++) 
            {
                bitmapgroup[i] = new Bitmap(filepaths[i]);
            }

            y = screenHeight - bitmapgroup[0].Height;

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
            e.Graphics.DrawImage(bitmapgroup[rotation], x, y, bitmapgroup[rotation].Width, bitmapgroup[rotation].Height);
        }


        private void ChangeRotation()
        {
            rotation = rotation>=6 ?  2 : rotation+1 ;            
        }
        private void ChangePosition(Bitmap bitmap)
        {
            x += 50;
            y -= 100;

            if (x  > screenWidth)
            {
                x = -bitmap.Width;
            }
            if (y  < - bitmap.Height )
            {
                y = screenHeight ;
            }
        }

        
    }
}
