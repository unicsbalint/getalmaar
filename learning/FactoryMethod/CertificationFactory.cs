using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.FactoryMethod
{
    public abstract class CertificationFactory
    {
        public ICertification CreateCertification()
        {
            return certification();
        }
        public abstract ICertification certification();
    }
}
