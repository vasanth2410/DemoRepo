using System;

namespace ConsoleApp7
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int carNumber = 16;

                Console.WriteLine("Car number is " + carNumber.IsEvenOrOdd());

                // Custom Exception usage
                ValidateCarNumber(carNumber);
            }
            catch (InvalidCarNumberException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }

            Console.ReadKey();
        }

        // Business logic method
        static void ValidateCarNumber(int number)
        {
            if (number <= 0)
            {
                throw new InvalidCarNumberException("Car number must be greater than zero");
            }
        }
    }

    // Extension Method Class
    public static class ExtensionMethodClass
    {
        public static string IsEvenOrOdd(this int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";

        }
    }
    // Custom Exception Class
    public class InvalidCarNumberException : Exception
    {
        public InvalidCarNumberException(string message) : base(message)
        {
        }
    }
}