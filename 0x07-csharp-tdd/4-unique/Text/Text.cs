using System;

namespace Text
{
    /// <summary> Str Class </summary>
    public class Str
    {
        /// <summary> Finds index of first non-repeated character </summary>
        /// <returns> Index of unique character of a string </returns>
        public static int UniqueCharacter(string s)
        {
            if (s.Length == 1)
            {
                return (0);
            }

            char[] countChar = new char[256];
            // Initialize index at one if there is no non-repeated number
            int index = -1;

            // Counting the number of times each character in s is repeated
            for (int i = 0; i < s.Length; i++)
            {
                countChar[s[i]]++;
            }

            for (int j = 0; j < s.Length; j++)
            {
                if (countChar[s[j]] != 1)
                {
                    continue;
                }
                else
                {
                    index = j;
                    break;
                }
            }

            return (index);

        }
    }
}
