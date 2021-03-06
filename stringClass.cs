using System;

namespace StringApplication {

   class StringProg {
   
      static void Main(string[] args) {
         string str1 = "This is test";
         string str2 = "This is text";

         if (String.Compare(str1, str2) == 0) {
            Console.WriteLine(str1 + " and " + str2 +  " are equal.");
         } else {
            Console.WriteLine(str1 + " and " + str2 + " are not equal.");
         }
         string str = "This is test";
         if (str.Contains("test")) {
            Console.WriteLine("The sequence 'test' was found.");
         }
         string str = "Last night I dreamt of San Pedro";
         string substr = str.Substring(23);//Getting a Substring
         Console.WriteLine(substr);//San Pedro
         
         string[] starray = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};
         string strr = String.Join("\n", starray);
         Console.WriteLine(strr);
         
         Console.ReadKey() ;
      }
   }
}
