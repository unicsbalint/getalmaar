using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    class Automobile : ICloneable
    {
        public Automobile(string brand,int horsePower)
        {
            this.brand = brand;
            this.horsePower = horsePower;
        }
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private int horsePower;

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        public object Clone() { return this.MemberwiseClone(); }
    }
}
