using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithOOPS
{
    public class jSoftEng:Employee
    {
        public jSoftEng()
        {
           
        }
        public jSoftEng(string Value, int Id, int Salery)
        {
            base.name = Value;
            base.id = Id;
            base.baseSalery = Salery;
        }

        public override int calculateSalery()
        {
            int ta = 500, hra = 2000;

            int totalSal = ta + hra+ baseSalery;

            return totalSal;
        }

    }
}
