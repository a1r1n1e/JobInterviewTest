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
        /// Naive factorial calculation.
        /// Unefficient.
        /// </summary>
        static BigInteger Factorial(int n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; ++i)
            {
                result *= i;
            }
            return result;
        }
    }
}
