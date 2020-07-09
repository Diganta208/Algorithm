using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insettionSort
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] arr = new int[10];

            

            for (int i = 1; i < arr.Count(); i++)
            {
                int item = arr[i];

                int j = i - 1;

                while (j >= 0 && arr[j] > item)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;

                    
                }
                arr[j + 1] = item;






            }

        }
    }
}
