using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapImplemantation
{
    class Implement
    {

        private int left(int i)
        {
            return i * 2;
        }

        private int right(int i)
        {
            return (i * 2 )+ 1;
        }

        private int parent(int i)
        {
            return i / 2;
        }


        public void heapSort(int[] heap, int heapSize)
        {

            int temp;
            for(int i= heapSize; i>1; i--)
            {
                temp = heap[i];
                heap[i] = heap[1];
                heap[1] = temp;

                heapSize--;
                buildMaxheap(heap, heapSize, 1);
            }

        }

        public  void buildMaxheap(int[] heap, int count, int parent)
        {
            int left = this.left(parent);
            int right = this.right(parent);
            int largest;

            if(left<=count && heap[left]>heap[parent])
            {
                largest = left;

            }
            else
            {
                largest = parent;
            }

            if (right <= count && heap[right] > heap[largest])
            {
                largest = right;
            }

            if(largest!=parent )
            {
                int temp = heap[parent];
                heap[parent] = heap[largest];
                heap[largest] = temp;

                buildMaxheap(heap,count, largest);
            }


        }
    }
}
