using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trials
{
    public class FibonacciTest
    {
        Dictionary<int, int> previous_keys = new Dictionary<int, int>();

        /// <summary>
        /// with dictionary use
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int PrintFibsWithDictionary(int n)
        {
            if (previous_keys.ContainsKey(n))
                return previous_keys[n];
            else if (n == 0 || n == 1)
                return 1;
            else
            {
                int newValue = PrintFibsWithDictionary(n - 1) + PrintFibsWithDictionary(n - 2);
                previous_keys.Add(n, newValue);
                return newValue;
            }
        }

        public void PrintFibsForwardingMethod(int n)
        {
            int prev = 0;
            int current = 1;

            for (int i = 0; i < n; i++)
            {
               // Console.WriteLine(current);
                int next = prev + current;
                prev = current;
                current = next;
            }

        }

        public int PrintFibsWithoutDictionary(int n)
        {
            
            if (n == 0 || n == 1)
                return 1;
            else
            {
                return PrintFibsWithoutDictionary(n - 1) + PrintFibsWithoutDictionary(n - 2);
            }
        }

    }
}
