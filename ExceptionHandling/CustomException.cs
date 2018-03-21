using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class CustomException:ApplicationException
    {
        public CustomException() : base() 
        {
        }

        public CustomException(string message) : base(message)
        {
        }
        public CustomException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}
