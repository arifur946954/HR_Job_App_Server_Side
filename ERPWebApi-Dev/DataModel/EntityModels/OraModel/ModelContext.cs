using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataModel.EntityModels.OraModel
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EtCmnmenu> EtCmnmenus { get; set; } = null!;
        public virtual DbSet<EtCmnmenupermission> EtCmnmenupermissions { get; set; } = null!;
        public virtual DbSet<EtCmnmodule> EtCmnmodules { get; set; } = null!;
        public virtual DbSet<EtCmnmodulepermission> EtCmnmodulepermissions { get; set; } = null!;
        public virtual DbSet<EtCmnuser> EtCmnusers { get; set; } = null!;
        public virtual DbSet<EtCmnuserauthentication> EtCmnuserauthentications { get; set; } = null!;
        public virtual DbSet<EtErrorlog> EtErrorlogs { get; set; } = null!;
        public virtual DbSet<TAudit> TAudits { get; set; } = null!;
        public virtual DbSet<TBassetType> TBassetTypes { get; set; } = null!;
        public virtual DbSet<TBmetric> TBmetrics { get; set; } = null!;
        public virtual DbSet<TBparameter> TBparameters { get; set; } = null!;
        public virtual DbSet<TBparameterTask> TBparameterTasks { get; set; } = null!;
        public virtual DbSet<TBplacement> TBplacements { get; set; } = null!;
        public virtual DbSet<TBplatform> TBplatforms { get; set; } = null!;
        public virtual DbSet<TBpublisher> TBpublishers { get; set; } = null!;
        public virtual DbSet<TBrand> TBrands { get; set; } = null!;
        public virtual DbSet<TBsupplement> TBsupplements { get; set; } = null!;
        public virtual DbSet<TCategory> TCategories { get; set; } = null!;
        public virtual DbSet<TClient> TClients { get; set; } = null!;
        public virtual DbSet<TClientBank> TClientBanks { get; set; } = null!;
        public virtual DbSet<TClientType> TClientTypes { get; set; } = null!;
        public virtual DbSet<TCmnCurrency> TCmnCurrencies { get; set; } = null!;
        public virtual DbSet<TCmndocument> TCmndocuments { get; set; } = null!;
        public virtual DbSet<TCmnmenu> TCmnmenus { get; set; } = null!;
        public virtual DbSet<TCmnmenupermission> TCmnmenupermissions { get; set; } = null!;
        public virtual DbSet<TErrorLog> TErrorLogs { get; set; } = null!;
        public virtual DbSet<TMediaAdPosition> TMediaAdPositions { get; set; } = null!;
        public virtual DbSet<TMediaBroadcast> TMediaBroadcasts { get; set; } = null!;
        public virtual DbSet<TMediaDay> TMediaDays { get; set; } = null!;
        public virtual DbSet<TMediaDayPart> TMediaDayParts { get; set; } = null!;
        public virtual DbSet<TMediaGenre> TMediaGenres { get; set; } = null!;
        public virtual DbSet<TMediaProgram> TMediaPrograms { get; set; } = null!;
        public virtual DbSet<TMediaSponsor> TMediaSponsors { get; set; } = null!;
        public virtual DbSet<TMediaSponsoredProject> TMediaSponsoredProjects { get; set; } = null!;
        public virtual DbSet<TMenu> TMenus { get; set; } = null!;
        public virtual DbSet<TMnud> TMnuds { get; set; } = null!;
        public virtual DbSet<TProcessFlow> TProcessFlows { get; set; } = null!;
        public virtual DbSet<TProcessFlowDetail> TProcessFlowDetails { get; set; } = null!;
        public virtual DbSet<TProcessTran> TProcessTrans { get; set; } = null!;
        public virtual DbSet<TProcessTranDetail> TProcessTranDetails { get; set; } = null!;
        public virtual DbSet<TProcessTranDetailHstry> TProcessTranDetailHstries { get; set; } = null!;
        public virtual DbSet<TProcessType> TProcessTypes { get; set; } = null!;
        public virtual DbSet<TQuotationDetail> TQuotationDetails { get; set; } = null!;
        public virtual DbSet<TQuotationDetailBuying> TQuotationDetailBuyings { get; set; } = null!;
        public virtual DbSet<TQuotationDetailMedium> TQuotationDetailMedia { get; set; } = null!;
        public virtual DbSet<TQuotationDetailPrint> TQuotationDetailPrints { get; set; } = null!;
        public virtual DbSet<TQuotationMaster> TQuotationMasters { get; set; } = null!;
        public virtual DbSet<TQuotationTermsCondition> TQuotationTermsConditions { get; set; } = null!;
        public virtual DbSet<TQuotationsDetail> TQuotationsDetails { get; set; } = null!;
        public virtual DbSet<TQuotationsMaster> TQuotationsMasters { get; set; } = null!;
        public virtual DbSet<TRoleSetup> TRoleSetups { get; set; } = null!;
        public virtual DbSet<TSbPhoteagraphy> TSbPhoteagraphies { get; set; } = null!;
        public virtual DbSet<TScustInfo> TScustInfos { get; set; } = null!;
        public virtual DbSet<TServiceHead> TServiceHeads { get; set; } = null!;
        public virtual DbSet<TServiceHeadGroup> TServiceHeadGroups { get; set; } = null!;
        public virtual DbSet<TSysUser> TSysUsers { get; set; } = null!;
        public virtual DbSet<TTermsCondition> TTermsConditions { get; set; } = null!;
        public virtual DbSet<TUser> TUsers { get; set; } = null!;
        public virtual DbSet<TUserMenu> TUserMenus { get; set; } = null!;
        public virtual DbSet<TUserRole> TUserRoles { get; set; } = null!;
        public virtual DbSet<TWorkorderDetail> TWorkorderDetails { get; set; } = null!;
        public virtual DbSet<TWorkorderDetailBuying> TWorkorderDetailBuyings { get; set; } = null!;
        public virtual DbSet<TWorkorderDetailMedium> TWorkorderDetailMedia { get; set; } = null!;
        public virtual DbSet<TWorkorderDetailPrint> TWorkorderDetailPrints { get; set; } = null!;
        public virtual DbSet<TWorkorderMaster> TWorkorderMasters { get; set; } = null!;
        public virtual DbSet<TWorkorderTermsCondition> TWorkorderTermsConditions { get; set; } = null!;
        public virtual DbSet<TvBankAccnt> TvBankAccnts { get; set; } = null!;
        public virtual DbSet<TvBankActype> TvBankActypes { get; set; } = null!;
        public virtual DbSet<TvBilld> TvBillds { get; set; } = null!;
        public virtual DbSet<TvBillsp> TvBillsps { get; set; } = null!;
        public virtual DbSet<TvBreak> TvBreaks { get; set; } = null!;
        public virtual DbSet<TvClient> TvClients { get; set; } = null!;
        public virtual DbSet<TvCommRate> TvCommRates { get; set; } = null!;
        public virtual DbSet<TvCommRateHistory> TvCommRateHistories { get; set; } = null!;
        public virtual DbSet<TvCprod> TvCprods { get; set; } = null!;
        public virtual DbSet<TvDelscdul> TvDelscduls { get; set; } = null!;
        public virtual DbSet<TvDelscdulMaster> TvDelscdulMasters { get; set; } = null!;
        public virtual DbSet<TvHour> TvHours { get; set; } = null!;
        public virtual DbSet<TvInvoc> TvInvocs { get; set; } = null!;
        public virtual DbSet<TvLog> TvLogs { get; set; } = null!;
        public virtual DbSet<TvLogMaster> TvLogMasters { get; set; } = null!;
        public virtual DbSet<TvLscdlarcvDetl> TvLscdlarcvDetls { get; set; } = null!;
        public virtual DbSet<TvLscdlarcvMaster> TvLscdlarcvMasters { get; set; } = null!;
        public virtual DbSet<TvLsscdul> TvLsscduls { get; set; } = null!;
        public virtual DbSet<TvLsscdulMaster> TvLsscdulMasters { get; set; } = null!;
        public virtual DbSet<TvMbank> TvMbanks { get; set; } = null!;
        public virtual DbSet<TvMnrcvd> TvMnrcvds { get; set; } = null!;
        public virtual DbSet<TvMnrcvm> TvMnrcvms { get; set; } = null!;
        public virtual DbSet<TvPenbil> TvPenbils { get; set; } = null!;
        public virtual DbSet<TvPenbilMaster> TvPenbilMasters { get; set; } = null!;
        public virtual DbSet<TvProgm> TvProgms { get; set; } = null!;
        public virtual DbSet<TvRcvtype> TvRcvtypes { get; set; } = null!;
        public virtual DbSet<TvSchedule> TvSchedules { get; set; } = null!;
        public virtual DbSet<TvScheduleMaster> TvScheduleMasters { get; set; } = null!;
        public virtual DbSet<TvScomp> TvScomps { get; set; } = null!;
        public virtual DbSet<TvSpbld> TvSpblds { get; set; } = null!;
        public virtual DbSet<TvSpblm> TvSpblms { get; set; } = null!;
        public virtual DbSet<TvSpot> TvSpots { get; set; } = null!;
        public virtual DbSet<TvSprod> TvSprods { get; set; } = null!;
        public virtual DbSet<TvStatus> TvStatuses { get; set; } = null!;
        public virtual DbSet<TvWrklsd> TvWrklsds { get; set; } = null!;
        public virtual DbSet<TvWrklsdMaster> TvWrklsdMasters { get; set; } = null!;
        public virtual DbSet<TvWrkord> TvWrkords { get; set; } = null!;
        public virtual DbSet<TvWrksdlMaster> TvWrksdlMasters { get; set; } = null!;
        public virtual DbSet<VwTvMoneyCashReceive> VwTvMoneyCashReceives { get; set; } = null!;
        public virtual DbSet<VwTvMoneyRcvAdjustment> VwTvMoneyRcvAdjustments { get; set; } = null!;
        public virtual DbSet<VwTvMoneyReceived> VwTvMoneyReceiveds { get; set; } = null!;
        public virtual DbSet<VwTvMrContactAmnt> VwTvMrContactAmnts { get; set; } = null!;
        public virtual DbSet<ZDebugTab> ZDebugTabs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle(

                    //"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=erpprd)(PORT=1528))(CONNECT_DATA=(SERVICE_NAME=MEDIAPDB)));User Id=city_media;Password=citymedia.it;;Persist Security Info=True"

                    );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("CITY_MEDIA")
                .UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<EtCmnmenu>(entity =>
            {
                entity.HasKey(e => e.Menuid)
                    .HasName("ET_CMNMENU_PK");

                entity.ToTable("ET_CMNMENU");

                entity.Property(e => e.Menuid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MENUID");

                entity.Property(e => e.Companyid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COMPANYID");

                entity.Property(e => e.Createby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Customcode)
                    .HasMaxLength(50)
                    .HasColumnName("CUSTOMCODE");

                entity.Property(e => e.Deleteby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Isdeleted)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ISDELETED")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Menuiconcss)
                    .HasMaxLength(50)
                    .HasColumnName("MENUICONCSS");

                entity.Property(e => e.Menuname)
                    .HasMaxLength(100)
                    .HasColumnName("MENUNAME");

                entity.Property(e => e.Menupath)
                    .HasMaxLength(300)
                    .HasColumnName("MENUPATH");

                entity.Property(e => e.Menushortname)
                    .HasMaxLength(100)
                    .HasColumnName("MENUSHORTNAME");

                entity.Property(e => e.Menutypeid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MENUTYPEID");

                entity.Property(e => e.Moduleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MODULEID");

                entity.Property(e => e.Parentid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PARENTID");

                entity.Property(e => e.Reportname)
                    .HasMaxLength(100)
                    .HasColumnName("REPORTNAME");

                entity.Property(e => e.Reportpath)
                    .HasMaxLength(300)
                    .HasColumnName("REPORTPATH");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SEQUENCE");

                entity.Property(e => e.Statusid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STATUSID");

                entity.Property(e => e.Updateby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<EtCmnmenupermission>(entity =>
            {
                entity.HasKey(e => e.Menupermissionid)
                    .HasName("ET_CMNMENUPERMISSION_PK");

                entity.ToTable("ET_CMNMENUPERMISSION");

                entity.Property(e => e.Menupermissionid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MENUPERMISSIONID");

                entity.Property(e => e.Companyid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COMPANYID");

                entity.Property(e => e.Createby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Customcode)
                    .HasMaxLength(50)
                    .HasColumnName("CUSTOMCODE");

                entity.Property(e => e.Deleteby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Effectivedate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVEDATE");

                entity.Property(e => e.Enabledelete)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENABLEDELETE");

                entity.Property(e => e.Enableinsert)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENABLEINSERT");

                entity.Property(e => e.Enableupdate)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENABLEUPDATE");

                entity.Property(e => e.Enableview)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENABLEVIEW");

                entity.Property(e => e.Isactive)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ISACTIVE");

                entity.Property(e => e.Isdeleted)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ISDELETED")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Menuid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MENUID");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .HasColumnName("OID");

                entity.Property(e => e.Organogramid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANOGRAMID");

                entity.Property(e => e.Statusid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STATUSID");

                entity.Property(e => e.Updateby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.Usergroupid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERGROUPID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(5)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<EtCmnmodule>(entity =>
            {
                entity.HasKey(e => e.Moduleid)
                    .HasName("ET_CMNMODULE_PK");

                entity.ToTable("ET_CMNMODULE");

                entity.Property(e => e.Moduleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MODULEID");

                entity.Property(e => e.Companyid)
                    .HasPrecision(10)
                    .HasColumnName("COMPANYID");

                entity.Property(e => e.Createby)
                    .HasPrecision(10)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Customcode)
                    .HasMaxLength(50)
                    .HasColumnName("CUSTOMCODE");

                entity.Property(e => e.Deleteby)
                    .HasPrecision(10)
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Imageurl)
                    .HasMaxLength(300)
                    .HasColumnName("IMAGEURL");

                entity.Property(e => e.Isdeleted)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("ISDELETED")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Modulename)
                    .HasMaxLength(150)
                    .HasColumnName("MODULENAME");

                entity.Property(e => e.Modulepath)
                    .HasMaxLength(300)
                    .HasColumnName("MODULEPATH");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SEQUENCE");

                entity.Property(e => e.Statusid)
                    .HasPrecision(10)
                    .HasColumnName("STATUSID");

                entity.Property(e => e.Updateby)
                    .HasPrecision(10)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<EtCmnmodulepermission>(entity =>
            {
                entity.HasKey(e => e.Modulepermissionid)
                    .HasName("ET_CMNMODULEPERMISSION_PK");

                entity.ToTable("ET_CMNMODULEPERMISSION");

                entity.Property(e => e.Modulepermissionid)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("MODULEPERMISSIONID");

                entity.Property(e => e.Companyid)
                    .HasPrecision(10)
                    .HasColumnName("COMPANYID");

                entity.Property(e => e.Createby)
                    .HasPrecision(10)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Customcode)
                    .HasMaxLength(50)
                    .HasColumnName("CUSTOMCODE");

                entity.Property(e => e.Deleteby)
                    .HasPrecision(10)
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Isdeleted)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("ISDELETED")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Menulistid)
                    .HasPrecision(10)
                    .HasColumnName("MENULISTID");

                entity.Property(e => e.Moduleid)
                    .HasPrecision(10)
                    .HasColumnName("MODULEID");

                entity.Property(e => e.Statusid)
                    .HasPrecision(10)
                    .HasColumnName("STATUSID");

                entity.Property(e => e.Updateby)
                    .HasPrecision(10)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<EtCmnuser>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("ET_CMNUSER_PK");

                entity.ToTable("ET_CMNUSER");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERID");

                entity.Property(e => e.Appointment)
                    .HasMaxLength(250)
                    .HasColumnName("APPOINTMENT");

                entity.Property(e => e.Companyid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COMPANYID");

                entity.Property(e => e.Contractemailid)
                    .HasMaxLength(250)
                    .HasColumnName("CONTRACTEMAILID");

                entity.Property(e => e.Createby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Customcode)
                    .HasMaxLength(50)
                    .HasColumnName("CUSTOMCODE");

                entity.Property(e => e.Customeraccountid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CUSTOMERACCOUNTID");

                entity.Property(e => e.Deleteby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Departmentname)
                    .HasMaxLength(250)
                    .HasColumnName("DEPARTMENTNAME");

                entity.Property(e => e.Effectivedate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVEDATE");

                entity.Property(e => e.Employeeid)
                    .HasMaxLength(50)
                    .HasColumnName("EMPLOYEEID");

                entity.Property(e => e.Facebookid)
                    .HasMaxLength(250)
                    .HasColumnName("FACEBOOKID");

                entity.Property(e => e.Genderid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GENDERID");

                entity.Property(e => e.Isactive)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ISACTIVE");

                entity.Property(e => e.Isdeleted)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ISDELETED")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Linkedin)
                    .HasMaxLength(250)
                    .HasColumnName("LINKEDIN");

                entity.Property(e => e.Mobileno)
                    .HasMaxLength(20)
                    .HasColumnName("MOBILENO");

                entity.Property(e => e.Officeid)
                    .HasMaxLength(50)
                    .HasColumnName("OFFICEID");

                entity.Property(e => e.Phoneno)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PHONENO");

                entity.Property(e => e.Religionid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("RELIGIONID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Sapcustomerid)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("SAPCUSTOMERID");

                entity.Property(e => e.Skypeid)
                    .HasMaxLength(250)
                    .HasColumnName("SKYPEID");

                entity.Property(e => e.Statusid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STATUSID");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(250)
                    .HasColumnName("TELEPHONE");

                entity.Property(e => e.Transactiontypeid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TRANSACTIONTYPEID");

                entity.Property(e => e.Uniqueidentity)
                    .HasMaxLength(250)
                    .HasColumnName("UNIQUEIDENTITY");

                entity.Property(e => e.Updateby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.Userdesignationid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERDESIGNATIONID");

                entity.Property(e => e.Userfirstname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("USERFIRSTNAME");

                entity.Property(e => e.Userfullname)
                    .HasMaxLength(200)
                    .HasColumnName("USERFULLNAME");

                entity.Property(e => e.Usergroupid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERGROUPID");

                entity.Property(e => e.Userjobtitle)
                    .HasMaxLength(100)
                    .HasColumnName("USERJOBTITLE");

                entity.Property(e => e.Userlastname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("USERLASTNAME");

                entity.Property(e => e.Usermiddlename)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("USERMIDDLENAME");

                entity.Property(e => e.Userparentid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERPARENTID");

                entity.Property(e => e.Usertitleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERTITLEID");

                entity.Property(e => e.Usertypeid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERTYPEID");

                entity.Property(e => e.Viber)
                    .HasMaxLength(250)
                    .HasColumnName("VIBER");

                entity.Property(e => e.Whatsapp)
                    .HasMaxLength(250)
                    .HasColumnName("WHATSAPP");
            });

            modelBuilder.Entity<EtCmnuserauthentication>(entity =>
            {
                entity.HasKey(e => e.Authenticationid)
                    .HasName("ET_CMNUSERAUTHENTICATION_PK");

                entity.ToTable("ET_CMNUSERAUTHENTICATION");

                entity.Property(e => e.Authenticationid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("AUTHENTICATIONID");

                entity.Property(e => e.Activationcode)
                    .HasMaxLength(200)
                    .HasColumnName("ACTIVATIONCODE");

                entity.Property(e => e.Activationdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACTIVATIONDATE");

                entity.Property(e => e.Allowmultiplelogin)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ALLOWMULTIPLELOGIN");

                entity.Property(e => e.Companyid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMPANYID");

                entity.Property(e => e.Confirmpassword)
                    .HasMaxLength(50)
                    .HasColumnName("CONFIRMPASSWORD");

                entity.Property(e => e.Createby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Deleteby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Encryptpassword)
                    .HasMaxLength(50)
                    .HasColumnName("ENCRYPTPASSWORD");

                entity.Property(e => e.Expiredate)
                    .HasColumnType("DATE")
                    .HasColumnName("EXPIREDATE");

                entity.Property(e => e.Isdeleted)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ISDELETED")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Isfirstlogin)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ISFIRSTLOGIN")
                    .HasDefaultValueSql("((0)) \n");

                entity.Property(e => e.Languageid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LANGUAGEID");

                entity.Property(e => e.Loginemail)
                    .HasMaxLength(50)
                    .HasColumnName("LOGINEMAIL");

                entity.Property(e => e.Loginphone)
                    .HasMaxLength(50)
                    .HasColumnName("LOGINPHONE");

                entity.Property(e => e.Nooflogin)
                    .HasMaxLength(10)
                    .HasColumnName("NOOFLOGIN")
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Registrationdate)
                    .HasColumnType("DATE")
                    .HasColumnName("REGISTRATIONDATE");

                entity.Property(e => e.Statusid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STATUSID");

                entity.Property(e => e.Timezoneid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TIMEZONEID");

                entity.Property(e => e.Updateby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.Userid)
                    .HasMaxLength(5)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<EtErrorlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ET_ERRORLOG");

                entity.Property(e => e.Errormessage)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ERRORMESSAGE");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<TAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_AUDIT");

                entity.Property(e => e.CompId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMP_ID");

                entity.Property(e => e.Dt)
                    .HasColumnType("DATE")
                    .HasColumnName("DT")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.ErrorCode)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ERROR_CODE");

                entity.Property(e => e.ErrorId)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ERROR_ID");

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("ERROR_MESSAGE");

                entity.Property(e => e.ErrorSolveStatus)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ERROR_SOLVE_STATUS");

                entity.Property(e => e.ErrorSolvedBy)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ERROR_SOLVED_BY");

                entity.Property(e => e.LocId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LOC_ID");

                entity.Property(e => e.MacId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAC_ID");

                entity.Property(e => e.RefOid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REF_OID");

                entity.Property(e => e.TabName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("TAB_NAME");

                entity.Property(e => e.UserId)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");
            });

            modelBuilder.Entity<TBassetType>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_BASSET_TYPE_PK");

                entity.ToTable("T_BASSET_TYPE");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.BassettypeBname)
                    .HasMaxLength(150)
                    .HasColumnName("BASSETTYPE_BNAME");

                entity.Property(e => e.BassettypeName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BASSETTYPE_NAME");

                entity.Property(e => e.BassettypeSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BASSETTYPE_SNAME");

                entity.Property(e => e.BassettypeTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BASSETTYPE_TRNO");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TBmetric>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_BMETRICS_PK");

                entity.ToTable("T_BMETRICS");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.BmetricsBname)
                    .HasMaxLength(150)
                    .HasColumnName("BMETRICS_BNAME");

                entity.Property(e => e.BmetricsName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BMETRICS_NAME");

                entity.Property(e => e.BmetricsSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BMETRICS_SNAME");

                entity.Property(e => e.BmetricsTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BMETRICS_TRNO");

                entity.Property(e => e.BmetricsValue)
                    .HasPrecision(12)
                    .HasColumnName("BMETRICS_VALUE");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TBparameter>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_BPARAMETER");

                entity.ToTable("T_BPARAMETER");

                entity.HasIndex(e => e.BparameterTrno, "UK_TRNO_BPARAMETER")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.BparameterBname)
                    .HasMaxLength(150)
                    .HasColumnName("BPARAMETER_BNAME");

                entity.Property(e => e.BparameterName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BPARAMETER_NAME");

                entity.Property(e => e.BparameterSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BPARAMETER_SNAME");

                entity.Property(e => e.BparameterTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BPARAMETER_TRNO");

                entity.Property(e => e.BplatformOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BPLATFORM_OID");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.HasOne(d => d.CategoryO)
                    .WithMany(p => p.TBparameters)
                    .HasForeignKey(d => d.CategoryOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CATEGORY_BPARAMETER");
            });

            modelBuilder.Entity<TBparameterTask>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_BPARAMETER_TASK_PK");

                entity.ToTable("T_BPARAMETER_TASK");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.BparameterOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BPARAMETER_OID");

                entity.Property(e => e.BparametertaskBname)
                    .HasMaxLength(150)
                    .HasColumnName("BPARAMETERTASK_BNAME");

                entity.Property(e => e.BparametertaskName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BPARAMETERTASK_NAME");

                entity.Property(e => e.BparametertaskSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BPARAMETERTASK_SNAME");

                entity.Property(e => e.BparametertaskTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BPARAMETERTASK_TRNO");

                entity.Property(e => e.BplatformOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BPLATFORM_OID");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TBplacement>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_BPLACEMENT_PK");

                entity.ToTable("T_BPLACEMENT");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.BplacementBname)
                    .HasMaxLength(150)
                    .HasColumnName("BPLACEMENT_BNAME");

                entity.Property(e => e.BplacementName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BPLACEMENT_NAME");

                entity.Property(e => e.BplacementSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BPLACEMENT_SNAME");

                entity.Property(e => e.BplacementTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BPLACEMENT_TRNO");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TBplatform>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_BPLATFORM");

                entity.ToTable("T_BPLATFORM");

                entity.HasIndex(e => e.BplatformTrno, "UK_TRNO_BPLATFORM")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.BplatformBname)
                    .HasMaxLength(150)
                    .HasColumnName("BPLATFORM_BNAME");

                entity.Property(e => e.BplatformName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BPLATFORM_NAME");

                entity.Property(e => e.BplatformSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BPLATFORM_SNAME");

                entity.Property(e => e.BplatformTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BPLATFORM_TRNO");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.HasOne(d => d.CategoryO)
                    .WithMany(p => p.TBplatforms)
                    .HasForeignKey(d => d.CategoryOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CATEGORY_BPLATFORM");
            });

            modelBuilder.Entity<TBpublisher>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_BPUBLISHER_PK");

                entity.ToTable("T_BPUBLISHER");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.BpublisherBname)
                    .HasMaxLength(150)
                    .HasColumnName("BPUBLISHER_BNAME");

                entity.Property(e => e.BpublisherName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BPUBLISHER_NAME");

                entity.Property(e => e.BpublisherSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BPUBLISHER_SNAME");

                entity.Property(e => e.BpublisherTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BPUBLISHER_TRNO");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TBrand>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_BRAND_PK");

                entity.ToTable("T_BRAND");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.BrandBname)
                    .HasMaxLength(150)
                    .HasColumnName("BRAND_BNAME");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BRAND_NAME");

                entity.Property(e => e.BrandSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BRAND_SNAME");

                entity.Property(e => e.BrandTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BRAND_TRNO");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE");

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TBsupplement>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_BSUPPLEMENTS_PK");

                entity.ToTable("T_BSUPPLEMENTS");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.BsupplementsBname)
                    .HasMaxLength(150)
                    .HasColumnName("BSUPPLEMENTS_BNAME");

                entity.Property(e => e.BsupplementsName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BSUPPLEMENTS_NAME");

                entity.Property(e => e.BsupplementsSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BSUPPLEMENTS_SNAME");

                entity.Property(e => e.BsupplementsTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BSUPPLEMENTS_TRNO");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.PublisherOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PUBLISHER_OID");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TCategory>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_CATEGORY_PK");

                entity.ToTable("T_CATEGORY");

                entity.HasIndex(e => e.CategoryTrno, "T_CATEGORY_UK1")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.CategoryBname)
                    .HasMaxLength(150)
                    .HasColumnName("CATEGORY_BNAME");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_NAME");

                entity.Property(e => e.CategorySname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_SNAME");

                entity.Property(e => e.CategoryTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_TRNO");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TClient>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_CLIENT_PK");

                entity.ToTable("T_CLIENT");

                entity.HasIndex(e => e.ClientCode, "T_CLIENT_UK1")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ClientAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_ADDRESS");

                entity.Property(e => e.ClientAddress2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_ADDRESS2");

                entity.Property(e => e.ClientBaddress)
                    .HasMaxLength(500)
                    .HasColumnName("CLIENT_BADDRESS");

                entity.Property(e => e.ClientBaddress2)
                    .HasMaxLength(500)
                    .HasColumnName("CLIENT_BADDRESS2");

                entity.Property(e => e.ClientBin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_BIN");

                entity.Property(e => e.ClientBname)
                    .HasMaxLength(250)
                    .HasColumnName("CLIENT_BNAME");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_CODE");

                entity.Property(e => e.ClientContactPerson)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_CONTACT_PERSON");

                entity.Property(e => e.ClientCreditLimit)
                    .HasColumnType("NUMBER(15,2)")
                    .HasColumnName("CLIENT_CREDIT_LIMIT");

                entity.Property(e => e.ClientDesig)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_DESIG");

                entity.Property(e => e.ClientEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_EMAIL");

                entity.Property(e => e.ClientEnrolldate)
                    .HasColumnType("DATE")
                    .HasColumnName("CLIENT_ENROLLDATE");

                entity.Property(e => e.ClientFax)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_FAX");

                entity.Property(e => e.ClientMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_MOBILE");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_NAME");

                entity.Property(e => e.ClientOwner)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_OWNER");

                entity.Property(e => e.ClientSname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_SNAME");

                entity.Property(e => e.ClientTin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_TIN");

                entity.Property(e => e.ClientType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_TYPE");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TClientBank>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_CLIENT_BANK");

                entity.ToTable("T_CLIENT_BANK");

                entity.HasIndex(e => e.ClientBankCode, "UK_CODE_CLIENT_BANK")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ClientAccountName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_ACCOUNT_NAME");

                entity.Property(e => e.ClientAccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_ACCOUNT_NUMBER");

                entity.Property(e => e.ClientAccountType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_ACCOUNT_TYPE");

                entity.Property(e => e.ClientBankBranch)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_BANK_BRANCH");

                entity.Property(e => e.ClientBankCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_BANK_CODE");

                entity.Property(e => e.ClientBankId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_BANK_ID");

                entity.Property(e => e.ClientBankRouting)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_BANK_ROUTING");

                entity.Property(e => e.ClientBankSwiftcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_BANK_SWIFTCODE");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_ID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TClientBanks)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_BANK_ID");
            });

            modelBuilder.Entity<TClientType>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_CLIENT_TYPE_PK");

                entity.ToTable("T_CLIENT_TYPE");

                entity.HasIndex(e => e.TypeTrno, "T_CLIENT_TYPE_UK1")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.TypeName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_NAME");

                entity.Property(e => e.TypeTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_TRNO");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TCmnCurrency>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_CMN_CURRENCY_PK");

                entity.ToTable("T_CMN_CURRENCY");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Currencyname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCYNAME");

                entity.Property(e => e.Deleteby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1 ")
                    .IsFixedLength();

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDELETE")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TCmndocument>(entity =>
            {
                entity.HasKey(e => e.Documentid)
                    .HasName("T_CMNDOCUMENT_PK");

                entity.ToTable("T_CMNDOCUMENT");

                entity.Property(e => e.Documentid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DOCUMENTID");

                entity.Property(e => e.Basepath)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("BASEPATH");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Deleteby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Documentfullpath)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENTFULLPATH");

                entity.Property(e => e.Documentname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENTNAME");

                entity.Property(e => e.Documentpath)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENTPATH");

                entity.Property(e => e.Documentsize)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DOCUMENTSIZE");

                entity.Property(e => e.Documenttype)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENTTYPE");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDELETE")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Originaldocname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ORIGINALDOCNAME");

                entity.Property(e => e.Referenceid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REFERENCEID");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.Virtualpath)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("VIRTUALPATH");
            });

            modelBuilder.Entity<TCmnmenu>(entity =>
            {
                entity.HasKey(e => e.Menuid)
                    .HasName("T_CMNMENU_PK");

                entity.ToTable("T_CMNMENU");

                entity.Property(e => e.Menuid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MENUID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Deleteby)
                    .HasMaxLength(20)
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDELETE")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Issubparent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISSUBPARENT")
                    .IsFixedLength();

                entity.Property(e => e.Menuicon)
                    .HasMaxLength(100)
                    .HasColumnName("MENUICON");

                entity.Property(e => e.Menuname)
                    .HasMaxLength(100)
                    .HasColumnName("MENUNAME");

                entity.Property(e => e.Menupath)
                    .HasMaxLength(300)
                    .HasColumnName("MENUPATH");

                entity.Property(e => e.Menushortname)
                    .HasMaxLength(100)
                    .HasColumnName("MENUSHORTNAME");

                entity.Property(e => e.Menutypeid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MENUTYPEID");

                entity.Property(e => e.Moduleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MODULEID");

                entity.Property(e => e.Parentid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PARENTID");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SEQUENCE");

                entity.Property(e => e.Subparentid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SUBPARENTID");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TCmnmenupermission>(entity =>
            {
                entity.HasKey(e => e.Menupermissionid)
                    .HasName("T_CMNMENUPERMISSION_PK");

                entity.ToTable("T_CMNMENUPERMISSION");

                entity.Property(e => e.Menupermissionid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MENUPERMISSIONID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Deleteby)
                    .HasMaxLength(20)
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Enabledelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLEDELETE")
                    .IsFixedLength();

                entity.Property(e => e.Enableinsert)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLEINSERT")
                    .IsFixedLength();

                entity.Property(e => e.Enableupdate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLEUPDATE")
                    .IsFixedLength();

                entity.Property(e => e.Enableview)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENABLEVIEW")
                    .IsFixedLength();

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDELETE")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.Menuid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MENUID");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TErrorLog>(entity =>
            {
                entity.HasKey(e => e.Errorid)
                    .HasName("T_ERROR_LOGS_PK");

                entity.ToTable("T_ERROR_LOGS");

                entity.Property(e => e.Errorid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ERRORID");

                entity.Property(e => e.Apipath)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("APIPATH");

                entity.Property(e => e.Browser)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("BROWSER");

                entity.Property(e => e.Clientagent)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTAGENT");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Errormessage)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("ERRORMESSAGE");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Requesttype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REQUESTTYPE");

                entity.Property(e => e.Spname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("SPNAME");

                entity.Property(e => e.Stacktrace)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("STACKTRACE");
            });

            modelBuilder.Entity<TMediaAdPosition>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_MEDIA_AD_POSITION_PK");

                entity.ToTable("T_MEDIA_AD_POSITION");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.PositionBname)
                    .HasMaxLength(150)
                    .HasColumnName("POSITION_BNAME");

                entity.Property(e => e.PositionName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("POSITION_NAME");

                entity.Property(e => e.PositionSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSITION_SNAME");

                entity.Property(e => e.PositionTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POSITION_TRNO");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TMediaBroadcast>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_MEDIA_BROADCAST_PK");

                entity.ToTable("T_MEDIA_BROADCAST");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.BroadcastBname)
                    .HasMaxLength(150)
                    .HasColumnName("BROADCAST_BNAME");

                entity.Property(e => e.BroadcastName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BROADCAST_NAME");

                entity.Property(e => e.BroadcastSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BROADCAST_SNAME");

                entity.Property(e => e.BroadcastTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BROADCAST_TRNO");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TMediaDay>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_MEDIA_DAY_PK");

                entity.ToTable("T_MEDIA_DAY");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.DayBname)
                    .HasMaxLength(150)
                    .HasColumnName("DAY_BNAME");

                entity.Property(e => e.DayName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DAY_NAME");

                entity.Property(e => e.DaySname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DAY_SNAME");

                entity.Property(e => e.DayTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DAY_TRNO");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TMediaDayPart>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_MEDIA_DAY_PART_PK");

                entity.ToTable("T_MEDIA_DAY_PART");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.DaypartBname)
                    .HasMaxLength(150)
                    .HasColumnName("DAYPART_BNAME");

                entity.Property(e => e.DaypartName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DAYPART_NAME");

                entity.Property(e => e.DaypartSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DAYPART_SNAME");

                entity.Property(e => e.DaypartTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DAYPART_TRNO");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TMediaGenre>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_MEDIA_GENRE_PK");

                entity.ToTable("T_MEDIA_GENRE");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.GenreBname)
                    .HasMaxLength(150)
                    .HasColumnName("GENRE_BNAME");

                entity.Property(e => e.GenreName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("GENRE_NAME");

                entity.Property(e => e.GenreSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GENRE_SNAME");

                entity.Property(e => e.GenreTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GENRE_TRNO");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TMediaProgram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_MEDIA_PROGRAM");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ProgramBegin)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_BEGIN");

                entity.Property(e => e.ProgramBname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_BNAME");

                entity.Property(e => e.ProgramEnd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_END");

                entity.Property(e => e.ProgramName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_NAME");

                entity.Property(e => e.ProgramSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_SNAME");

                entity.Property(e => e.ProgramTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_TRNO");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TMediaSponsor>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_MEDIA_SPONSOR_PK");

                entity.ToTable("T_MEDIA_SPONSOR");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.SponsorBname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPONSOR_BNAME");

                entity.Property(e => e.SponsorName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SPONSOR_NAME");

                entity.Property(e => e.SponsorSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPONSOR_SNAME");

                entity.Property(e => e.SponsorTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SPONSOR_TRNO");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TMediaSponsoredProject>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_MEDIA_SPONSORED_PROJECT_PK");

                entity.ToTable("T_MEDIA_SPONSORED_PROJECT");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.ProjectBname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROJECT_BNAME");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PROJECT_NAME");

                entity.Property(e => e.ProjectSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROJECT_SNAME");

                entity.Property(e => e.ProjectTrno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PROJECT_TRNO");

                entity.Property(e => e.SponsorOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPONSOR_OID");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TMenu>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_MENU");

                entity.ToTable("T_MENU");

                entity.HasIndex(e => e.MenuText, "UK_TEXT_MENU")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.MenuActv)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MENU_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MenuFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MENU_FLAG")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MenuMaster)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MENU_MASTER");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MENU_NAME");

                entity.Property(e => e.MenuSeqn)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MENU_SEQN");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MENU_TEXT");

                entity.Property(e => e.Web)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WEB")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TMnud>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_MNUD");

                entity.ToTable("T_MNUD");

                entity.HasIndex(e => e.MnudText, "UK_TEXT_MNUD")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.MnudActv)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MNUD_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MnudDnam)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MNUD_DNAM");

                entity.Property(e => e.MnudFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MNUD_FLAG")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MnudHnam)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MNUD_HNAM");

                entity.Property(e => e.MnudMenu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MNUD_MENU");

                entity.Property(e => e.MnudMnam)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MNUD_MNAM");

                entity.Property(e => e.MnudName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MNUD_NAME");

                entity.Property(e => e.MnudPage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MNUD_PAGE");

                entity.Property(e => e.MnudSeqn)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MNUD_SEQN");

                entity.Property(e => e.MnudText)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MNUD_TEXT");

                entity.HasOne(d => d.MnudMenuNavigation)
                    .WithMany(p => p.TMnuds)
                    .HasForeignKey(d => d.MnudMenu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MENU_MNUD");
            });

            modelBuilder.Entity<TProcessFlow>(entity =>
            {
                entity.HasKey(e => e.Processflowid)
                    .HasName("T_CMNPROCESS_FLOW_PK");

                entity.ToTable("T_PROCESS_FLOW");

                entity.Property(e => e.Processflowid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSFLOWID");

                entity.Property(e => e.Categoryid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1 ")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.Menuid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MENUID");

                entity.Property(e => e.Processflowcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSFLOWCODE");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TProcessFlowDetail>(entity =>
            {
                entity.HasKey(e => e.Processflowdetailid)
                    .HasName("T_CMNPROCESS_FLOW_DETAIL_PK");

                entity.ToTable("T_PROCESS_FLOW_DETAIL");

                entity.Property(e => e.Processflowdetailid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSFLOWDETAILID");

                entity.Property(e => e.Categoryid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1 ")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.Processflowid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSFLOWID");

                entity.Property(e => e.Processtypeid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSTYPEID");

                entity.Property(e => e.Sequences)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SEQUENCES");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<TProcessTran>(entity =>
            {
                entity.HasKey(e => e.Transactionid)
                    .HasName("T_PROCESS_TRAN_PK");

                entity.ToTable("T_PROCESS_TRAN");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Approvedcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEDCOMMENTS");

                entity.Property(e => e.Approveduserid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEDUSERID");

                entity.Property(e => e.Categoryid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Currentsequence)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CURRENTSEQUENCE");

                entity.Property(e => e.Declinedcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DECLINEDCOMMENTS");

                entity.Property(e => e.Declineduserid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DECLINEDUSERID");

                entity.Property(e => e.Fromuserid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FROMUSERID");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1 ")
                    .IsFixedLength();

                entity.Property(e => e.Isapproved)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISAPPROVED")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Isapprovedall)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISAPPROVEDALL")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.Isdeclined)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDECLINED")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Processflowdetailid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSFLOWDETAILID");

                entity.Property(e => e.Processflowid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSFLOWID");

                entity.Property(e => e.Processtypeid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSTYPEID");

                entity.Property(e => e.Referenceid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REFERENCEID");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Touserid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOUSERID");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<TProcessTranDetail>(entity =>
            {
                entity.HasKey(e => e.Transactiondetailid)
                    .HasName("T_PROCESS_TRAN_DETAIL_PK");

                entity.ToTable("T_PROCESS_TRAN_DETAIL");

                entity.Property(e => e.Transactiondetailid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACTIONDETAILID");

                entity.Property(e => e.Approvedcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEDCOMMENTS");

                entity.Property(e => e.Approveduserid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPROVEDUSERID");

                entity.Property(e => e.Categoryid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Currentsequence)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CURRENTSEQUENCE");

                entity.Property(e => e.Declinedcomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DECLINEDCOMMENTS");

                entity.Property(e => e.Declineduserid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DECLINEDUSERID");

                entity.Property(e => e.Fromuserid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FROMUSERID");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1 ")
                    .IsFixedLength();

                entity.Property(e => e.Isapproved)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISAPPROVED")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Isapprovedall)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISAPPROVEDALL")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.Isdeclined)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDECLINED")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Processflowdetailid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSFLOWDETAILID");

                entity.Property(e => e.Processflowid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSFLOWID");

                entity.Property(e => e.Processtypeid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSTYPEID");

                entity.Property(e => e.Referenceid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REFERENCEID");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Touserid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOUSERID");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<TProcessTranDetailHstry>(entity =>
            {
                entity.HasKey(e => e.Transactiondetilhistoryid)
                    .HasName("T_PROCESS_TRAN_DETAIL_HSTR_PK");

                entity.ToTable("T_PROCESS_TRAN_DETAIL_HSTRY");

                entity.Property(e => e.Transactiondetilhistoryid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACTIONDETILHISTORYID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Fromuserid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FROMUSERID");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1 ")
                    .IsFixedLength();

                entity.Property(e => e.Isapproved)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISAPPROVED")
                    .HasDefaultValueSql("NULL")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Touserid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOUSERID");

                entity.Property(e => e.Transactiondetailid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACTIONDETAILID");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<TProcessType>(entity =>
            {
                entity.HasKey(e => e.Processtypeid)
                    .HasName("T_PROCESS_TYPE_PK");

                entity.ToTable("T_PROCESS_TYPE");

                entity.Property(e => e.Processtypeid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSTYPEID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Deleteby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1 ")
                    .IsFixedLength();

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDELETE")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.Processtype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSTYPE");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TQuotationDetail>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_QUOTATION_DETAIL_PK");

                entity.ToTable("T_QUOTATION_DETAIL");

                entity.HasIndex(e => e.Numid, "T_QUOTATION_DETAIL_UK1")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Daysshift)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("DAYSSHIFT");

                entity.Property(e => e.HeadGroupOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HEAD_GROUP_OID");

                entity.Property(e => e.HeadOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HEAD_OID");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Narration)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NARRATION");

                entity.Property(e => e.Numid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("QUANTITY");

                entity.Property(e => e.QuotNumid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("QUOT_NUMID");

                entity.Property(e => e.QuotOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("QUOT_OID");

                entity.Property(e => e.Setno)
                    .HasPrecision(12)
                    .HasColumnName("SETNO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Seton)
                    .HasPrecision(12)
                    .HasColumnName("SETON")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("UNIT_PRICE");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.HasOne(d => d.QuotO)
                    .WithMany(p => p.TQuotationDetails)
                    .HasForeignKey(d => d.QuotOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QUOT_DETAIL_FK_QUOT_MASTER_PK");
            });

            modelBuilder.Entity<TQuotationDetailBuying>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_QUOTATION_DETAIL_BUYING_PK");

                entity.ToTable("T_QUOTATION_DETAIL_BUYING");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.AgencyChargePcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_PCNT");

                entity.Property(e => e.AgencyChargeTkBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_TK_BDT");

                entity.Property(e => e.AgencyChargeTkUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_TK_USD");

                entity.Property(e => e.AssetTypeOid)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_TYPE_OID");

                entity.Property(e => e.Assettypename)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSETTYPENAME");

                entity.Property(e => e.CampaignBeginDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CAMPAIGN_BEGIN_DATE");

                entity.Property(e => e.CampaignEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CAMPAIGN_END_DATE");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.ContentCount)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("CONTENT_COUNT");

                entity.Property(e => e.ConversionRate)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("CONVERSION_RATE");

                entity.Property(e => e.CostPerResultBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_PER_RESULT_BDT");

                entity.Property(e => e.CostPerResultUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_PER_RESULT_USD");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.DiscountBdt)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_BDT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DiscountUsd)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_USD")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GrandTotalBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("GRAND_TOTAL_BDT");

                entity.Property(e => e.GrandTotalUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("GRAND_TOTAL_USD");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.MetricsOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("METRICS_OID");

                entity.Property(e => e.Numid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMID");

                entity.Property(e => e.ParameterOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER_OID");

                entity.Property(e => e.ParameterTaskOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER_TASK_OID");

                entity.Property(e => e.PlatformOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PLATFORM_OID");

                entity.Property(e => e.QuotNumid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("QUOT_NUMID");

                entity.Property(e => e.QuotOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("QUOT_OID");

                entity.Property(e => e.RemittancePcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("REMITTANCE_PCNT");

                entity.Property(e => e.RemittanceTkBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("REMITTANCE_TK_BDT");

                entity.Property(e => e.RemittanceTkUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("REMITTANCE_TK_USD");

                entity.Property(e => e.SubTotalBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SUB_TOTAL_BDT");

                entity.Property(e => e.SubTotalUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SUB_TOTAL_USD");

                entity.Property(e => e.TotalBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_BDT");

                entity.Property(e => e.TotalBudgetBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_BUDGET_BDT");

                entity.Property(e => e.TotalBudgetUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_BUDGET_USD");

                entity.Property(e => e.TotalResult)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_RESULT");

                entity.Property(e => e.TotalUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_USD");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.VatPcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_PCNT");

                entity.Property(e => e.VatTkBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_TK_BDT");

                entity.Property(e => e.VatTkUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_TK_USD");
            });

            modelBuilder.Entity<TQuotationDetailMedium>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_QUOTATION_DETAIL_MEDIA_PK");

                entity.ToTable("T_QUOTATION_DETAIL_MEDIA");

                entity.HasIndex(e => e.Numid, "T_QUOTATION_DETAIL_MEDIA_UK1")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.AdPositionOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AD_POSITION_OID");

                entity.Property(e => e.AgencyChargePcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_PCNT");

                entity.Property(e => e.AgencyChargeTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_TK");

                entity.Property(e => e.BroadcastOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BROADCAST_OID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CAMPAIGN_NAME");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.CostAfterAsf)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_AFTER_ASF");

                entity.Property(e => e.CostBeforeAsf)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_BEFORE_ASF");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.DayOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DAY_OID");

                entity.Property(e => e.DaypartOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DAYPART_OID");

                entity.Property(e => e.DiscountTk)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_TK")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DurationSec)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("DURATION_SEC");

                entity.Property(e => e.GenreOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GENRE_OID");

                entity.Property(e => e.GrandTotal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("GRAND_TOTAL");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.NegotiatedCost)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("NEGOTIATED_COST");

                entity.Property(e => e.Numid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMID");

                entity.Property(e => e.ProgramBegin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_BEGIN");

                entity.Property(e => e.ProgramEnd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_END");

                entity.Property(e => e.ProgramOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_OID");

                entity.Property(e => e.ProjectOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROJECT_OID");

                entity.Property(e => e.QuotNumid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("QUOT_NUMID");

                entity.Property(e => e.QuotOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("QUOT_OID");

                entity.Property(e => e.SponsorOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPONSOR_OID");

                entity.Property(e => e.Total)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.TotalDuration)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_DURATION");

                entity.Property(e => e.TotalSpots)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_SPOTS");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.VatPcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_PCNT");

                entity.Property(e => e.VatTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_TK");

                entity.HasOne(d => d.QuotO)
                    .WithMany(p => p.TQuotationDetailMedia)
                    .HasForeignKey(d => d.QuotOid)
                    .HasConstraintName("QUOT_DTL_MEDIA_FK_QUOT_MSTR_PK");
            });

            modelBuilder.Entity<TQuotationDetailPrint>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_QUOTATION_DETAIL_PRINT_PK");

                entity.ToTable("T_QUOTATION_DETAIL_PRINT");

                entity.HasIndex(e => e.Numid, "T_QUOTATION_DETAIL_PRINT_UK1")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.AgencyChargePcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_PCNT");

                entity.Property(e => e.AgencyChargeTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_TK");

                entity.Property(e => e.AreaSize)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AREA_SIZE");

                entity.Property(e => e.BasicCost)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("BASIC_COST");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.CostAfterAsf)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_AFTER_ASF");

                entity.Property(e => e.CostAfterRebate)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_AFTER_REBATE");

                entity.Property(e => e.CostBeforeAsf)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_BEFORE_ASF");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Discount)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("DISCOUNT");

                entity.Property(e => e.DiscountTk)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_TK")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EstimatedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ESTIMATED_DATE");

                entity.Property(e => e.GrandTotal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("GRAND_TOTAL");

                entity.Property(e => e.InsertCount)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("INSERT_COUNT");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Numid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMID");

                entity.Property(e => e.PlacementOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PLACEMENT_OID");

                entity.Property(e => e.PublisherOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PUBLISHER_OID");

                entity.Property(e => e.QuotNumid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("QUOT_NUMID");

                entity.Property(e => e.QuotOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("QUOT_OID");

                entity.Property(e => e.SupplementOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SUPPLEMENT_OID");

                entity.Property(e => e.Total)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.UnitRate)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("UNIT_RATE");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.VatPcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_PCNT");

                entity.Property(e => e.VatTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_TK");

                entity.HasOne(d => d.QuotO)
                    .WithMany(p => p.TQuotationDetailPrints)
                    .HasForeignKey(d => d.QuotOid)
                    .HasConstraintName("QUOT_DTL_PRINT_FK_QUOT_MSTR_PK");
            });

            modelBuilder.Entity<TQuotationMaster>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_QUOTATION_MASTER_PK");

                entity.ToTable("T_QUOTATION_MASTER");

                entity.HasIndex(e => e.Numid, "T_QUOTATION_MASTER_UK1")
                    .IsUnique();

                entity.HasIndex(e => e.QuotRefNo, "T_QUOTATION_MASTER_UK2")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.AdvancedPcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("ADVANCED_PCNT");

                entity.Property(e => e.AdvancedTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("ADVANCED_TK");

                entity.Property(e => e.AgencyChargePcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_PCNT");

                entity.Property(e => e.AgencyChargeTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_TK");

                entity.Property(e => e.Brandname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("BRANDNAME");

                entity.Property(e => e.Campaign)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CAMPAIGN");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.ClientOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_OID");

                entity.Property(e => e.Conversionrate)
                    .HasPrecision(12)
                    .HasColumnName("CONVERSIONRATE");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCYID");

                entity.Property(e => e.DevelopmentCharge)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("DEVELOPMENT_CHARGE");

                entity.Property(e => e.Director)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DIRECTOR");

                entity.Property(e => e.DirectorMusic)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DIRECTOR_MUSIC");

                entity.Property(e => e.DiscountPcnt)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_PCNT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DiscountTk)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_TK")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DiscountUsd)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_USD")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dop)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOP");

                entity.Property(e => e.EarningTk)
                    .HasPrecision(12)
                    .HasColumnName("EARNING_TK");

                entity.Property(e => e.Invoiceno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("INVOICENO");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Isinprocess)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISINPROCESS")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Isinvoice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISINVOICE")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Islock)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISLOCK")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Ispost)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISPOST")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Isprocesscomplete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISPROCESSCOMPLETE")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Isworkorder)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISWORKORDER")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Numid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMID");

                entity.Property(e => e.ProdHouse)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PROD_HOUSE");

                entity.Property(e => e.Producer)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCER");

                entity.Property(e => e.Programme)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.QuotCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QUOT_CODE");

                entity.Property(e => e.QuotDate)
                    .HasColumnType("DATE")
                    .HasColumnName("QUOT_DATE");

                entity.Property(e => e.QuotGrandtotal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("QUOT_GRANDTOTAL");

                entity.Property(e => e.QuotRefNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("QUOT_REF_NO");

                entity.Property(e => e.QuotSubtotal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("QUOT_SUBTOTAL");

                entity.Property(e => e.QuotTotal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("QUOT_TOTAL");

                entity.Property(e => e.QuotType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("QUOT_TYPE");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.RemittancePcnt)
                    .HasPrecision(12)
                    .HasColumnName("REMITTANCE_PCNT");

                entity.Property(e => e.RemittanceTk)
                    .HasPrecision(12)
                    .HasColumnName("REMITTANCE_TK");

                entity.Property(e => e.Reviseddate)
                    .HasColumnType("DATE")
                    .HasColumnName("REVISEDDATE");

                entity.Property(e => e.RowTotal)
                    .HasPrecision(12)
                    .HasColumnName("ROW_TOTAL");

                entity.Property(e => e.ShootDays)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SHOOT_DAYS");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.VatPcnt)
                    .HasPrecision(12)
                    .HasColumnName("VAT_PCNT");

                entity.Property(e => e.VatTk)
                    .HasPrecision(12)
                    .HasColumnName("VAT_TK");

                entity.Property(e => e.VideoDuration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIDEO_DURATION");

                entity.Property(e => e.VideoFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIDEO_FORMAT");

                entity.Property(e => e.Workorderno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WORKORDERNO");
            });

            modelBuilder.Entity<TQuotationTermsCondition>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_QUOTATION_TERMS_CONDITIO_PK");

                entity.ToTable("T_QUOTATION_TERMS_CONDITIONS");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1 ")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.QuotationOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("QUOTATION_OID");

                entity.Property(e => e.Slnumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SLNUMBER");

                entity.Property(e => e.Tcoid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TCOID");

                entity.Property(e => e.Termsconditions)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TERMSCONDITIONS");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TQuotationsDetail>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_QUOTATIONS_DETAIL_PK");

                entity.ToTable("T_QUOTATIONS_DETAIL");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Daysshift)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("DAYSSHIFT");

                entity.Property(e => e.HeadGroupOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HEAD_GROUP_OID");

                entity.Property(e => e.HeadOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HEAD_OID");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Narration)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NARRATION");

                entity.Property(e => e.Numid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("QUANTITY");

                entity.Property(e => e.QuotNumid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("QUOT_NUMID");

                entity.Property(e => e.QuotOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("QUOT_OID");

                entity.Property(e => e.Setno)
                    .HasPrecision(12)
                    .HasColumnName("SETNO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Seton)
                    .HasPrecision(12)
                    .HasColumnName("SETON")
                    .HasDefaultValueSql("0\n");

                entity.Property(e => e.Total)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("UNIT_PRICE");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TQuotationsMaster>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_QUOTATIONS_MASTER_PK");

                entity.ToTable("T_QUOTATIONS_MASTER");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.AdvancedPcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("ADVANCED_PCNT");

                entity.Property(e => e.AdvancedTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("ADVANCED_TK");

                entity.Property(e => e.AgencyChargePcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_PCNT");

                entity.Property(e => e.AgencyChargeTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_TK");

                entity.Property(e => e.BrandId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRAND_ID");

                entity.Property(e => e.Brandname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("BRANDNAME");

                entity.Property(e => e.Campaign)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CAMPAIGN");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.ClientOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_OID");

                entity.Property(e => e.Conversionrate)
                    .HasPrecision(12)
                    .HasColumnName("CONVERSIONRATE");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCYID");

                entity.Property(e => e.DevelopmentCharge)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("DEVELOPMENT_CHARGE");

                entity.Property(e => e.Director)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DIRECTOR");

                entity.Property(e => e.DirectorMusic)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DIRECTOR_MUSIC");

                entity.Property(e => e.DiscountPcnt)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_PCNT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DiscountTk)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_TK")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DiscountUsd)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_USD")
                    .HasDefaultValueSql("0\n   \n");

                entity.Property(e => e.Dop)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOP");

                entity.Property(e => e.EarningTk)
                    .HasPrecision(12)
                    .HasColumnName("EARNING_TK");

                entity.Property(e => e.Invoiceno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("INVOICENO");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Isinprocess)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISINPROCESS")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Isinvoice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISINVOICE")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Islock)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISLOCK")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Ispost)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISPOST")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Isprocesscomplete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISPROCESSCOMPLETE")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Isworkorder)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISWORKORDER")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Numid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMID");

                entity.Property(e => e.ProdHouse)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PROD_HOUSE");

                entity.Property(e => e.Producer)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCER");

                entity.Property(e => e.Programme)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.QuotCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QUOT_CODE");

                entity.Property(e => e.QuotDate)
                    .HasColumnType("DATE")
                    .HasColumnName("QUOT_DATE");

                entity.Property(e => e.QuotGrandtotal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("QUOT_GRANDTOTAL");

                entity.Property(e => e.QuotRefNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("QUOT_REF_NO");

                entity.Property(e => e.QuotSubtotal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("QUOT_SUBTOTAL");

                entity.Property(e => e.QuotTotal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("QUOT_TOTAL");

                entity.Property(e => e.QuotType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("QUOT_TYPE");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.RemittancePcnt)
                    .HasPrecision(12)
                    .HasColumnName("REMITTANCE_PCNT");

                entity.Property(e => e.RemittanceTk)
                    .HasPrecision(12)
                    .HasColumnName("REMITTANCE_TK");

                entity.Property(e => e.Reviseddate)
                    .HasColumnType("DATE")
                    .HasColumnName("REVISEDDATE");

                entity.Property(e => e.RowTotal)
                    .HasPrecision(12)
                    .HasColumnName("ROW_TOTAL");

                entity.Property(e => e.ShootDays)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SHOOT_DAYS");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.VatPcnt)
                    .HasPrecision(12)
                    .HasColumnName("VAT_PCNT");

                entity.Property(e => e.VatTk)
                    .HasPrecision(12)
                    .HasColumnName("VAT_TK");

                entity.Property(e => e.VideoDuration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIDEO_DURATION");

                entity.Property(e => e.VideoFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIDEO_FORMAT");

                entity.Property(e => e.Workorderno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WORKORDERNO");
            });

            modelBuilder.Entity<TRoleSetup>(entity =>
            {
                entity.HasKey(e => e.Roleid)
                    .HasName("T_ROLE_SETUP_PK");

                entity.ToTable("T_ROLE_SETUP");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Deleteby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deletelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETELPC");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1 ")
                    .IsFixedLength();

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDELETE")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TSbPhoteagraphy>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_SB_PHOTEAGRAPHY_PK");

                entity.ToTable("T_SB_PHOTEAGRAPHY");

                entity.Property(e => e.Oid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Age)
                    .HasMaxLength(10)
                    .HasColumnName("AGE");

                entity.Property(e => e.Description)
                    .HasColumnType("NCLOB")
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Device)
                    .HasMaxLength(100)
                    .HasColumnName("DEVICE");

                entity.Property(e => e.Dt)
                    .HasColumnType("DATE")
                    .HasColumnName("DT")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.ImageCategory)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_CATEGORY");

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_FILE_NAME");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");

                entity.Property(e => e.ImageSize)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_SIZE");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_URL");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IsUpload)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IS_UPLOAD")
                    .HasDefaultValueSql("'0' ");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(30)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Ts)
                    .HasPrecision(6)
                    .HasColumnName("TS")
                    .HasDefaultValueSql("SYSTIMESTAMP ");
            });

            modelBuilder.Entity<TScustInfo>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_SCUST_INFO");

                entity.ToTable("T_SCUST_INFO");

                entity.HasIndex(e => e.ScustInfoText, "UK_TEXT_SCUST_INFO")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.ScustInfoActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_ACTV")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScustInfoAdd1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_ADD1");

                entity.Property(e => e.ScustInfoAdd2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_ADD2");

                entity.Property(e => e.ScustInfoBad1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_BAD1");

                entity.Property(e => e.ScustInfoBad2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_BAD2");

                entity.Property(e => e.ScustInfoBangl)
                    .HasMaxLength(300)
                    .HasColumnName("SCUST_INFO_BANGL");

                entity.Property(e => e.ScustInfoBgno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_BGNO");

                entity.Property(e => e.ScustInfoBkgcldt)
                    .HasColumnType("DATE")
                    .HasColumnName("SCUST_INFO_BKGCLDT");

                entity.Property(e => e.ScustInfoBkgopdt)
                    .HasColumnType("DATE")
                    .HasColumnName("SCUST_INFO_BKGOPDT");

                entity.Property(e => e.ScustInfoBkgrnt)
                    .HasPrecision(18)
                    .HasColumnName("SCUST_INFO_BKGRNT");

                entity.Property(e => e.ScustInfoBlock)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_BLOCK")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ScustInfoBnam)
                    .HasMaxLength(300)
                    .HasColumnName("SCUST_INFO_BNAM");

                entity.Property(e => e.ScustInfoBrnch)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_BRNCH");

                entity.Property(e => e.ScustInfoBtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_BTYPE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScustInfoClient)
                    .HasMaxLength(50)
                    .HasColumnName("SCUST_INFO_CLIENT");

                entity.Property(e => e.ScustInfoCper)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_CPER");

                entity.Property(e => e.ScustInfoCrdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SCUST_INFO_CRDT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScustInfoCtype)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_CTYPE");

                entity.Property(e => e.ScustInfoEmal)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_EMAL");

                entity.Property(e => e.ScustInfoFxno)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_FXNO");

                entity.Property(e => e.ScustInfoInasp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_INASP");

                entity.Property(e => e.ScustInfoName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_NAME");

                entity.Property(e => e.ScustInfoOpdt)
                    .HasColumnType("DATE")
                    .HasColumnName("SCUST_INFO_OPDT");

                entity.Property(e => e.ScustInfoOwnr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_OWNR");

                entity.Property(e => e.ScustInfoPhno)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_PHNO");

                entity.Property(e => e.ScustInfoSbank)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_SBANK");

                entity.Property(e => e.ScustInfoSctyp)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_SCTYP");

                entity.Property(e => e.ScustInfoScuntry)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_SCUNTRY");

                entity.Property(e => e.ScustInfoSincat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_SINCAT");

                entity.Property(e => e.ScustInfoSstyp)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_SSTYP");

                entity.Property(e => e.ScustInfoTenor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_TENOR");

                entity.Property(e => e.ScustInfoText)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_TEXT");

                entity.Property(e => e.ScustInfoTrdn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_TRDN");

                entity.Property(e => e.ScustInfoUniadd)
                    .HasMaxLength(500)
                    .HasColumnName("SCUST_INFO_UNIADD");

                entity.Property(e => e.ScustInfoUniname)
                    .HasMaxLength(300)
                    .HasColumnName("SCUST_INFO_UNINAME");

                entity.Property(e => e.ScustInfoVtid)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SCUST_INFO_VTID");

                entity.Property(e => e.Udt)
                    .HasColumnType("DATE")
                    .HasColumnName("UDT")
                    .HasDefaultValueSql("to_date(sysdate,'dd-mm-yy')");

                entity.Property(e => e.Ver)
                    .HasPrecision(10)
                    .HasColumnName("VER")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<TServiceHead>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_SERVICE_HEAD");

                entity.ToTable("T_SERVICE_HEAD");

                entity.HasIndex(e => e.HeadCode, "UK_CODE_HEAD")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.HeadBname)
                    .HasMaxLength(150)
                    .HasColumnName("HEAD_BNAME");

                entity.Property(e => e.HeadCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("HEAD_CODE");

                entity.Property(e => e.HeadCost)
                    .HasPrecision(12)
                    .HasColumnName("HEAD_COST");

                entity.Property(e => e.HeadGroupOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HEAD_GROUP_OID");

                entity.Property(e => e.HeadName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("HEAD_NAME");

                entity.Property(e => e.HeadSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HEAD_SNAME");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.HasOne(d => d.CategoryO)
                    .WithMany(p => p.TServiceHeads)
                    .HasForeignKey(d => d.CategoryOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CATEGORY_HRAD");

                entity.HasOne(d => d.HeadGroupO)
                    .WithMany(p => p.TServiceHeads)
                    .HasForeignKey(d => d.HeadGroupOid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GROUP_OID_HEAD");
            });

            modelBuilder.Entity<TServiceHeadGroup>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_SERVICE_HEAD_GROUP_PK");

                entity.ToTable("T_SERVICE_HEAD_GROUP");

                entity.HasIndex(e => e.HeadGroupCode, "T_SERVICE_HEAD_GROUP_UK1")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.HeadGroupBname)
                    .HasMaxLength(150)
                    .HasColumnName("HEAD_GROUP_BNAME");

                entity.Property(e => e.HeadGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("HEAD_GROUP_CODE");

                entity.Property(e => e.HeadGroupName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("HEAD_GROUP_NAME");

                entity.Property(e => e.HeadGroupSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HEAD_GROUP_SNAME");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TSysUser>(entity =>
            {
                entity.HasKey(e => e.Sysid)
                    .HasName("T_SYS_USER_PK");

                entity.ToTable("T_SYS_USER");

                entity.Property(e => e.Sysid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SYSID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Deleteby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESIGNATION");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1 ")
                    .IsFixedLength();

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDELETE")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.Issys)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISSYS")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PHOTO");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TTermsCondition>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_TERMS_CONDITIONS_PK");

                entity.ToTable("T_TERMS_CONDITIONS");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1 ")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.Termsconditions)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TERMSCONDITIONS");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_USER");

                entity.ToTable("T_USER");

                entity.HasIndex(e => e.UserText, "UK_TEXT_USER")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_ID");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.UserBkdt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USER_BKDT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_EMAIL");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");

                entity.Property(e => e.UserPass)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("USER_PASS");

                entity.Property(e => e.UserPrnt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USER_PRNT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserRexp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USER_REXP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserRpnt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USER_RPNT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserSname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_SNAME");

                entity.Property(e => e.UserSpcl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USER_SPCL")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserStat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USER_STAT")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UserText)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USER_TEXT");

                entity.Property(e => e.UserType)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("USER_TYPE");

                entity.Property(e => e.UserWeb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USER_WEB")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TUserMenu>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_USERMENU");

                entity.ToTable("T_USER_MENU");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.UsermenuActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USERMENU_ACTV");

                entity.Property(e => e.UsermenuMnud)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USERMENU_MNUD");

                entity.Property(e => e.UsermenuUser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USERMENU_USER");

                entity.HasOne(d => d.UsermenuMnudNavigation)
                    .WithMany(p => p.TUserMenus)
                    .HasForeignKey(d => d.UsermenuMnud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USERMENU_MNUD");

                entity.HasOne(d => d.UsermenuUserNavigation)
                    .WithMany(p => p.TUserMenus)
                    .HasForeignKey(d => d.UsermenuUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USERMENU_USER");
            });

            modelBuilder.Entity<TUserRole>(entity =>
            {
                entity.HasKey(e => e.Userroleid)
                    .HasName("T_USER_ROLE_PK");

                entity.ToTable("T_USER_ROLE");

                entity.Property(e => e.Userroleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERROLEID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Deleteby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELETEBY");

                entity.Property(e => e.Deleteon)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1 ")
                    .IsFixedLength();

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDELETE")
                    .HasDefaultValueSql("0 ")
                    .IsFixedLength();

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.UserId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");
            });

            modelBuilder.Entity<TWorkorderDetail>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_WORKORDER_DETAIL");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Daysshift)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("DAYSSHIFT");

                entity.Property(e => e.HeadGroupOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HEAD_GROUP_OID");

                entity.Property(e => e.HeadOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HEAD_OID");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Narration)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NARRATION");

                entity.Property(e => e.Numid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("QUANTITY");

                entity.Property(e => e.Setno)
                    .HasPrecision(12)
                    .HasColumnName("SETNO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Seton)
                    .HasPrecision(12)
                    .HasColumnName("SETON")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("UNIT_PRICE");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.WorkorderNumid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("WORKORDER_NUMID");

                entity.Property(e => e.WorkorderOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WORKORDER_OID");

                entity.HasOne(d => d.WorkorderO)
                    .WithMany(p => p.TWorkorderDetails)
                    .HasForeignKey(d => d.WorkorderOid)
                    .HasConstraintName("FK_T_WORKORDER_DETAIL_WORKORDER_OID");
            });

            modelBuilder.Entity<TWorkorderDetailBuying>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_WORKORDER_DETAIL_BUYING");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.AgencyChargePcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_PCNT");

                entity.Property(e => e.AgencyChargeTkBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_TK_BDT");

                entity.Property(e => e.AgencyChargeTkUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_TK_USD");

                entity.Property(e => e.AssetTypeOid)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_TYPE_OID");

                entity.Property(e => e.Assettypename)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ASSETTYPENAME");

                entity.Property(e => e.CampaignBeginDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CAMPAIGN_BEGIN_DATE");

                entity.Property(e => e.CampaignEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CAMPAIGN_END_DATE");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.ContentCount)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("CONTENT_COUNT");

                entity.Property(e => e.ConversionRate)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("CONVERSION_RATE");

                entity.Property(e => e.CostPerResultBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_PER_RESULT_BDT");

                entity.Property(e => e.CostPerResultUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_PER_RESULT_USD");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.DiscountBdt)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_BDT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DiscountUsd)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_USD")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GrandTotalBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("GRAND_TOTAL_BDT");

                entity.Property(e => e.GrandTotalUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("GRAND_TOTAL_USD");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.MetricsOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("METRICS_OID");

                entity.Property(e => e.Numid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMID");

                entity.Property(e => e.ParameterOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER_OID");

                entity.Property(e => e.ParameterTaskOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER_TASK_OID");

                entity.Property(e => e.PlatformOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PLATFORM_OID");

                entity.Property(e => e.RemittancePcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("REMITTANCE_PCNT");

                entity.Property(e => e.RemittanceTkBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("REMITTANCE_TK_BDT");

                entity.Property(e => e.RemittanceTkUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("REMITTANCE_TK_USD");

                entity.Property(e => e.SubTotalBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SUB_TOTAL_BDT");

                entity.Property(e => e.SubTotalUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SUB_TOTAL_USD");

                entity.Property(e => e.TotalBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_BDT");

                entity.Property(e => e.TotalBudgetBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_BUDGET_BDT");

                entity.Property(e => e.TotalBudgetUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_BUDGET_USD");

                entity.Property(e => e.TotalResult)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_RESULT");

                entity.Property(e => e.TotalUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_USD");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.VatPcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_PCNT");

                entity.Property(e => e.VatTkBdt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_TK_BDT");

                entity.Property(e => e.VatTkUsd)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_TK_USD");

                entity.Property(e => e.WorkorderNumid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("WORKORDER_NUMID");

                entity.Property(e => e.WorkorderOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WORKORDER_OID");
            });

            modelBuilder.Entity<TWorkorderDetailMedium>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_WORKORDER_DETAIL_MEDIA");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.AdPositionOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AD_POSITION_OID");

                entity.Property(e => e.AgencyChargePcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_PCNT");

                entity.Property(e => e.AgencyChargeTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_TK");

                entity.Property(e => e.BroadcastOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BROADCAST_OID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CAMPAIGN_NAME");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.CostAfterAsf)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_AFTER_ASF");

                entity.Property(e => e.CostBeforeAsf)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_BEFORE_ASF");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.DayOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DAY_OID");

                entity.Property(e => e.DaypartOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DAYPART_OID");

                entity.Property(e => e.DiscountTk)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_TK")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DurationSec)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("DURATION_SEC");

                entity.Property(e => e.GenreOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GENRE_OID");

                entity.Property(e => e.GrandTotal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("GRAND_TOTAL");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.NegotiatedCost)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("NEGOTIATED_COST");

                entity.Property(e => e.Numid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMID");

                entity.Property(e => e.ProgramBegin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_BEGIN");

                entity.Property(e => e.ProgramEnd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_END");

                entity.Property(e => e.ProgramOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_OID");

                entity.Property(e => e.ProjectOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROJECT_OID");

                entity.Property(e => e.SponsorOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPONSOR_OID");

                entity.Property(e => e.Total)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.TotalDuration)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_DURATION");

                entity.Property(e => e.TotalSpots)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL_SPOTS");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.VatPcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_PCNT");

                entity.Property(e => e.VatTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_TK");

                entity.Property(e => e.WorkorderNumid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("WORKORDER_NUMID");

                entity.Property(e => e.WorkorderOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WORKORDER_OID");

                entity.HasOne(d => d.WorkorderO)
                    .WithMany(p => p.TWorkorderDetailMedia)
                    .HasForeignKey(d => d.WorkorderOid)
                    .HasConstraintName("FK_T_WORKORDER_DETAIL_MEDIA_WORKORDER_OID");
            });

            modelBuilder.Entity<TWorkorderDetailPrint>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_WORKORDER_DETAIL_PRINT");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.AgencyChargePcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_PCNT");

                entity.Property(e => e.AgencyChargeTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_TK");

                entity.Property(e => e.AreaSize)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AREA_SIZE");

                entity.Property(e => e.BasicCost)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("BASIC_COST");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.CostAfterAsf)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_AFTER_ASF");

                entity.Property(e => e.CostAfterRebate)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_AFTER_REBATE");

                entity.Property(e => e.CostBeforeAsf)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COST_BEFORE_ASF");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Discount)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("DISCOUNT");

                entity.Property(e => e.DiscountTk)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_TK")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EstimatedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ESTIMATED_DATE");

                entity.Property(e => e.GrandTotal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("GRAND_TOTAL");

                entity.Property(e => e.InsertCount)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("INSERT_COUNT");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Numid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMID");

                entity.Property(e => e.PlacementOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PLACEMENT_OID");

                entity.Property(e => e.PublisherOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PUBLISHER_OID");

                entity.Property(e => e.SupplementOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SUPPLEMENT_OID");

                entity.Property(e => e.Total)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.UnitRate)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("UNIT_RATE");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.VatPcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_PCNT");

                entity.Property(e => e.VatTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("VAT_TK");

                entity.Property(e => e.WorkorderNumid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("WORKORDER_NUMID");

                entity.Property(e => e.WorkorderOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WORKORDER_OID");

                entity.HasOne(d => d.WorkorderO)
                    .WithMany(p => p.TWorkorderDetailPrints)
                    .HasForeignKey(d => d.WorkorderOid)
                    .HasConstraintName("FK_T_WORKORDER_DETAIL_PRINT_WORKORDER_OID");
            });

            modelBuilder.Entity<TWorkorderMaster>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_WORKORDER_MASTER");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.AdvancedPcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("ADVANCED_PCNT");

                entity.Property(e => e.AdvancedTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("ADVANCED_TK");

                entity.Property(e => e.AgencyChargePcnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_PCNT");

                entity.Property(e => e.AgencyChargeTk)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("AGENCY_CHARGE_TK");

                entity.Property(e => e.BrandId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRAND_ID");

                entity.Property(e => e.Brandname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("BRANDNAME");

                entity.Property(e => e.Campaign)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CAMPAIGN");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.CategoryOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_OID");

                entity.Property(e => e.ClientOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_OID");

                entity.Property(e => e.Conversionrate)
                    .HasPrecision(12)
                    .HasColumnName("CONVERSIONRATE");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCYID");

                entity.Property(e => e.DateWorkorder)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_WORKORDER");

                entity.Property(e => e.DevelopmentCharge)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("DEVELOPMENT_CHARGE");

                entity.Property(e => e.Director)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DIRECTOR");

                entity.Property(e => e.DirectorMusic)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DIRECTOR_MUSIC");

                entity.Property(e => e.DiscountPcnt)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_PCNT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DiscountTk)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_TK")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DiscountUsd)
                    .HasPrecision(12)
                    .HasColumnName("DISCOUNT_USD")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dop)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOP");

                entity.Property(e => e.EarningTk)
                    .HasPrecision(12)
                    .HasColumnName("EARNING_TK");

                entity.Property(e => e.Invoiceno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("INVOICENO");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .IsFixedLength();

                entity.Property(e => e.Isinprocess)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISINPROCESS")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Isinvoice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISINVOICE")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Islock)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISLOCK")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Ispost)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISPOST")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Isprocesscomplete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISPROCESSCOMPLETE")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Isworkorder)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISWORKORDER")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Numid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMID");

                entity.Property(e => e.ProdHouse)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PROD_HOUSE");

                entity.Property(e => e.Producer)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCER");

                entity.Property(e => e.Programme)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.QuotOid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("QUOT_OID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.RemittancePcnt)
                    .HasPrecision(12)
                    .HasColumnName("REMITTANCE_PCNT");

                entity.Property(e => e.RemittanceTk)
                    .HasPrecision(12)
                    .HasColumnName("REMITTANCE_TK");

                entity.Property(e => e.Reviseddate)
                    .HasColumnType("DATE")
                    .HasColumnName("REVISEDDATE");

                entity.Property(e => e.RowTotal)
                    .HasPrecision(12)
                    .HasColumnName("ROW_TOTAL");

                entity.Property(e => e.ShootDays)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SHOOT_DAYS");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.VatPcnt)
                    .HasPrecision(12)
                    .HasColumnName("VAT_PCNT");

                entity.Property(e => e.VatTk)
                    .HasPrecision(12)
                    .HasColumnName("VAT_TK");

                entity.Property(e => e.VideoDuration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIDEO_DURATION");

                entity.Property(e => e.VideoFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIDEO_FORMAT");

                entity.Property(e => e.WorkorderCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("WORKORDER_CODE");

                entity.Property(e => e.WorkorderDate)
                    .HasColumnType("DATE")
                    .HasColumnName("WORKORDER_DATE");

                entity.Property(e => e.WorkorderGrandtotal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("WORKORDER_GRANDTOTAL");

                entity.Property(e => e.WorkorderRefNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WORKORDER_REF_NO");

                entity.Property(e => e.WorkorderSubtotal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("WORKORDER_SUBTOTAL");

                entity.Property(e => e.WorkorderTotal)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("WORKORDER_TOTAL");

                entity.Property(e => e.WorkorderType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WORKORDER_TYPE");
            });

            modelBuilder.Entity<TWorkorderTermsCondition>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_WORKORDER_TERMS_CONDITIONS");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELBY");

                entity.Property(e => e.Cancelon)
                    .HasColumnType("DATE")
                    .HasColumnName("CANCELON");

                entity.Property(e => e.Cancelpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CANCELPC");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createon)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATEON");

                entity.Property(e => e.Createpc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATEPC");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Iscancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISCANCEL")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Slnumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SLNUMBER");

                entity.Property(e => e.Tcoid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TCOID");

                entity.Property(e => e.Termsconditions)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TERMSCONDITIONS");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updateon)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATEON");

                entity.Property(e => e.Updatepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEPC");

                entity.Property(e => e.WorkorderOid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WORKORDER_OID");
            });

            modelBuilder.Entity<TvBankAccnt>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_BANK_ACCNT");

                entity.ToTable("TV_BANK_ACCNT");

                entity.HasIndex(e => e.AccntText, "UK_TEXT_ACCNT")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.AccntAccno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACCNT_ACCNO");

                entity.Property(e => e.AccntActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCNT_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AccntActype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCNT_ACTYPE");

                entity.Property(e => e.AccntBranch)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ACCNT_BRANCH");

                entity.Property(e => e.AccntClsfg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCNT_CLSFG")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AccntMbank)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCNT_MBANK");

                entity.Property(e => e.AccntName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ACCNT_NAME");

                entity.Property(e => e.AccntOpdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACCNT_OPDATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.AccntPosf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCNT_POSF")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AccntRefcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCNT_REFCODE");

                entity.Property(e => e.AccntScomp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCNT_SCOMP");

                entity.Property(e => e.AccntText)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACCNT_TEXT");

                entity.Property(e => e.AccntTtfg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACCNT_TTFG")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.HasOne(d => d.AccntActypeNavigation)
                    .WithMany(p => p.TvBankAccnts)
                    .HasForeignKey(d => d.AccntActype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACTYPE_ACCNT");

                entity.HasOne(d => d.AccntMbankNavigation)
                    .WithMany(p => p.TvBankAccnts)
                    .HasForeignKey(d => d.AccntMbank)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MBANK_ACCNT");

                entity.HasOne(d => d.AccntScompNavigation)
                    .WithMany(p => p.TvBankAccnts)
                    .HasForeignKey(d => d.AccntScomp)
                    .HasConstraintName("FK_SCOMP_ACCNT");
            });

            modelBuilder.Entity<TvBankActype>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_ACTYPE");

                entity.ToTable("TV_BANK_ACTYPE");

                entity.HasIndex(e => e.ActypeText, "UK_TEXT_ACTYPE")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ActypeActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTYPE_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ActypeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ACTYPE_NAME");

                entity.Property(e => e.ActypeStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTYPE_STOP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ActypeText)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ACTYPE_TEXT");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");
            });

            modelBuilder.Entity<TvBilld>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_BILLD");

                entity.ToTable("TV_BILLD");

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.BilldBreak)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_BREAK");

                entity.Property(e => e.BilldCprod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_CPROD");

                entity.Property(e => e.BilldHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_HOUR");

                entity.Property(e => e.BilldLine)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_LINE");

                entity.Property(e => e.BilldLog)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_LOG");

                entity.Property(e => e.BilldLogdur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_LOGDUR");

                entity.Property(e => e.BilldNdur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_NDUR");

                entity.Property(e => e.BilldPenbil)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_PENBIL");

                entity.Property(e => e.BilldPftime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_PFTIME");

                entity.Property(e => e.BilldProgm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_PROGM");

                entity.Property(e => e.BilldPttime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_PTTIME");

                entity.Property(e => e.BilldRate)
                    .HasColumnType("NUMBER(18,6)")
                    .HasColumnName("BILLD_RATE");

                entity.Property(e => e.BilldSpblm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_SPBLM");

                entity.Property(e => e.BilldSpot)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_SPOT");

                entity.Property(e => e.BilldSprod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLD_SPROD");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.HasOne(d => d.BilldBreakNavigation)
                    .WithMany(p => p.TvBillds)
                    .HasForeignKey(d => d.BilldBreak)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BREAK_BILLD");

                entity.HasOne(d => d.BilldCprodNavigation)
                    .WithMany(p => p.TvBillds)
                    .HasForeignKey(d => d.BilldCprod)
                    .HasConstraintName("FK_CPROD_BILLD");

                entity.HasOne(d => d.BilldHourNavigation)
                    .WithMany(p => p.TvBillds)
                    .HasForeignKey(d => d.BilldHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_BILLD");

                entity.HasOne(d => d.BilldLogNavigation)
                    .WithMany(p => p.TvBillds)
                    .HasForeignKey(d => d.BilldLog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOG_BILLD");

                entity.HasOne(d => d.BilldPenbilNavigation)
                    .WithMany(p => p.TvBillds)
                    .HasForeignKey(d => d.BilldPenbil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PENBIL_BILLD");

                entity.HasOne(d => d.BilldProgmNavigation)
                    .WithMany(p => p.TvBillds)
                    .HasForeignKey(d => d.BilldProgm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROGM_BILLD");

                entity.HasOne(d => d.BilldSpblmNavigation)
                    .WithMany(p => p.TvBillds)
                    .HasForeignKey(d => d.BilldSpblm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPBLM_BILLD");

                entity.HasOne(d => d.BilldSpotNavigation)
                    .WithMany(p => p.TvBillds)
                    .HasForeignKey(d => d.BilldSpot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPOT_BILLD");

                entity.HasOne(d => d.BilldSprodNavigation)
                    .WithMany(p => p.TvBillds)
                    .HasForeignKey(d => d.BilldSprod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPROD_BILLD");
            });

            modelBuilder.Entity<TvBillsp>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_BILLSP");

                entity.ToTable("TV_BILLSP");

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.BillspCprod)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BILLSP_CPROD");

                entity.Property(e => e.BillspDatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("BILLSP_DATETIME");

                entity.Property(e => e.BillspDur)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("BILLSP_DUR");

                entity.Property(e => e.BillspHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLSP_HOUR");

                entity.Property(e => e.BillspHour2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLSP_HOUR2");

                entity.Property(e => e.BillspLine)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BILLSP_LINE");

                entity.Property(e => e.BillspLsscdul)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BILLSP_LSSCDUL");

                entity.Property(e => e.BillspPftime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLSP_PFTIME");

                entity.Property(e => e.BillspPname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BILLSP_PNAME");

                entity.Property(e => e.BillspProgm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLSP_PROGM");

                entity.Property(e => e.BillspPttime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLSP_PTTIME");

                entity.Property(e => e.BillspRate)
                    .HasColumnType("NUMBER(16,8)")
                    .HasColumnName("BILLSP_RATE");

                entity.Property(e => e.BillspSpblm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLSP_SPBLM");

                entity.Property(e => e.BillspSpno)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("BILLSP_SPNO");

                entity.Property(e => e.BillspSprod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLSP_SPROD");

                entity.Property(e => e.BillspStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BILLSP_STATUS");

                entity.Property(e => e.BillspTldur)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("BILLSP_TLDUR");

                entity.Property(e => e.BillspType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BILLSP_TYPE");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.HasOne(d => d.BillspCprodNavigation)
                    .WithMany(p => p.TvBillsps)
                    .HasForeignKey(d => d.BillspCprod)
                    .HasConstraintName("FK_CPROD_BILLSP");

                entity.HasOne(d => d.BillspHourNavigation)
                    .WithMany(p => p.TvBillspBillspHourNavigations)
                    .HasForeignKey(d => d.BillspHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_BILLSP");

                entity.HasOne(d => d.BillspHour2Navigation)
                    .WithMany(p => p.TvBillspBillspHour2Navigations)
                    .HasForeignKey(d => d.BillspHour2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR2_BILLSP");

                entity.HasOne(d => d.BillspLsscdulNavigation)
                    .WithMany(p => p.TvBillsps)
                    .HasForeignKey(d => d.BillspLsscdul)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LSSCDUL_BILLSP");

                entity.HasOne(d => d.BillspProgmNavigation)
                    .WithMany(p => p.TvBillsps)
                    .HasForeignKey(d => d.BillspProgm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROGM_BILLSP");

                entity.HasOne(d => d.BillspSpblmNavigation)
                    .WithMany(p => p.TvBillsps)
                    .HasForeignKey(d => d.BillspSpblm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPBLM_BILLSP");

                entity.HasOne(d => d.BillspSprodNavigation)
                    .WithMany(p => p.TvBillsps)
                    .HasForeignKey(d => d.BillspSprod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPROD_BILLSP");

                entity.HasOne(d => d.BillspStatusNavigation)
                    .WithMany(p => p.TvBillsps)
                    .HasForeignKey(d => d.BillspStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STATUS_BILLSP");
            });

            modelBuilder.Entity<TvBreak>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_BREAK");

                entity.ToTable("TV_BREAK");

                entity.HasIndex(e => e.BreakText, "UK_TEXT_BREAK")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.BreakActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BREAK_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BreakName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BREAK_NAME");

                entity.Property(e => e.BreakStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BREAK_STOP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BreakText)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BREAK_TEXT");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");
            });

            modelBuilder.Entity<TvClient>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_CLIENT");

                entity.ToTable("TV_CLIENT");

                entity.HasIndex(e => e.ClientText, "UK_TEXT_CLIENT")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ClientActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ClientAdd1)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_ADD1");

                entity.Property(e => e.ClientAdd2)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_ADD2");

                entity.Property(e => e.ClientBadd1)
                    .HasMaxLength(300)
                    .HasColumnName("CLIENT_BADD1");

                entity.Property(e => e.ClientBadd2)
                    .HasMaxLength(300)
                    .HasColumnName("CLIENT_BADD2");

                entity.Property(e => e.ClientBlock)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_BLOCK")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClientBname)
                    .HasMaxLength(300)
                    .HasColumnName("CLIENT_BNAME");

                entity.Property(e => e.ClientConper)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_CONPER");

                entity.Property(e => e.ClientCrdtLmit)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("CLIENT_CRDT_LMIT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClientEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_EMAIL");

                entity.Property(e => e.ClientFxno)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_FXNO");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_NAME");

                entity.Property(e => e.ClientOpdt)
                    .HasColumnType("DATE")
                    .HasColumnName("CLIENT_OPDT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.ClientOwnr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_OWNR");

                entity.Property(e => e.ClientPhno)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_PHNO");

                entity.Property(e => e.ClientScustInfo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_SCUST_INFO");

                entity.Property(e => e.ClientText)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_TEXT");

                entity.Property(e => e.ClientType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_TYPE");

                entity.Property(e => e.ClientVatid)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_VATID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");
            });

            modelBuilder.Entity<TvCommRate>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_COMM_RATE");

                entity.ToTable("TV_COMM_RATE");

                entity.HasIndex(e => e.CommRateText, "UK_COMM_RATE_SPROD")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.CommRateActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COMM_RATE_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CommRateClient)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMM_RATE_CLIENT");

                entity.Property(e => e.CommRateHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMM_RATE_HOUR");

                entity.Property(e => e.CommRateOpdt)
                    .HasColumnType("DATE")
                    .HasColumnName("COMM_RATE_OPDT");

                entity.Property(e => e.CommRateRate)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("COMM_RATE_RATE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CommRateText)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COMM_RATE_TEXT");

                entity.Property(e => e.CommRateType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COMM_RATE_TYPE");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.EditDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EDIT_DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.EditUser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_USER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.VerifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VERIFIED_BY");

                entity.Property(e => e.VerifiedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("VERIFIED_DATE");

                entity.HasOne(d => d.CommRateClientNavigation)
                    .WithMany(p => p.TvCommRates)
                    .HasForeignKey(d => d.CommRateClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_COMM_RATE");

                entity.HasOne(d => d.CommRateHourNavigation)
                    .WithMany(p => p.TvCommRates)
                    .HasForeignKey(d => d.CommRateHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_COMM_RATE");
            });

            modelBuilder.Entity<TvCommRateHistory>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_RATE_HIST");

                entity.ToTable("TV_COMM_RATE_HISTORY");

                entity.HasIndex(e => e.RateHistText, "UK_RATE_HIST_SPROD")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.EditDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EDIT_DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.EditUser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_USER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.RateHistActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RATE_HIST_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RateHistClient)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RATE_HIST_CLIENT");

                entity.Property(e => e.RateHistHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RATE_HIST_HOUR");

                entity.Property(e => e.RateHistOpdate)
                    .HasColumnType("DATE")
                    .HasColumnName("RATE_HIST_OPDATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.RateHistRate)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("RATE_HIST_RATE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RateHistText)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RATE_HIST_TEXT");

                entity.Property(e => e.RateHistType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("RATE_HIST_TYPE");

                entity.Property(e => e.VerifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VERIFIED_BY");

                entity.Property(e => e.VerifiedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("VERIFIED_DATE");

                entity.HasOne(d => d.RateHistClientNavigation)
                    .WithMany(p => p.TvCommRateHistories)
                    .HasForeignKey(d => d.RateHistClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_RATE_HIST");

                entity.HasOne(d => d.RateHistHourNavigation)
                    .WithMany(p => p.TvCommRateHistories)
                    .HasForeignKey(d => d.RateHistHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_RATE_HIST");
            });

            modelBuilder.Entity<TvCprod>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_CPROD");

                entity.ToTable("TV_CPROD");

                entity.HasIndex(e => e.CprodText, "UK_TEXT_CPROD")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.CprodActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CPROD_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CprodClient)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CPROD_CLIENT");

                entity.Property(e => e.CprodName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CPROD_NAME");

                entity.Property(e => e.CprodRate)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("CPROD_RATE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CprodSname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CPROD_SNAME");

                entity.Property(e => e.CprodText)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CPROD_TEXT");

                entity.Property(e => e.CprodType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CPROD_TYPE");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.HasOne(d => d.CprodClientNavigation)
                    .WithMany(p => p.TvCprods)
                    .HasForeignKey(d => d.CprodClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_CPROD");
            });

            modelBuilder.Entity<TvDelscdul>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_DELSCDUL");

                entity.ToTable("TV_DELSCDUL");

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DelscdulAgent)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_AGENT");

                entity.Property(e => e.DelscdulBreak)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_BREAK");

                entity.Property(e => e.DelscdulCdate)
                    .HasColumnType("DATE")
                    .HasColumnName("DELSCDUL_CDATE");

                entity.Property(e => e.DelscdulClient)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_CLIENT");

                entity.Property(e => e.DelscdulClnsts)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_CLNSTS");

                entity.Property(e => e.DelscdulCmtim)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_CMTIM");

                entity.Property(e => e.DelscdulCode)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_CODE");

                entity.Property(e => e.DelscdulColr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_COLR");

                entity.Property(e => e.DelscdulCtyp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_CTYP");

                entity.Property(e => e.DelscdulFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_FLAG");

                entity.Property(e => e.DelscdulFtime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_FTIME");

                entity.Property(e => e.DelscdulHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_HOUR");

                entity.Property(e => e.DelscdulLine)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_LINE");

                entity.Property(e => e.DelscdulMaster)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_MASTER");

                entity.Property(e => e.DelscdulPend)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_PEND");

                entity.Property(e => e.DelscdulPftime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_PFTIME");

                entity.Property(e => e.DelscdulPnam)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_PNAM");

                entity.Property(e => e.DelscdulPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_POSF");

                entity.Property(e => e.DelscdulProgm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_PROGM");

                entity.Property(e => e.DelscdulPttime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_PTTIME");

                entity.Property(e => e.DelscdulRate)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("DELSCDUL_RATE");

                entity.Property(e => e.DelscdulSchedule)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_SCHEDULE");

                entity.Property(e => e.DelscdulSdate)
                    .HasColumnType("DATE")
                    .HasColumnName("DELSCDUL_SDATE");

                entity.Property(e => e.DelscdulSeqn)
                    .HasPrecision(10)
                    .HasColumnName("DELSCDUL_SEQN")
                    .HasDefaultValueSql("200");

                entity.Property(e => e.DelscdulSpot)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_SPOT");

                entity.Property(e => e.DelscdulSprod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_SPROD");

                entity.Property(e => e.DelscdulSptm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_SPTM");

                entity.Property(e => e.DelscdulStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_STATUS");

                entity.Property(e => e.DelscdulTmdur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_TMDUR");

                entity.Property(e => e.DelscdulTpid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_TPID");

                entity.Property(e => e.DelscdulTtime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_TTIME");

                entity.Property(e => e.DelscdulType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_TYPE");

                entity.Property(e => e.DelscdulWrkord)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDUL_WRKORD");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.HasOne(d => d.DelscdulAgentNavigation)
                    .WithMany(p => p.TvDelscdulDelscdulAgentNavigations)
                    .HasForeignKey(d => d.DelscdulAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENT_DELSCDUL");

                entity.HasOne(d => d.DelscdulBreakNavigation)
                    .WithMany(p => p.TvDelscduls)
                    .HasForeignKey(d => d.DelscdulBreak)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BREAK_DELSCDUL");

                entity.HasOne(d => d.DelscdulClientNavigation)
                    .WithMany(p => p.TvDelscdulDelscdulClientNavigations)
                    .HasForeignKey(d => d.DelscdulClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_DELSCDUL");

                entity.HasOne(d => d.DelscdulHourNavigation)
                    .WithMany(p => p.TvDelscduls)
                    .HasForeignKey(d => d.DelscdulHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_DELSCDUL");

                entity.HasOne(d => d.DelscdulMasterNavigation)
                    .WithMany(p => p.TvDelscduls)
                    .HasForeignKey(d => d.DelscdulMaster)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASTER_DELSCDUL");

                entity.HasOne(d => d.DelscdulProgmNavigation)
                    .WithMany(p => p.TvDelscduls)
                    .HasForeignKey(d => d.DelscdulProgm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROGM_DELSCDUL");

                entity.HasOne(d => d.DelscdulSpotNavigation)
                    .WithMany(p => p.TvDelscduls)
                    .HasForeignKey(d => d.DelscdulSpot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPOT_DELSCDUL");

                entity.HasOne(d => d.DelscdulSprodNavigation)
                    .WithMany(p => p.TvDelscduls)
                    .HasForeignKey(d => d.DelscdulSprod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPROD_DELSCDUL");
            });

            modelBuilder.Entity<TvDelscdulMaster>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_DELSCDLM");

                entity.ToTable("TV_DELSCDUL_MASTER");

                entity.HasIndex(e => e.DelscdlmText, "UK_TEXT_DELSCDUL_MASTER")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DelscdlmCdate)
                    .HasColumnType("DATE")
                    .HasColumnName("DELSCDLM_CDATE");

                entity.Property(e => e.DelscdlmHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDLM_HOUR");

                entity.Property(e => e.DelscdlmPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDLM_POSF");

                entity.Property(e => e.DelscdlmSdate)
                    .HasColumnType("DATE")
                    .HasColumnName("DELSCDLM_SDATE");

                entity.Property(e => e.DelscdlmText)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DELSCDLM_TEXT");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.HasOne(d => d.DelscdlmHourNavigation)
                    .WithMany(p => p.TvDelscdulMasters)
                    .HasForeignKey(d => d.DelscdlmHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_DELSCDLM");
            });

            modelBuilder.Entity<TvHour>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_HOUR");

                entity.ToTable("TV_HOUR");

                entity.HasIndex(e => e.HourText, "UK_TEXT_HOUR")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.HourActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HOUR_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.HourFtime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HOUR_FTIME");

                entity.Property(e => e.HourName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("HOUR_NAME");

                entity.Property(e => e.HourText)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("HOUR_TEXT");

                entity.Property(e => e.HourTtime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HOUR_TTIME");

                entity.Property(e => e.HourType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HOUR_TYPE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");
            });

            modelBuilder.Entity<TvInvoc>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_INVOC");

                entity.ToTable("TV_INVOC");

                entity.HasIndex(e => e.InvocInvno, "UK_INVNO_INVOC")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.InvocAmnt)
                    .HasColumnType("NUMBER(18,6)")
                    .HasColumnName("INVOC_AMNT");

                entity.Property(e => e.InvocDate)
                    .HasColumnType("DATE")
                    .HasColumnName("INVOC_DATE");

                entity.Property(e => e.InvocFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("INVOC_FLAG");

                entity.Property(e => e.InvocInvno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("INVOC_INVNO");

                entity.Property(e => e.InvocLine)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("INVOC_LINE");

                entity.Property(e => e.InvocMnno)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("INVOC_MNNO");

                entity.Property(e => e.InvocMont)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("INVOC_MONT");

                entity.Property(e => e.InvocPntdate)
                    .HasColumnType("DATE")
                    .HasColumnName("INVOC_PNTDATE");

                entity.Property(e => e.InvocPntflag)
                    .HasPrecision(2)
                    .HasColumnName("INVOC_PNTFLAG")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InvocPntuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("INVOC_PNTUSER");

                entity.Property(e => e.InvocPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("INVOC_POSF");

                entity.Property(e => e.InvocSbank)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("INVOC_SBANK");

                entity.Property(e => e.InvocSpblm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("INVOC_SPBLM");

                entity.Property(e => e.InvocType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("INVOC_TYPE");

                entity.Property(e => e.InvocVtflg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("INVOC_VTFLG");

                entity.Property(e => e.InvocYear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INVOC_YEAR");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");
            });

            modelBuilder.Entity<TvLog>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_LOG");

                entity.ToTable("TV_LOG");

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_ID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.LogApproveby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOG_APPROVEBY");

                entity.Property(e => e.LogAppvdate)
                    .HasColumnType("DATE")
                    .HasColumnName("LOG_APPVDATE");

                entity.Property(e => e.LogAppvdur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOG_APPVDUR");

                entity.Property(e => e.LogAppvfalg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOG_APPVFALG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.LogAppvspno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOG_APPVSPNO");

                entity.Property(e => e.LogCode)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("LOG_CODE");

                entity.Property(e => e.LogDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LOG_DATE");

                entity.Property(e => e.LogDuration)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOG_DURATION");

                entity.Property(e => e.LogExtr1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("LOG_EXTR1");

                entity.Property(e => e.LogExtr2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("LOG_EXTR2");

                entity.Property(e => e.LogExtr3)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("LOG_EXTR3");

                entity.Property(e => e.LogExtr4)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("LOG_EXTR4");

                entity.Property(e => e.LogFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOG_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.LogLine)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOG_LINE");

                entity.Property(e => e.LogMaster)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LOG_MASTER");

                entity.Property(e => e.LogNote)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("LOG_NOTE");

                entity.Property(e => e.LogPath)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("LOG_PATH");

                entity.Property(e => e.LogPftime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOG_PFTIME");

                entity.Property(e => e.LogPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOG_POSF");

                entity.Property(e => e.LogProgdtls)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("LOG_PROGDTLS");

                entity.Property(e => e.LogProvenance)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("LOG_PROVENANCE");

                entity.Property(e => e.LogPttime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOG_PTTIME");

                entity.Property(e => e.LogRamcom)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("LOG_RAMCOM");

                entity.Property(e => e.LogReasult)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("LOG_REASULT");

                entity.Property(e => e.LogSdate)
                    .HasColumnType("DATE")
                    .HasColumnName("LOG_SDATE");

                entity.Property(e => e.LogStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOG_STATUS");

                entity.Property(e => e.LogTxdt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOG_TXDT");

                entity.Property(e => e.LogType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOG_TYPE");

                entity.HasOne(d => d.LogMasterNavigation)
                    .WithMany(p => p.TvLogs)
                    .HasForeignKey(d => d.LogMaster)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASTER_LOG");
            });

            modelBuilder.Entity<TvLogMaster>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_LOGMST");

                entity.ToTable("TV_LOG_MASTER");

                entity.HasIndex(e => e.LogmstText, "UK_TEXT_LOGMST_MASTER")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.LogmstDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LOGMST_DATE");

                entity.Property(e => e.LogmstFlg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOGMST_FLG");

                entity.Property(e => e.LogmstPntflg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOGMST_PNTFLG");

                entity.Property(e => e.LogmstPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOGMST_POSF");

                entity.Property(e => e.LogmstSdate)
                    .HasColumnType("DATE")
                    .HasColumnName("LOGMST_SDATE");

                entity.Property(e => e.LogmstText)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LOGMST_TEXT");

                entity.Property(e => e.LogmstTxdt)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LOGMST_TXDT");
            });

            modelBuilder.Entity<TvLscdlarcvDetl>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_ARCVLSDL");

                entity.ToTable("TV_LSCDLARCV_DETL");

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ArcvlsdlAgent)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_AGENT");

                entity.Property(e => e.ArcvlsdlApproveby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_APPROVEBY");

                entity.Property(e => e.ArcvlsdlAppvdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ARCVLSDL_APPVDATE");

                entity.Property(e => e.ArcvlsdlAppvdur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_APPVDUR");

                entity.Property(e => e.ArcvlsdlAppvfalg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_APPVFALG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ArcvlsdlAppvspno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_APPVSPNO");

                entity.Property(e => e.ArcvlsdlCdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ARCVLSDL_CDATE");

                entity.Property(e => e.ArcvlsdlClient)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_CLIENT");

                entity.Property(e => e.ArcvlsdlCode)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_CODE");

                entity.Property(e => e.ArcvlsdlColr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_COLR");

                entity.Property(e => e.ArcvlsdlDay)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_DAY");

                entity.Property(e => e.ArcvlsdlDuration)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_DURATION");

                entity.Property(e => e.ArcvlsdlFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ArcvlsdlFnpost)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_FNPOST")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ArcvlsdlHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_HOUR");

                entity.Property(e => e.ArcvlsdlHour2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_HOUR2");

                entity.Property(e => e.ArcvlsdlLine)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_LINE");

                entity.Property(e => e.ArcvlsdlLsscdul)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_LSSCDUL");

                entity.Property(e => e.ArcvlsdlMaster)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_MASTER");

                entity.Property(e => e.ArcvlsdlNote)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_NOTE");

                entity.Property(e => e.ArcvlsdlPend)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_PEND")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArcvlsdlPftime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_PFTIME");

                entity.Property(e => e.ArcvlsdlPname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_PNAME");

                entity.Property(e => e.ArcvlsdlPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_POSF");

                entity.Property(e => e.ArcvlsdlProgm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_PROGM");

                entity.Property(e => e.ArcvlsdlPttime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_PTTIME");

                entity.Property(e => e.ArcvlsdlRate)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("ARCVLSDL_RATE");

                entity.Property(e => e.ArcvlsdlSdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ARCVLSDL_SDATE");

                entity.Property(e => e.ArcvlsdlSeqn)
                    .HasPrecision(10)
                    .HasColumnName("ARCVLSDL_SEQN");

                entity.Property(e => e.ArcvlsdlSpno)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_SPNO");

                entity.Property(e => e.ArcvlsdlSprod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_SPROD");

                entity.Property(e => e.ArcvlsdlStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_STATUS");

                entity.Property(e => e.ArcvlsdlStop)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_STOP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArcvlsdlTotdur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_TOTDUR");

                entity.Property(e => e.ArcvlsdlType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_TYPE");

                entity.Property(e => e.ArcvlsdlWrklsd)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSDL_WRKLSD");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.HasOne(d => d.ArcvlsdlAgentNavigation)
                    .WithMany(p => p.TvLscdlarcvDetlArcvlsdlAgentNavigations)
                    .HasForeignKey(d => d.ArcvlsdlAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENT_ARCVLSDL");

                entity.HasOne(d => d.ArcvlsdlClientNavigation)
                    .WithMany(p => p.TvLscdlarcvDetlArcvlsdlClientNavigations)
                    .HasForeignKey(d => d.ArcvlsdlClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_ARCVLSDL");

                entity.HasOne(d => d.ArcvlsdlHourNavigation)
                    .WithMany(p => p.TvLscdlarcvDetlArcvlsdlHourNavigations)
                    .HasForeignKey(d => d.ArcvlsdlHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_ARCVLSDL");

                entity.HasOne(d => d.ArcvlsdlHour2Navigation)
                    .WithMany(p => p.TvLscdlarcvDetlArcvlsdlHour2Navigations)
                    .HasForeignKey(d => d.ArcvlsdlHour2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR2_ARCVLSDL");

                entity.HasOne(d => d.ArcvlsdlMasterNavigation)
                    .WithMany(p => p.TvLscdlarcvDetls)
                    .HasForeignKey(d => d.ArcvlsdlMaster)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASTER_ARCVLSDL");

                entity.HasOne(d => d.ArcvlsdlProgmNavigation)
                    .WithMany(p => p.TvLscdlarcvDetls)
                    .HasForeignKey(d => d.ArcvlsdlProgm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROGM_ARCVLSDL");

                entity.HasOne(d => d.ArcvlsdlSprodNavigation)
                    .WithMany(p => p.TvLscdlarcvDetls)
                    .HasForeignKey(d => d.ArcvlsdlSprod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPROD_ARCVLSDL");

                entity.HasOne(d => d.ArcvlsdlStatusNavigation)
                    .WithMany(p => p.TvLscdlarcvDetls)
                    .HasForeignKey(d => d.ArcvlsdlStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STATUS_ARCVLSDL");

                entity.HasOne(d => d.ArcvlsdlWrklsdNavigation)
                    .WithMany(p => p.TvLscdlarcvDetls)
                    .HasForeignKey(d => d.ArcvlsdlWrklsd)
                    .HasConstraintName("FK_WRKLSD_ARCVLSDL");
            });

            modelBuilder.Entity<TvLscdlarcvMaster>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_ARCVLSSM");

                entity.ToTable("TV_LSCDLARCV_MASTER");

                entity.HasIndex(e => e.ArcvlssmText, "UK_TEXT_ARCVLSSM_MASTER")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.ArcvlssmCdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ARCVLSSM_CDATE");

                entity.Property(e => e.ArcvlssmHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSSM_HOUR");

                entity.Property(e => e.ArcvlssmPntflg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSSM_PNTFLG");

                entity.Property(e => e.ArcvlssmPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSSM_POSF");

                entity.Property(e => e.ArcvlssmSdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ARCVLSSM_SDATE");

                entity.Property(e => e.ArcvlssmText)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ARCVLSSM_TEXT");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.PrintBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRINT_BY");

                entity.Property(e => e.PrintDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PRINT_DATE");

                entity.Property(e => e.VerifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VERIFIED_BY");

                entity.Property(e => e.VerifiedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("VERIFIED_DATE");

                entity.HasOne(d => d.ArcvlssmHourNavigation)
                    .WithMany(p => p.TvLscdlarcvMasters)
                    .HasForeignKey(d => d.ArcvlssmHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_ARCVLSSM");
            });

            modelBuilder.Entity<TvLsscdul>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_LSSCDUL");

                entity.ToTable("TV_LSSCDUL");

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.LsscdulAgent)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_AGENT");

                entity.Property(e => e.LsscdulApproveby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_APPROVEBY");

                entity.Property(e => e.LsscdulAppvdate)
                    .HasColumnType("DATE")
                    .HasColumnName("LSSCDUL_APPVDATE");

                entity.Property(e => e.LsscdulAppvdur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_APPVDUR");

                entity.Property(e => e.LsscdulAppvfalg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_APPVFALG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.LsscdulAppvspno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_APPVSPNO");

                entity.Property(e => e.LsscdulCdate)
                    .HasColumnType("DATE")
                    .HasColumnName("LSSCDUL_CDATE");

                entity.Property(e => e.LsscdulClient)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_CLIENT");

                entity.Property(e => e.LsscdulCode)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_CODE");

                entity.Property(e => e.LsscdulColr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_COLR");

                entity.Property(e => e.LsscdulDay)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_DAY");

                entity.Property(e => e.LsscdulDuration)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_DURATION");

                entity.Property(e => e.LsscdulFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.LsscdulFnpost)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_FNPOST")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.LsscdulHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_HOUR");

                entity.Property(e => e.LsscdulHour2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_HOUR2");

                entity.Property(e => e.LsscdulLine)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_LINE");

                entity.Property(e => e.LsscdulMaster)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_MASTER");

                entity.Property(e => e.LsscdulNote)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_NOTE");

                entity.Property(e => e.LsscdulPend)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_PEND")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LsscdulPftime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_PFTIME");

                entity.Property(e => e.LsscdulPname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_PNAME");

                entity.Property(e => e.LsscdulPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_POSF");

                entity.Property(e => e.LsscdulProgm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_PROGM");

                entity.Property(e => e.LsscdulPttime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_PTTIME");

                entity.Property(e => e.LsscdulRate)
                    .HasColumnType("NUMBER(18,8)")
                    .HasColumnName("LSSCDUL_RATE");

                entity.Property(e => e.LsscdulSdate)
                    .HasColumnType("DATE")
                    .HasColumnName("LSSCDUL_SDATE");

                entity.Property(e => e.LsscdulSeqn)
                    .HasPrecision(10)
                    .HasColumnName("LSSCDUL_SEQN");

                entity.Property(e => e.LsscdulSpno)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_SPNO");

                entity.Property(e => e.LsscdulSprod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_SPROD");

                entity.Property(e => e.LsscdulStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_STATUS");

                entity.Property(e => e.LsscdulStop)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_STOP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LsscdulTotdur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_TOTDUR");

                entity.Property(e => e.LsscdulType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_TYPE");

                entity.Property(e => e.LsscdulWrklsd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LSSCDUL_WRKLSD");

                entity.HasOne(d => d.LsscdulAgentNavigation)
                    .WithMany(p => p.TvLsscdulLsscdulAgentNavigations)
                    .HasForeignKey(d => d.LsscdulAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENT_LSSCDUL");

                entity.HasOne(d => d.LsscdulClientNavigation)
                    .WithMany(p => p.TvLsscdulLsscdulClientNavigations)
                    .HasForeignKey(d => d.LsscdulClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_LSSCDUL");

                entity.HasOne(d => d.LsscdulHourNavigation)
                    .WithMany(p => p.TvLsscdulLsscdulHourNavigations)
                    .HasForeignKey(d => d.LsscdulHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_LSSCDUL");

                entity.HasOne(d => d.LsscdulHour2Navigation)
                    .WithMany(p => p.TvLsscdulLsscdulHour2Navigations)
                    .HasForeignKey(d => d.LsscdulHour2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR2_LSSCDUL");

                entity.HasOne(d => d.LsscdulMasterNavigation)
                    .WithMany(p => p.TvLsscduls)
                    .HasForeignKey(d => d.LsscdulMaster)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASTER_LSSCDUL");

                entity.HasOne(d => d.LsscdulProgmNavigation)
                    .WithMany(p => p.TvLsscduls)
                    .HasForeignKey(d => d.LsscdulProgm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROGM_LSSCDUL");

                entity.HasOne(d => d.LsscdulSprodNavigation)
                    .WithMany(p => p.TvLsscduls)
                    .HasForeignKey(d => d.LsscdulSprod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPROD_LSSCDUL");

                entity.HasOne(d => d.LsscdulStatusNavigation)
                    .WithMany(p => p.TvLsscduls)
                    .HasForeignKey(d => d.LsscdulStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STATUS_LSSCDUL");

                entity.HasOne(d => d.LsscdulWrklsdNavigation)
                    .WithMany(p => p.TvLsscduls)
                    .HasForeignKey(d => d.LsscdulWrklsd)
                    .HasConstraintName("FK_WRKLSD_LSSCDUL");
            });

            modelBuilder.Entity<TvLsscdulMaster>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_LSCDLM");

                entity.ToTable("TV_LSSCDUL_MASTER");

                entity.HasIndex(e => e.LscdlmText, "UK_TEXT_LSSCDUL_MASTER")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.LscdlmCdate)
                    .HasColumnType("DATE")
                    .HasColumnName("LSCDLM_CDATE");

                entity.Property(e => e.LscdlmHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LSCDLM_HOUR");

                entity.Property(e => e.LscdlmPntflg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LSCDLM_PNTFLG");

                entity.Property(e => e.LscdlmPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LSCDLM_POSF");

                entity.Property(e => e.LscdlmSdate)
                    .HasColumnType("DATE")
                    .HasColumnName("LSCDLM_SDATE");

                entity.Property(e => e.LscdlmText)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LSCDLM_TEXT");

                entity.Property(e => e.PrintBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRINT_BY");

                entity.Property(e => e.PrintDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PRINT_DATE");

                entity.Property(e => e.VerifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VERIFIED_BY");

                entity.Property(e => e.VerifiedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("VERIFIED_DATE");

                entity.HasOne(d => d.LscdlmHourNavigation)
                    .WithMany(p => p.TvLsscdulMasters)
                    .HasForeignKey(d => d.LscdlmHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_LSCDLM");
            });

            modelBuilder.Entity<TvMbank>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_MBANK");

                entity.ToTable("TV_MBANK");

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.MbankActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MBANK_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MbankName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MBANK_NAME");

                entity.Property(e => e.MbankStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MBANK_STOP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MbankText)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("MBANK_TEXT");
            });

            modelBuilder.Entity<TvMnrcvd>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_MNRCVD");

                entity.ToTable("TV_MNRCVD");

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.MnrcvdAgent)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_AGENT");

                entity.Property(e => e.MnrcvdAmnt)
                    .HasColumnType("NUMBER(12,5)")
                    .HasColumnName("MNRCVD_AMNT");

                entity.Property(e => e.MnrcvdClient)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_CLIENT");

                entity.Property(e => e.MnrcvdCraccd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_CRACCD");

                entity.Property(e => e.MnrcvdDate)
                    .HasColumnType("DATE")
                    .HasColumnName("MNRCVD_DATE");

                entity.Property(e => e.MnrcvdDocn)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_DOCN");

                entity.Property(e => e.MnrcvdDraccd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_DRACCD");

                entity.Property(e => e.MnrcvdInvoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_INVOC");

                entity.Property(e => e.MnrcvdLine)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_LINE");

                entity.Property(e => e.MnrcvdLocshd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_LOCSHD");

                entity.Property(e => e.MnrcvdMrno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_MRNO");

                entity.Property(e => e.MnrcvdNote)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_NOTE");

                entity.Property(e => e.MnrcvdPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_POSF");

                entity.Property(e => e.MnrcvdRcvtype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_RCVTYPE");

                entity.Property(e => e.MnrcvdSbank)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_SBANK");

                entity.Property(e => e.MnrcvdScomp)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_SCOMP");

                entity.Property(e => e.MnrcvdScust)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_SCUST");

                entity.Property(e => e.MnrcvdSgloc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_SGLOC");

                entity.Property(e => e.MnrcvdSmnyrm)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_SMNYRM");

                entity.Property(e => e.MnrcvdSmode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_SMODE");

                entity.Property(e => e.MnrcvdSpblm)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVD_SPBLM");

                entity.HasOne(d => d.MnrcvdAgentNavigation)
                    .WithMany(p => p.TvMnrcvdMnrcvdAgentNavigations)
                    .HasForeignKey(d => d.MnrcvdAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENT_MNRCVD");

                entity.HasOne(d => d.MnrcvdClientNavigation)
                    .WithMany(p => p.TvMnrcvdMnrcvdClientNavigations)
                    .HasForeignKey(d => d.MnrcvdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_MNRCVD");

                entity.HasOne(d => d.MnrcvdInvocNavigation)
                    .WithMany(p => p.TvMnrcvds)
                    .HasForeignKey(d => d.MnrcvdInvoc)
                    .HasConstraintName("FK_INVOC_MNRCVD");

                entity.HasOne(d => d.MnrcvdRcvtypeNavigation)
                    .WithMany(p => p.TvMnrcvds)
                    .HasForeignKey(d => d.MnrcvdRcvtype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RCVTYPE_MNRCVD");

                entity.HasOne(d => d.MnrcvdSpblmNavigation)
                    .WithMany(p => p.TvMnrcvds)
                    .HasForeignKey(d => d.MnrcvdSpblm)
                    .HasConstraintName("FK_SPBLM_MNRCVD");
            });

            modelBuilder.Entity<TvMnrcvm>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_OID_MNRCVM");

                entity.ToTable("TV_MNRCVM");

                entity.HasIndex(e => e.MnrcvmMrno, "UK_MRNO_MNRCVM")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.MnrcvmAgent)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_AGENT");

                entity.Property(e => e.MnrcvmAgloc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_AGLOC");

                entity.Property(e => e.MnrcvmCcom)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_CCOM");

                entity.Property(e => e.MnrcvmClient)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_CLIENT");

                entity.Property(e => e.MnrcvmHocshd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_HOCSHD");

                entity.Property(e => e.MnrcvmMcom)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_MCOM");

                entity.Property(e => e.MnrcvmMrdt)
                    .HasColumnType("DATE")
                    .HasColumnName("MNRCVM_MRDT");

                entity.Property(e => e.MnrcvmMrno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_MRNO");

                entity.Property(e => e.MnrcvmNote)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_NOTE");

                entity.Property(e => e.MnrcvmOtgloc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_OTGLOC");

                entity.Property(e => e.MnrcvmPosf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_POSF")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.MnrcvmRefno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_REFNO");

                entity.Property(e => e.MnrcvmScomp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_SCOMP");

                entity.Property(e => e.MnrcvmSctyp)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_SCTYP");

                entity.Property(e => e.MnrcvmScustInfo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_SCUST_INFO");

                entity.Property(e => e.MnrcvmSgloc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_SGLOC");

                entity.Property(e => e.MnrcvmType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MNRCVM_TYPE");

                entity.HasOne(d => d.MnrcvmAgentNavigation)
                    .WithMany(p => p.TvMnrcvmMnrcvmAgentNavigations)
                    .HasForeignKey(d => d.MnrcvmAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENT_MNRCVM");

                entity.HasOne(d => d.MnrcvmClientNavigation)
                    .WithMany(p => p.TvMnrcvmMnrcvmClientNavigations)
                    .HasForeignKey(d => d.MnrcvmClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_MNRCVM");
            });

            modelBuilder.Entity<TvPenbil>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_PENBIL");

                entity.ToTable("TV_PENBIL");

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ApvDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APV_DATE");

                entity.Property(e => e.ApvDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APV_DEVICE_IP");

                entity.Property(e => e.ApvDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APV_DEVICE_NAME");

                entity.Property(e => e.ApvDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APV_DEVICE_USER");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.PenbilAgent)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_AGENT");

                entity.Property(e => e.PenbilBnflg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_BNFLG");

                entity.Property(e => e.PenbilClient)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_CLIENT");

                entity.Property(e => e.PenbilCndur)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_CNDUR");

                entity.Property(e => e.PenbilCode)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_CODE");

                entity.Property(e => e.PenbilDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PENBIL_DATE");

                entity.Property(e => e.PenbilDatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("PENBIL_DATETIME");

                entity.Property(e => e.PenbilFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_FLAG");

                entity.Property(e => e.PenbilFtime)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_FTIME");

                entity.Property(e => e.PenbilHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_HOUR");

                entity.Property(e => e.PenbilLdate)
                    .HasColumnType("DATE")
                    .HasColumnName("PENBIL_LDATE");

                entity.Property(e => e.PenbilLine)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_LINE");

                entity.Property(e => e.PenbilLog)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_LOG");

                entity.Property(e => e.PenbilMaster)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_MASTER");

                entity.Property(e => e.PenbilNote)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_NOTE");

                entity.Property(e => e.PenbilPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_POSF");

                entity.Property(e => e.PenbilProcs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_PROCS")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.PenbilRate)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("PENBIL_RATE");

                entity.Property(e => e.PenbilSprod)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_SPROD");

                entity.Property(e => e.PenbilStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_STATUS");

                entity.Property(e => e.PenbilTime)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_TIME");

                entity.Property(e => e.PenbilTmdur)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_TMDUR");

                entity.Property(e => e.PenbilTtime)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_TTIME");

                entity.Property(e => e.PenbilTxdt)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_TXDT");

                entity.Property(e => e.PenbilType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PENBIL_TYPE");

                entity.HasOne(d => d.PenbilAgentNavigation)
                    .WithMany(p => p.TvPenbilPenbilAgentNavigations)
                    .HasForeignKey(d => d.PenbilAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PENBIL_AGENT");

                entity.HasOne(d => d.PenbilClientNavigation)
                    .WithMany(p => p.TvPenbilPenbilClientNavigations)
                    .HasForeignKey(d => d.PenbilClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PENBIL_CLIENT");

                entity.HasOne(d => d.PenbilHourNavigation)
                    .WithMany(p => p.TvPenbils)
                    .HasForeignKey(d => d.PenbilHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PENBIL_HOUR");

                entity.HasOne(d => d.PenbilLogNavigation)
                    .WithMany(p => p.TvPenbils)
                    .HasForeignKey(d => d.PenbilLog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PENBIL_LOG");

                entity.HasOne(d => d.PenbilMasterNavigation)
                    .WithMany(p => p.TvPenbils)
                    .HasForeignKey(d => d.PenbilMaster)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASTER_PENBIL");

                entity.HasOne(d => d.PenbilSprodNavigation)
                    .WithMany(p => p.TvPenbils)
                    .HasForeignKey(d => d.PenbilSprod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PENBIL_SPROD");

                entity.HasOne(d => d.PenbilStatusNavigation)
                    .WithMany(p => p.TvPenbils)
                    .HasForeignKey(d => d.PenbilStatus)
                    .HasConstraintName("FK_PENBIL_STATUS");
            });

            modelBuilder.Entity<TvPenbilMaster>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_PENBILMST_MASTER");

                entity.ToTable("TV_PENBIL_MASTER");

                entity.HasIndex(e => e.PenbilmstText, "UK_TEXT_PENBILMST_MASTER")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.PenbilmstDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PENBILMST_DATE");

                entity.Property(e => e.PenbilmstFlg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PENBILMST_FLG");

                entity.Property(e => e.PenbilmstLdate)
                    .HasColumnType("DATE")
                    .HasColumnName("PENBILMST_LDATE");

                entity.Property(e => e.PenbilmstPntflg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PENBILMST_PNTFLG");

                entity.Property(e => e.PenbilmstPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PENBILMST_POSF");

                entity.Property(e => e.PenbilmstText)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PENBILMST_TEXT");

                entity.Property(e => e.PenbilmstTxdt)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PENBILMST_TXDT");
            });

            modelBuilder.Entity<TvProgm>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_PROGM");

                entity.ToTable("TV_PROGM");

                entity.HasIndex(e => e.ProgmText, "UK_TEXT_PROGM")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.ProgmActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROGM_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ProgmAllot)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROGM_ALLOT");

                entity.Property(e => e.ProgmCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PROGM_CODE");

                entity.Property(e => e.ProgmDftime)
                    .HasColumnType("DATE")
                    .HasColumnName("PROGM_DFTIME")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.ProgmDttime)
                    .HasColumnType("DATE")
                    .HasColumnName("PROGM_DTTIME")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.ProgmDurtn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROGM_DURTN");

                entity.Property(e => e.ProgmFtime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROGM_FTIME");

                entity.Property(e => e.ProgmHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROGM_HOUR");

                entity.Property(e => e.ProgmName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PROGM_NAME");

                entity.Property(e => e.ProgmOpdate)
                    .HasColumnType("DATE")
                    .HasColumnName("PROGM_OPDATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.ProgmSeqn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROGM_SEQN");

                entity.Property(e => e.ProgmStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROGM_STOP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProgmText)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("PROGM_TEXT");

                entity.Property(e => e.ProgmTtime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PROGM_TTIME");

                entity.HasOne(d => d.ProgmHourNavigation)
                    .WithMany(p => p.TvProgms)
                    .HasForeignKey(d => d.ProgmHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_PROGM");
            });

            modelBuilder.Entity<TvRcvtype>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_RCVTYPE");

                entity.ToTable("TV_RCVTYPE");

                entity.HasIndex(e => e.RcvtypeText, "UK_TEXT_RCVTYPE")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.RcvtypeActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RCVTYPE_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RcvtypeName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("RCVTYPE_NAME");

                entity.Property(e => e.RcvtypeSname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RCVTYPE_SNAME");

                entity.Property(e => e.RcvtypeStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RCVTYPE_STOP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RcvtypeText)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("RCVTYPE_TEXT");
            });

            modelBuilder.Entity<TvSchedule>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_SCHEDULE");

                entity.ToTable("TV_SCHEDULE");

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.AmnedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("AMNED_DATE");

                entity.Property(e => e.AmnedDeviceIp)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AMNED_DEVICE_IP");

                entity.Property(e => e.AmnedDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AMNED_DEVICE_USER");

                entity.Property(e => e.AmnedUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AMNED_USER");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.ScheduleAgent)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_AGENT");

                entity.Property(e => e.ScheduleBreak)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_BREAK");

                entity.Property(e => e.ScheduleCdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SCHEDULE_CDATE");

                entity.Property(e => e.ScheduleClient)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_CLIENT");

                entity.Property(e => e.ScheduleClnsts)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_CLNSTS");

                entity.Property(e => e.ScheduleCmtim)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_CMTIM");

                entity.Property(e => e.ScheduleCode)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_CODE");

                entity.Property(e => e.ScheduleColr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_COLR");

                entity.Property(e => e.ScheduleCtyp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_CTYP");

                entity.Property(e => e.ScheduleFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_FLAG");

                entity.Property(e => e.ScheduleFnlfg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_FNLFG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ScheduleFtime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_FTIME");

                entity.Property(e => e.ScheduleHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_HOUR");

                entity.Property(e => e.ScheduleLine)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_LINE");

                entity.Property(e => e.ScheduleMaster)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_MASTER");

                entity.Property(e => e.SchedulePend)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_PEND");

                entity.Property(e => e.SchedulePftime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_PFTIME");

                entity.Property(e => e.SchedulePnam)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_PNAM");

                entity.Property(e => e.SchedulePosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_POSF");

                entity.Property(e => e.ScheduleProgm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_PROGM");

                entity.Property(e => e.SchedulePttime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_PTTIME");

                entity.Property(e => e.ScheduleRate)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SCHEDULE_RATE");

                entity.Property(e => e.ScheduleSdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SCHEDULE_SDATE");

                entity.Property(e => e.ScheduleSeqn)
                    .HasPrecision(10)
                    .HasColumnName("SCHEDULE_SEQN")
                    .HasDefaultValueSql("200");

                entity.Property(e => e.ScheduleSpot)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_SPOT");

                entity.Property(e => e.ScheduleSprod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_SPROD");

                entity.Property(e => e.ScheduleSptm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_SPTM");

                entity.Property(e => e.ScheduleStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_STATUS");

                entity.Property(e => e.ScheduleTmdur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_TMDUR");

                entity.Property(e => e.ScheduleTpid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_TPID");

                entity.Property(e => e.ScheduleTtime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_TTIME");

                entity.Property(e => e.ScheduleType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_TYPE");

                entity.Property(e => e.ScheduleWrkord)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULE_WRKORD");

                entity.Property(e => e.VerifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VERIFIED_BY");

                entity.Property(e => e.VerifiedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("VERIFIED_DATE");

                entity.HasOne(d => d.ScheduleAgentNavigation)
                    .WithMany(p => p.TvScheduleScheduleAgentNavigations)
                    .HasForeignKey(d => d.ScheduleAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENT_SCHEDULE");

                entity.HasOne(d => d.ScheduleBreakNavigation)
                    .WithMany(p => p.TvSchedules)
                    .HasForeignKey(d => d.ScheduleBreak)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BREAK_SCHEDULE");

                entity.HasOne(d => d.ScheduleClientNavigation)
                    .WithMany(p => p.TvScheduleScheduleClientNavigations)
                    .HasForeignKey(d => d.ScheduleClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_SCHEDULE");

                entity.HasOne(d => d.ScheduleHourNavigation)
                    .WithMany(p => p.TvSchedules)
                    .HasForeignKey(d => d.ScheduleHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_SCHEDULE");

                entity.HasOne(d => d.ScheduleMasterNavigation)
                    .WithMany(p => p.TvSchedules)
                    .HasForeignKey(d => d.ScheduleMaster)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASTER_SCHEDULE");

                entity.HasOne(d => d.ScheduleProgmNavigation)
                    .WithMany(p => p.TvSchedules)
                    .HasForeignKey(d => d.ScheduleProgm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROGM_SCHEDULE");

                entity.HasOne(d => d.ScheduleSpotNavigation)
                    .WithMany(p => p.TvSchedules)
                    .HasForeignKey(d => d.ScheduleSpot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPOT_SCHEDULE");

                entity.HasOne(d => d.ScheduleSprodNavigation)
                    .WithMany(p => p.TvSchedules)
                    .HasForeignKey(d => d.ScheduleSprod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPROD_SCHEDULE");
            });

            modelBuilder.Entity<TvScheduleMaster>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_SCHDLM");

                entity.ToTable("TV_SCHEDULE_MASTER");

                entity.HasIndex(e => e.SchdlmText, "UK_TEXT_SCHEDULE_MASTER")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.PrintBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRINT_BY");

                entity.Property(e => e.PrintDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PRINT_DATE");

                entity.Property(e => e.SchdlmCdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SCHDLM_CDATE");

                entity.Property(e => e.SchdlmHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCHDLM_HOUR");

                entity.Property(e => e.SchdlmPntflg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SCHDLM_PNTFLG");

                entity.Property(e => e.SchdlmPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SCHDLM_POSF");

                entity.Property(e => e.SchdlmSdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SCHDLM_SDATE");

                entity.Property(e => e.SchdlmText)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SCHDLM_TEXT");

                entity.Property(e => e.VerifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VERIFIED_BY");

                entity.Property(e => e.VerifiedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("VERIFIED_DATE");

                entity.HasOne(d => d.SchdlmHourNavigation)
                    .WithMany(p => p.TvScheduleMasters)
                    .HasForeignKey(d => d.SchdlmHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_SCHDLM");
            });

            modelBuilder.Entity<TvScomp>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_SCOMP");

                entity.ToTable("TV_SCOMP");

                entity.HasIndex(e => e.ScompText, "UK_TEXT_SCOMP")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.ScompActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCOMP_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ScompBname)
                    .HasMaxLength(200)
                    .HasColumnName("SCOMP_BNAME");

                entity.Property(e => e.ScompCcom)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SCOMP_CCOM");

                entity.Property(e => e.ScompMcom)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SCOMP_MCOM");

                entity.Property(e => e.ScompName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCOMP_NAME");

                entity.Property(e => e.ScompStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCOMP_STOP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScompText)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SCOMP_TEXT");
            });

            modelBuilder.Entity<TvSpbld>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_SPBLD");

                entity.ToTable("TV_SPBLD");

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.SpbldHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLD_HOUR");

                entity.Property(e => e.SpbldLine)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SPBLD_LINE");

                entity.Property(e => e.SpbldMont)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SPBLD_MONT");

                entity.Property(e => e.SpbldNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLD_NO");

                entity.Property(e => e.SpbldPntdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SPBLD_PNTDATE");

                entity.Property(e => e.SpbldPnttc)
                    .HasPrecision(2)
                    .HasColumnName("SPBLD_PNTTC")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpbldPntuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLD_PNTUSER");

                entity.Property(e => e.SpbldSpblm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLD_SPBLM");

                entity.Property(e => e.SpbldSpdt)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("SPBLD_SPDT");

                entity.Property(e => e.SpbldTot)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLD_TOT");

                entity.Property(e => e.SpbldYear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPBLD_YEAR");

                entity.HasOne(d => d.SpbldHourNavigation)
                    .WithMany(p => p.TvSpblds)
                    .HasForeignKey(d => d.SpbldHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_SPBLD");

                entity.HasOne(d => d.SpbldSpblmNavigation)
                    .WithMany(p => p.TvSpblds)
                    .HasForeignKey(d => d.SpbldSpblm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPBLM_SPBLD");
            });

            modelBuilder.Entity<TvSpblm>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_SPBLM");

                entity.ToTable("TV_SPBLM");

                entity.HasIndex(e => e.SpblmCont, "UK_CONT_SPBLM")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.SpblmAgaccd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_AGACCD");

                entity.Property(e => e.SpblmAgency)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SPBLM_AGENCY");

                entity.Property(e => e.SpblmAgent)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_AGENT");

                entity.Property(e => e.SpblmAgloc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_AGLOC");

                entity.Property(e => e.SpblmAiaccd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_AIACCD");

                entity.Property(e => e.SpblmAit)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SPBLM_AIT");

                entity.Property(e => e.SpblmAit2)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SPBLM_AIT2");

                entity.Property(e => e.SpblmAmnt)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SPBLM_AMNT");

                entity.Property(e => e.SpblmCcom)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_CCOM");

                entity.Property(e => e.SpblmClient)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_CLIENT");

                entity.Property(e => e.SpblmCondt)
                    .HasColumnType("DATE")
                    .HasColumnName("SPBLM_CONDT");

                entity.Property(e => e.SpblmCont)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_CONT");

                entity.Property(e => e.SpblmCprod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_CPROD");

                entity.Property(e => e.SpblmCprod2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_CPROD2");

                entity.Property(e => e.SpblmCprod3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_CPROD3");

                entity.Property(e => e.SpblmCrcshd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_CRCSHD");

                entity.Property(e => e.SpblmDraccd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_DRACCD");

                entity.Property(e => e.SpblmDrcshd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_DRCSHD");

                entity.Property(e => e.SpblmDur)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SPBLM_DUR");

                entity.Property(e => e.SpblmEndt)
                    .HasColumnType("DATE")
                    .HasColumnName("SPBLM_ENDT");

                entity.Property(e => e.SpblmEpsod)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SPBLM_EPSOD");

                entity.Property(e => e.SpblmFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_FLAG");

                entity.Property(e => e.SpblmMcom)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_MCOM");

                entity.Property(e => e.SpblmMukdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SPBLM_MUKDATE");

                entity.Property(e => e.SpblmMushok)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_MUSHOK");

                entity.Property(e => e.SpblmNote)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_NOTE");

                entity.Property(e => e.SpblmPntdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SPBLM_PNTDATE");

                entity.Property(e => e.SpblmPntflag)
                    .HasPrecision(2)
                    .HasColumnName("SPBLM_PNTFLAG")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpblmPntuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_PNTUSER");

                entity.Property(e => e.SpblmPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_POSF");

                entity.Property(e => e.SpblmRate)
                    .HasColumnType("NUMBER(18,6)")
                    .HasColumnName("SPBLM_RATE");

                entity.Property(e => e.SpblmScomp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_SCOMP");

                entity.Property(e => e.SpblmSgloc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_SGLOC");

                entity.Property(e => e.SpblmSpadj)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SPBLM_SPADJ");

                entity.Property(e => e.SpblmSraccd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_SRACCD");

                entity.Property(e => e.SpblmStdt)
                    .HasColumnType("DATE")
                    .HasColumnName("SPBLM_STDT");

                entity.Property(e => e.SpblmTprat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_TPRAT");

                entity.Property(e => e.SpblmTrdt)
                    .HasColumnType("DATE")
                    .HasColumnName("SPBLM_TRDT");

                entity.Property(e => e.SpblmType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_TYPE");

                entity.Property(e => e.SpblmVat)
                    .HasColumnType("NUMBER(12,2)")
                    .HasColumnName("SPBLM_VAT");

                entity.Property(e => e.SpblmVtaccd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_VTACCD");

                entity.Property(e => e.SpblmVtflg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM_VTFLG");

                entity.HasOne(d => d.SpblmAgentNavigation)
                    .WithMany(p => p.TvSpblmSpblmAgentNavigations)
                    .HasForeignKey(d => d.SpblmAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENT_SPBLM");

                entity.HasOne(d => d.SpblmClientNavigation)
                    .WithMany(p => p.TvSpblmSpblmClientNavigations)
                    .HasForeignKey(d => d.SpblmClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_SPBLM");

                entity.HasOne(d => d.SpblmCprodNavigation)
                    .WithMany(p => p.TvSpblmSpblmCprodNavigations)
                    .HasForeignKey(d => d.SpblmCprod)
                    .HasConstraintName("FK_CPROD_SPBLM");

                entity.HasOne(d => d.SpblmCprod2Navigation)
                    .WithMany(p => p.TvSpblmSpblmCprod2Navigations)
                    .HasForeignKey(d => d.SpblmCprod2)
                    .HasConstraintName("FK_CPROD2_SPBLM");

                entity.HasOne(d => d.SpblmCprod3Navigation)
                    .WithMany(p => p.TvSpblmSpblmCprod3Navigations)
                    .HasForeignKey(d => d.SpblmCprod3)
                    .HasConstraintName("FK_CPROD3_SPBLM");

                entity.HasOne(d => d.SpblmScompNavigation)
                    .WithMany(p => p.TvSpblms)
                    .HasForeignKey(d => d.SpblmScomp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCOMP_SPBLM");
            });

            modelBuilder.Entity<TvSpot>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_SPOT");

                entity.ToTable("TV_SPOT");

                entity.HasIndex(e => e.SpotText, "UK_TEXT_SPOT")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.SpotActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPOT_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SpotName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SPOT_NAME");

                entity.Property(e => e.SpotStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPOT_STOP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpotText)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SPOT_TEXT");
            });

            modelBuilder.Entity<TvSprod>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_SPROD");

                entity.ToTable("TV_SPROD");

                entity.HasIndex(e => e.SprodCode, "UK_CODE_SPROD")
                    .IsUnique();

                entity.HasIndex(e => e.SprodText, "UK_TEXT_SPROD")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.SprodActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPROD_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SprodAgent)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPROD_AGENT");

                entity.Property(e => e.SprodClient)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPROD_CLIENT");

                entity.Property(e => e.SprodCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SPROD_CODE");

                entity.Property(e => e.SprodDur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPROD_DUR");

                entity.Property(e => e.SprodName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SPROD_NAME");

                entity.Property(e => e.SprodOpndt)
                    .HasColumnType("DATE")
                    .HasColumnName("SPROD_OPNDT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.SprodStop)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SPROD_STOP");

                entity.Property(e => e.SprodText)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SPROD_TEXT");

                entity.Property(e => e.SprodType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SPROD_TYPE");

                entity.HasOne(d => d.SprodAgentNavigation)
                    .WithMany(p => p.TvSprodSprodAgentNavigations)
                    .HasForeignKey(d => d.SprodAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENT_SPROD");

                entity.HasOne(d => d.SprodClientNavigation)
                    .WithMany(p => p.TvSprodSprodClientNavigations)
                    .HasForeignKey(d => d.SprodClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_SPROD");
            });

            modelBuilder.Entity<TvStatus>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_STATUS");

                entity.ToTable("TV_STATUS");

                entity.HasIndex(e => e.StatusText, "UK_TEXT_STATUS")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.StatusActv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ACTV")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.StatusSname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_SNAME");

                entity.Property(e => e.StatusStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_STOP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatusText)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_TEXT");

                entity.Property(e => e.StatusType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_TYPE");
            });

            modelBuilder.Entity<TvWrklsd>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_WRKLSD");

                entity.ToTable("TV_WRKLSD");

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.WrklsdAgent)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_AGENT");

                entity.Property(e => e.WrklsdApproveby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_APPROVEBY");

                entity.Property(e => e.WrklsdAppvdate)
                    .HasColumnType("DATE")
                    .HasColumnName("WRKLSD_APPVDATE");

                entity.Property(e => e.WrklsdAppvdur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_APPVDUR");

                entity.Property(e => e.WrklsdAppvfalg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_APPVFALG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.WrklsdAppvspno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_APPVSPNO");

                entity.Property(e => e.WrklsdCdate)
                    .HasColumnType("DATE")
                    .HasColumnName("WRKLSD_CDATE");

                entity.Property(e => e.WrklsdClient)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_CLIENT");

                entity.Property(e => e.WrklsdCode)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_CODE");

                entity.Property(e => e.WrklsdColr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_COLR");

                entity.Property(e => e.WrklsdDay)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_DAY");

                entity.Property(e => e.WrklsdDuration)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_DURATION");

                entity.Property(e => e.WrklsdFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.WrklsdHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_HOUR");

                entity.Property(e => e.WrklsdHour2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_HOUR2");

                entity.Property(e => e.WrklsdLine)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_LINE");

                entity.Property(e => e.WrklsdMaster)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_MASTER");

                entity.Property(e => e.WrklsdNote)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_NOTE");

                entity.Property(e => e.WrklsdPend)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_PEND")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WrklsdPftime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_PFTIME");

                entity.Property(e => e.WrklsdPname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_PNAME");

                entity.Property(e => e.WrklsdPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_POSF");

                entity.Property(e => e.WrklsdProgm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_PROGM");

                entity.Property(e => e.WrklsdPttime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_PTTIME");

                entity.Property(e => e.WrklsdRate)
                    .HasColumnType("NUMBER(18,8)")
                    .HasColumnName("WRKLSD_RATE");

                entity.Property(e => e.WrklsdSdate)
                    .HasColumnType("DATE")
                    .HasColumnName("WRKLSD_SDATE");

                entity.Property(e => e.WrklsdSeqn)
                    .HasPrecision(10)
                    .HasColumnName("WRKLSD_SEQN");

                entity.Property(e => e.WrklsdSpno)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_SPNO");

                entity.Property(e => e.WrklsdSprod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_SPROD");

                entity.Property(e => e.WrklsdStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_STATUS");

                entity.Property(e => e.WrklsdStop)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_STOP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WrklsdTotdur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_TOTDUR");

                entity.Property(e => e.WrklsdType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WRKLSD_TYPE");

                entity.HasOne(d => d.WrklsdAgentNavigation)
                    .WithMany(p => p.TvWrklsdWrklsdAgentNavigations)
                    .HasForeignKey(d => d.WrklsdAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENT_WRKLSD");

                entity.HasOne(d => d.WrklsdClientNavigation)
                    .WithMany(p => p.TvWrklsdWrklsdClientNavigations)
                    .HasForeignKey(d => d.WrklsdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_WRKLSD");

                entity.HasOne(d => d.WrklsdHourNavigation)
                    .WithMany(p => p.TvWrklsdWrklsdHourNavigations)
                    .HasForeignKey(d => d.WrklsdHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_WRKLSD");

                entity.HasOne(d => d.WrklsdHour2Navigation)
                    .WithMany(p => p.TvWrklsdWrklsdHour2Navigations)
                    .HasForeignKey(d => d.WrklsdHour2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR2_WRKLSD");

                entity.HasOne(d => d.WrklsdMasterNavigation)
                    .WithMany(p => p.TvWrklsds)
                    .HasForeignKey(d => d.WrklsdMaster)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASTER_WRKLSD");

                entity.HasOne(d => d.WrklsdProgmNavigation)
                    .WithMany(p => p.TvWrklsds)
                    .HasForeignKey(d => d.WrklsdProgm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROGM_WRKLSD");

                entity.HasOne(d => d.WrklsdSprodNavigation)
                    .WithMany(p => p.TvWrklsds)
                    .HasForeignKey(d => d.WrklsdSprod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPROD_WRKLSD");

                entity.HasOne(d => d.WrklsdStatusNavigation)
                    .WithMany(p => p.TvWrklsds)
                    .HasForeignKey(d => d.WrklsdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STATUS_WRKLSD");
            });

            modelBuilder.Entity<TvWrklsdMaster>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_WRLSM");

                entity.ToTable("TV_WRKLSD_MASTER");

                entity.HasIndex(e => e.WrlsmText, "UK_TEXT_WRKLSD_MASTER")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPROVED_BY");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVED_DATE");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.PrintBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRINT_BY");

                entity.Property(e => e.PrintDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PRINT_DATE");

                entity.Property(e => e.VerifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VERIFIED_BY");

                entity.Property(e => e.VerifiedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("VERIFIED_DATE");

                entity.Property(e => e.WrlsmCdate)
                    .HasColumnType("DATE")
                    .HasColumnName("WRLSM_CDATE");

                entity.Property(e => e.WrlsmHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRLSM_HOUR");

                entity.Property(e => e.WrlsmPntflg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WRLSM_PNTFLG");

                entity.Property(e => e.WrlsmPosf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WRLSM_POSF");

                entity.Property(e => e.WrlsmSdate)
                    .HasColumnType("DATE")
                    .HasColumnName("WRLSM_SDATE");

                entity.Property(e => e.WrlsmText)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRLSM_TEXT");

                entity.HasOne(d => d.WrlsmHourNavigation)
                    .WithMany(p => p.TvWrklsdMasters)
                    .HasForeignKey(d => d.WrlsmHour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOUR_WRLSM");
            });

            modelBuilder.Entity<TvWrkord>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_WRKORD_OID");

                entity.ToTable("TV_WRKORD");

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.WrkordActv)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_ACTV");

                entity.Property(e => e.WrkordBreak)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_BREAK");

                entity.Property(e => e.WrkordDate)
                    .HasColumnType("DATE")
                    .HasColumnName("WRKORD_DATE");

                entity.Property(e => e.WrkordFdate)
                    .HasColumnType("DATE")
                    .HasColumnName("WRKORD_FDATE");

                entity.Property(e => e.WrkordFtime)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_FTIME");

                entity.Property(e => e.WrkordFttime)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_FTTIME");

                entity.Property(e => e.WrkordHour)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_HOUR");

                entity.Property(e => e.WrkordLine)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_LINE");

                entity.Property(e => e.WrkordMaster)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_MASTER");

                entity.Property(e => e.WrkordPftime)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_PFTIME");

                entity.Property(e => e.WrkordProgm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_PROGM");

                entity.Property(e => e.WrkordRate)
                    .HasColumnType("NUMBER(15,6)")
                    .HasColumnName("WRKORD_RATE");

                entity.Property(e => e.WrkordSpoot)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_SPOOT");

                entity.Property(e => e.WrkordSprod)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_SPROD");

                entity.Property(e => e.WrkordTdate)
                    .HasColumnType("DATE")
                    .HasColumnName("WRKORD_TDATE");

                entity.Property(e => e.WrkordTmdur)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_TMDUR");

                entity.Property(e => e.WrkordTtime)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_TTIME");

                entity.Property(e => e.WrkordType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("WRKORD_TYPE");

                entity.HasOne(d => d.WrkordBreakNavigation)
                    .WithMany(p => p.TvWrkords)
                    .HasForeignKey(d => d.WrkordBreak)
                    .HasConstraintName("FK_BREAK_WRKORD");

                entity.HasOne(d => d.WrkordHourNavigation)
                    .WithMany(p => p.TvWrkords)
                    .HasForeignKey(d => d.WrkordHour)
                    .HasConstraintName("FK_HOUR_WRKORD");

                entity.HasOne(d => d.WrkordMasterNavigation)
                    .WithMany(p => p.TvWrkords)
                    .HasForeignKey(d => d.WrkordMaster)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASTER_WRKORD");

                entity.HasOne(d => d.WrkordProgmNavigation)
                    .WithMany(p => p.TvWrkords)
                    .HasForeignKey(d => d.WrkordProgm)
                    .HasConstraintName("FK_PROGM_WRKORD");

                entity.HasOne(d => d.WrkordSpootNavigation)
                    .WithMany(p => p.TvWrkords)
                    .HasForeignKey(d => d.WrkordSpoot)
                    .HasConstraintName("FK_SPOOT_WRKORD");

                entity.HasOne(d => d.WrkordSprodNavigation)
                    .WithMany(p => p.TvWrkords)
                    .HasForeignKey(d => d.WrkordSprod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPROD_WRKORD");
            });

            modelBuilder.Entity<TvWrksdlMaster>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_WRKSDL_OID");

                entity.ToTable("TV_WRKSDL_MASTER");

                entity.HasIndex(e => e.WrksdlTrno, "UK_TRNO_WRKSDL")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEVICE_USER");

                entity.Property(e => e.Edat)
                    .HasColumnType("DATE")
                    .HasColumnName("EDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EditDeviceIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_IP");

                entity.Property(e => e.EditDeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_NAME");

                entity.Property(e => e.EditDeviceUser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DEVICE_USER");

                entity.Property(e => e.Euser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Idat)
                    .HasColumnType("DATE")
                    .HasColumnName("IDAT")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Iuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IUSER")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.WrksdlActv)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WRKSDL_ACTV");

                entity.Property(e => e.WrksdlAgent)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRKSDL_AGENT");

                entity.Property(e => e.WrksdlClient)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRKSDL_CLIENT");

                entity.Property(e => e.WrksdlDate)
                    .HasColumnType("DATE")
                    .HasColumnName("WRKSDL_DATE");

                entity.Property(e => e.WrksdlFdate)
                    .HasColumnType("DATE")
                    .HasColumnName("WRKSDL_FDATE");

                entity.Property(e => e.WrksdlFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WRKSDL_FLAG");

                entity.Property(e => e.WrksdlTdate)
                    .HasColumnType("DATE")
                    .HasColumnName("WRKSDL_TDATE");

                entity.Property(e => e.WrksdlTrno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("WRKSDL_TRNO");

                entity.Property(e => e.WrksdlType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WRKSDL_TYPE");

                entity.HasOne(d => d.WrksdlAgentNavigation)
                    .WithMany(p => p.TvWrksdlMasterWrksdlAgentNavigations)
                    .HasForeignKey(d => d.WrksdlAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENT_WRKSDL");

                entity.HasOne(d => d.WrksdlClientNavigation)
                    .WithMany(p => p.TvWrksdlMasterWrksdlClientNavigations)
                    .HasForeignKey(d => d.WrksdlClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_WRKSDL");
            });

            modelBuilder.Entity<VwTvMoneyCashReceive>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_TV_MONEY_CASH_RECEIVE");

                entity.Property(e => e.Cramnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CRAMNT");

                entity.Property(e => e.Dramnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DRAMNT");

                entity.Property(e => e.Flag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FLAG")
                    .IsFixedLength();

                entity.Property(e => e.Intcom)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("INTCOM");

                entity.Property(e => e.Locshd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LOCSHD");

                entity.Property(e => e.Mrno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MRNO");

                entity.Property(e => e.Narra)
                    .HasMaxLength(246)
                    .IsUnicode(false)
                    .HasColumnName("NARRA");

                entity.Property(e => e.Scomp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCOMP");

                entity.Property(e => e.Sl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SL")
                    .IsFixedLength();

                entity.Property(e => e.Smnyrm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMNYRM");

                entity.Property(e => e.Traccd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRACCD");
            });

            modelBuilder.Entity<VwTvMoneyRcvAdjustment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_TV_MONEY_RCV_ADJUSTMENT");

                entity.Property(e => e.Cramnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CRAMNT");

                entity.Property(e => e.Dramnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DRAMNT");

                entity.Property(e => e.Flag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FLAG")
                    .IsFixedLength();

                entity.Property(e => e.Intcom)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("INTCOM");

                entity.Property(e => e.Locshd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LOCSHD");

                entity.Property(e => e.Mrno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MRNO");

                entity.Property(e => e.Narra)
                    .HasMaxLength(246)
                    .IsUnicode(false)
                    .HasColumnName("NARRA");

                entity.Property(e => e.Scomp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCOMP");

                entity.Property(e => e.Sl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SL")
                    .IsFixedLength();

                entity.Property(e => e.Smnyrm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMNYRM");

                entity.Property(e => e.Traccd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRACCD");
            });

            modelBuilder.Entity<VwTvMoneyReceived>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_TV_MONEY_RECEIVED");

                entity.Property(e => e.Cramnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CRAMNT");

                entity.Property(e => e.Dramnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DRAMNT");

                entity.Property(e => e.Flag)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FLAG")
                    .IsFixedLength();

                entity.Property(e => e.Intcom)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("INTCOM");

                entity.Property(e => e.Locshd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LOCSHD");

                entity.Property(e => e.Mrno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MRNO");

                entity.Property(e => e.Narra)
                    .IsUnicode(false)
                    .HasColumnName("NARRA");

                entity.Property(e => e.Scomp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SCOMP");

                entity.Property(e => e.Sl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SL")
                    .IsFixedLength();

                entity.Property(e => e.Smnyrm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMNYRM");

                entity.Property(e => e.Traccd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRACCD");
            });

            modelBuilder.Entity<VwTvMrContactAmnt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_TV_MR_CONTACT_AMNT");

                entity.Property(e => e.Amnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AMNT");

                entity.Property(e => e.Clnt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CLNT");

                entity.Property(e => e.Cont)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("CONT");

                entity.Property(e => e.Spblm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SPBLM");
            });

            modelBuilder.Entity<ZDebugTab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_DEBUG_TAB");

                entity.Property(e => e.Msg)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("MSG");
            });

            modelBuilder.HasSequence("LC_T_ERRORLOG_SEQ");

            modelBuilder.HasSequence("T_CMNMENU_SEQ");

            modelBuilder.HasSequence("T_CMNMENUPERMISSION_SEQ");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
