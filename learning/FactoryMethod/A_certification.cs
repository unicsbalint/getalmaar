using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.FactoryMethod
{
    class A_certification : ICertification
    {
        public void Certificate()
        {
            Console.WriteLine("Gets A certification");
        }
    }
}
