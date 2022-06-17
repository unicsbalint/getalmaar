using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.Proxy
{
    class Hammer : Item
    {
        public override void Request()
        {
            Console.WriteLine("Hammer's query method");
        }
    }
}
