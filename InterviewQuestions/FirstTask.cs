using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("InterviewQuestionsTestProject")]

namespace InterviewQuestions
{
    internal static class FirstTask
    {
        internal static string CompressString(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("String compression impossible, null string passed.");
            }

            if (input.Length == 0)
            {
                return input;
            }

            var builder = new StringBuilder("");

            bool wasStringCompressed = false;
            int charsInARow = 1;
            char charInARow = input[0];
            for (int i = 1; i < input.Length; ++i)
            {
                if (input[i] == charInARow)
                {
                    ++charsInARow;
                    wasStringCompressed = true;
                }
                else
                {
                    builder.Append(charInARow);
                    builder.Append(charsInARow);
                    charInARow = input[i];
                    charsInARow = 1;
                }
            }

            builder.Append(charInARow);
            builder.Append(charsInARow);

            if (wasStringCompressed)
            {
                return builder.ToString();
            }
            return input;
        }
    }
}
