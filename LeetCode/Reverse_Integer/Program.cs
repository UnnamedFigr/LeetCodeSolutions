namespace Reverse_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Difficulty: Medium
            return;
        }
        public int Reverse(int x)
        {
            bool isNegative = false;
            if (x < int.MinValue || x > int.MaxValue)
            {
                return 0;
            }
            if (x < 0)
            {
                isNegative = true;
                x *= (-1);
            }
            char[] array = new char[20];
            int count = 0;
            while (x != 0)
            {
                int digit = x % 10;
                array[count] = (char)('0' + digit);
                x /= 10;
                count++;
            }
            string result = new string(array);
            int.TryParse(result, out int intResult);
            return isNegative ? intResult * (-1) : intResult;
        }  
    }
}