using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public static class calc
    {
        public static void OuterDevide(int a, int b)
        {
            try
            {
                // Devide(10, 0);
                Devide(a, b);
            }

            catch (DivideByZeroException exp1)
            {
                throw ;
            }
            catch (CustomException custe)
            {
                throw;
            }
            catch (Exception exp2)
            {
                throw ;
            }
        }
        public static int Devide(int a, int b)
        {
            int ret = 0;
            if (b==0)
            throw new CustomException("My custom exception");
            ret = a / b;

            return ret;
        }
    }
}
