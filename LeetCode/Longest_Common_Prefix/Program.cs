using System.Text;

namespace Longest_Common_Prefix
{
    internal class Program
    {
        //Difficulty: Easy
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {

            StringBuilder strB = new StringBuilder();
            string word = strs[0];
            int i = 0;
            while (i < word.Length)
            {
                char letter = word[i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (i > strs[j].Length - 1 || strs[j][i] != letter)
                    {
                        return strB.ToString();
                    }
                }
                strB.Append(letter);
                i++;
            }
            return strB.ToString();
        }
    }
}