using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUBIC_WORKING_PROGRAM
{
    class Game
    {
        Board board;
        Player[] p;
        int turn;


        public Game()
        {
            board = new Board();
            p = new Player[2];
            p[0] = new HumanPlayer();
            p[1] = new HumanPlayer();
            turn = 1;
        }


        public void checkplayer() {
            board.plotpiece(p[turn % 2].move(), turn%2);
        }

        public void start()
        {
             int moveCount = 0;
            while (true)
            {
                p[moveCount++ % 2].move();
                Console.WriteLine(moveCount);

            }
        }
    }
}


