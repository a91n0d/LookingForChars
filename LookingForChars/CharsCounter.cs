using System;

namespace LookingForChars
{
    public static class CharsCounter
    {
        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <returns>The number of occurrences of all characters.</returns>
        public static int GetCharsCount(string str, char[] chars)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            else if (chars == null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            int count = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    count += (chars[i] == str[j]) ? 1 : 0;
                }
            }

            return count;
        }

        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <returns>The number of occurrences of all characters within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            else if (chars == null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            if (startIndex > str.Length - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }
            else if (endIndex > str.Length - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }
            else if (startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (startIndex == endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            int i = startIndex;
            int count = 0;
            while (i <= endIndex)
            {
                int j = 0;
                while (j < chars.Length)
                {
                    count += (chars[j++] == str[i]) ? 1 : 0;
                }

                i++;
            }

            return count;
        }

        /// <summary>
        /// Searches a string for a limited number of characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <param name="limit">A maximum number of characters to search.</param>
        /// <returns>The limited number of occurrences of characters to search for within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex, int limit)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            else if (chars == null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            if (startIndex > str.Length - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }
            else if (endIndex > str.Length - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }
            else if (startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (startIndex == endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            if (limit < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(limit));
            }

            int i = startIndex;
            int count = 0;
            do
            {
                int j = 0;
                do
                {
                    count += (chars[j++] == str[i]) ? 1 : 0;
                }
                while (j < chars.Length);
                i++;
                if (count == limit)
                {
                    return count;
                }
            }
            while (i <= endIndex);
            return count;
        }
    }
}
