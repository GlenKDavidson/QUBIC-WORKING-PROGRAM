using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUBIC_WORKING_PROGRAM
{
    class Tree
    {
        public node root = null;
        public node temp = null;
        Boolean sort = false;
        public void Add(String input)
        {
            if (root == null)
            {
                root = new node
                {
                    name = input

                };
            }
            else
            {
                temp = root;
                sort = false;
                while (!sort)
                {
                    if (temp.left == null)
                    {
                        if (temp.name.CompareTo(input) >= 1)
                        {
                            temp.left = new node
                            {
                                name = input
                            };
                            sort = true;
                        }


                    }
                    else if (temp.name.CompareTo(input) >= 1)
                    {
                        temp = temp.left;

                    }

                    else if (temp.right == null)
                    {
                        if (temp.name.CompareTo(input) < 1)
                        {
                            temp.right = new node
                            {
                                name = input
                            };
                            sort = true;
                        }
                    }

                    else if (temp.name.CompareTo(input) < 1)
                    {
                        temp = temp.right;
                    }
                }
            }
        }

    }
}
