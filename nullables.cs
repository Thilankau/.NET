using System;

namespace CalculatorApplication {
   class NullablesAtShow {
      static void Main(string[] args) {
         int? num1 = null;
         int? num2 = 45;
         
         double? num3 = new double?();
         double? num4 = 3.14157;
         double num5;
         bool? boolval = new bool?();

         // display the values
         Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
         Console.WriteLine("A Nullable boolean value: {0}", boolval);
         
         num5 = num1 ?? 5.34;      
         Console.WriteLine(" Value of num3: {0}", num5);
         
         num5 = num2 ?? 5.34;
         Console.WriteLine(" Value of num3: {0}", num5);
         
         Console.ReadLine();
      }
   }
}
