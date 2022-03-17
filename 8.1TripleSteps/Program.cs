using System;

namespace _8._1TripleSteps
{
    class Program
    {
        static void Main(string[] args)
        {

            int stairs = 5;
             Console.WriteLine(CountWays(stairs));         
            Console.ReadKey();
        }
        public static int CountWays(int stairs)
        {
            if (stairs < 0) return 0;
            else if (stairs == 0) return 1;
            else return CountWays(stairs - 1) + CountWays(stairs - 2) + CountWays(stairs - 3);
        }

    }
}
