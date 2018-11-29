using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Bike : IFactory
    {
        public void Drive(int km)
        {
            Console.WriteLine("Bike going with: {0} km/h", km);
        }
    }
}
