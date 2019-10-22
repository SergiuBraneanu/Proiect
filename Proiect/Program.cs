using System;
using System.Text;

namespace Proiect
{
    class Program
    {
        static int Conversie_b_10(string input,int b)
        {
            int v = 0;
            for(int i=0;i<input.Length;i++)
            {
                if (Char.IsDigit(input[i])) v = v * b + (input[i] - '0');
                else if(input[i]>='A' && input[i]<='F') v = v * b + (input[i] - 'A' + 10);
            }
            return v;
        }
        static string Conversie_10_b1(int n,int b)
        {
            int r;
            char c;
            StringBuilder sb = new StringBuilder();
            while(n>0)
            {
                r = n % b;
                n = n / b;
                if (r < 10) c = (char)('0' + r);
                else
                    c = (char)('A' + (r - 10));
                    sb.Append(c);
            }
        }
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            double m = 0;
            float  aux,m1=0;
            int ok = 0;
            int b = 0,b1=0,p=0;
            string n;
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
            n = Console.ReadLine();
            aux =float.Parse( n);
            while (aux != 0)
            {
                if (aux % 10 >= b)
                {
                    Console.WriteLine("Numarul introdus nu se afla in baza {0}!", b);
                    Console.Write("Introduceti numarul in baza {0}:", b);
                    n = Console.ReadLine();
                    aux = float.Parse(n);

                }
                else aux = aux / 10;
            }
            Console.Write("Introduceti baza in care vreti sa schimbati numarul:");
            b1 = int.Parse(Console.ReadLine());
            if (b < 10) Console.WriteLine(Conversie_10_b1(Conversie_b_10(n, b), b1));
            else
            if (b == 10) Console.WriteLine(Conversie_b_10(n, b));
            else
            if (b > 10) Console.WriteLine(Reverse(Conversie_10_b1(Conversie_b_10(n, b), b1)));
            
        }



    }
}

