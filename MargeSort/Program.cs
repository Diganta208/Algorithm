using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MargeSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] t = new int[10];

            for (int i = 0; i < t.Count(); i++)
            {
                t[i] = Convert.ToInt32(Console.ReadLine());
            }

            Marge aMarge = new Marge();

            
            aMarge.MargeShort(t, 0, t.Count()-1);

            for(int i=0; i<t.Count(); i++)
            {
                Console.WriteLine(t[i]);
            }
          

            

        }
    }
}
