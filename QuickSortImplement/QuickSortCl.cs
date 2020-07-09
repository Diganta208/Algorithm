using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortImplement
{
    class QuickSortCl
    {

        public void QuickSort(int[] arr, int start, int end)
        {
            if(start>=end)
            {
                return;
            }

            int p = Partion(arr, start, end);
            QuickSort(arr, start, p - 1);
            QuickSort(arr, p + 1, end);

               
     
        }


        private int Partion(int[] arr, int start, int end)
        {

            int paivot = arr[end];
            int i= start;
            int temp;

            for (int j = start; j <= end - 1; j++)
            {
                if(arr[j]<paivot)
                {
                   
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    i++;
                   

                }
            }

            temp = paivot;
            arr[end] = arr[i];
            arr[i] = paivot;

            return i;

        }

    }
}
