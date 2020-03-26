using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Bike : IVehicle1
    {
        public string Name => "Bike";
        public virtual int GetSpeed()
        {
            return 15;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine(Name);
        }
    }
}
