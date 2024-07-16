using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("InterviewQuestionsTestProject")]

namespace InterviewQuestions
{
    internal static class SecondTask
    {
        internal static long GetNumberOfWaysToGetUpTheStairs(int stairsCount)
        {
            return GetNumberOfWays(stairsCount);
        }

        /// <summary>
        /// Current realization isn`t optimized one.
        /// You will get performance troubles at pretty low "stairsCount" value.
        /// Logarithmic optimizations can be performed, but author of this solution
        /// didn`t have enough time to implement them.
        /// </summary>
        private static long GetNumberOfWays(int stairsCount)
        {
            var stack = new Stack<int>();
            long totalNumberOfWays = 0;
            stack.Push(stairsCount);

            while(stack.Count > 0)
            {
                var currentStep = stack.Pop();
                if (currentStep > 0)
                {
                    stack.Push(currentStep - 1);
                    stack.Push(currentStep - 2);
                    stack.Push(currentStep - 3);
                }
                else if (currentStep == 0)
                {
                    ++totalNumberOfWays;
                }
            }
            return totalNumberOfWays;
        }
    }
}
