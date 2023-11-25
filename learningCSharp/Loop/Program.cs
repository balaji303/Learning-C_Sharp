using System;

namespace forLoop
{
  class forloopClass
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter Max:");
      int MaxValue = Convert.ToInt32(Console.ReadLine()), i = 1;
      // do
      // {
      //   Console.WriteLine("i="+i);
      //   i++;
      // } while (i<=MaxValue);
      for (;i<=MaxValue;i++)
      {
        Console.WriteLine("i="+i);
      }
    }
  }
}