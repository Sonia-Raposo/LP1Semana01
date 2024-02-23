using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 13;
            int b = 0b11011;
            int c = 0x7;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            char d = '\u2665';
            char e = '\u2666';
            char f = '\u2660';
            char g = '\u2663';

            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);

            float h = 12.86f;
            double i = 62.567;
            decimal j = 7.777m;

            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);

            bool k = true;
            bool l = false; 

            Console.WriteLine(k);
            Console.WriteLine(l);

            

        }
    }
}
