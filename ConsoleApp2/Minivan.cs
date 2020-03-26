using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Minivan:Car
    {
        
        private int maxNumberOfSeats = 10;
        private int numberOfSeats = 4;
        public Minivan(int numberOfSeats, string carName, int id) : base(carName, id, 1000)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override string Name => "Minivan";
        public override int GetSpeed()
        {
            return 150;
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

        public override string ToString()
        {
            return base.ToString() + $",Number of Seats{NumberOfSeats}";
        }
        public override void PrintInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}
