using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    class Sportscar : Automobile
    {
        private int maxSpeed;
        public int color;
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public Sportscar(string brand, int horsePower, int maxSpeed) : base (brand, horsePower)
        {
            this.maxSpeed = maxSpeed;
        }

    }
}
