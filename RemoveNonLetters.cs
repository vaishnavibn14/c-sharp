using System;
using System.Text.RegularExpressions;

namespace RemoveNonLetters
{
    class Program
    {

	 public static string removeNonLetter(string s)
        {
            return Regex.Replace(s, @"[^a-zA-Z]", "");
        }

        static void Main(string[] args)
          {
            string s;
	   Console.WriteLine("Enter a String ");
	   s = Console.ReadLine();
            Console.WriteLine("String after removing all non characters: " + removeNonLetter(s));
        }

       
    }
}
