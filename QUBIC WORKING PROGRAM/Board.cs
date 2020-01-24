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

        public Board()
        {
            playfield = new int[4, 4, 4];

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    for (int z = 0; z < 4; z++)
                    {
                        playfield[x, y, z] = 0;
                    }
                }
            }
        }




        public Boolean checkwin()
        {
            return true;
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

                playfield[move.x - 1, move.y - 1, move.z - 1] = 15;
            }
            else
            {
                playfield[move.x - 1, move.y - 1, move.z - 1] = 1;
            }

        }


    }


}
