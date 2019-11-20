using System;

namespace LiveCoding2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(longRepeat(""));
        }

        /*
         * Length of Longest Repeating Substring
            In this problem you are given a string of alphabetic characters. You need to find the length of the longest substring of repeating characters.
            Examples:
            longRepeat("aaa") => 3
            longRepeat("a") => 1
            longRepeat("bdsagbgagggaaatttyyyyau") => 4
            longRepeat("abcdefghijklmnopqrstuvwxyz") => 1
            longRepeat("") => 0
         * 
         */
         public static int longRepeat(string strToCheck)
        {
            int numRepeat = 0;
            string theLetter;
            string letter;

            if (strToCheck.Length > 0)
            {
                for (int i = 0; i < strToCheck.Length; i++)
                {
                    letter = strToCheck.Substring(i, 1);
                    //numRepeat = numRepeat + 1;
                    int curNum = 1;

                    for (int ii = i+1; ii < strToCheck.Length; ii++)
                    {
                        
                        if (strToCheck.Substring(ii, 1) == letter)
                        {
                            curNum = curNum + 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (curNum > numRepeat )
                    {
                        theLetter = letter;
                        numRepeat = curNum;
                    }
                    
                    
                    //Console.WriteLine(letter);
                }
            }
            return numRepeat;
        }
    }


}
