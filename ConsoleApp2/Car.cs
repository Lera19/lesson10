using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Car: IVehicle1
    {

        public Car(string carName, int id, double price)
        {
            CarName = carName;
            ID = id;
            Price = price;
        }
        public int ID { get; set; }
        public string CarName { get; set; }
        public double Price { get; set; }
        public virtual string Name => "Van";
        
        public double GetSale()
            {
            var saleSum = new Random().Next(5, 20);
            return Price = (saleSum / 100 * Price);
        }

        public override string ToString()
        {
            return $"Id: {ID}, Name: {CarName}, Price: {Price}";
        }
        public virtual int GetSpeed()
        {
            return 10;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

    }
}
