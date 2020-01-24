using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUBIC_WORKING_PROGRAM
{

    class HumanPlayer : Player
    {


        public  override int move(Board board)
        {
            Console.WriteLine("humanplayer");
            return 1;
        }
        public override Move minimax(Board board)
        {
            return null;
        }
    }
}
