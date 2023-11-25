// See https://aka.ms/new-console-template for more information
//dotnet new console -o testApp
//dotnet run
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int y = 10;
      int x= 5,z=2;
      double aa = 5.55;
      char b = 'b';
      bool c = true;
      string d = "abcd";
      Console.WriteLine("Hello World!");    
      Console.Write("\nBalaji\n\rWelcome:");    
      Console.Write(x+y+z);
      Console.WriteLine(aa);
      Console.Write(b);
      Console.Write(c);
      Console.Write(d);
      //Type Caste
      Console.WriteLine(Convert.ToString(aa));
      // Read Input
      // string username = Console.ReadLine();
      // Console.WriteLine(username);
      long num = Convert.ToInt64(Console.ReadLine());
      Console.WriteLine(num);
      Console.WriteLine(Math.Max(x,num));
    }
  }
}