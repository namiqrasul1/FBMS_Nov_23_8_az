using ConsoleApp1.Enums;

namespace ConsoleApp1.Helpers
{

    internal static class RandomGenerator
    {
        private static Random _random = new Random();

        public static string GenerateString(int len, RandomStringType type)
        {
            string str = type switch
            {
                RandomStringType.Numeric => "0123456789",
                RandomStringType.Alpha => "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                RandomStringType.AlphaNumeric => "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789",
                _ => throw new ArgumentException()
            };

            string result = string.Empty;
            for (int i = 0; i < len; i++)
            {
                result += str[_random.Next(0, str.Length)];
            }
            return result;
        }
    }
}
