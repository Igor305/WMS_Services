#nullable disable

namespace DataAccessLayer.Entities.AvroraWMS
{
    public partial class Provider
    {
        public int CompCode { get; set; }
        public string CompName { get; set; }
        public int? GmsId { get; set; }
        public string SourceCreateComps { get; set; }
    }
}
