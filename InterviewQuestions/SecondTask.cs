using System.Numerics;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("InterviewQuestionsTestProject")]

namespace InterviewQuestions
{
    internal static class SecondTask
    {
        internal static BigInteger GetNumberOfWaysToGetUpTheStairs(int stairsCount)
        {
            return GetNumberOfWays(stairsCount);
        }

        private static BigInteger GetNumberOfWays(int stairsCount)
        {
            BigInteger totalNumberOfWays = 0;
            var maxNumOfThrees = stairsCount / 3;
            for (int numOfThrees = maxNumOfThrees; numOfThrees >= 0; --numOfThrees)
            {
                var maxNumOfTwos = (stairsCount - numOfThrees * 3) / 2;
                for (int numOfTwos = maxNumOfTwos; numOfTwos >= 0; --numOfTwos)
                {
                    var numOfOnes = stairsCount - numOfThrees * 3 - numOfTwos * 2;

                    var totalNumOfUnits = numOfThrees + numOfTwos + numOfOnes;

                    totalNumberOfWays += Factorial(totalNumOfUnits) / 
                        Factorial(numOfThrees) / Factorial(numOfTwos) / Factorial(numOfOnes);
                }
            }
            return totalNumberOfWays;
        }

        /// <summary>
        /// Primes powers factorial algorithm.
        /// </summary>
        static BigInteger Factorial(int n)
        {
            if (n < 0)
            {
                return 0;
            }
            if (n == 0)
            {
                return 1;
            }
            if (n == 1 || n == 2)
            {
                return n;
            }
            bool[] isCompositeNumFlags = new bool[n + 1];
            List<Tuple<int, int>> primes = new List<Tuple<int, int>>();
            for (int i = 2; i <= n; ++i)
            {
                if (!isCompositeNumFlags[i])
                {
                    int k = n / i;
                    int c = 0;
                    while (k > 0)
                    {
                        c += k;
                        k /= i;
                    }
                    primes.Add(new Tuple<int, int>(i, c));
                    int j = 2;
                    while (i * j <= n)
                    {
                        isCompositeNumFlags[i * j] = true;
                        ++j;
                    }
                }
            }
            BigInteger result = 1;
            for (int i = primes.Count() - 1; i >= 0; --i)
            {
                result *= BigInteger.Pow(primes[i].Item1, primes[i].Item2);
            }
            return result;
        }
    }
}
