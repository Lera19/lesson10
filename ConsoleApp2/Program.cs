using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var vehicle1s = new List<IVehicle1>
            {
                new Minivan(5, "BMV", 1),
                new Minivan(5, "Kalina", 15),
                new Bus(25,"ORN", 333),
                new Bike(),
                new Train(),
                new Van(
                    100,
                    100000,
                    new Insurence(DateTime.Now, DateTime.Now, "Valeriia"),
                    "Lada",
                    10,
                    12000),

            };
            foreach (IVehicle1 car in vehicle1s)
            {
                Console.WriteLine(car.Name + " ");
                Console.WriteLine("Speed: " + car.GetSpeed());
            }

            IVehicle1 van = new Van(
               100,
               100000,
               new Insurence(DateTime.Now, DateTime.Now, "Valeriia"),
               "Lada",
               10,
               12000);

            van.PrintInfo();
        }
    }
}


            //Car[] cars = new Car[3];
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    cars[i] = new Car();

            //    Console.WriteLine("Please enter car's name:");
            //    cars[i].Name = Console.ReadLine();

            //    Console.WriteLine("Please enter car's price:");
            //    cars[i].Price = int.Parse(Console.ReadLine());

            //    //Console.WriteLine("Input color:");
            //    //cars[i].Color = Console.ReadLine();
            //}

            //Console.WriteLine($"Source price: {cars[0].Price} ; Price after sale: {cars[0].GetSale()}");