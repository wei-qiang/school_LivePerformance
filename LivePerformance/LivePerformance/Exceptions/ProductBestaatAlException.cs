using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Exceptions
{
    public class ProductBestaatAlException: Exception
    {
        public ProductBestaatAlException(string message)
            :base(message)
        {
            
        }
    }
}
