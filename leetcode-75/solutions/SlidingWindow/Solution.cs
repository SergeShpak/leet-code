using System;

namespace solutions.SlidingWindow;

public partial class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double sum = 0;
        double avg;
        for (var i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        avg = sum / k;

        for (var i = 1; i + k - 1 < nums.Length; i++)
        {
            sum = sum - nums[i - 1] + nums[i + k - 1];
            var currAvg = sum / k;
            if (currAvg > avg)
            {
                avg = currAvg;
            }
        }

        return avg;
    }
}