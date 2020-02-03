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
            Move optimal = new Move();
            optimal.x = -1;
            optimal.y = -1;
            optimal.z = -1;
            Move tester = new Move();

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        tester.x = x;
                        tester.y = y;
                        tester.z = z;
                        board.plotpiece(tester, 1);
                        if (board.checkwin(tester, 1))
                        {
                            optimal = tester;
                        }

                    }
                }
            }
            while (true)
            {
                if (optimal.x == -1)
                {
                    optimal.x = rnd.Next(0, 3);
                    optimal.y = rnd.Next(0, 3);
                    optimal.z = rnd.Next(0, 3);
                }
                if (board.validmove(optimal))
                {
                    break;
                }

            }
            return optimal;
        }

    }
}
