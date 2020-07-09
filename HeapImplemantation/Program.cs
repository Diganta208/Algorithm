using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapImplemantation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heap = new int[10];

            for (int i = 0; i < heap.Count(); i++)
            {
                heap[i] = Convert.ToInt32(Console.ReadLine());
            }

            Implement newImplement = new Implement();
            for(int i=(heap.Count()-1)/2; i>=1; i--)
            {
                newImplement.buildMaxheap(heap,heap.Count(), i);
            }
            newImplement.heapSort(heap, heap.Count()-1);

            for(int i = 0; i < heap.Count(); i++)
            {
                Console.WriteLine(heap[i]);
            }

        }
    }
}
