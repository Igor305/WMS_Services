using System;

#nullable disable

namespace DataAccessLayer.Entities.AvroraWMS
{
    public partial class Icstier
    {
        public int DataActionType { get; set; }
        public int StockCode { get; set; }
        public int DepoCode { get; set; }
        public int ProdOwnerCode { get; set; }
        public int CompType { get; set; }
        public string CompCode { get; set; }
        public string AlternatyveCompCode { get; set; }
        public string ValueAddedTaxCode { get; set; }
        public string ShortCompName { get; set; }
        public string CompName1 { get; set; }
        public string CompName2 { get; set; }
        public string CompName3 { get; set; }
        public string CompAddress1 { get; set; }
        public string CompAddress2 { get; set; }
        public string CompPost { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostIndex { get; set; }
        public int? CountryCode { get; set; }
        public short Ecidentifier { get; set; }
        public string ShortCountryName { get; set; }
        public string LongCountryName { get; set; }
        public int? AlcoholManagement { get; set; }
        public string Contact { get; set; }
        public string Phone1 { get; set; }
        public string Fax { get; set; }
        public string Telex { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public short LateDelivery { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string UserName { get; set; }
        public string Comments { get; set; }
    }
}
