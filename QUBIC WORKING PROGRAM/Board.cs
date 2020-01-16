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
        int turns = 0;
        public Board()
        {
            playfield = new int[4, 4, 4];
            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 4; y++)
                    for (int z = 0; z < 4; z++)

                        playfield[x, y, z] = 0;


        }





        public int turncount(int turns)
        {
            return turns++;
        }
        public Boolean checkwin()
        {
            return true;
        }

        public void plotpiece(int x, int y, int z, int whichplayer)
        {
            if (whichplayer % 2 == 1)
            {

                playfield[x, y, z] = 15;
            }
            else
            {
                playfield[x, y, z] = 1;
            }

        }
    }

}
