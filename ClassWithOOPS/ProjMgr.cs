using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithOOPS
{
    public class ProjMgr:Employee
    {
        public ProjMgr()
        {
            
        }
        public ProjMgr(string Value, int Id, int Salery)
        {
            base.name = Value;
            base.id = Id;
            base.baseSalery = Salery;
        }

        public override int calculateSalery()
        {
            int ta = 2000, hra = 5000, projBouns = 10000;

            int totalSal = ta + hra + projBouns+ baseSalery;

            return totalSal;
        }
    }
}
