using System;
using System.Linq;

namespace TDD_StringCheck
{
    public class TDD_StringCheckers
    {
        public string shortwords (string str_input)
        {
            var words = str_input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 0)
            {
                return null;
            }
            return words.OrderBy(w => w.Length).First();
        }


        public int wordLeight(string str_input)
        {
            return str_input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public int wordCount(string str_input)
        {
            return str_input.Length;
        }

        public char? wordNight(string str_input)
        {
            if (str_input.Length < 9)
            {
                return null;
            }

            return str_input[8];
        }

        public int ints(string str_input)
        {
            int count = 0;
            foreach (char c in str_input)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }


        public int ints_count(string str_input)
        {
            int maxCount = 0;
            int currentCount = 0;

            foreach (char c in str_input)
            {
                if (char.IsDigit(c))
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 0;
                }
            }

            return maxCount;
        }

        public int search_am(string str_input, string substr)
        {
            int count = 0;
            int index = 0;

            while ((index = str_input.IndexOf(substr, index)) != -1)
            {
                count++;
                index += substr.Length;
            }

            return count;
        }
        
        
    }
}