public class Exercise16
 {
  	static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
	    string s = Console.ReadLine();
	    Console.WriteLine("String After Swapping last and first character"+first_last(s)); 

        }
       public static string first_last(string s)
        {
         	String str = s.Substring(ustr.Length - 1) + s.Substring(1, ustr.Length - 2) + s.Substring(0, 1);
		return str;
        }
}