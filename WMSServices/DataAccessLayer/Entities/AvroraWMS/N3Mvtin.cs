using System;

#nullable disable

namespace DataAccessLayer.Entities.AvroraWMS
{
    public partial class N3Mvtin
    {
        public DateTime Mi3datmvt { get; set; }
        public string Mi3cproin { get; set; }
        public string Mi3cecart { get; set; }
        public decimal Mi3qteuvc { get; set; }
        public long? Mi3numorc { get; set; }
        public string Mi3cexops { get; set; }
        public bool? SyncToGms { get; set; }
        public long? Mi3noinvs { get; set; }
    }
}
