using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Devide(10, 0);
                calc.OuterDevide(10,0);
            }
            
            catch (DivideByZeroException exp1)
            {
                Console.WriteLine($"Error in fun:- {exp1.Message}");
            }
            catch (CustomException custexp)
            {
                Console.WriteLine($"Error in fun:- {custexp.Message}");
            }
            catch (Exception exp2)
            {
                Console.WriteLine($"Error in fun:- {exp2.Message}");
            }
        }
        public static int Devide( int a, int b)
        {
            int ret = 0;
            if (b < a)
                throw new Exception("New Error ");
            ret = a / b;

            return ret;
        }

    }
}
