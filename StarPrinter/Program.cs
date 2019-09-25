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

            int upper_stars = CreatePattern(minimum, maximum);
            int reverse_stars = InvertPattern(minimum, maximum);
            int total_stars = upper_stars + reverse_stars;

            string message = String.Format("The total number of stars printed is {0}", total_stars);

            Console.WriteLine("\n" + message);
        }

        private static int CreatePattern(int minimum, int maximum)
        {
            int i, j;
            // number of spaces
            int space = maximum - 1;
            int total = 0;

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
                    total += 1;
                }

                Console.WriteLine("");
                space--;    /* decrement one space after one row*/
            }
            return total;
        }


        private static int InvertPattern(int minimum, int maximum)
        {
            int i, j;
            // number of spaces
            int space = minimum;
            int total = 0;

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
                    total += 1;
                }

                Console.WriteLine("");
                space++;
            }
            return total;
        }
    }
}
