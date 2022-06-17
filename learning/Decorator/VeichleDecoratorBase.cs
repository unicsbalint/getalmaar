using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.Decorator
{
    public abstract class VehicleDecoratorBase : VehicleBase // a dekorátor osztály
    {
        private VehicleBase vehicle; // HAS-A kapcsolat, ezt csomagoljuk be
        public VehicleDecoratorBase(VehicleBase v) { vehicle = v; }
        public override string Make { get { return vehicle.Make; } }
        public override string Model { get { return vehicle.Model; } }
        public override double HirePrice { get { return vehicle.HirePrice; } }
        public override int HireLaps { get { return vehicle.HireLaps; } }
    }
}
