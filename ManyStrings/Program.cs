using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}
