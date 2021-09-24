using System;

#nullable disable

namespace DataAccessLayer.Entities.AvroraWMS
{
    public partial class Icsentor
    {
        public short TransferCode { get; set; }
        public short DepoCode { get; set; }
        public int StockCode { get; set; }
        public int OwnerProdCode { get; set; }
        public string ExternalDocId { get; set; }
        public long InternalDocId { get; set; }
        public short DocType { get; set; }
        public string ExternalCompId { get; set; }
        public int? SupplyChainCode { get; set; }
        public string ClientCode { get; set; }
        public string ExternalCompNameLong { get; set; }
        public string ExternalCompName { get; set; }
        public string ExternalCompAddress1 { get; set; }
        public string ExternalCompAddress2 { get; set; }
        public string ExternalCompCity { get; set; }
        public string PostIndex { get; set; }
        public string PostOffice { get; set; }
        public int? CountryCode { get; set; }
        public string CountryName { get; set; }
        public string Region { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Telex { get; set; }
        public string Email { get; set; }
        public string StandartPhone { get; set; }
        public string DirectPhone { get; set; }
        public string MobilePhone { get; set; }
        public DateTime PlannedDateDelivery { get; set; }
        public DateTime? MaxDateDelivery { get; set; }
        public int SubType { get; set; }
        public short PaymentIndicator { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public string LastModifyProgram { get; set; }
        public int? InternalPromoActionCode { get; set; }
        public string ExternalPromoActionCode { get; set; }
        public string CampaignCode { get; set; }
        public string GlobalLocationCode { get; set; }
        public string ContractorCarrierCode { get; set; }
        public int? GroupingCode { get; set; }
        public short? ReceivePickupIndicator { get; set; }
        public string ExternalCarrierCode { get; set; }
        public string CarrierContract { get; set; }
        public int? CarrierChainAddress { get; set; }
        public int? HomeDeliveryDocId { get; set; }
        public int? LockTagNumber { get; set; }
        public short? PalletAdvanceIndicator { get; set; }
        public string TransitStockNumber { get; set; }
        public int TransitDocId { get; set; }
        public bool? ToWms { get; set; }
    }
}
