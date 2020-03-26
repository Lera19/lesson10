using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface IVehicle1
    {
        string Name { get; }
        int GetSpeed();

        void PrintInfo();

    }
}
