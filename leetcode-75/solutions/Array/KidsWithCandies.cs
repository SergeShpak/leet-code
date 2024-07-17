using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace solutions.Array;

// #1431
public partial class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int maxCandiesCount = 
            candies.Max();
    
        List<bool> result = new List<bool>(candies.Length);
        foreach (var candyCount in candies)
        {
            result.Add(candyCount + extraCandies >= maxCandiesCount);
        }
    
        return result;
    }
}