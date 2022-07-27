using System;
namespace palindromecheck {
   class Program {
      static void Main(string[] args) {

         string s;
         s = Console.ReadLine();
         
         int len = s.Length;
         int flag = 1;
         
         for(int i = 0, j = (len-1); i< len/2; i++,j--)
         {
             if(s[i] != s[j])
             {
                 flag = 0;
                 break;
             }
         }
         
         if(flag == 1)
         {
             Console.WriteLine("String is not palindrome");
         }
         else
         {
             Console.WriteLine("String is palindrome"); 
         }
         
      
      }
   }
}