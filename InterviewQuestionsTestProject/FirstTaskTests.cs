using InterviewQuestions;

namespace InterviewQuestionsTestProject
{
    public class FirstTaskTests
    {
        [Theory]
        [InlineData("a", "a")]
        [InlineData("ab", "ab")]
        [InlineData("abcde", "abcde")]
        [InlineData("aa", "a2")]
        [InlineData("aaaaa", "a5")]
        [InlineData("aaabbbccc", "a3b3c3")]
        [InlineData("1```jkkk", "11`3j1k3")]
        public void CompressionTests(string input, string output)
        {
            var compressedString = FirstTask.CompressString(input);
            Assert.Equal(compressedString, output);
        }
    }
}