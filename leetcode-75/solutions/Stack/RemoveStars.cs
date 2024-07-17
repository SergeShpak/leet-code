using System;
using System.Collections.Generic;
using System.Text;

namespace solutions.Stack;

public partial class Solution
{
    public string RemoveStars(string s)
    {
        byte[] sBytes = Encoding.ASCII.GetBytes(s);

        var stack = new Stack<byte>();
        for (var i = 0; i < sBytes.Length; i++)
        {
            var ch = sBytes[i];
            if (ch != '*')
            {
                stack.Push(ch);
                continue;
            }

            stack.Pop();
        }

        return Encoding.ASCII.GetString(stack.GetAll().ToArray());
    }
}