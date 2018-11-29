using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Skateboard : IFactory
    {
        public void Drive(int km)
        {
            Console.WriteLine("Skateboard going with: {0} km/h", km);
        }
    }
}
