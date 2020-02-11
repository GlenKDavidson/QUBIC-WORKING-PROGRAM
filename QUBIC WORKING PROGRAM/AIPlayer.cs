using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUBIC_WORKING_PROGRAM
{
    class AIPlayer : Player
    {



        public override int move(Board board)
        {
            Console.WriteLine("aiplayer");
            return 2;
        }

        public override Move minimax(Board board)
        {
            Board testee = new Board();
            testee = board;
            Move optimal = new Move();
            optimal.x = -1;
            optimal.y = -1;
            optimal.z = -1;
            Move tester = new Move();
            Boolean nowin = true;

            //for (int x = 1; x < 4; x++)
            //{
            //    for (int y = 1; y < 4; y++)
            //    {
            //        for (int z = 1; z < 4; z++)
            //        {
            //            tester.x = x;
            //            tester.y = y;
            //            tester.z = z;
            //            testee.plotpiece(tester, 1);
            //            if (testee.checkwin(tester, tester, 1))
            //            {
            //                Console.WriteLine("Winning move found");
            //                return tester;
            //            }
            //            else
            //            {
            //                nowin = true;
            //            }

            //        }
            //    }
            //}
            //Random rnd = new Random();

            //int counter = 0;
            //while (counter < 20)
            //{
            //    counter++;

            //    optimal.x = rnd.Next(1, 4);
            //    optimal.y = rnd.Next(1, 4);
            //    optimal.z = rnd.Next(1, 4);
            //    if (testee.validmove(optimal))
            //    {
            //        Console.WriteLine("Random Move Found");
            //        return optimal;
            //    }
            //}
            //Console.WriteLine("Random move not found");

            optimal.z = 4;
            for (int x = 1; x < 5; x++)
            {
                for (int y = 1; y < 5; y++)
                {
                    
                        optimal.x = x;
                        optimal.y = y;
                        
                        if (testee.validmove(optimal))
                        {
                            Console.WriteLine("Forced move found");
                            return optimal;
                        }
                    
                }
            }
            return optimal;
        }

    }
}
