namespace Roman_To_Integer
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
        public static Dictionary<char, int> romanLetters = new Dictionary<char, int>()
    {
         { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
    };

        public int RomanToInt(string s)
        {
            int result = 0;
            int len = s.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int current = romanLetters[s[i]];
                int next = romanLetters[s[i + 1]];
                if (current > next)
                {
                    result += current;
                }
                else if (current == next)
                {
                    result += current;
                }
                else
                {
                    result -= current;
                }
            }
            // We need to add the last element, because 'i' iterates to the element before the last one.
            result += romanLetters[s[len - 1]];
            return result;
        }
    }
}