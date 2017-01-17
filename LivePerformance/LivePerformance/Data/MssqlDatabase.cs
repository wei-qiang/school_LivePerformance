using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Data
{
    public abstract class MssqlDatabase
    {
        protected const string Connstring = @"Data Source=mssql.fhict.local;Initial Catalog=dbi344145;Integrated Security=False;User ID=dbi344145;Password=liveperformance;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    } 
}
