using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.Strategy
{
    class StrategyDeNincsIdoMegirniRendesen
    {
        public abstract class KávéStratégia
        {
            public abstract void KávéFőzés();
        }
        public class GyengeKávé : KávéStratégia
        {
            public override void KávéFőzés()
            {
                Console.WriteLine("Gyenge kávét főztél. Ha csak kicsit vagy fáradt.");
            }
        }
        public class NormalKávé : KávéStratégia
        {
            public override void KávéFőzés()
            {
                Console.WriteLine("Normál kávét főztél. Egy átlagos napra.");
            }
        }
        public class ErősKávé : KávéStratégia
        {
            public override void KávéFőzés()
            {
                Console.WriteLine("Egy erős kávé. A hosszú és fárasztó napokra.");
            }
        }
        public class KávéGép
        {
            private KávéStratégia kávéStratégia;
            public void KávéValasztás(KávéStratégia k)
            {
                kávéStratégia = k;
            }
            public void KávéFőzés()
            {
                kávéStratégia.KávéFőzés();
            }
        }
    }
}

