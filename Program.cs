namespace FifteenC
{
    class ReverseText
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input text to be reversed: ");
                var input = Console.ReadLine();
                var reversed = ReverseString(input);
                Console.WriteLine(reversed);
            }
        }

        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

