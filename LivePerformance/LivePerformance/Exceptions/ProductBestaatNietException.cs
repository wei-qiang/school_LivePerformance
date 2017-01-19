using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Exceptions
{
    public class ProductBestaatNietException: Exception
    {
        public ProductBestaatNietException(string message)
            :base (message)
        {
        }
    }
}
