using System;

namespace Classes
{
   class Program
   {
      static void Main(string[] args)
      {
         var manufacturer = new Manufacturer();
         manufacturer.SetCar();
      }
   }

   class Car
   {
      public int NumberOfWheels { get; set; }
      public int NumberOfHorns { get; set; }

      public override string ToString()
      {
         return $"I have {NumberOfWheels} wheels and {NumberOfHorns} horn.";
      }
   }

   class Manufacturer
   {
      public string Name { get; set; }

      public void SetCar()
      {
         var car = new Car();
         car.NumberOfHorns = 1;
         car.NumberOfWheels = 4;

         Console.WriteLine(car);
      }
   }
}
