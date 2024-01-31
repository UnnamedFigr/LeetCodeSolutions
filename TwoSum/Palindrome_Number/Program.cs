namespace Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Difficulty: Easy
            Console.WriteLine("Hello, World!");
        }
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                int reversed = 0;
                int temp = x;
                while (temp > 0)
                {
                    reversed = reversed * 10 + temp % 10;
                    temp /= 10;
                }
                return reversed == x;
            }
        }
    }
}