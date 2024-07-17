using NUnit.Framework;

using solutions.Stack;

namespace solutions.UTests.Stack;

public class Tests
{
    [TestCase("leet**cod*e", ExpectedResult = "lecoe")]
    [TestCase("erase*****", ExpectedResult = "")]
    public string ReverseWordsInStringTest(string s)
    {
        return new Solution().RemoveStars(s);
    }
}