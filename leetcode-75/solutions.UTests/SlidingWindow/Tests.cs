using NUnit.Framework;

using solutions.SlidingWindow;

namespace solutions.UTests.SlidingWindow;

public class Tests
{
    [TestCase(new [] { 1,12,-5,-6,50,3 }, 4, ExpectedResult = 12.75)]
    [TestCase(new [] { 5 }, 1, ExpectedResult = 5.0)]
    public double FindMaxAverage(int[] nums, int k)
    {
        return new Solution().FindMaxAverage(nums, k);
    }
}