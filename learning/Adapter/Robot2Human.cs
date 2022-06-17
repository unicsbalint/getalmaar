using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.Adapter
{
    class Robot2Human : Human
    {
        Robot robi;
        public Robot2Human(Robot robi)
        {
            this.robi = robi;
        }

        public override string GetName()
        {
            return robi.GetID();
        }

        public override int GetIQ()
        {
            return robi.GetMemory();
        }
    }
}
