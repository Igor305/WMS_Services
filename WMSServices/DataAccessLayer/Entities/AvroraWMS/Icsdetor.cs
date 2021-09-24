using System;

#nullable disable

namespace DataAccessLayer.Entities.AvroraWMS
{
    public partial class Icsdetor
    {
        public int StockCode { get; set; }
        public short DepoCode { get; set; }
        public int CargoOwnerCode { get; set; }
        public string ExternalDocId { get; set; }
        public int? InternalDocId { get; set; }
        public string SrcPosId { get; set; }
        public string ProdId { get; set; }
        public int ExternalCode { get; set; }
        public int? ProviderSrcPosId { get; set; }
        public decimal Qty { get; set; }
        public string Notes { get; set; }
        public string ProviderProdId { get; set; }
        public decimal? SalePrice { get; set; }
        public string ClientCode { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public string LastModifyProgram { get; set; }
        public int? PromoActionCode { get; set; }
        public int LinePrice { get; set; }
        public short AccountingArticles { get; set; }
        public string OrderedArticleCode { get; set; }
        public int? LogisticVariantOrderedArticle { get; set; }
        public string PromoActionCode2 { get; set; }
        public short? Indicator { get; set; }
        public int ActionCode { get; set; }
        public decimal QtyBefore { get; set; }
        public int? ReasonCode { get; set; }
        public string ProviderExternalCode { get; set; }
        public string ExternalCodeExternalDocId { get; set; }
        public int? SupplyChainCode { get; set; }
        public int? SupplyNumber { get; set; }
        public short? ReceivePickupIndicator { get; set; }
        public int? SalesRecordNumber { get; set; }
        public string ExternalConsumerCode { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostOffice { get; set; }
        public string Region { get; set; }
        public string Telephone { get; set; }
        public int? Idrnvoie { get; set; }
        public string Idrbtcq { get; set; }
        public string Idrtvoie { get; set; }
        public short? ProdBlockedCustoms { get; set; }
        public string CustomsDocId { get; set; }
        public DateTime? PlannedDeliveryDate { get; set; }
        public DateTime? DeadlineForDelivery { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public int? ReliabilityState { get; set; }
        public short? ReverseOrderControlIndicator { get; set; }
        public int? TransitDocId { get; set; }
        public bool? ToWms { get; set; }
    }
}
