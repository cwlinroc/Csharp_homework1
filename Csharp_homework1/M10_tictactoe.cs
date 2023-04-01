using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_homework1
{
    public partial class M10_tictactoe : Form
    {

        private int[] boardstatus = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private string [] mark = { "", "O", "X" };
        private int turnplayer = 1;
        private int stepcount = 0;

        public M10_tictactoe()
        {
            InitializeComponent();
        }

        private void btn_block0_Click(object sender, EventArgs e)
        {
            ImplementStep(0, btn_block0);
        }
        private void btn_block1_Click(object sender, EventArgs e)
        {
            ImplementStep(1, btn_block1);
        }

        private void btn_block2_Click(object sender, EventArgs e)
        {
            ImplementStep(2, btn_block2);
        }

        private void btn_block3_Click(object sender, EventArgs e)
        {
            ImplementStep(3, btn_block3);
        }

        private void btn_block4_Click(object sender, EventArgs e)
        {
            ImplementStep(4, btn_block4);
        }

        private void btn_block5_Click(object sender, EventArgs e)
        {
            ImplementStep(5, btn_block5);
        }

        private void btn_block6_Click(object sender, EventArgs e)
        {
            ImplementStep(6, btn_block6);
        }

        private void btn_block7_Click(object sender, EventArgs e)
        {
            ImplementStep(7, btn_block7);
        }

        private void btn_block8_Click(object sender, EventArgs e)
        {
            ImplementStep(8, btn_block8);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetBoard();
        }
        

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void M10_tictactoe_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.R) 
            {
                btn_reset.PerformClick();
            }

            if(e.KeyCode == Keys.Escape)
            {
                btn_exit.PerformClick();
            }
        }



        private void ImplementStep(int step ,Button btn)
        {
            boardstatus[step] = turnplayer;
            stepcount++;

            ChangeButtonStatus(btn);
            ChangeTurnPlayer();

            int winner = CheckWhoWins();

            if (winner != 0)
            {
                ShowWinner(winner);
            }

            CheckDraw();
        }

        private void ChangeButtonStatus(Button btn)
        {
            btn.Enabled= false;
            btn.Text = mark[turnplayer];
        }

        private void ChangeTurnPlayer()
        {
            turnplayer %= 2;
            turnplayer += 1;
        }

        private int CheckWhoWins()
        {

            for(int i = 0; i<9 ; i+=3)
            {
                if (boardstatus[i] == boardstatus[i + 1] && boardstatus[i + 1] == boardstatus[i + 2]
                        && boardstatus[i] != 0)
                {
                    return boardstatus[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (boardstatus[i] == boardstatus[i + 3] && boardstatus[i + 3] == boardstatus[i + 6]
                        && boardstatus[i] != 0)
                {
                    return boardstatus[i];
                }
            }

            if (boardstatus[0] == boardstatus[4] && boardstatus[4] == boardstatus[8]
                        && boardstatus[0] != 0)
            {
                return boardstatus[0];
            }

            if (boardstatus[2] == boardstatus[4] && boardstatus[4] == boardstatus[6]
                        && boardstatus[2] != 0)
            {
                return boardstatus[2];
            }

            return 0;
        }

        private void ShowWinner(int winner)
        {
            MessageBox.Show($"{mark[winner]}手獲勝!", "完局");
            ResetBoard();
        }

        private void CheckDraw()
        {
            if(stepcount == 9)
            {
                MessageBox.Show("平手!按下確定重新開始", "完局");
                ResetBoard();
            }
        }

        private void ResetBoard()
        {
            for(int i=0; i <9 ; i++)
            {
                boardstatus[i] = 0;
            }

            RefreshButton(btn_block0);
            RefreshButton(btn_block1);
            RefreshButton(btn_block2);
            RefreshButton(btn_block3);
            RefreshButton(btn_block4);
            RefreshButton(btn_block5);
            RefreshButton(btn_block6);
            RefreshButton(btn_block7);
            RefreshButton(btn_block8);

            stepcount = 0;
            turnplayer = 1;

        }
        private void RefreshButton(Button btn)
        {
            btn.Enabled = true;
            btn.Text = "";
        }

        
    }
}
