namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 121;

            bool result = IsPalindrome(x);

            Console.WriteLine("Input: " + x);
            Console.WriteLine("Output:" +x);

            Console.ReadLine();
        }

        public static bool IsPalindrome(int x)
        {
            // Step 1: Negative numbers are NOT palindrome
            if(x<0)
                return false;
            // Step 2: Store original value

            int original = x;
            int reversed = 0;

            // Step 3: Reverse the number
            while (x > 0)
            {
                int digit = x % 10;
                reversed = reversed*10+digit;
                x = x / 10;
            }
            // Step 4: Compare original and reversed
            return original == reversed;
        }
    }
}
