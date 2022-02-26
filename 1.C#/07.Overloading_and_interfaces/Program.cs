using System;

namespace Overloading_and_interfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Angle angle1 = new Angle(2,45,23);
            Angle angle2 = new Angle(4, 45, 23);
            Angle angle3 = angle1 + angle2;
            angle1.ComputeAngle();
            angle2.ComputeAngle();
            Console.WriteLine("The sum of the angles is: ");
            angle3.ComputeAngle();


            Angle angle4 = new Angle(57, 3444, 4565);
            Console.WriteLine();
            Angle angle5 = angle3 + angle4;
            angle3.ComputeAngle();
            angle4.ComputeAngle();
            Console.WriteLine("The sum of the angles is: ");
            angle5.ComputeAngle();
            Console.WriteLine();

            Angle angle6 = new Angle(311, 45, 53);


            angle3.ComputeAngle();
            angle6.ComputeAngle();
            Angle angle7 = angle3 + angle6;
            Console.WriteLine("The sum of the angles is: ");
            angle7.ComputeAngle();
            Console.WriteLine();



            angle5.ComputeAngle();
            angle6.ComputeAngle();
            
            Console.WriteLine("The difference of the angles is: ");
            Angle angle8 = angle6 - angle5;
            angle8.ComputeAngle();



            Console.WriteLine("***** Sorting Array of cars *****\n");
            // Make an array of Car types.
            Car[] myAutos = new Car[5]
            {
                new Car {ID=1, Marka="Dacia", Speed=150 },
                new Car {ID=234, Marka="Ford", Speed=170 },
                new Car {ID=34, Marka="BMW", Speed=220 },
                new Car {ID=45, Marka="Audi", Speed=200 },
                new Car {ID=5, Marka="Mazda", Speed=180 }
            };

            // Dump current array.
            Console.WriteLine("Here is the unordered set of cars:");
            foreach (Car c in myAutos)
                Console.WriteLine(c);

            // Now, sort them using IComparable!
            Array.Sort(myAutos);

            // Dump sorted array.
            Console.WriteLine("\nHere is the ordered set of cars:");
            foreach (Car c in myAutos)
                Console.WriteLine(c);

            // Now sort by speed.
            Array.Sort(myAutos, Car.SortByMarka);

            // Dump sorted array.
            Console.WriteLine("\nOrdering by speed:");
            foreach (Car c in myAutos)
                Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
