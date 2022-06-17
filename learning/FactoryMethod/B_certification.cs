using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.FactoryMethod
{
    class B_certification : ICertification
    {
        public void Certificate()
        {
            Console.WriteLine("Gets B certification");
        }
    }
}
