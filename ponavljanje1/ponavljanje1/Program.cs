using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int kateta1, kateta2, hipotenuza;
            Console.WriteLine("Unesi duljinu prve stranice trokuta:");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Unesi duljinu drzge stranice trokuta:");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Unesi duljinu treće stranice trokuta:");
            c = Convert.ToInt16(Console.ReadLine());


            if (a > b && a > c)
            {
                hipotenuza = a;
                kateta1 = b;
                kateta2 = c;
            }
            else if (b > c)
            {
                hipotenuza = b;
                kateta1 = a;
                kateta2 = c;
            }
            else
            {
                hipotenuza = c;
                kateta1 = a;
                kateta2 = b;
            }


            if (Math.Pow(hipotenuza, 2) ==
                     Math.Pow(kateta1, 2) + Math.Pow(kateta2, 2))

            {
                Console.WriteLine("Trokut je pravokutan");
            }
            else
            {
                Console.WriteLine("Trokut nije pravokutan");
            }
            if (a <= 0 || b <= 0 || c <= 0 )
            {
                Console.WriteLine("stranice trkouta moraju biti veće od 0");
            } 



            Console.ReadKey();
        }
    }
}
