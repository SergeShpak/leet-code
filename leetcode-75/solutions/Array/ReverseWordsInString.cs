using System;
using System.Text;

namespace solutions.Array;

// #151
public partial class Solution {
    public string ReverseWords(string s)
    {
        int wordStartIdx;
        int wordEndIdx = -1;
        byte[] sBytes = Encoding.ASCII.GetBytes(s);
        StringBuilder result = new StringBuilder(s.Length);

        for (var i = sBytes.Length - 1; i >= 0; i--)
        {
            var b = sBytes[i];
            if (b == ' ')
            {
                if (wordEndIdx == -1)
                {
                    continue;
                }

                wordStartIdx = i + 1;

                for (var j = wordStartIdx; j <= wordEndIdx; j++)
                {
                    result.Append((char)sBytes[j]);
                    
                }

                result.Append(' ');
                wordEndIdx = -1;
                continue;
            }

            if (wordEndIdx == -1)
            {
                wordEndIdx = i;
            }
        }

        if (wordEndIdx == -1)
        {
            result.Remove(result.Length - 1, 1);
        }
        else
        {
            wordStartIdx = 0;
            for (var j = wordStartIdx; j <= wordEndIdx; j++)
            {
                result.Append((char)sBytes[j]);
            }
        }

        return result.ToString();
    }
}