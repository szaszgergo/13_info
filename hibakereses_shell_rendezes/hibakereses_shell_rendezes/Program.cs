using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hibakereses_shell_rendezes
{
    class Program
    {
        static void Main(string[] args)
        {
          
            shellsort();
            Console.ReadLine();
          

        }
        static void ShellRendezes(int[] a)
        {
        

           
            int gap, n, i, j, x, y;
            gap = 1;
            n = a.Length;
            do
            {
                while (gap * 2 <= n)
                {
                    gap = gap * 2;
                }
                gap = gap - 1;
                i = 0;
                while ((i <= gap) && (i + gap < n))
                {
                    j = i + gap;
                    while (j < n)
                    {
                        x = a[j];
                        y = j - gap;
                        while ((y > -1) && (x < a[y]))
                        {
                            a[y + gap] = a[y];
                            y = y - gap;
                        }
                        a[y + gap] = x;
                        j = j + gap;
                    }
                    i = i + 1;
                }
                gap = gap / 2;
            } while (gap > 0);
           
                //nemjo itt do while loop kell
            

        }

        static void shellsort()
        {

            int[] t = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            t[0] = 63;
            t[1] = 54;
            t[2] = 33;
            t[3] = 45;
            t[4] = 23;
            t[5] = 99;
            t[6] = 43;
            t[7] = 10;
            t[8] = 35;
            t[9] = 87;
            ShellRendezes(t);
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine($"\n {t[i]} ");
            }
        }



    }
}
