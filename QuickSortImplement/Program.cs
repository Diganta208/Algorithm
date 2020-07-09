using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortImplement
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];

            for(int i=0; i<arr.Count(); i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            QuickSortCl aQuickSortCl = new QuickSortCl();
            
            aQuickSortCl.QuickSort(arr, 0, arr.Count() - 1);

            for (int i = 0; i < arr.Count(); i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }
    }
}
