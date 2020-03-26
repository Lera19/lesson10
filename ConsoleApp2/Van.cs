using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Van : Car
    {
        private int mileage = 0;
        private int maxCarrying = 5000;
        private int carrying = 100;
        public Van(int carrying, int mileage, Insurence insurence, string carName, int id, double price) : base(carName, id, 1000)
        {
            Carrying = carrying;
            Mileage = mileage;
            Insurence = insurence;
        }
        public override string Name => "Van";
        public Insurence Insurence { get; set; }
        

        
        public int Mileage { 
            get=> mileage;
            set
            {
                if (value<0)
                {
                    Console.WriteLine("iNVALID INPUT");
                }
                else
                {
                    mileage = value;
                }
            }
        }
        public int Carrying
        {
            get => carrying;
            set
            {
                if (value < 0 || value>maxCarrying)
                {
                    Console.WriteLine("iNVALID INPUT");
                }
                else
                {
                   carrying = value;
                }
            }
        }
        public override int GetSpeed()
        {
            return 90;
        }
        public override void PrintInfo()
        {
            Console.WriteLine(ToString());
        }



    }
}
