using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUBIC_WORKING_PROGRAM
{

    class HumanPlayer : Player
    {

        
        public  override void move(Board board, Game qubic)
        {
            
            Console.WriteLine("humanplayer");
            board.plotpiece(qubic.getlocation(), qubic.actingplayer());
        }
        
    }
}
