using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraMethods
{
    public class MyExtraMethods
    {
        public bool WesternStyleEmoticon(string emoticon)
        {
            if (emoticon[0] == ':' || emoticon[0] == ';' || emoticon[0] == '=' || emoticon[0] == '<')
            {
                return true;
            }
            return false;
        }

        public String LongestConsec(string[] strarr, int k)
        {
            string retString = "";
            if (strarr.Length != 0 && k <= strarr.Length && k > 0)
            {
                for (int i = 0; i <= strarr.Length - k; i++)
                {
                    string concString = "";
                    for (int x = 0; x < k; x++)
                    {
                        concString += strarr[i + x];
                    }
                    if (concString.Length > retString.Length)
                    {
                        retString = concString;
                    }
                }
            }
            return retString;
        }

        public bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;

            for (int i = 2; i < (Math.Sqrt(n) + 1); i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        public int FindOddInt(int[] seq)
        {
            int theInt = 0;
            foreach (int x in seq)
            {
                if (seq.Count(y => y == x) % 2 != 0)
                {
                    theInt = x;
                }
            }
            return theInt;
        }

        public string ReversedString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string newString = new string(charArray);
            return newString;
        }
    }
}

