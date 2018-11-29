using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vehicle = new ConcreteVehicleFactory();

            IFactory bike = vehicle.GetVehicle("Bike");
            bike.Drive(12);

            IFactory skateboard = vehicle.GetVehicle("Skateboard");
            skateboard.Drive(7);

            Console.ReadLine();
        }
    }
}
