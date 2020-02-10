using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUBIC_WORKING_PROGRAM
{
    class AIPlayer : Player
    {
        Random rnd = new Random();



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
            Boolean nowin = false;
            for (int x = 1; x < 4; x++)
            {
                for (int y = 1; y < 4; y++)
                {
                    for (int z = 1; z < 4; z++)
                    {
                        tester.x = x;
                        tester.y = y;
                        tester.z = z;
                        testee.plotpiece(tester, 1);
                        if (testee.checkwin(tester, 1))
                        {
                            optimal = tester;
                            nowin = false;
                        }
                        else
                        {
                            nowin = true;
                        }

                    }
                }
            }
            while (nowin)
            {

                optimal.x = rnd.Next(1, 4);
                optimal.y = rnd.Next(1, 4);
                optimal.z = rnd.Next(1, 4);

                if (testee.validmove(optimal))
                {
                    break;
                }

            }
            optimal.x = 2;
            optimal.y = 2;
            optimal.z = 2;
            return optimal;
        }

    }
}
