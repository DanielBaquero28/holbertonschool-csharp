using System;

namespace Text
{
    /// <summary> Str Class that handles string operations </summary>
    public class Str
    {
        /// <summary> Finds the number of words there is in a string </summary>
        /// <returns> Number of words in a string </returns>
        public static int CamelCase(string s)
        {
            if (s.Length == 0)
            {
                return (0);
            }
            int countWords = 1;
            int AsciiValue = 0;
            int i = 0;
            while (i < s.Length)
            {
                AsciiValue = (int)Convert.ToChar(s[i]);
                if ((AsciiValue >= 65 && AsciiValue <= 90))
                {
                    countWords += 1;
                }
                i++;
            }

            return (countWords);
        }
    }
}
