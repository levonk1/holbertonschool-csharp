using System;
using System.Text.RegularExpressions;
namespace Text
{
    /// <summary>
    /// Class Str
    /// </summary>
    public class Str
    {
        /// <summary>Function to check if a string is a palindrome</summary>
        /// <param name="s">The string to be checked</param>
        /// <returns>True if is a palindrome, false if not</returns>
        public static bool IsPalindrome(string s)
        {
            if (s.Length < 2)
                return true;

            s = s.ToLower();
            s = Regex.Replace(s, "[:;,. \t\n\r]", "");

            int size = s.Length, j = 0;

            while (j < s.Length)
            {
                if (s[j] != s[size - 1])
                    return false;
                j++;
                size--;
            }
            return true;
        }
    }
}