using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.Visitor_min
{
    class VisitorCsakNincsIdoMegirniRendesen
    {
        public abstract class BFa
        {
            BFa bal, jobb;
            public BFa Bal { get { return bal; } }
            public BFa Jobb { get { return jobb; } }
            public BFa(BFa bal, BFa jobb)
            {
                this.bal = bal;
                this.jobb = jobb;
            }
            public BFa() : this(null, null) { }
            public abstract void Accept(Visitor v);
        }
        public class Fa : BFa
        {
            int szám;
            public int Szám { get { return szám; } }
            public Fa(int szám, BFa bal, BFa jobb) : base(bal, jobb)
            {
                this.szám = szám;
            }
            public override void Accept(Visitor v)
            {
                v.VisitFa(this);
            }
        }
        public class Levél : BFa
        {
            int szám;
            public int Szám { get { return szám; } }
            public Levél(int szám) : base()
            {
                this.szám = szám;
            }
            public override void Accept(Visitor v)
            {
            v.VisitLevél(this);
            }
        }
        public abstract class Visitor
        {
            public abstract void VisitFa(Fa f);
            public abstract void VisitLevél(Levél f);
        }
        public class SumVisitor : Visitor
        {
            int sum = 0;
            public int Sum { get { return sum; } }
            public override void VisitFa(Fa f)
            {
                sum += f.Szám;
                if (f.Bal != null) f.Bal.Accept(this);
                if (f.Jobb != null) f.Jobb.Accept(this);
            }
            public override void VisitLevél(Levél f)
            {
                sum += f.Szám;
            }
        }
        public class MaxVisitor : Visitor
        {
            int max = int.MinValue;
            public int Max { get { return max; } }
            public override void VisitFa(Fa f)
            {
                if (f.Szám > max) max = f.Szám;
                if (f.Bal != null) f.Bal.Accept(this);
                if (f.Jobb != null) f.Jobb.Accept(this);
            }
            public override void VisitLevél(Levél f)
            {
                if (f.Szám > max) max = f.Szám;
            }
        }

    }
}
