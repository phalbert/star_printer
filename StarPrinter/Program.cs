using System;

namespace StarPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to print star patterns");
            int minimum = 0, maximum = 0;
            Console.Write("Enter the minimum number of stars: ");
            minimum = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the maximum number of stars: ");
            maximum = Int32.Parse(Console.ReadLine());

            CreatePattern(minimum, maximum);
            InvertPattern(minimum, maximum);
        }

        private static void CreatePattern(int minimum, int maximum)
        {
            int i, j;
            // number of spaces
            int space = maximum - 1;

            for (i = minimum; i <= maximum; i++)
            {
                /*loop for initially space, before star printing*/
                for (j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
                space--;    /* decrement one space after one row*/
            }
        }


        private static void InvertPattern(int minimum, int maximum)
        {
            int i, j;
            // number of spaces
            int space = 1;

            for (i = maximum - 1; i >= minimum; i--)
            {
                /*loop for initially space, before star printing*/
                for (j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
                space++;
            }
        }
    }
}
