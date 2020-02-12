using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUBIC_WORKING_PROGRAM
{
    abstract class Player
    {

        string name;
        int turnsTaken;

        public abstract void move(Board board,Game qubic);

       


    }
}
