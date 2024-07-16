using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("InterviewQuestionsTestProject")]

namespace InterviewQuestions
{
    internal static class SecondTask
    {
        internal static long GetNumberOfWaysToGetUpTheStairs(int stairsCount)
        {
            //return RecGetNumberOfWays(stairsCount);
            return GetNumberOfWays(stairsCount);
        }

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

        private static long RecGetNumberOfWays(int numberOfStairs)
        {
            if (numberOfStairs < 0)
            {
                return 0;
            }

            if (numberOfStairs == 0)
            {
                return 1;
            }

            long totalNumber = 0;
            totalNumber += RecGetNumberOfWays(numberOfStairs - 1);
            totalNumber += RecGetNumberOfWays(numberOfStairs - 2);
            totalNumber += RecGetNumberOfWays(numberOfStairs - 3);

            return totalNumber;
        }
    }
}
