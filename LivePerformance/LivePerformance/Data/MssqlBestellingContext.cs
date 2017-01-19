using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Models;

namespace LivePerformance.Data
{
    public class MssqlBestellingContext: MssqlDatabase, IBestellingContext
    {
        public Bestelling GetBestellingbyId(int id)
        {
            throw new NotImplementedException();
        }

        public void AddBestelling()
        {
            throw new NotImplementedException();
        }
    }
}
