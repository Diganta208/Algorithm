using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplement
{
    class Stack
    {

        private int[] arr;

        private  int top;
        public Stack()
        {
            top = 0;
            arr = new int[10];
        }

        public void push(int data)
        {
            if (top >= arr.Count())
            {
                Console.WriteLine("array is ful");
            }

            else
            {
                arr[top] = data;
                top++;

            }
            
        }

        public int pop()
        {
            int item;
            if(top==0)
            {
                Console.WriteLine("There is no element in this stack");
                return -1;
            }
            else
            {
                top--;
                item = arr[top];
                return item;

            }

            
        }
    }
}
