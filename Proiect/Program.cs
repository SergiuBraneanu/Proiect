using System;

namespace Proiect
{
    class Program
    {
        static void Main(string[] args)
        {
            double m = 0;
            float n, aux,m1=0;
            int ok = 0;
            int b = 0,b1=0,p=0;
            while (ok == 0)
            {
                ok = 1;
                try
                {
                    Console.Write("Introduceti baza in care veti scrie numarul:");
                    b = int.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    ok = 0;
                    Console.WriteLine("Nu ati introdus un numar!");

                }
            }
            Console.Write("Introduceti numarul in baza {0}:", b);
            n = float.Parse(Console.ReadLine());
            aux = n;
            while (aux != 0)
            {
                if (aux % 10 >= b)
                {
                    Console.WriteLine("Numarul introdus nu se afla in baza {0}!", b);
                    Console.Write("Introduceti numarul in baza {0}:", b);
                    n = float.Parse(Console.ReadLine());
                    aux = n;

                }
                else aux = aux / 10;
            }
            Console.Write("Introduceti baza in care vreti sa schimbati numarul:");
            b1 = int.Parse(Console.ReadLine());
            //work in progres
            aux = n;
            while(aux!=0)
            {
                m = m + aux % 10 * (double)Math.Pow(b, p);
                aux = aux / 10;
                p = p + 1;
            }
            Console.WriteLine(m);
            
        }



    }
}

