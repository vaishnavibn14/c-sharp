using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter a string to convert into integer");
      string s = Console.ReadLine();    
      int i = Convert.ToInt32(s);
      Console.WriteLine(i);
      
      Console.WriteLine("Enter a integer to convert into string");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(a.ToString());
      
      
    }
  }
}