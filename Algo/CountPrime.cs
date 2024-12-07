using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class CountPrime
    {
        public static int CountPrimes(int n)
        {
            if (n <= 2) return 0;
            List<int> previousPrimes = new List<int>();
            bool isPrime = true;
            for (int i = 3; i < n; i = i + 2)
            {
                isPrime = true;
                foreach (int prime in previousPrimes)
                {
                    if (prime * prime > i) break;
                    if (i % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    previousPrimes.Add(i);
                }
            }
            return 1 + previousPrimes.Count;

        }

        public static int CountPrimeFaster(int n)
        {
            bool[] isPrime = new bool[n];
            for (int i = 2; i < n; i++)
            {
                isPrime[i] = true;
            }
            // Loop's ending condition is i * i < n instead of i < sqrt(n)
            // to avoid repeatedly calling an expensive function sqrt().
            for (int i = 2; i * i < n; i++)
            {
                if (!isPrime[i]) continue;
                for (int j = i * i; j < n; j += i)
                {
                    isPrime[j] = false;
                }
            }
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i]) count++;
            }
            return count;

        }
    }
}
