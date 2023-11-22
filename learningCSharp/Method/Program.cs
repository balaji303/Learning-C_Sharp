using System;

namespace UsingMethod
{
  class UsingMethodClass
  {
    static int myNum(int x,int y)
    {
        return (x+y);
    }
    static void Main(string[] args)
    {
      Func();
      int z = myNum(2,3);
      Console.WriteLine("Value of z:"+z);
    }

    static void Func()
    {
      Console.WriteLine("Hi! from Func");
    }
  }
}