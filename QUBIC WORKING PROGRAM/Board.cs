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
            validSame = true;
            validAcross = true;
            Boolean winning = true;

            if (cplayer == 0)
            {
                cplayer = 2;
            }
            else
            {
                cplayer = 1;
            }



            //check same x
            if (validSame)
            {

                for (int x = 0; x < 4; x++)
                {
                    if (playfield[x, checkedmove.y - 1, checkedmove.z - 1] == cplayer)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        return true;
                    }

                }
            }
            winning = true;
            //check same y
            if (validSame)
            {

                for (int x = 0; x < 4; x++)
                {
                    if (playfield[checkedmove.x - 1, x, checkedmove.z - 1] == cplayer)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        return true;
                    }

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
