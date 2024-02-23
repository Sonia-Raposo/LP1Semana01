using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;


            string a = "I'm a string";
            string b = "I'm a more complex string";
            b = "Because I have changed";
            string c = "I'm a string just \\chilling\\ here \u2746";


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            string d = "I'm a math string look, 1+1=" +2;
            string e = "Here is a statment: " + d;
            string f = $"Here is a wise talking string: {d}";

            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            Console.WriteLine($"{xx:f2}");
            Console.WriteLine($"{xx:p1}");

            Console.WriteLine($"{ii:x}");
            Console.WriteLine($"{ii:c}");

        }
    }
}
