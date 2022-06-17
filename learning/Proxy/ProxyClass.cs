using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.Proxy
{
    class ProxyClass : Item
    {
        private Hammer hammer;
        public override void Request()
        {
            if (hammer == null) { hammer = new Hammer(); }
            hammer.Request();
        }

    }
}
