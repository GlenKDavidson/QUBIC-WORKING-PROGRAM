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
        Boolean gametype;
        Move humanmove = new Move();
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
                gametype = false;
            }
            else
            {
                p[1] = new AIPlayer();
                gametype = true;
            }
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
            Boolean check = board.validmove(checkedMove);
            humanmove = board.getlastmove();
            return check;
        }
        public Boolean checkwin(Move checkMove)
        {
            return board.checkwin(checkMove,turn % 2);
        }
        public int actingplayer()
        {
            return turn % 2;
        }

        public Boolean getGametype()
        {
            return gametype;
        }

        //check the type of current player, give the form the correct colour player, check move is valid, plot if valid
        public void makemove()
        {

            if (gametype && actingplayer() == 1)
            {
                p[actingplayer()].move(board, this);
                turn++;
            }
            else if (!gametype || (actingplayer() != 1))
            {
                if (board.validmove(humanmove))
                {
                    
                    p[actingplayer()].move(board, this);
                    turn++;
                }
            }
        }

        public Move getlocation()
        {
            return humanmove;
        }
        public void setAIMove(Move move)
        {
            AIMoveHold = move;
        }
        public Move getaimove()
        {
            return AIMoveHold;
        }

        
          
        
    }
}
