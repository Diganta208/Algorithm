using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MargeSort
{
    class Marge
    {

        public void MargeShort(int[] a, int left, int right)
        {
            if (right <= left)
            { return;  }
            int mid = (left + right) / 2;
            MargeShort(a,left,mid);
            MargeShort(a,mid+1,right);

           finalMarge(a,left, right);

        }

         private void finalMarge(int[] a, int left, int right)
        {
            int mid = (left + right) / 2;
            int i = left;
            int j = mid+1;
            int k = left;

             int[] r = new int[100];
             while (i <= mid && j <= right)
             {
                 if (a[i] < a[j])
                 {
                     r[k] = a[i];
                     i++;
                 }

                 else
                 {
                     r[k] = a[j];
                     j++;
                 }
                 k++;
             }
            while (i <= mid)
             {
                 r[k] = a[i];
                 i++;
                 k++;
             }
             while (j <= right)
             {
                 r[k] = a[j];
                 j++;
                 k++;
             }

             for(int m=left; m<=right; m++ )
             {
                 a[m] = r[m];
             }

             
        }

    }
}
