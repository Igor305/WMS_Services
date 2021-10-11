using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer.Entities.AvroraWMS
{
    [Keyless]
    public class CrTemp
    {
        public decimal Nlotpr { get; set; }
        public decimal Nligpr { get; set; }
        public string Donord { get; set; }
        public string Depot { get; set; }
        public string Ean { get; set; }
        public string Cproin { get; set; }
        public string Arprom { get; set; }
        public string Ilogis { get; set; }
        public string Livrea { get; set; }
        public decimal Uvreel { get; set; }
        public decimal? Qauvreel { get; set; }
        public string Usscc { get; set; }
        public string Csscc { get; set; }
        public string Block { get; set; }
        public string Adrums { get; set; }
        public DateTime? Datcre { get; set; }
        public string Libpro { get; set; }
    }
}
