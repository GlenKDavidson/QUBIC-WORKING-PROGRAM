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

        public override Move minimax(Board board) {
            Move optimal = new Move();
            optimal.x = 1;
            optimal.y = 2;
            optimal.z = 3;

            return optimal;
        }

      }
    }
