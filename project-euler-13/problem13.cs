using System;
using System.IO;
/*  Large Sum
* Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
* -> numbers.txt
*/

namespace ProjectEuler
{
  class Problem13
  {
    static void Main(string[] args)
    {
      Console.WriteLine("The Euler Project");
      Console.WriteLine("Problem 13\n");

      try
      {
        using (StreamReader sr = new StreamReader("numbers.txt"))
        {
          String number = sr.ReadToEnd();
          Console.WriteLine(number);
        }
      }
      catch (IOException e)
      {
        Console.WriteLine("The file could not be read:");
        Console.WriteLine(e.Message);
      }

    }
  }
}