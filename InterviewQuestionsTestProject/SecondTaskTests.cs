using InterviewQuestions;

namespace InterviewQuestionsTestProject
{

    public class SecondTaskTests
    {
        [Theory]
        [InlineData(1, 1)] // 1
        [InlineData(2, 2)] // 11 2
        [InlineData(3, 4)] // 111 12 21 3
        [InlineData(4, 7)] // 1111 112 121 211 13 22 31
        [InlineData(5, 13)] // 11111 1112 1121 1211 2111 122 212 221 113 131 311 23 32
        public void GreedyAlgorithmTests(int stairsCount, int output)
        {
            var numberOfWays = SecondTask.GetNumberOfWaysToGetUpTheStairs(stairsCount);
            Assert.Equal(numberOfWays, output);
        }

        [Theory]
        [InlineData(35)] // Works for a pretty long time
        public void GreedyAlgorithmBigNumbersTests(int stairsCount)
        {
            var stackOverflowExceptionWasThrown = false;
            var memoryOverflowExceptionWasThrown = false;
            try
            {
                SecondTask.GetNumberOfWaysToGetUpTheStairs(stairsCount);
            }
            catch (StackOverflowException e)
            {
                stackOverflowExceptionWasThrown = true;
            }
            catch (OutOfMemoryException e)
            {
                memoryOverflowExceptionWasThrown = true;
            }

            Assert.False(stackOverflowExceptionWasThrown);
            Assert.False(memoryOverflowExceptionWasThrown);
        }

    }
}
