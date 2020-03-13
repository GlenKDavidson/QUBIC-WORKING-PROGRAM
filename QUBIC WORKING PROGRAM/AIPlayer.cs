using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUBIC_WORKING_PROGRAM
{
    class AIPlayer : Player
    {

        int[,,] movesToCheck;
        

        public override void move(Board board, Game qubic)
        {
            Move aiMove = new Move();
            Console.WriteLine("aiplayer");
            aiMove = minimax(board, qubic);
            qubic.setAIMove(aiMove);

            board.plotpiece(aiMove, qubic.actingplayer());
            incrementTurns();
        }

        public void addToCheckArray(Move move)
        {
        }

        public Move minimax(Board board, Game qubic)
        {

            if (getTurns() == 0)
            {

            }

            Move optimal = new Move();
            optimal.x = -1;
            optimal.y = -1;
            optimal.z = -1;
            Move tester = new Move();
            Boolean nowin = true;
            int heuristic = 0;

            for (int x = 1; x < 5; x++)
            {
                for (int y = 1; y < 5; y++)
                {
                    for (int z = 1; z < 5; z++)
                    {
                        Console.WriteLine(x);
                        Console.WriteLine(y);
                        Console.WriteLine(z);
                        tester.x = x;
                        tester.y = y;
                        tester.z = z;
                        if (board.validmove(tester))
                        {
                            board.plotpiece(tester, 1);
                            if (board.checkwin(tester, 0))
                            {
                                board.reset(tester, 1);
                                Console.WriteLine("Winning move found");
                                heuristic = 10;
                                return tester;
                            }

                            board.reset(tester, 1);
                            board.plotpiece(tester, 0);
                            if (board.checkwin(tester, 1))
                            {
                                board.reset(tester, 0);
                                Console.WriteLine("Winning move countered");
                                heuristic = 5;
                                optimal.x = tester.x;
                                optimal.y = tester.y;
                                optimal.z = tester.z;

                            }
                            board.reset(tester, 0);

                        }
                    }
                }
            }


            if (heuristic == 5)
            {
                return optimal;
            }
            //first move in corner
            if (getTurns() < 5)
            {
                optimal.x = 3;
                optimal.y = 3;
                optimal.z = 3;
                if (board.validmove(optimal))
                {
                    return optimal;
                }
                optimal.x = 3;
                optimal.y = 0;
                optimal.z = 3;
                if (board.validmove(optimal))
                {
                    return optimal;
                }
                optimal.x = 0;
                optimal.y = 0;
                optimal.z = 3;
                if (board.validmove(optimal))
                {
                    return optimal;
                }
                optimal.x = 0;
                optimal.y = 3;
                optimal.z = 3;
                if (board.validmove(optimal))
                {
                    return optimal;
                }
                optimal.x = 0;
                optimal.y = 0;
                optimal.z = 0;
                if (board.validmove(optimal))
                {
                    return optimal;
                }
                optimal.x = 0;
                optimal.y = 3;
                optimal.z = 0;
                if (board.validmove(optimal))
                {
                    return optimal;
                }
                optimal.x = 3;
                optimal.y = 3;
                optimal.z = 0;
                if (board.validmove(optimal))
                {
                    return optimal;
                }
                optimal.x = 3;
                optimal.y = 0;
                optimal.z = 3;
                if (board.validmove(optimal))
                {
                    return optimal;
                }
            }

            //move adjacent to itself

            //random move
            Random rnd = new Random();
            int counter = 0;
            while (counter < 20)
            {
                counter++;

                optimal.x = rnd.Next(1, 5);
                optimal.y = rnd.Next(1, 5);
                optimal.z = rnd.Next(1, 5);
                if (board.validmove(optimal))
                {
                    Console.WriteLine("Random Move Found");
                    return optimal;
                }
            }
            Console.WriteLine("Random move not found");



            return optimal;
        }

    }
}
