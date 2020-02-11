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

        Board board;


        Move AIMoveHold = new Move();

        public Game(int a)
        {
            Console.WriteLine("x");
            board = new Board();
            p = new Player[2];
            p[0] = new HumanPlayer();
            if (a == 1)
            {
                p[1] = new HumanPlayer();
            }
            else p[1] = new AIPlayer();
            turn = 0;

        }
        public Move getlastmove()
        {
            return board.getlastmove();
        }

        public Boolean validmove(Move checkedMove)
        {
            if (checkedMove.x == -1)
            {
                return false;
            }
            return board.validmove(checkedMove);
        }
        public Boolean checkwin(Move checkMove)
        {
            return board.checkwin(checkMove, AIMoveHold, turn % 2);
        }

        //check the type of current player, give the form the correct colour player, check move is valid, plot if valid
        public int checkplayer(Move location)
        {
            if (p[turn % 2].move(board) == 1)
            {

                if (board.validmove(location))
                {
                    board.plotpiece(location, turn % 2);
                    turn++;  //increment turn after valid human move
                }


            }
            else
            {
                AIMoveHold = p[turn % 2].minimax(board);
                board.plotpiece(AIMoveHold, turn % 2);

                turn++; //increment turn after AI move
            }
            return (turn - 1) % 2;
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
