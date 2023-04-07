using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_homework1
{
    internal class tic_optimal_play
    {
        private int[] board ;
        private int step_count = 0;

        public tic_optimal_play()
        {
            this.board = new int[9];
        }

        public void SetBoard( int[] board )
        {

            for (int i = 0; i < 9; i++)
            {
                this.board[i] = board[i];
            }

            step_count = 0;

            foreach (int block in this.board)
            {
                if (block != 0)
                {
                    step_count++;
                }
            }
        }

        public int GetOptimalMove() 
        {

            int best_result;
            int beststep = -1;

            if (step_count % 2 != 0)
            {
                best_result = 100;

                for (int i = 0; i < 9; i++)
                {
                    if (board[i] == 0)
                    {
                        board[i] = -1;

                        int estimateresult = WinEstimate(board, step_count + 1);                        

                        if (estimateresult < best_result)
                        {
                            best_result = estimateresult;
                            beststep = i;
                        }

                        board[i] = 0;

                        if (estimateresult == -1)
                        {
                            return i;
                        }
                    }
                }

            }
            else
            {
                best_result = -100;

                for (int i = 0; i < 9; i++)
                {
                    if (board[i] == 0)
                    {
                        board[i] = 1;

                        int estimateresult = WinEstimate(board, step_count + 1);

                        if (estimateresult > best_result)
                        {
                            best_result = estimateresult;
                            beststep = i;
                        }

                        board[i] = 0;

                        if (best_result == 1)
                        {
                            return i;
                        }
                    }
                }              
                
            }

            return beststep;

        }


        private int WinEstimate(int[] board, int step)
        {

            int status = CheckWhoWin(board);

            if(status != 0)
            {
                return status;
            }
            else if (step >= 9)
            {
                return 0;
            }

            int best_result;
            
            if (step % 2 != 0)
            {
                best_result = 100;

                for (int i = 0; i < 9; i++)
                {
                    if (board[i] == 0)
                    {
                        board[i] = -1;

                        int estimateresult = WinEstimate(board, step + 1);

                        if (estimateresult < best_result)
                        {
                            best_result = estimateresult;
                        }

                        board[i] = 0;

                        if (best_result == -1)
                        {
                            return -1;
                        }
                    }
                }

            }
            else
            {
                best_result = -100;

                for (int i = 0; i < 9; i++)
                {
                    if (board[i] == 0)
                    {
                        board[i] = 1;

                        int estimateresult = WinEstimate(board, step + 1);

                        if (estimateresult > best_result)
                        {
                            best_result = estimateresult;
                        }

                        board[i] = 0;

                        if (best_result == 1)
                        {
                            return 1;
                        }
                    }
                }
            }

            return best_result;

        }



        private int CheckWhoWin(int[] board) 
        {
            int linesum;
            
            for(int i =0; i <9; i+=3)
            {
                linesum = board[i] + board[i + 1] + board[i + 2];

                if (Math.Abs(linesum) == 3)
                {
                    return linesum / 3;
                }
            }
            
            for(int i =0 ; i <3 ; i++ )
            {
                linesum = board[i] + board[i+3] + board[i+6];

                if (Math.Abs(linesum) == 3)
                {
                    return linesum / 3;
                }
            }

            linesum = board[0] + board[4] + board[8] ;

            if (Math.Abs(linesum) == 3)
            {
                return linesum / 3;
            }

            linesum = board[2] + board[4] + board[6] ;

            if (Math.Abs(linesum) == 3)
            {
                return linesum / 3;
            }

            return 0;
        }


    }









}
