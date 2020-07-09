using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bainarySearch
{
    class Search
    {
        public int bainarySearch (int[] arr, int V)
        {
            int left = 0;
            int right = arr.Count() - 1;
            int result = 0;

            while (left <= right)
            {
                int mid = arr.Count() / 2;
                if (arr[mid] == V)
                {
                    result = mid;
                }
                else if (V < arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return result;

        }
        
       
    }
}
