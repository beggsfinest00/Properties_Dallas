using System;
using System.Collections.Generic;
using System.Text;

namespace Properties_Dallas
{
    class Program
    {
        static void Main(string[] args)
        {
            //assinges an object called car and gives it a make and model.
            Car car = new Car();
            car.Make = "Ford";
            car.Model = "Mustang";

            //prints car make and model to the console.
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            //assinges an object called car2 and gives it a make and model.
            Car car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Camero";

            //prints car make and model to the console.
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            //assins an object called car3 and prints make and model to the console but make and model will be blank
            Car car3 = new Car();
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");


        }
    }
}
