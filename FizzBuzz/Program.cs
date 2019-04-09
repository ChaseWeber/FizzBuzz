using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                var printme = "";
                if (i % 3 == 0)
                {
                    printme += "Fizz";
                }
                if (i % 5 == 0)
                {
                    printme += "Buzz";
                }
                if (printme == "")
                {
                    printme += i;
                }
                Console.WriteLine(printme);
            }
        }
    }
}
