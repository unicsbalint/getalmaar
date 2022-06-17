using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    class AutoFactory
    {
        public Automobile[] StartProduction(Automobile auto, int horsePower, int count)
        {
            Automobile[] productionArray = new Automobile[count];
            for (int i = 0; i < count; i++)
            {
                productionArray[i] = (Automobile)auto.Clone();
                productionArray[i].HorsePower = 200;
            }
            return productionArray;
        }
    }
}
