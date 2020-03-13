using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUBIC_WORKING_PROGRAM
{
    class stack<T>
    {

        int pointer;
        List<T> stackStruct;
        T temp;
        public stack()
        {
            this.pointer = 0;
            stackStruct = new List<T>();
        }

        public void add(T data)
        {
            stackStruct.Add(data);
            pointer++;
        }
        public T pop()
        {
            temp = stackStruct[pointer];
            stackStruct.RemoveAt(pointer);
            pointer--;
            return temp;
        }
    }
}
