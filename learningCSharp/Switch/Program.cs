using System;

namespace SwitchLoop
{
  class CSharpCode
  {
    static void Main(string[] args)
    {
      int x = 0;
      x = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(x);
      switch(x)
      {
        case 10:
          Console.WriteLine("Ten");
          break;

        case 50:
          Console.WriteLine("50");
          break;

        case 100:
          Console.WriteLine("100");
          break;

        default:
          Console.WriteLine("default");
          break;
      }
    }
  }
}