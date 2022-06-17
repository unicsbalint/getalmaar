using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.Decorator
{
    class AudiA5 : VehicleBase
    {
        public override string Make { get { return "Audi"; } }
        public override string Model { get { return "A5"; } }
        public override int HireLaps { get { return 10; } }
        public override double HirePrice { get { return 20000; } }

    }
}
