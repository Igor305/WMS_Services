using DataAccessLayer.Entities.AvroraWMS;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataAccessLayer.AppContext
{
    public partial class AvroraWMSContext : DbContext
    {
        public AvroraWMSContext()
        {
        }

        public AvroraWMSContext(DbContextOptions<AvroraWMSContext> options)
            : base(options)
        {
            Database.SetCommandTimeout(60);
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ConversionCoefficient> ConversionCoefficients { get; set; }
        public virtual DbSet<CrTempqa> CrTempqas { get; set; }
        public virtual DbSet<CrTemp> CrTemps { get; set; }
        public virtual DbSet<Icsarticle> Icsarticles { get; set; }
        public virtual DbSet<IcsarticleOnline> IcsarticleOnlines { get; set; }
        public virtual DbSet<Icsdeol> Icsdeols { get; set; }
        public virtual DbSet<Icsdetor> Icsdetors { get; set; }
        public virtual DbSet<Icsentor> Icsentors { get; set; }
        public virtual DbSet<Icstier> Icstiers { get; set; }
        public virtual DbSet<N3Mvtex> N3Mvtices { get; set; }
        public virtual DbSet<N3Mvtin> N3Mvtins { get; set; }
        public virtual DbSet<N3Mvtre> N3Mvtres { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<SqlCommand> SqlCommands { get; set; }
        public virtual DbSet<SqlText> SqlTexts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=sql34;Initial Catalog=AvroraWMS;Persist Security Info=True;User ID=j-AvroraWMS-writer;Password=xv2H47k55Xiz7BmXH3Ar");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.CompCode)
                    .HasName("PK__Clients__969C5CE2F99B4AEF");

                entity.Property(e => e.CompCode).ValueGeneratedNever();

                entity.Property(e => e.CompName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.GmsId).HasColumnName("GmsID");

                entity.Property(e => e.SourceCreateComps)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConversionCoefficient>(entity =>
            {
                entity.ToTable("ConversionCoefficient");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Coefficient).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrTempqa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CR_TEMPQA");

                entity.Property(e => e.Adrums)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("ADRUMS");

               entity.Property(e => e.Arprom)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ARPROM");

                entity.Property(e => e.Block)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BLOCK");

                entity.Property(e => e.Cproin)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CPROIN");

                entity.Property(e => e.Csscc)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CSSCC");

                entity.Property(e => e.Datcre)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATCRE");

                entity.Property(e => e.Depot)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DEPOT");

                entity.Property(e => e.Donord)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DONORD");

                entity.Property(e => e.Ean)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("EAN");

                entity.Property(e => e.Ilogis)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ILOGIS");

                entity.Property(e => e.Livrea)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("LIVREA");

                entity.Property(e => e.Nligpr).HasColumnName("NLIGPR");

                entity.Property(e => e.Nlotpr).HasColumnName("NLOTPR");

                entity.Property(e => e.Qauvreel).HasColumnName("QAUVREEL");

                entity.Property(e => e.Usscc)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("USSCC");

                entity.Property(e => e.Uvreel).HasColumnName("UVREEL");
            });

            modelBuilder.Entity<Icsarticle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ICSARTICLE");

                entity.Property(e => e.ActionTypeStatic).HasColumnName("ActionType_Static");

                entity.Property(e => e.ArticleLogisticVersionStatic).HasColumnName("ArticleLogisticVersion_Static");

                entity.Property(e => e.ArticleTypeStatic).HasColumnName("ArticleType_Static");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BarCodeTransferCodeStatic).HasColumnName("BarCodeTransferCode_Static");

                entity.Property(e => e.BarCodeTypeStatic).HasColumnName("BarCodeType_Static");

                entity.Property(e => e.BoxHeightCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("BoxHeight_cm");

                entity.Property(e => e.BoxLengthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("BoxLength_cm");

                entity.Property(e => e.BoxWeightKg)
                    .HasColumnType("numeric(26, 14)")
                    .HasColumnName("BoxWeight_kg");

                entity.Property(e => e.BoxWidthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("BoxWidth_cm");

                entity.Property(e => e.CapacityValueStatic).HasColumnName("CapacityValue_Static");

                entity.Property(e => e.CompId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CompID");

                entity.Property(e => e.CompName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DepotCodeStatic).HasColumnName("DepotCode_Static");

                entity.Property(e => e.ExpirationDateOnCustomerStatic).HasColumnName("ExpirationDateOnCustomer_Static");

                entity.Property(e => e.ExpirationDateOnProviderStatic).HasColumnName("ExpirationDateOnProvider_Static");

                entity.Property(e => e.ExpirationDateOnShopStatic).HasColumnName("ExpirationDateOnShop_Static");

                entity.Property(e => e.ExpirationDateOnStockStatic).HasColumnName("ExpirationDateOnStock_Static");

                entity.Property(e => e.ExpirationDateStatic).HasColumnName("ExpirationDate_Static");

                entity.Property(e => e.ExpirationDateUnitTypeStatic).HasColumnName("ExpirationDateUnitType_Static");

                entity.Property(e => e.Iarcalc).HasColumnName("IARCALC");

                entity.Property(e => e.Iarcerc).HasColumnName("IARCERC");

                entity.Property(e => e.Iarcero).HasColumnName("IARCERO");

                entity.Property(e => e.Iarcers).HasColumnName("IARCERS");

                entity.Property(e => e.Iarcexv).HasColumnName("IARCEXV");

                entity.Property(e => e.Iarcnuflou).HasColumnName("IARCNUFLOU");

                entity.Property(e => e.Iarcont).HasColumnName("IARCONT");

                entity.Property(e => e.Iarcreg).HasColumnName("IARCREG");

                entity.Property(e => e.Iarcvin).HasColumnName("IARCVIN");

                entity.Property(e => e.Iardang).HasColumnName("IARDANG");

                entity.Property(e => e.Iardcre)
                    .HasColumnType("datetime")
                    .HasColumnName("IARDCRE");

                entity.Property(e => e.Iardegr).HasColumnName("IARDEGR");

                entity.Property(e => e.Iardmaj)
                    .HasColumnType("datetime")
                    .HasColumnName("IARDMAJ");

                entity.Property(e => e.Iareancde).HasColumnName("IAREANCDE");

                entity.Property(e => e.Iarecou).HasColumnName("IARECOU");

                entity.Property(e => e.Iareinter).HasColumnName("IAREINTER");

                entity.Property(e => e.Iarepal).HasColumnName("IAREPAL");

                entity.Property(e => e.Iarepcb).HasColumnName("IAREPCB");

                entity.Property(e => e.Iarespcb).HasColumnName("IARESPCB");

                entity.Property(e => e.Iareuvc).HasColumnName("IAREUVC");

                entity.Property(e => e.Iarfcarc).HasColumnName("IARFCARC");

                entity.Property(e => e.Iarfcpal).HasColumnName("IARFCPAL");

                entity.Property(e => e.Iarfpcb).HasColumnName("IARFPCB");

                entity.Property(e => e.Iarfspcb).HasColumnName("IARFSPCB");

                entity.Property(e => e.Iargescon).HasColumnName("IARGESCON");

                entity.Property(e => e.Iariger).HasColumnName("IARIGER");

                entity.Property(e => e.Iarintemb).HasColumnName("IARINTEMB");

                entity.Property(e => e.Iarndouan).HasColumnName("IARNDOUAN");

                entity.Property(e => e.Iarnlis)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IARNLIS");

                entity.Property(e => e.Iarpent).HasColumnName("IARPENT");

                entity.Property(e => e.Iarperm).HasColumnName("IARPERM");

                entity.Property(e => e.Iarpger).HasColumnName("IARPGER");

                entity.Property(e => e.IarpnetunitCodeStatic).HasColumnName("IARPNETUnitCode_Static");

                entity.Property(e => e.IarpnetunitTypeStatic).HasColumnName("IARPNETUnitType_Static");

                entity.Property(e => e.Iarpori).HasColumnName("IARPORI");

                entity.Property(e => e.Iarppv).HasColumnName("IARPPV");

                entity.Property(e => e.Iarralc).HasColumnName("IARRALC");

                entity.Property(e => e.Iarsuivemb).HasColumnName("IARSUIVEMB");

                entity.Property(e => e.Iartmax).HasColumnName("IARTMAX");

                entity.Property(e => e.Iartmin).HasColumnName("IARTMIN");

                entity.Property(e => e.Iartsit).HasColumnName("IARTSIT");

                entity.Property(e => e.Iartucont).HasColumnName("IARTUCONT");

                entity.Property(e => e.Iartypeemb).HasColumnName("IARTYPEEMB");

                entity.Property(e => e.Iartypul).HasColumnName("IARTYPUL");

                entity.Property(e => e.Iarucont).HasColumnName("IARUCONT");

                entity.Property(e => e.Iarugest).HasColumnName("IARUGEST");

                entity.Property(e => e.Iarupcou).HasColumnName("IARUPCOU");

                entity.Property(e => e.Iaruppal).HasColumnName("IARUPPAL");

                entity.Property(e => e.Iaruppcb).HasColumnName("IARUPPCB");

                entity.Property(e => e.Iarupspc).HasColumnName("IARUPSPC");

                entity.Property(e => e.Iarupuvc).HasColumnName("IARUPUVC");

                entity.Property(e => e.Iarutil)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IARUTIL");

                entity.Property(e => e.IndicatorInStickerAreaStatic).HasColumnName("IndicatorInStickerArea_Static");

                entity.Property(e => e.ItemManagementTypeStatic).HasColumnName("ItemManagementType_Static");

                entity.Property(e => e.LayerHeightCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("LayerHeight_cm");

                entity.Property(e => e.LayerLengthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("LayerLength_cm");

                entity.Property(e => e.LayerWeightKg)
                    .HasColumnType("numeric(26, 14)")
                    .HasColumnName("LayerWeight_kg");

                entity.Property(e => e.LayerWidthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("LayerWidth_cm");

                entity.Property(e => e.LengthUnitStatic).HasColumnName("LengthUnit_Static");

                entity.Property(e => e.LogisticVersionCodeStatic).HasColumnName("LogisticVersionCode_Static");

                entity.Property(e => e.OwnerStockCodeStatic).HasColumnName("OwnerStockCode_Static");

                entity.Property(e => e.PalletGrossWeightKg)
                    .HasColumnType("numeric(26, 14)")
                    .HasColumnName("PalletGrossWeight_kg");

                entity.Property(e => e.PalletHeightCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("PalletHeight_cm");

                entity.Property(e => e.PalletLengthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("PalletLength_cm");

                entity.Property(e => e.PalletWidthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("PalletWidth_cm");

                entity.Property(e => e.PcatId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("PCatID");

                entity.Property(e => e.PcatName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PCatName");

                entity.Property(e => e.Pgr1Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PGr1Name");

                entity.Property(e => e.Pgr2Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PGr2Name");

                entity.Property(e => e.Pgr3NameStatic).HasColumnName("PGr3Name_Static");

                entity.Property(e => e.Pgr4NameStatic).HasColumnName("PGr4Name_Static");

                entity.Property(e => e.PgrId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("PGrID");

                entity.Property(e => e.PgrId1)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("PGrID1");

                entity.Property(e => e.PgrId2)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("PGrID2");

                entity.Property(e => e.PgrId3Static).HasColumnName("PGrID3_Static");

                entity.Property(e => e.PgrId4Static).HasColumnName("PGrID4_Static");

                entity.Property(e => e.PgrName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PGrName");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleUnitStatic).HasColumnName("SaleUnit_Static");

                entity.Property(e => e.SamplingUnitCodeStatic).HasColumnName("SamplingUnitCode_Static");

                entity.Property(e => e.SellingPriceAfterTaxStatic)
                    .HasColumnType("numeric(3, 3)")
                    .HasColumnName("SellingPrice(after tax)_Static");

                entity.Property(e => e.SpaceUnitStatic).HasColumnName("SpaceUnit_Static");

                entity.Property(e => e.StockCodeStatic).HasColumnName("StockCode_Static");

                entity.Property(e => e.SubBoxHeightCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("SubBoxHeight_cm");

                entity.Property(e => e.SubBoxLengthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("SubBoxLength_cm");

                entity.Property(e => e.SubBoxWeightKg)
                    .HasColumnType("numeric(26, 14)")
                    .HasColumnName("SubBoxWeight_kg");

                entity.Property(e => e.SubBoxWidthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("SubBoxWidth_cm");

                entity.Property(e => e.TagFormatStatic).HasColumnName("TagFormat_Static");

                entity.Property(e => e.TrackWms).HasColumnName("TrackWMS");

                entity.Property(e => e.UnitGrossWeightKg)
                    .HasColumnType("numeric(26, 14)")
                    .HasColumnName("UnitGrossWeight_kg");

                entity.Property(e => e.UnitHeightCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("UnitHeight_cm");

                entity.Property(e => e.UnitLengthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("UnitLength_cm");

                entity.Property(e => e.UnitQtyInbox).HasColumnName("UnitQtyINBox");

                entity.Property(e => e.UnitQtyInsubBox).HasColumnName("UnitQtyINSubBox");

                entity.Property(e => e.UnitWidthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("UnitWidth_cm");

                entity.Property(e => e.WeightUnitStatic).HasColumnName("WeightUnit_Static");
            });

            modelBuilder.Entity<IcsarticleOnline>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ICSARTICLE_ONLINE");

                entity.Property(e => e.ActionTypeStatic).HasColumnName("ActionType_Static");

                entity.Property(e => e.ArticleLogisticVersionStatic).HasColumnName("ArticleLogisticVersion_Static");

                entity.Property(e => e.ArticleTypeStatic).HasColumnName("ArticleType_Static");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BarCodeTransferCodeStatic).HasColumnName("BarCodeTransferCode_Static");

                entity.Property(e => e.BarCodeTypeStatic).HasColumnName("BarCodeType_Static");

                entity.Property(e => e.BoxHeightCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("BoxHeight_cm");

                entity.Property(e => e.BoxLengthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("BoxLength_cm");

                entity.Property(e => e.BoxWeightKg)
                    .HasColumnType("numeric(26, 14)")
                    .HasColumnName("BoxWeight_kg");

                entity.Property(e => e.BoxWidthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("BoxWidth_cm");

                entity.Property(e => e.CapacityValueStatic).HasColumnName("CapacityValue_Static");

                entity.Property(e => e.CompId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CompID");

                entity.Property(e => e.CompName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DepotCodeStatic).HasColumnName("DepotCode_Static");

                entity.Property(e => e.ExpirationDateOnCustomerStatic).HasColumnName("ExpirationDateOnCustomer_Static");

                entity.Property(e => e.ExpirationDateOnProviderStatic).HasColumnName("ExpirationDateOnProvider_Static");

                entity.Property(e => e.ExpirationDateOnShopStatic).HasColumnName("ExpirationDateOnShop_Static");

                entity.Property(e => e.ExpirationDateOnStockStatic).HasColumnName("ExpirationDateOnStock_Static");

                entity.Property(e => e.ExpirationDateStatic).HasColumnName("ExpirationDate_Static");

                entity.Property(e => e.ExpirationDateUnitTypeStatic).HasColumnName("ExpirationDateUnitType_Static");

                entity.Property(e => e.Iarcalc).HasColumnName("IARCALC");

                entity.Property(e => e.Iarcerc).HasColumnName("IARCERC");

                entity.Property(e => e.Iarcero).HasColumnName("IARCERO");

                entity.Property(e => e.Iarcers).HasColumnName("IARCERS");

                entity.Property(e => e.Iarcexv).HasColumnName("IARCEXV");

                entity.Property(e => e.Iarcnuflou).HasColumnName("IARCNUFLOU");

                entity.Property(e => e.Iarcont).HasColumnName("IARCONT");

                entity.Property(e => e.Iarcreg).HasColumnName("IARCREG");

                entity.Property(e => e.Iarcvin).HasColumnName("IARCVIN");

                entity.Property(e => e.Iardang).HasColumnName("IARDANG");

                entity.Property(e => e.Iardcre)
                    .HasColumnType("datetime")
                    .HasColumnName("IARDCRE");

                entity.Property(e => e.Iardegr).HasColumnName("IARDEGR");

                entity.Property(e => e.Iardmaj)
                    .HasColumnType("datetime")
                    .HasColumnName("IARDMAJ");

                entity.Property(e => e.Iareancde).HasColumnName("IAREANCDE");

                entity.Property(e => e.Iarecou).HasColumnName("IARECOU");

                entity.Property(e => e.Iareinter).HasColumnName("IAREINTER");

                entity.Property(e => e.Iarepal).HasColumnName("IAREPAL");

                entity.Property(e => e.Iarepcb).HasColumnName("IAREPCB");

                entity.Property(e => e.Iarespcb).HasColumnName("IARESPCB");

                entity.Property(e => e.Iareuvc).HasColumnName("IAREUVC");

                entity.Property(e => e.Iarfcarc).HasColumnName("IARFCARC");

                entity.Property(e => e.Iarfcpal).HasColumnName("IARFCPAL");

                entity.Property(e => e.Iarfpcb).HasColumnName("IARFPCB");

                entity.Property(e => e.Iarfspcb).HasColumnName("IARFSPCB");

                entity.Property(e => e.Iargescon).HasColumnName("IARGESCON");

                entity.Property(e => e.Iariger).HasColumnName("IARIGER");

                entity.Property(e => e.Iarintemb).HasColumnName("IARINTEMB");

                entity.Property(e => e.Iarndouan).HasColumnName("IARNDOUAN");

                entity.Property(e => e.Iarnlis)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IARNLIS");

                entity.Property(e => e.Iarpent).HasColumnName("IARPENT");

                entity.Property(e => e.Iarperm).HasColumnName("IARPERM");

                entity.Property(e => e.Iarpger).HasColumnName("IARPGER");

                entity.Property(e => e.IarpnetunitCodeStatic).HasColumnName("IARPNETUnitCode_Static");

                entity.Property(e => e.IarpnetunitTypeStatic).HasColumnName("IARPNETUnitType_Static");

                entity.Property(e => e.Iarpori).HasColumnName("IARPORI");

                entity.Property(e => e.Iarppv).HasColumnName("IARPPV");

                entity.Property(e => e.Iarralc).HasColumnName("IARRALC");

                entity.Property(e => e.Iarsuivemb).HasColumnName("IARSUIVEMB");

                entity.Property(e => e.Iartmax).HasColumnName("IARTMAX");

                entity.Property(e => e.Iartmin).HasColumnName("IARTMIN");

                entity.Property(e => e.Iartsit).HasColumnName("IARTSIT");

                entity.Property(e => e.Iartucont).HasColumnName("IARTUCONT");

                entity.Property(e => e.Iartypeemb).HasColumnName("IARTYPEEMB");

                entity.Property(e => e.Iartypul).HasColumnName("IARTYPUL");

                entity.Property(e => e.Iarucont).HasColumnName("IARUCONT");

                entity.Property(e => e.Iarugest).HasColumnName("IARUGEST");

                entity.Property(e => e.Iarupcou).HasColumnName("IARUPCOU");

                entity.Property(e => e.Iaruppal).HasColumnName("IARUPPAL");

                entity.Property(e => e.Iaruppcb).HasColumnName("IARUPPCB");

                entity.Property(e => e.Iarupspc).HasColumnName("IARUPSPC");

                entity.Property(e => e.Iarupuvc).HasColumnName("IARUPUVC");

                entity.Property(e => e.Iarutil)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IARUTIL");

                entity.Property(e => e.IndicatorInStickerAreaStatic).HasColumnName("IndicatorInStickerArea_Static");

                entity.Property(e => e.ItemManagementTypeStatic).HasColumnName("ItemManagementType_Static");

                entity.Property(e => e.LayerHeightCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("LayerHeight_cm");

                entity.Property(e => e.LayerLengthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("LayerLength_cm");

                entity.Property(e => e.LayerWeightKg)
                    .HasColumnType("numeric(26, 14)")
                    .HasColumnName("LayerWeight_kg");

                entity.Property(e => e.LayerWidthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("LayerWidth_cm");

                entity.Property(e => e.LengthUnitStatic).HasColumnName("LengthUnit_Static");

                entity.Property(e => e.LogisticVersionCodeStatic).HasColumnName("LogisticVersionCode_Static");

                entity.Property(e => e.OwnerStockCodeStatic).HasColumnName("OwnerStockCode_Static");

                entity.Property(e => e.PalletGrossWeightKg)
                    .HasColumnType("numeric(26, 14)")
                    .HasColumnName("PalletGrossWeight_kg");

                entity.Property(e => e.PalletHeightCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("PalletHeight_cm");

                entity.Property(e => e.PalletLengthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("PalletLength_cm");

                entity.Property(e => e.PalletWidthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("PalletWidth_cm");

                entity.Property(e => e.PcatId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("PCatID");

                entity.Property(e => e.PcatName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PCatName");

                entity.Property(e => e.Pgr1Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PGr1Name");

                entity.Property(e => e.Pgr2Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PGr2Name");

                entity.Property(e => e.Pgr3NameStatic).HasColumnName("PGr3Name_Static");

                entity.Property(e => e.Pgr4NameStatic).HasColumnName("PGr4Name_Static");

                entity.Property(e => e.PgrId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("PGrID");

                entity.Property(e => e.PgrId1)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("PGrID1");

                entity.Property(e => e.PgrId2)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("PGrID2");

                entity.Property(e => e.PgrId3Static).HasColumnName("PGrID3_Static");

                entity.Property(e => e.PgrId4Static).HasColumnName("PGrID4_Static");

                entity.Property(e => e.PgrName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PGrName");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleUnitStatic).HasColumnName("SaleUnit_Static");

                entity.Property(e => e.SamplingUnitCodeStatic).HasColumnName("SamplingUnitCode_Static");

                entity.Property(e => e.SellingPriceAfterTaxStatic)
                    .HasColumnType("numeric(3, 3)")
                    .HasColumnName("SellingPrice(after tax)_Static");

                entity.Property(e => e.SpaceUnitStatic).HasColumnName("SpaceUnit_Static");

                entity.Property(e => e.StockCodeStatic).HasColumnName("StockCode_Static");

                entity.Property(e => e.SubBoxHeightCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("SubBoxHeight_cm");

                entity.Property(e => e.SubBoxLengthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("SubBoxLength_cm");

                entity.Property(e => e.SubBoxWeightKg)
                    .HasColumnType("numeric(26, 14)")
                    .HasColumnName("SubBoxWeight_kg");

                entity.Property(e => e.SubBoxWidthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("SubBoxWidth_cm");

                entity.Property(e => e.TagFormatStatic).HasColumnName("TagFormat_Static");

                entity.Property(e => e.TrackWms).HasColumnName("TrackWMS");

                entity.Property(e => e.UnitGrossWeightKg)
                    .HasColumnType("numeric(26, 14)")
                    .HasColumnName("UnitGrossWeight_kg");

                entity.Property(e => e.UnitHeightCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("UnitHeight_cm");

                entity.Property(e => e.UnitLengthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("UnitLength_cm");

                entity.Property(e => e.UnitQtyInbox).HasColumnName("UnitQtyINBox");

                entity.Property(e => e.UnitQtyInsubBox).HasColumnName("UnitQtyINSubBox");

                entity.Property(e => e.UnitWidthCm)
                    .HasColumnType("numeric(24, 12)")
                    .HasColumnName("UnitWidth_cm");

                entity.Property(e => e.WeightUnitStatic).HasColumnName("WeightUnit_Static");
            });

            modelBuilder.Entity<Icsdeol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ICSDEOL");

                entity.Property(e => e.Iolacci)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IOLACCI");

                entity.Property(e => e.Iolacti).HasColumnName("IOLACTI");

                entity.Property(e => e.Ioladr1)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("IOLADR1");

                entity.Property(e => e.Ioladr2)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("IOLADR2");

                entity.Property(e => e.Iolaori)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IOLAORI");

                entity.Property(e => e.Iolaslo).HasColumnName("IOLASLO");

                entity.Property(e => e.Iolbudcode)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("IOLBUDCODE");

                entity.Property(e => e.Iolcargrp).HasColumnName("IOLCARGRP");

                entity.Property(e => e.Iolccom)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IOLCCOM");

                entity.Property(e => e.Iolcdev)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IOLCDEV");

                entity.Property(e => e.Iolcent).HasColumnName("IOLCENT");

                entity.Property(e => e.Iolcexcde)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("IOLCEXCDE");

                entity.Property(e => e.Iolcexglo)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("IOLCEXGLO");

                entity.Property(e => e.Iolcexops)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("IOLCEXOPS");

                entity.Property(e => e.Iolcexvlc).HasColumnName("IOLCEXVLC");

                entity.Property(e => e.Iolcexvlp).HasColumnName("IOLCEXVLP");

                entity.Property(e => e.Iolcfam)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IOLCFAM");

                entity.Property(e => e.Iolcfxf)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IOLCFXF");

                entity.Property(e => e.Iolcinbv).HasColumnName("IOLCINBV");

                entity.Property(e => e.Iolcincde).HasColumnName("IOLCINCDE");

                entity.Property(e => e.Iolclcus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IOLCLCUS");

                entity.Property(e => e.Iolclet)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IOLCLET");

                entity.Property(e => e.Iolcnuf)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IOLCNUF");

                entity.Property(e => e.Iolcodc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IOLCODC");

                entity.Property(e => e.Iolcodp)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IOLCODP");

                entity.Property(e => e.Iolcoef).HasColumnName("IOLCOEF");

                entity.Property(e => e.Iolcomm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IOLCOMM");

                entity.Property(e => e.Iolcpay).HasColumnName("IOLCPAY");

                entity.Property(e => e.Iolcpos)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IOLCPOS");

                entity.Property(e => e.Iolcrgp).HasColumnName("IOLCRGP");

                entity.Property(e => e.Iolcset)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IOLCSET");

                entity.Property(e => e.Iolcsmcext)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IOLCSMCEXT");

                entity.Property(e => e.Iolcsnn)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLCSNN");

                entity.Property(e => e.Iolcsnp)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLCSNP");

                entity.Property(e => e.Iolctva).HasColumnName("IOLCTVA");

                entity.Property(e => e.Iolcuex).HasColumnName("IOLCUEX");

                entity.Property(e => e.Iolcus).HasColumnName("IOLCUS");

                entity.Property(e => e.Ioldcom)
                    .HasColumnType("date")
                    .HasColumnName("IOLDCOM");

                entity.Property(e => e.Ioldcre)
                    .HasColumnType("date")
                    .HasColumnName("IOLDCRE");

                entity.Property(e => e.Ioldelim)
                    .HasColumnType("date")
                    .HasColumnName("IOLDELIM");

                entity.Property(e => e.Ioldelpt1).HasColumnName("IOLDELPT1");

                entity.Property(e => e.Ioldelpt1adr1).HasColumnName("IOLDELPT1ADR1");

                entity.Property(e => e.Ioldelpt1adr2).HasColumnName("IOLDELPT1ADR2");

                entity.Property(e => e.Ioldelpt1cpay).HasColumnName("IOLDELPT1CPAY");

                entity.Property(e => e.Ioldelpt1cpos).HasColumnName("IOLDELPT1CPOS");

                entity.Property(e => e.Ioldelpt1dist).HasColumnName("IOLDELPT1DIST");

                entity.Property(e => e.Ioldelpt1lcor).HasColumnName("IOLDELPT1LCOR");

                entity.Property(e => e.Ioldelpt1lfon).HasColumnName("IOLDELPT1LFON");

                entity.Property(e => e.Ioldelpt1lpay).HasColumnName("IOLDELPT1LPAY");

                entity.Property(e => e.Ioldelpt1mail).HasColumnName("IOLDELPT1MAIL");

                entity.Property(e => e.Ioldelpt1nfax).HasColumnName("IOLDELPT1NFAX");

                entity.Property(e => e.Ioldelpt1ntel).HasColumnName("IOLDELPT1NTEL");

                entity.Property(e => e.Ioldelpt1ntlx).HasColumnName("IOLDELPT1NTLX");

                entity.Property(e => e.Ioldelpt1rais).HasColumnName("IOLDELPT1RAIS");

                entity.Property(e => e.Ioldelpt1regn).HasColumnName("IOLDELPT1REGN");

                entity.Property(e => e.Ioldelpt1vill).HasColumnName("IOLDELPT1VILL");

                entity.Property(e => e.Ioldelpt2).HasColumnName("IOLDELPT2");

                entity.Property(e => e.Ioldelpt2adr1).HasColumnName("IOLDELPT2ADR1");

                entity.Property(e => e.Ioldelpt2adr2).HasColumnName("IOLDELPT2ADR2");

                entity.Property(e => e.Ioldelpt2cpay).HasColumnName("IOLDELPT2CPAY");

                entity.Property(e => e.Ioldelpt2cpos).HasColumnName("IOLDELPT2CPOS");

                entity.Property(e => e.Ioldelpt2dist).HasColumnName("IOLDELPT2DIST");

                entity.Property(e => e.Ioldelpt2lcor).HasColumnName("IOLDELPT2LCOR");

                entity.Property(e => e.Ioldelpt2lfon).HasColumnName("IOLDELPT2LFON");

                entity.Property(e => e.Ioldelpt2lpay).HasColumnName("IOLDELPT2LPAY");

                entity.Property(e => e.Ioldelpt2mail).HasColumnName("IOLDELPT2MAIL");

                entity.Property(e => e.Ioldelpt2nfax).HasColumnName("IOLDELPT2NFAX");

                entity.Property(e => e.Ioldelpt2ntel).HasColumnName("IOLDELPT2NTEL");

                entity.Property(e => e.Ioldelpt2ntlx).HasColumnName("IOLDELPT2NTLX");

                entity.Property(e => e.Ioldelpt2rais).HasColumnName("IOLDELPT2RAIS");

                entity.Property(e => e.Ioldelpt2regn).HasColumnName("IOLDELPT2REGN");

                entity.Property(e => e.Ioldelpt2vill).HasColumnName("IOLDELPT2VILL");

                entity.Property(e => e.Ioldepo).HasColumnName("IOLDEPO");

                entity.Property(e => e.Ioldgrpfor).HasColumnName("IOLDGRPFOR");

                entity.Property(e => e.Ioldist)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("IOLDIST");

                entity.Property(e => e.Ioldlim)
                    .HasColumnType("date")
                    .HasColumnName("IOLDLIM");

                entity.Property(e => e.Ioldliv)
                    .HasColumnType("date")
                    .HasColumnName("IOLDLIV");

                entity.Property(e => e.Ioldlvmax)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("IOLDLVMAX");

                entity.Property(e => e.Ioldlvmin)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("IOLDLVMIN");

                entity.Property(e => e.Ioldmaj)
                    .HasColumnType("date")
                    .HasColumnName("IOLDMAJ");

                entity.Property(e => e.Ioldmar)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("IOLDMAR");

                entity.Property(e => e.Ioldplim)
                    .HasColumnType("date")
                    .HasColumnName("IOLDPLIM");

                entity.Property(e => e.Ioledtfac).HasColumnName("IOLEDTFAC");

                entity.Property(e => e.Iolfilc).HasColumnName("IOLFILC");

                entity.Property(e => e.Iolfili).HasColumnName("IOLFILI");

                entity.Property(e => e.Iolflgmut).HasColumnName("IOLFLGMUT");

                entity.Property(e => e.Iolflgtrc).HasColumnName("IOLFLGTRC");

                entity.Property(e => e.Iolflir).HasColumnName("IOLFLIR");

                entity.Property(e => e.Iolfrei)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("IOLFREI");

                entity.Property(e => e.Iolgancode).HasColumnName("IOLGANCODE");

                entity.Property(e => e.Iolgrpforadr1).HasColumnName("IOLGRPFORADR1");

                entity.Property(e => e.Iolgrpforadr2).HasColumnName("IOLGRPFORADR2");

                entity.Property(e => e.Iolgrpforcpay).HasColumnName("IOLGRPFORCPAY");

                entity.Property(e => e.Iolgrpforcpos).HasColumnName("IOLGRPFORCPOS");

                entity.Property(e => e.Iolgrpfordist).HasColumnName("IOLGRPFORDIST");

                entity.Property(e => e.Iolgrpforlcor).HasColumnName("IOLGRPFORLCOR");

                entity.Property(e => e.Iolgrpforlfon).HasColumnName("IOLGRPFORLFON");

                entity.Property(e => e.Iolgrpforlpay).HasColumnName("IOLGRPFORLPAY");

                entity.Property(e => e.Iolgrpformail).HasColumnName("IOLGRPFORMAIL");

                entity.Property(e => e.Iolgrpfornfax).HasColumnName("IOLGRPFORNFAX");

                entity.Property(e => e.Iolgrpforntel).HasColumnName("IOLGRPFORNTEL");

                entity.Property(e => e.Iolgrpforntlx).HasColumnName("IOLGRPFORNTLX");

                entity.Property(e => e.Iolgrpforrais).HasColumnName("IOLGRPFORRAIS");

                entity.Property(e => e.Iolgrpforregn).HasColumnName("IOLGRPFORREGN");

                entity.Property(e => e.Iolgrpforvill).HasColumnName("IOLGRPFORVILL");

                entity.Property(e => e.Ioliacc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IOLIACC");

                entity.Property(e => e.Iolicmp).HasColumnName("IOLICMP");

                entity.Property(e => e.Iolidcmp)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("IOLIDCMP");

                entity.Property(e => e.Ioliebl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IOLIEBL");

                entity.Property(e => e.Ioliedf).HasColumnName("IOLIEDF");

                entity.Property(e => e.Ioliflu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IOLIFLU");

                entity.Property(e => e.Iolimrl).HasColumnName("IOLIMRL");

                entity.Property(e => e.Iolitce).HasColumnName("IOLITCE");

                entity.Property(e => e.Ioliurg).HasColumnName("IOLIURG");

                entity.Property(e => e.Iollcor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IOLLCOR");

                entity.Property(e => e.Iollfon)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("IOLLFON");

                entity.Property(e => e.Iollibbl)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLLIBBL");

                entity.Property(e => e.Iollibl)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("IOLLIBL");

                entity.Property(e => e.Iollpay)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IOLLPAY");

                entity.Property(e => e.Iolmail)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("IOLMAIL");

                entity.Property(e => e.Iolmarg)
                    .HasColumnType("numeric(9, 3)")
                    .HasColumnName("IOLMARG");

                entity.Property(e => e.Iolmodtno).HasColumnName("IOLMODTNO");

                entity.Property(e => e.Iolnacc)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("IOLNACC");

                entity.Property(e => e.Iolncli)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IOLNCLI");

                entity.Property(e => e.Iolnctl).HasColumnName("IOLNCTL");

                entity.Property(e => e.Iolnfax)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLNFAX");

                entity.Property(e => e.Iolnflu)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("IOLNFLU");

                entity.Property(e => e.Iolngrp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("IOLNGRP");

                entity.Property(e => e.Iolnlig).HasColumnName("IOLNLIG");

                entity.Property(e => e.Iolnligp).HasColumnName("IOLNLIGP");

                entity.Property(e => e.Iolnliv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IOLNLIV");

                entity.Property(e => e.Iolnolign)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("IOLNOLIGN");

                entity.Property(e => e.Iolnolv).HasColumnName("IOLNOLV");

                entity.Property(e => e.Iolnooe).HasColumnName("IOLNOOE");

                entity.Property(e => e.Iolnops).HasColumnName("IOLNOPS");

                entity.Property(e => e.Iolntel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLNTEL");

                entity.Property(e => e.Iolntlx)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLNTLX");

                entity.Property(e => e.Ioloptin1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IOLOPTIN1");

                entity.Property(e => e.Ioloptin2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IOLOPTIN2");

                entity.Property(e => e.Ioloptin3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IOLOPTIN3");

                entity.Property(e => e.Ioloptin4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IOLOPTIN4");

                entity.Property(e => e.Ioloptin5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IOLOPTIN5");

                entity.Property(e => e.Iolpcht)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("IOLPCHT");

                entity.Property(e => e.Iolpcttc)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("IOLPCTTC");

                entity.Property(e => e.Iolpenu).HasColumnName("IOLPENU");

                entity.Property(e => e.Iolphodir)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLPHODIR");

                entity.Property(e => e.Iolphomob)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLPHOMOB");

                entity.Property(e => e.Iolphostd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLPHOSTD");

                entity.Property(e => e.Iolplet)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IOLPLET");

                entity.Property(e => e.Iolprif).HasColumnName("IOLPRIF");

                entity.Property(e => e.Iolpvht)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("IOLPVHT");

                entity.Property(e => e.Iolpvttc)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("IOLPVTTC");

                entity.Property(e => e.Iolqtec)
                    .HasColumnType("numeric(9, 3)")
                    .HasColumnName("IOLQTEC");

                entity.Property(e => e.Iolqtei)
                    .HasColumnType("numeric(9, 3)")
                    .HasColumnName("IOLQTEI");

                entity.Property(e => e.Iolqteip).HasColumnName("IOLQTEIP");

                entity.Property(e => e.Iolqtelp).HasColumnName("IOLQTELP");

                entity.Property(e => e.Iolrais)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("IOLRAIS");

                entity.Property(e => e.Iolrefcde)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("IOLREFCDE");

                entity.Property(e => e.Iolregn)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("IOLREGN");

                entity.Property(e => e.Iolsite).HasColumnName("IOLSITE");

                entity.Property(e => e.Iolstowith).HasColumnName("IOLSTOWITH");

                entity.Property(e => e.Ioltrcnum)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IOLTRCNUM");

                entity.Property(e => e.Ioltret).HasColumnName("IOLTRET");

                entity.Property(e => e.Ioltrfil).HasColumnName("IOLTRFIL");

                entity.Property(e => e.Ioltrsp)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("IOLTRSP");

                entity.Property(e => e.Iolttva)
                    .HasColumnType("numeric(10, 3)")
                    .HasColumnName("IOLTTVA");

                entity.Property(e => e.Ioltype).HasColumnName("IOLTYPE");

                entity.Property(e => e.Ioltypin1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IOLTYPIN1");

                entity.Property(e => e.Ioltypin2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IOLTYPIN2");

                entity.Property(e => e.Ioltypin3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IOLTYPIN3");

                entity.Property(e => e.Ioltypin4)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IOLTYPIN4");

                entity.Property(e => e.Ioltypin5)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IOLTYPIN5");

                entity.Property(e => e.Ioltypr)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IOLTYPR");

                entity.Property(e => e.Ioluint).HasColumnName("IOLUint");

                entity.Property(e => e.Iolupre).HasColumnName("IOLUPRE");

                entity.Property(e => e.Iolutil)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("IOLUTIL");

                entity.Property(e => e.Iolvalin1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLVALIN1");

                entity.Property(e => e.Iolvalin2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLVALIN2");

                entity.Property(e => e.Iolvalin3)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLVALIN3");

                entity.Property(e => e.Iolvalin4)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLVALIN4");

                entity.Property(e => e.Iolvalin5)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IOLVALIN5");

                entity.Property(e => e.Iolvill)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("IOLVILL");

                entity.Property(e => e.Iolvtliv).HasColumnName("IOLVTLIV");
            });

            modelBuilder.Entity<Icsdetor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ICSDETOR");

                entity.Property(e => e.ArrivalDate).HasColumnType("date");

                entity.Property(e => e.City)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CustomsDocId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CustomsDocID");

                entity.Property(e => e.DateCreate).HasColumnType("date");

                entity.Property(e => e.DeadlineForDelivery).HasColumnType("date");

                entity.Property(e => e.ExternalCodeExternalDocId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ExternalCodeExternalDocID");

                entity.Property(e => e.ExternalConsumerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ExternalDocID");

                entity.Property(e => e.Idrbtcq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IDRBTCQ");

                entity.Property(e => e.Idrnvoie).HasColumnName("IDRNVOIE");

                entity.Property(e => e.Idrtvoie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDRTVOIE");

                entity.Property(e => e.InternalDocId).HasColumnName("InternalDocID");

                entity.Property(e => e.LastModifyDate).HasColumnType("date");

                entity.Property(e => e.LastModifyProgram)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OrderedArticleCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PlannedDeliveryDate).HasColumnType("date");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostOffice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.PromoActionCode2)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("PromoActionCode_2");

                entity.Property(e => e.ProviderExternalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderProdId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ProviderProdID");

                entity.Property(e => e.ProviderSrcPosId).HasColumnName("ProviderSrcPosID");

                entity.Property(e => e.Qty).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.QtyBefore)
                    .HasColumnType("numeric(12, 3)")
                    .HasColumnName("Qty_Before");

                entity.Property(e => e.Region)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SalePrice).HasColumnType("numeric(13, 3)");

                entity.Property(e => e.SrcPosId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("SrcPosID");

                entity.Property(e => e.Street1)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("Street_1");

                entity.Property(e => e.Street2)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("Street_2");

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToWms).HasColumnName("ToWMS");

                entity.Property(e => e.TransitDocId).HasColumnName("TransitDocID");
            });

            modelBuilder.Entity<Icsentor>(entity =>
            {
                entity.HasKey(e => e.TransitDocId)
                    .HasName("PK__ICSENTOR__9CD543C451FBE714");

                entity.ToTable("ICSENTOR");

                entity.Property(e => e.TransitDocId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransitDocID");

                entity.Property(e => e.CampaignCode)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CarrierContract)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContractorCarrierCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DirectPhone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.ExternalCarrierCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalCompAddress1)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("ExternalCompAddress_1");

                entity.Property(e => e.ExternalCompAddress2)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("ExternalCompAddress_2");

                entity.Property(e => e.ExternalCompCity)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalCompId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ExternalCompID");

                entity.Property(e => e.ExternalCompName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalCompNameLong)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("ExternalCompName_Long");

                entity.Property(e => e.ExternalDocId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ExternalDocID");

                entity.Property(e => e.ExternalPromoActionCode)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalLocationCode)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.HomeDeliveryDocId).HasColumnName("HomeDeliveryDocID");

                entity.Property(e => e.InternalDocId).HasColumnName("InternalDocID");

                entity.Property(e => e.LastModifyDate).HasColumnType("date");

                entity.Property(e => e.LastModifyProgram)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MaxDateDelivery).HasColumnType("date");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlannedDateDelivery).HasColumnType("date");

                entity.Property(e => e.PostIndex)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostOffice)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("Post Office");

                entity.Property(e => e.Region)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.StandartPhone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telex)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToWms).HasColumnName("ToWMS");

                entity.Property(e => e.TransitStockNumber)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Icstier>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ICSTIERS");

                entity.Property(e => e.AlternatyveCompCode)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CompAddress1)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CompAddress2)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CompCode)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CompName1)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CompName2)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CompName3)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CompPost)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Ecidentifier).HasColumnName("ECIdentifier");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LongCountryName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone3)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PostIndex)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ShortCompName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShortCountryName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telex)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ValueAddedTaxCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<N3Mvtex>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("N3_MVTEX");

                entity.Property(e => e.Me3cexops)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ME3CEXOPS");

                entity.Property(e => e.Me3codcli)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ME3CODCLI");

                entity.Property(e => e.Me3cproin)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ME3CPROIN");

                entity.Property(e => e.Me3numcde)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ME3NUMCDE");

                entity.Property(e => e.Me3qteexp)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("ME3QTEEXP");

                entity.Property(e => e.Me3sscc)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("ME3SSCC");

                entity.Property(e => e.Me3typol)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ME3TYPOL");

                entity.Property(e => e.SyncToGms).HasColumnName("SyncToGMS");
            });

            modelBuilder.Entity<N3Mvtin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("N3_MVTIN");

                entity.Property(e => e.Mi3cecart)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MI3CECART");

                entity.Property(e => e.Mi3cexops)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("MI3CEXOPS");

                entity.Property(e => e.Mi3cproin)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MI3CPROIN");

                entity.Property(e => e.Mi3datmvt)
                    .HasColumnType("datetime")
                    .HasColumnName("MI3DATMVT");

                entity.Property(e => e.Mi3noinvs).HasColumnName("MI3NOINVS");

                entity.Property(e => e.Mi3numorc).HasColumnName("MI3NUMORC");

                entity.Property(e => e.Mi3qteuvc)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("MI3QTEUVC");

                entity.Property(e => e.SyncToGms).HasColumnName("SyncToGMS");
            });

            modelBuilder.Entity<N3Mvtre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("N3_MVTRE");

                entity.Property(e => e.Mr3cproin)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MR3CPROIN");

                entity.Property(e => e.Mr3datrec)
                    .HasColumnType("date")
                    .HasColumnName("MR3DATREC");

                entity.Property(e => e.Mr3ncdefo)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("MR3NCDEFO");

                entity.Property(e => e.Mr3nolign)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("MR3NOLIGN");

                entity.Property(e => e.Mr3numroc)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MR3NUMROC");

                entity.Property(e => e.Mr3uvcrec)
                    .HasColumnType("numeric(12, 3)")
                    .HasColumnName("MR3UVCREC");

                entity.Property(e => e.SyncToGms).HasColumnName("SyncToGMS");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasKey(e => e.CompCode)
                    .HasName("PK__Provider__969C5CE2724C2A6C");

                entity.Property(e => e.CompCode).ValueGeneratedNever();

                entity.Property(e => e.CompName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.GmsId).HasColumnName("GmsID");

                entity.Property(e => e.SourceCreateComps)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SqlCommand>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_sql_command");

                entity.Property(e => e.CommandText).HasColumnName("command_text");
            });

            modelBuilder.Entity<SqlText>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_sql_text");

                entity.Property(e => e.BatchText).HasColumnName("batchText");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
