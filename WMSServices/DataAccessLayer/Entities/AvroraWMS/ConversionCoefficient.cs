#nullable disable

namespace DataAccessLayer.Entities.AvroraWMS
{
    public partial class ConversionCoefficient
    {
        public short Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public decimal Coefficient { get; set; }
    }
}
