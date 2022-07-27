using System;

namespace LongestWord
{
  class Program
  {
    static void Main(string[] args)
    {
    	
      Console.WriteLine("Enter a String : ");
      string s = Console.ReadLine();
      string[] words = s.Split(' ');
      
      int max = 0;
      //int position = 0;
      
      for(int i=0;i< words.Length;i++)
      {
      	string s1 = words[i];
        int len = s1.Length;
      	if(len > max)
        {
        	max = i;
        }
      }
      
      Console.WriteLine("Longest word in the string is : "+words[max]);
     
    }
  }
}