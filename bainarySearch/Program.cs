using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bainarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];
            for (int i = 0; i < arr.Count(); i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int V= Convert.ToInt32(Console.ReadLine());

            Search aSearch = new Search();
            int result= aSearch.bainarySearch(arr, V);

            Console.WriteLine(result);
            Console.ReadKey();

            
        }
    }
}
