using System;
using System.Collections.Generic;

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
            int[] vals = SplitInts(lstInputLines[0]);
            int X, Y, N;
            X = vals[0];
            Y = vals[1];
            N = vals[2];
            for (int i = 0; i < N; i++)
            {
                if (i % X == 0 && i % Y == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % X == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % Y== 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


        }
        #region LIB

        static int[] SplitInts(string strLine)
        {
            var items = strLine.Split(new[] { ' ' });
            int[] retInts = new int[items.Length];
            int i = 0;
            foreach (string s in items)
            {
                retInts[i] = int.Parse(items[i++]);

            }
            return retInts;
        }


        #endregion

        #region IGNORE
        static void Main(string[] args)
        {
            List<string> lstInputLines = new List<string>();
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                lstInputLines.Add(line);
            }
            SolveKattisAndWriteOutput(lstInputLines);
        }

    }
    #endregion

}