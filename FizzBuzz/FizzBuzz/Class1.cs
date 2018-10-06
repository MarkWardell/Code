using System;

namespace FizzBuzz
{
    class Prog2
    {
        static void Main(string[] args)
        {

        
        int X, Y, N;
        var items = Console.ReadLine().Split(new[] { ' ' });
        X = int.Parse(items[0]);
        Y = int.Parse(items[1]);
        N = int.Parse(items[2]);
            for (int i = 1; i <= N; i++)
            {
                if (i % X == 0 && i % Y == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % X == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i %
                    Y == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
