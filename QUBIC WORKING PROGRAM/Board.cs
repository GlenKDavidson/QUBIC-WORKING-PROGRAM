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
        Move lastmove = null;
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

        public Move getlastmove()
        {
            return lastmove;
        }

        public Boolean checkwin(Move checkedmove, int cplayer)
        {
            int y = 0;
            Boolean validSame = false;
            Boolean validAcross = false;
            validSame = true;
            validAcross = true;

            if (cplayer == 0)
            {
                cplayer = 2;
            }
            else
            {
                cplayer = 1;
            }

            //check same y,z different x
            Boolean winning = true;
            if (validSame)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (!(playfield[x, checkedmove.y - 1, checkedmove.z - 1] == cplayer))
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        Console.WriteLine("SAME Y Z ");
                        return true;
                    }

                }
            }

            //check same x,z different y
            winning = true;
            if (validSame)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (!(playfield[checkedmove.x - 1, x, checkedmove.z - 1] == cplayer))
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        Console.WriteLine("SAME X Z");
                        return true;
                    }

                }
            }

            //check same x,y different z
            winning = true;
            if (validSame)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (!(playfield[checkedmove.x - 1, checkedmove.y - 1, x] == cplayer))
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        Console.WriteLine("SAME X Y");
                        return true;
                    }

                }
            }

            //check positive diagonal one board
            winning = true;
            if (validSame)
            {

                for (int x = 0; x < 4; x++)
                {
                    if (!(playfield[x, x, checkedmove.z - 1] == cplayer))
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        Console.WriteLine("DIAGONAL BOTTOM LEFT TO TOP RIGHT");
                        return true;
                    }

                }
            }

            //check negative diagonal one board
            winning = true;
            if (validSame)
            {
                for (int x = 0; x < 4; x++)
                {

                    if (!(playfield[x, 3 - x, checkedmove.z - 1] == cplayer))
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        Console.WriteLine("DIAGONAL TOP LEFT TO BOTTOM RIGHT");
                        return true;
                    }

                }
            }

            //check 4 boards positve diagonal from bottom left
            winning = true;
            if (validSame)
            {
                for (int x = 0; x < 4; x++)
                {

                    if (!(playfield[x, x, x] == cplayer))
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        Console.WriteLine("DIAGONAL ACROSS ALL BOARDS");
                        return true;
                    }

                }
            }

            //check 4 boards positve diagonal from top left
            winning = true;
            if (validSame)
            {
                for (int x = 0; x < 4; x++)
                {

                    if (!(playfield[x, 3 - x, x] == cplayer))
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        Console.WriteLine("DIAGONAL ACROSS ALL BOARDS");
                        return true;
                    }

                }
            }

            //check 4 boards negative diagonal from top right
            winning = true;
            if (validSame)
            {
                for (int x = 0; x < 4; x++)
                {

                    if (!(playfield[3 - x, 3 - x, x] == cplayer))
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        Console.WriteLine("DIAGONAL ACROSS ALL BOARDS");
                        return true;
                    }

                }
            }

            //check 4 boards negative diagonal from bottom right
            winning = true;
            if (validSame)
            {
                for (int x = 0; x < 4; x++)
                {

                    if (!(playfield[3 - x, x, x] == cplayer))
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        Console.WriteLine("DIAGONAL ACROSS ALL BOARDS");
                        return true;
                    }

                }
            }

            winning = true;
            //check same y different x,z - up boards
            if (validSame)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (!(playfield[x, checkedmove.y - 1, x] == cplayer))
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        Console.WriteLine("SAME Y Z ");
                        return true;
                    }

                }
            }

            winning = true;
            //check same y different x,z - down boards
            if (validSame)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (!(playfield[x, checkedmove.y - 1, 3 - x] == cplayer))
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        Console.WriteLine("SAME Y Z ");
                        return true;
                    }

                }
            }

            winning = true;
            //check same x different y,z - up boards
            if (validSame)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (!(playfield[checkedmove.x - 1, x, x] == cplayer))
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        Console.WriteLine("SAME Y Z ");
                        return true;
                    }

                }
            }

            winning = true;
            //check same x different y,z - down boards
            if (validSame)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (!(playfield[checkedmove.x - 1, x, 3 - x] == cplayer))
                    {
                        winning = false;
                        break;
                    }
                    if ((x == 3) && (winning == true))
                    {
                        Console.WriteLine("SAME Y Z ");
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
                

                lastmove = move;
            }
            else
            {

                playfield[move.x - 1, move.y - 1, move.z - 1] = 1;
                piecesOnEachBoard[cplayer, move.z - 1]++;
                lastmove = move;
            }

        }


    }


}
