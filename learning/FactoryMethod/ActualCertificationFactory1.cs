using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.FactoryMethod
{
    class ActualCertificationFactory1 : CertificationFactory
    {
        public override ICertification certification()
        {
            return new A_certification();
        }
    }
}
