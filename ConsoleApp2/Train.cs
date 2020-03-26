using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Train: IVehicle1
    {
        public string Name => "Train";
        public virtual int GetSpeed()
        {
            return 230;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine(Name);
        }
    }
}
