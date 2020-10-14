using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Strings.ReverseWordsInSentence
{
    public class Tests
    {
        [Fact]
        public void ReverseWords()
        {
            var sentence = "ram is costly".ToCharArray();

            Solution.ReverseWords(sentence);

            var expectedSentence = "costly is ram".ToCharArray();

            sentence.Should().BeEquivalentTo(expectedSentence, options => options.WithoutStrictOrdering());
        }
    }
}