using System;
namespace Text
{
    /// <summary>Create a Str class.</summary>
    public class Str
    {
        /// <summary> Function to find the index of the first unique char in a string</summary>
        /// <param name="s">the string</param>
        /// <returns>The index of the first unique char or -1 if not unique char</returns>
        public static int UniqueChar(string s)
        {
            int ch = 256, idx = -1, j;
            char[] count = new char[ch];
            for (j = 0; j < s.Length; j++)
                count[s[j]]++;
            for (j = 0; j < s.Length; j++)
            {
                if (count[s[j]] == 1)
                {
                    idx = j;
                    break;
                }
            }
            return idx;
        }
    }
}