using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUBIC_WORKING_PROGRAM
{
    class AIPlayer : Player
    {



        public override void move(Board board, Game qubic)
        {
            Move aiMove = new Move();
            Console.WriteLine("aiplayer");
            aiMove = minimax(board, qubic);
            qubic.setAIMove(aiMove);

            board.plotpiece(aiMove, qubic.actingplayer());

        }


        public Move minimax(Board board, Game qubic)
        {


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

                            board.plotpiece(tester, 0);

                            board.reset(tester, 0);
                            
                            if (board.checkwin(tester, 1))
                            {
                                board.reset(tester, 1);
                                Console.WriteLine("Winning move countered");
                                heuristic = 5;
                            }


                            board.plotpiece(tester, 1);
                            board.reset(tester, 1);
                            if (board.checkwin(tester, 0))
                            {

                                Console.WriteLine("Winning move found");
                                heuristic = 10;
                            }
                            if (heuristic == 10) {
                                return tester;
                            }
                           
                        }
                    }
                }
            }
            if (heuristic != 0) {
                return tester;
            }
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


            for (int z = 1; z < 5; z++)
            {
                for (int x = 1; x < 5; x++)
                {
                    for (int y = 1; y < 5; y++)
                    {

                        optimal.x = x;
                        optimal.y = y;

                        if (board.validmove(optimal))
                        {
                            Console.WriteLine("Forced move found");
                            return optimal;
                        }

                    }
                }
            }
            return optimal;
        }

    }
}
