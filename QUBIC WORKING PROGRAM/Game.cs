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
        Move AIMoveHold = new Move();

        public Game()
        {
            Console.WriteLine("x");

            p = new Player[2];
            p[0] = new HumanPlayer();
            p[1] = new HumanPlayer();
            turn = 0;

        }

        public Boolean validmove(Move checkedMove)
        {
            return board.validmove(checkedMove);
        }
        public Boolean checkwin(Move checkMove)
        {
            return board.checkwin(checkMove, turn %2);
        }

        //check the type of current player, give the form the correct colour player, check move is valid, plot if valid
        public int checkplayer(Move location)
        {
            if (p[turn % 2].move(board) == 1)
            {
                Console.WriteLine("Human Player");
                if (board.validmove(location))
                {
                    board.plotpiece(location, turn %    2);
                    turn++;  //increment turn after valid human move
                }


            }
            else
            {
                AIMoveHold = p[turn % 2].minimax(board);
                board.plotpiece(AIMoveHold, turn % 2);
                Console.WriteLine("AI Player");
                turn++; //increment turn after AI move
            }
            return (turn-1) % 2;
        }



        public Move checkplayer()
        {
            if (p[turn % 2].move(board) == 1)
            {
                return null;
            }
            else
            {
                return AIMoveHold;
            }

        }

    }
}
