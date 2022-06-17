using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.Template_min
{
    class TemplateDeNincsIdomMegirniRendesen
    {
        public abstract class Ital
        {
            public void Elkészít()
            {// Ez a függvény nem kapta meg a virtual jelzőt a sorrend betartása miatt.
                vízforraló();// kötelező és közös lépés
                főz(); // inversion of control, mert a gyermek főz metódusa fog futni
                édesít(); // kötelező és nem közös lépés
                rum(); // opcionális
            kitölt();
            }
            private void vízforraló() // kötelező közös lépés
            {// Ennek szintén nem kell felűlírhatónak lennie
                Console.WriteLine("Vízforralás 98..99..100c");
            }
            protected abstract void főz(); // Ki kell dolgoznia a konkrét osztálynak.
            protected abstract void édesít(); // Ezek kötelező nem közös lépések.
            protected virtual void rum() { } // Ez egy hook, vagyis egy opcionális lépés.
            private void kitölt() // kötelező közös lépés
            {
                Console.WriteLine("Egy szép porceláncsészébe öntöm az italt\n");
            }
        }
        public class Tea : Ital
        {
            protected override void főz()
            {
                // ezt ki kell dolgozni, hiszen másképp főzök teát, mint kávét
                Console.WriteLine("Belógatom és tunkolom a tea filtert");
            }
            protected override void édesít()
            {
                Console.WriteLine("Kis cukor, és egy kis citrom ízlés szerint");
            }
        }
        public class Kávé : Ital
        {
            protected override void főz()
            {
                // ezt ki kell dolgozni, hiszen másképp főzök teát, mint kávét
                Console.WriteLine("Leforrázom a kávét egy jó török kávé kedvéért.");
            }
            protected override void édesít()
            {
                Console.WriteLine("Kis cukor, és egy kis tej ízlés szerint");
            }
        }
        
    }
}
