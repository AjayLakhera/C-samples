using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithOOPS
{
    public enum EmpType
    {
        JSE,
        SE,
        AssistantManager
    }
    public abstract class Employee
    {
        public int id;
        public string name;
        EmpType empType;
        public int baseSalery;

        public string EmpName
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }

        public abstract int calculateSalery();


    }
}
