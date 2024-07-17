using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Reflection;

namespace solutions.Queue;

public partial class Solution
{
    public class RecentCounter
    {
        private int total = 0;
        private Queue<int> pings = new();

        public RecentCounter() {}
    
        public int Ping(int t)
        {
            while (pings.TryPeek(out var oldestPing) && (t - oldestPing > 3000))
            {
                _ = pings.Dequeue();
                total--;
            }
            pings.Enqueue(t);
            total++;
            return total;
        }
    }
}