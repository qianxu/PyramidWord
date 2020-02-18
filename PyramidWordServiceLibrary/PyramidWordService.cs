using System;

namespace PyramidWordServiceLibrary
{
    public class PyramidWordService : IPyramidWordService
    {
        /// <summary>
        /// Check whether the inputted word is pyramid word:
        /// 1. The word can only contain letter.
        /// 2. It is case sensitive.
        /// 3. It can arrange the letters in increasing frequency, starting with 1 and continuing without gaps and without duplicates.
        /// </summary>
        /// <param name="word">The inputted word</param>
        /// <returns>
        /// True: it is pyramid word.
        /// False: it is not pyramid word.
        /// </returns>
        public bool IsPyramidWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return false;
            }
            // The ASCII code of z is 122.
            int[] charCounts = new int[123];
            // Count the number of every letter.
            for (int i = 0; i < word.Length; i++)
            {
                if (!Char.IsLetter(word[i]))
                {
                    return false;
                }
                charCounts[word[i]]++;
            }
            // Sort the array of counts in increasing frequency.
            Array.Sort(charCounts);
            int count = charCounts[charCounts.Length - 1];
            // Check whether the count of the letters are unique and continuous in increasing frequency.
            for (int i = charCounts.Length - 1; i >= 0; i--)
            {
                if (charCounts[i] != count--)
                {
                    return false;
                }
                if (charCounts[i] == 0)
                {
                    break;
                }
            }

            return true;
        }
    }
}
