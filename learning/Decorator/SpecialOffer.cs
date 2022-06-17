using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.Decorator
{
    public class SpecialOffer : VehicleDecoratorBase // konkrét dekorátor osztály
    {
        public SpecialOffer(VehicleBase v) : base(v) { }
        public int Discount { get; set; }
        public int ExtraLaps { get; set; }
        public override double HirePrice
        {
            get
            {
                double price = base.HirePrice;
                int percentage = 100 - Discount;
                return Math.Round((price * percentage) / 100, 2);
            }
        }
        public override int HireLaps { get { return (base.HireLaps + ExtraLaps); } }
    }
}
