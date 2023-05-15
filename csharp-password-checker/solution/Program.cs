using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {  
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopgrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "~!@#$%^&*-+";

      Console.Write("Enter a password: ");
      string password = Console.ReadLine();
      
      int score = 0;

      if (password.Length >= minLength)
      {
        score++;
      }
      if (Tools.Contains(password, uppercase))
      {
        score++;
      }
      if (Tools.Contains(password, lowercase))
      {
        score++;
      }
      if (Tools.Contains(password, digits))
      {
        score++;
      }
      if (Tools.Contains(password, specialChars))
      {
        score++;
      }
      
      switch (score)
        {
          case 5:
          case 4:
            Console.WriteLine("Wow, your password is sooo strong!");
            break;
          case 3:
            Console.WriteLine("Nice, your password is strong.");
            break;
          case 2:
            Console.WriteLine("Eh, your password is medium.");
            break;
          case 1:
            Console.WriteLine("Oof, your password is weak!");
            break;
          default:
            Console.WriteLine("Sorry, your password doesn't meet any of our requirements!");
          break;
        }
    }
  }
}
