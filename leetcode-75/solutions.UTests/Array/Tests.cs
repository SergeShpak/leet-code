using System.Collections.Generic;
using NUnit.Framework;

using solutions.Array;

namespace solutions.UTests.Array;

public class Tests
{
    [TestCase(new[] {2, 3, 5, 1, 3}, 3, ExpectedResult = new[] {true, true, true, false, true})]
    [TestCase(new[] {4, 2, 1, 1, 2}, 1, ExpectedResult = new[] {true, false, false, false, false})]
    [TestCase(new[] {12, 1, 12}, 10, ExpectedResult = new[] {true, false, true})]
    public IList<bool> KidsWithCandiesTest(int[] candies, int extraCandies)
    {
        return new Solution().KidsWithCandies(candies, extraCandies);
    }
    
    [TestCase("the sky is blue", ExpectedResult = "blue is sky the")]
    [TestCase("  hello world  ", ExpectedResult = "world hello")]
    [TestCase("a good   example", ExpectedResult = "example good a")]
    public string ReverseWordsInStringTest(string s)
    {
        return new Solution().ReverseWords(s);
    }
}