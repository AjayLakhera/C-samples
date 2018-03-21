using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            jSoftEng jsoftEng = new jSoftEng { name="Lax", id=201,baseSalery=4000};
            ProjMgr projmgr = new ProjMgr { name = "Ajay", id = 323,baseSalery=345 };
            Console.WriteLine("Jonior name"+jsoftEng.EmpName);
            Console.WriteLine("Manager name" + projmgr.EmpName);

            TestInterfaceImpl tinterface = new TestInterfaceImpl();
            tinterface.color();
            tinterface.Type();
        }
    }
}
