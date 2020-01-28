using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUBIC_WORKING_PROGRAM
{
    class Board
    {

        int[,,] playfield;
        int[,] piecesOnEachBoard;

        public Board()
        {
            playfield = new int[4, 4, 4];
            piecesOnEachBoard = new int[4, 4];
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    piecesOnEachBoard[x, y] = 0;
                    for (int z = 0; z < 4; z++)
                    {
                        playfield[x, y, z] = 0;
                    }
                }
            }

        }





        public Boolean checkwin(Move checkedmove, int cplayer)
        {

            Boolean validSame = false;
            Boolean validAcross = false;
            

            //  if (piecesOnEachBoard[cplayer, checkedmove.z - 1] >= 3)
            // {
            validSame = true;
            //  }
            //  if ((piecesOnEachBoard[cplayer, 0] >= 1) && (piecesOnEachBoard[cplayer, 1] >= 1) && (piecesOnEachBoard[cplayer, 2] >= 1) && (piecesOnEachBoard[cplayer, 3] >= 1))
            //  {
            validAcross = true;
            //}


            //check same x
            if (validSame)
            {
                
                for (int x = 0; x < 4; x++)
                {
                    playfield[x,checkedmove.y - 1,  checkedmove.z - 1];
                }
                
            }
            //check same y
            if (validSame)
            {
                int winningmove = 0;
                for (int x = 0; x < 4; x++)
                {
                    winningmove += playfield[checkedmove.x - 1, x, checkedmove.z - 1];
                    if (winningmove % criticalValue != 0)
                    {
                        Console.WriteLine("X:" + x + "Total number" + winningmove);
                        Console.WriteLine("LOOP BROKEN");
                        break;
                    }
                    Console.WriteLine("Total number" + winningmove);
                    if (winningmove == (4 * criticalValue))
                    {
                        Console.WriteLine(criticalValue);
                        return true;
                    }
                }

            }
            //check same z
            if (validAcross)
            {
                int winningmove = 0;
                for (int x = 0; x < 4; x++)
                {
                    winningmove += playfield[checkedmove.x - 1, checkedmove.y - 1, x];
                    if (winningmove % criticalValue != 0)
                    {
                        Console.WriteLine("X:" + x + "Total number" + winningmove);
                        Console.WriteLine("LOOP BROKEN");
                        break;
                    }
                    Console.WriteLine("Total number" + winningmove);
                    if (winningmove == (4 * criticalValue))
                    {
                        Console.WriteLine(criticalValue);
                        return true;
                    }
                }

            }
            //check one board diagonal
            if (validSame)
            {
                int winningmove = 0;
                for (int x = 0; x < 4; x++)
                {

                }
            }
            //check four boards same x diagonal
            if (validAcross)
            {
                int winningmove = 0;
                for (int x = 0; x < 4; x++)
                {

                }
            }
            //check four boards same y diagonal
            if (validAcross)
            {
                int winningmove = 0;
                for (int x = 0; x < 4; x++)
                {

                }
            }
            //check four boards full diagonal
            if (validAcross)
            {
                int winningmove = 0;
                for (int x = 0; x < 4; x++)
                {
                }
            }


            return false;
        }

        public Boolean validmove(Move checkedmove)
        {
            if (playfield[checkedmove.x - 1, checkedmove.y - 1, checkedmove.z - 1] != 0)
            {
                Console.WriteLine("INVALID");
                return false;
            }
            else
            {
                Console.WriteLine("VALID");
                return true;
            }
        }

        public void plotpiece(Move move, int cplayer)
        {
            if (cplayer == 1)
            {

                playfield[move.x - 1, move.y - 1, move.z - 1] = 2;
                piecesOnEachBoard[cplayer, move.z - 1]++;

            }
            else
            {

                playfield[move.x - 1, move.y - 1, move.z - 1] = 1;
                piecesOnEachBoard[cplayer, move.z - 1]++;

            }

        }


    }


}
