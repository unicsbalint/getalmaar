using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.FactoryMethod
{
    class ActualCertificationFactory2 : CertificationFactory
    {
        public override ICertification certification()
        {
            return new B_certification();
        }
    }
}
