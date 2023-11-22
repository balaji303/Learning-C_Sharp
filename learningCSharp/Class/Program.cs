using System;


namespace testClass
{
  class dupliClass
  {
    public void ClonePrint()
    {
      Console.WriteLine("Hello Clone");
    }
  }
  class orginalClass
  {
    string music = "Guitar";
    static void Main(string[] args)
    {
      dupliClass blues = new dupliClass();
      blues.ClonePrint();
      orginalClass dup = new orginalClass();
      Console.WriteLine(dup.music);
    }
  } 
}