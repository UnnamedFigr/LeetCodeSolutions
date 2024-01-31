namespace Index_Of_First_Occurance_In_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Difficulty: Easy
            Console.WriteLine("Hello, World!");
        }

    }
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            int index = -1;

            if (haystack.Length < needle.Length) return -1;
            int i = 0;
            while (i <= haystack.Length - needle.Length)
            {
                int j = 0;
                while (j < needle.Length && haystack[i + j] == needle[j])
                {
                    j++;
                }
                if (j == needle.Length)
                {
                    index = i;
                    break;
                }
                i++;
            }
            return index;
        }
    }
}