using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeKattisStarter1
{
    class Program
    {
        /// <summary>
        /// Here you will get a list each item is an input line. 
        /// </summary>
        /// <param name="lstInputLines"> these represent a line/item representation of the input file </param>
        public static void SolveKattisAndWriteOutput(List<string> lstInputLines)
        {
            int X, Y, N;
            var items = lstInputLines[0].Split(new[] { ' ' });
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
                    Y== 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
        #region IGNORE
        static void Main(string[] args)
        {
            List<string> lstInputLines = new List<string>();
            string line;
            while ((line = TrimFront()) != null)
            {
                lstInputLines.Add(line.Trim());
            }
            SolveKattisAndWriteOutput(lstInputLines);
        }



        private static string TrimFront()
        {
            var s = Console.ReadLine();
            if (s == null)
                return s;
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }
            return (sb.ToString());
        }
        #endregion
    }
}