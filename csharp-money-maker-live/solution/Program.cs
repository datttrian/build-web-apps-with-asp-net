using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {   
          // Greet the user and get input
          Console.WriteLine("Welcome to Money Maker!");
          Console.Write("Enter an amount to convert to coins: ");
          string totalAsString = Console.ReadLine();
          double total = Convert.ToDouble(totalAsString);
          Console.WriteLine($"{total} is equal to ...");

          // Define coin values
          int goldValue = 10;
          int silverValue = 5;

          // Calculate the change
          double goldCoins = Math.Floor(total / goldValue);
          double remainder = total % goldValue;


          double silverCoins = Math.Floor(total / silverValue);
          remainder = total % silverValue;

          // Print the results
          Console.WriteLine($"Gold coins: {goldCoins}");
          Console.WriteLine($"Silver coins: {silverCoins}");
          Console.WriteLine($"Bronze coins: {remainder}");
        }
    }
}
