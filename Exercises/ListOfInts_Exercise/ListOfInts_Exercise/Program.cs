using System;
using System.Collections.Generic;

namespace ListOfInts_Exercise
{
   class Program
   {
      static void Main(string[] args)
      {
         var myList = new List<int>
         {
            1, 3, 5, 7, 9, 11, 13, 15
         };

         foreach (var theInt in myList)
         {
            Console.WriteLine(theInt);
         }
      }
   }
}
