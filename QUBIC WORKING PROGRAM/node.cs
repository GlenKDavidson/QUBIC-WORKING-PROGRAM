using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUBIC_WORKING_PROGRAM
{
    class node
    {
        public string name;
        public node left;
        public node right;

        public node(string name, node left, node right)
        {
            this.name = name;
            this.left = left;
            this.right = right;
        }

        public node()
        {
            left = null;
            right = null;
        }

        public node(string name)
        {
            this.name = name;
            left = null;
            right = null;
        }

    }
}
