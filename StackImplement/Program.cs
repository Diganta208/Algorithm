using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplement
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack aStack = new Stack();
            aStack.push(7);
            aStack.push(10);
            aStack.pop();
            aStack.push(13);
        }
    }
}
