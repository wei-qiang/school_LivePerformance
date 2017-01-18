using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Models;

namespace LivePerformance.Data
{
    public interface IArtikelContext
    {
        List<Artikel> GetAllArtikelen();
    }
}
