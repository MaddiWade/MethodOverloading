using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add(7, 9);
            Add(6.0m, 8.0m);
            Add(12, 11, true);
            Console.WriteLine(Add(12, 11, true));
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isPlural)
        {
            var sum = x+ y;
            if (sum == 1)
            {
                isPlural = true;
                return ($"{sum} dollar");
            }
            else  
            {
                return ($"{sum} dollars");
            }
        }
    }


}
