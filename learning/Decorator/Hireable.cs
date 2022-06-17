using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.Decorator
{
    public class Hireable : VehicleDecoratorBase
    {
        public Hireable(VehicleBase v) : base(v) { }
        public void Hire(string name)
        {
            Console.WriteLine(@"{0} {1} típust kölcsönzött {2} {3}$-ért {4}
           körre.\r\n", Make, Model, name, HirePrice, HireLaps);
        }
    }
}
