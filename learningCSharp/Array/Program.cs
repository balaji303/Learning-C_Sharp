using System;

namespace ArrayLoop
{
  class ArrayClass
  {
      static void Main(string[] args)
      {
        string[] alpha = {"a","bb","z","ccc"};
        int[] numbers = {1,2,3,77,4};
        Console.WriteLine(alpha[0]+ ' ' +alpha[1]);
        Array.Sort(alpha);
        foreach (var item in alpha)
        {
          Console.WriteLine(item);
        }
        Console.WriteLine(numbers.Max());
        Console.WriteLine(numbers.Min());
      }
  }
}