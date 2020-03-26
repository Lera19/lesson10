using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Bus : Car
    {

        private int maxNumberOfSeats = 40;
        private int numberOfSeats = 20;
        public Bus(int numberOfSeats, string carName, int id) : base(carName, id, 1000)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override string Name => "Bus";
        public override int GetSpeed()
        {
            return 100;
        }
        public int NumberOfSeats
        {
            get => numberOfSeats;
            set
            {
                if (value < 0 || value > maxNumberOfSeats)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    numberOfSeats = value;
                }
            }
        }

        //public override string ToString()
        //{
        //    return base.ToString() + $",Number of Seats{NumberOfSeats}";
        //}
        //public override void PrintInfo()
        //{
        //    Console.WriteLine(ToString());
        //}
    }
}
