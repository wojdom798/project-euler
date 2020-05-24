using System;
using System.IO;

/* Problem 1
* If we list all the natural numbers below 10 that are multiples of 3 or 5,
* we get 3, 5, 6 and 9. The sum of these multiples is 23.
* Find the sum of all the multiples of 3 or 5 below 1000.
*/

namespace ProjectEuler
{
  class Problem1
  {
    static void Main(string[] args)
    {
      Console.WriteLine("The Euler Project");
      Console.WriteLine("Problem 1\n");

      string input;
      int value;
      Console.Write("Enter Integer: ");
      input = Console.ReadLine();
      value = Convert.ToInt32(input);

      int sum = 0;
      for (int i = 0; i < value; i++) {
        if ( (i % 3 == 0) || (i % 5 == 0) ) {
          sum += i;
        }
      }

      Console.WriteLine("Sum of the multiples of 3 or 5 below {0}: {1}", value, sum);
    }
  }
}