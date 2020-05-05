using System;
using System.Text.RegularExpressions;


namespace Text
{
    /// <summary> Str Class </summary>
    public class Str
    {
        /// <summary> Checks if a string is palindrome </summary>
        /// <returns> True if string is a palindrome, else false </returns>
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0)
            {
                return (true);
            }

            s = s.ToLower();
            s = Regex.Replace(s, "[ .,:;\n]", "");

            string reverse = string.Empty;
            int len = s.Length - 1;
            while(len >= 0)
            {
                reverse += s[len];
                len--;
            }

            if (s == reverse)
            {
                return (true);
            }

            return (false);
        }
    }
}
