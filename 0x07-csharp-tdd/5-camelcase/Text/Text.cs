using System;
namespace Text
{
    /// <summary>
    /// Class Str
    /// </summary>
    public class Str
    {
        /// <summary>Function to count of the words in a string.</summary>
        /// <param name="s">The string</param>
        /// <returns>The count of the words</returns>
        public static int CamelCase(string s)
        {
            if (String.IsNullOrEmpty(s))
                return 0;
            int words = 1;
            for (int j = 0; j < s.Length; j++)
                if (s[j] >= 'A' && s[j] <= 'Z')
                 words += 1;
            return words;
        }
    }
}
