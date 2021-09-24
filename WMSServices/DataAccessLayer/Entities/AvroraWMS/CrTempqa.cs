using System;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataAccessLayer.Entities.AvroraWMS
{
    public partial class CrTempqa
    {
        public int Nlotpr { get; set; }
        public int Nligpr { get; set; }
        public string Donord { get; set; }
        public string Depot { get; set; }
        public string Ean { get; set; }
        public string Cproin { get; set; }
        public string Arprom { get; set; }
        public string Ilogis { get; set; }
        public string Livrea { get; set; }
        public long Uvreel { get; set; }
        public long? Qauvreel { get; set; }
        public string Usscc { get; set; }
        public string Csscc { get; set; }
        public string Block { get; set; }
        public string Adrums { get; set; }
        public DateTime? Datcre { get; set; }
    }
}
