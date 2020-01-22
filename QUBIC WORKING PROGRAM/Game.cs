using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUBIC_WORKING_PROGRAM
{
    class Game
    {

        Player[] p;
        int turn;



        static Board board = new Board();

        public Game()
        {
            Console.WriteLine("x");

            p = new Player[2];
            p[0] = new HumanPlayer();
            p[1] = new HumanPlayer();
            turn = 0;

        }

        public Boolean checkwin()
        {
            return board.checkwin();
        }

        public void checkplayer(Move location)
        {
            if (p[turn % 2].move(board) == 1)
            {
                Console.WriteLine("Human Player");
            }
            else
            {
                Console.WriteLine("AI Player");
            }

        }


    }
}
