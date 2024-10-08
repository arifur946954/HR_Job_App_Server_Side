using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataModel.JobEntityModel.JobOraModelTest
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

        public virtual DbSet<TCmnmenu> TCmnmenus { get; set; } = null!;
        public virtual DbSet<TCmnmenupermission> TCmnmenupermissions { get; set; } = null!;
        public virtual DbSet<TErrorLog> TErrorLogs { get; set; } = null!;
        public virtual DbSet<TJobAppAcaQualification> TJobAppAcaQualifications { get; set; } = null!;
        public virtual DbSet<TJobAppAddress> TJobAppAddresses { get; set; } = null!;
        public virtual DbSet<TJobAppApplicantForm> TJobAppApplicantForms { get; set; } = null!;
        public virtual DbSet<TJobAppCircular> TJobAppCirculars { get; set; } = null!;
        public virtual DbSet<TJobAppCv> TJobAppCvs { get; set; } = null!;
        public virtual DbSet<TJobAppExperience> TJobAppExperiences { get; set; } = null!;
        public virtual DbSet<TJobAppImage> TJobAppImages { get; set; } = null!;
        public virtual DbSet<TJobAppRegister> TJobAppRegisters { get; set; } = null!;
        public virtual DbSet<TJobAppSignature> TJobAppSignatures { get; set; } = null!;
        public virtual DbSet<TJobApplicantAcaQualification> TJobApplicantAcaQualifications { get; set; } = null!;
        public virtual DbSet<TJobApplicantDocument> TJobApplicantDocuments { get; set; } = null!;
        public virtual DbSet<TJobApplicantExperience> TJobApplicantExperiences { get; set; } = null!;
        public virtual DbSet<TJobApplicantMaster> TJobApplicantMasters { get; set; } = null!;
        public virtual DbSet<TJobCmnmenu> TJobCmnmenus { get; set; } = null!;
        public virtual DbSet<TJobEmployee> TJobEmployees { get; set; } = null!;
        public virtual DbSet<TJobRegister> TJobRegisters { get; set; } = null!;
        public virtual DbSet<TRoleSetup> TRoleSetups { get; set; } = null!;
        public virtual DbSet<TSysUser> TSysUsers { get; set; } = null!;
        public virtual DbSet<TUser> TUsers { get; set; } = null!;
        public virtual DbSet<TUserMenu> TUserMenus { get; set; } = null!;
        public virtual DbSet<TUserRole> TUserRoles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=erpprd)(PORT=1525))(CONNECT_DATA=(SERVICE_NAME=hrdpdb)));User Id=hr_job_app;Password=hr_job_it;;Persist Security Info=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("HR_JOB_APP")
                .UseCollation("USING_NLS_COMP");

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
                    .HasName("T_JOB_CMNMENUPERMISSION_PK");

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
                    .HasDefaultValueSql("0")
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

            modelBuilder.Entity<TJobAppAcaQualification>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_JOB_APP_ACA_QUALIFICATION");

                entity.Property(e => e.Oid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OID");

                entity.Property(e => e.ApplicantOid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("APPLICANT_OID");

                entity.Property(e => e.Board)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOARD");

                entity.Property(e => e.Degree)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEGREE");

                entity.Property(e => e.Institution)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INSTITUTION");

                entity.Property(e => e.Major)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MAJOR");

                entity.Property(e => e.Passingyear)
                    .HasColumnType("NUMBER(20)")
                    .HasColumnName("PASSINGYEAR");

                entity.Property(e => e.Result)
                    .HasColumnType("NUMBER(4,2)")
                    .HasColumnName("RESULT");

                entity.HasOne(d => d.ApplicantO)
                    .WithMany(p => p.TJobAppAcaQualifications)
                    .HasForeignKey(d => d.ApplicantOid)
                    .HasConstraintName("FK_T_JOB_APP_ACA_QUALIFICATION_APPLICANT_OID");
            });

            modelBuilder.Entity<TJobAppAddress>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_JOB_APP_ADDRESS");

                entity.Property(e => e.Oid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OID");

                entity.Property(e => e.ApplicantOid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("APPLICANT_OID");

                entity.Property(e => e.ParmAddDistrict)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PARM_ADD_DISTRICT");

                entity.Property(e => e.ParmAddDivision)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PARM_ADD_DIVISION");

                entity.Property(e => e.ParmAddPostOffice)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PARM_ADD_POST_OFFICE");

                entity.Property(e => e.ParmAddThana)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PARM_ADD_THANA");

                entity.Property(e => e.ParmAddVillage)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PARM_ADD_VILLAGE");

                entity.Property(e => e.PersAddDistrict)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERS_ADD_DISTRICT");

                entity.Property(e => e.PresAddDivision)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRES_ADD_DIVISION");

                entity.Property(e => e.PresAddPostOffice)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRES_ADD_POST_OFFICE");

                entity.Property(e => e.PresAddThana)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRES_ADD_THANA");

                entity.Property(e => e.PresAddVillage)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRES_ADD_VILLAGE");

                entity.HasOne(d => d.ApplicantO)
                    .WithMany(p => p.TJobAppAddresses)
                    .HasForeignKey(d => d.ApplicantOid)
                    .HasConstraintName("FK_T_JOB_APP_ADDRESS_APPLICANT_OID");
            });

            modelBuilder.Entity<TJobAppApplicantForm>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_JOB_APP_APPLICANT_FORM");

                entity.Property(e => e.Oid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OID");

                entity.Property(e => e.AppliedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPLIED_BY");

                entity.Property(e => e.AppliedPost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPLIED_POST");

                entity.Property(e => e.ApplyDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPLY_DATE");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIRTH_PLACE");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BLOOD_GROUP");

                entity.Property(e => e.CompanyDeptPost)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_DEPT_POST");

                entity.Property(e => e.CompanyDeptPostActiveStatus)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_DEPT_POST_ACTIVE_STATUS");

                entity.Property(e => e.CompanyDeptPostOpenDate)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_DEPT_POST_OPEN_DATE");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_NAME");

                entity.Property(e => e.CvId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CV_ID");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_OF_BIRTH");

                entity.Property(e => e.Department)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.ExpectedSelery)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXPECTED_SELERY");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FATHER_NAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.ImageId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("IMAGE_ID");

                entity.Property(e => e.InterviewDate)
                    .HasColumnType("DATE")
                    .HasColumnName("INTERVIEW_DATE");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("JOB_TITLE");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MARITAL_STATUS");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE_NUMBER");

                entity.Property(e => e.MotherName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOTHER_NAME");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Nid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NID");

                entity.Property(e => e.ProbablyJoiningDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PROBABLY_JOINING_DATE");

                entity.Property(e => e.Religion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RELIGION");

                entity.Property(e => e.SignatureId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SIGNATURE_ID");

                entity.Property(e => e.SpouseName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPOUSE_NAME");
            });

            modelBuilder.Entity<TJobAppCircular>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_JOB_APP_CIRCULAR");

                entity.Property(e => e.Oid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OID");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_STATUS");

                entity.Property(e => e.CircularEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CIRCULAR_END_DATE");

                entity.Property(e => e.CircularStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CIRCULAR_START_DATE");

                entity.Property(e => e.CompanyDeptPost)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_DEPT_POST");

                entity.Property(e => e.CompanyDeptPostActiveStatus)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_DEPT_POST_ACTIVE_STATUS");

                entity.Property(e => e.CompanyDeptPostOpenDate)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_DEPT_POST_OPEN_DATE");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_NAME");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_NAME");

                entity.Property(e => e.JobDescription)
                    .HasColumnType("CLOB")
                    .HasColumnName("JOB_DESCRIPTION");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("JOB_TITLE");

                entity.Property(e => e.Post)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("POST");
            });

            modelBuilder.Entity<TJobAppCv>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_JOB_APP_CV");

                entity.Property(e => e.Oid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OID");

                entity.Property(e => e.Cv)
                    .HasColumnType("BLOB")
                    .HasColumnName("CV");

                entity.Property(e => e.CvName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CV_NAME");
            });

            modelBuilder.Entity<TJobAppExperience>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_JOB_APP_EXPERIENCE");

                entity.Property(e => e.Oid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OID");

                entity.Property(e => e.ApplicantOid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("APPLICANT_OID");

                entity.Property(e => e.DefaultProduct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_PRODUCT");

                entity.Property(e => e.JobLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JOB_LOCATION");

                entity.Property(e => e.Organization)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORGANIZATION");

                entity.Property(e => e.Post)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POST");

                entity.Property(e => e.ReportingTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REPORTING_TO");

                entity.Property(e => e.Salary)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SALARY");

                entity.HasOne(d => d.ApplicantO)
                    .WithMany(p => p.TJobAppExperiences)
                    .HasForeignKey(d => d.ApplicantOid)
                    .HasConstraintName("FK_T_JOB_APP_EXPERIENCE_APPLICANT_OID");
            });

            modelBuilder.Entity<TJobAppImage>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_JOB_APP_IMAGE");

                entity.Property(e => e.Oid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OID");

                entity.Property(e => e.Image)
                    .HasColumnType("BLOB")
                    .HasColumnName("IMAGE");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<TJobAppRegister>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_JOB_APP_REGISTER");

                entity.Property(e => e.Oid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE_NUMBER");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.RefreshToken)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("REFRESH_TOKEN");

                entity.Property(e => e.RefreshTokenExpireTime)
                    .HasColumnType("DATE")
                    .HasColumnName("REFRESH_TOKEN_EXPIRE_TIME");

                entity.Property(e => e.Role)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROLE");

                entity.Property(e => e.Token)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TOKEN");
            });

            modelBuilder.Entity<TJobAppSignature>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("T_JOB_APP_SIGNATURE");

                entity.Property(e => e.Oid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OID");

                entity.Property(e => e.Signature)
                    .HasColumnType("BLOB")
                    .HasColumnName("SIGNATURE");

                entity.Property(e => e.SignatureName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SIGNATURE_NAME");
            });

            modelBuilder.Entity<TJobApplicantAcaQualification>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_JOB_APPLICANT_ACA_QUALIFICATION_PK");

                entity.ToTable("T_JOB_APPLICANT_ACA_QUALIFICATION");

                entity.Property(e => e.Oid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.AcdmicqlfCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ACDMICQLF_CODE");

                entity.Property(e => e.ApplicantOid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("APPLICANT_OID");

                entity.Property(e => e.Board)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOARD");

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

                entity.Property(e => e.Degree)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEGREE");

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

                entity.Property(e => e.Institution)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INSTITUTION");

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

                entity.Property(e => e.Major)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MAJOR");

                entity.Property(e => e.Passingyear)
                    .HasColumnType("NUMBER(20)")
                    .HasColumnName("PASSINGYEAR");

                entity.Property(e => e.Result)
                    .HasColumnType("NUMBER(4,2)")
                    .HasColumnName("RESULT");

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

            modelBuilder.Entity<TJobApplicantDocument>(entity =>
            {
                entity.HasKey(e => e.Documentid)
                    .HasName("T_JOB_APPLICANT_DOCUMENT_PK");

                entity.ToTable("T_JOB_APPLICANT_DOCUMENT");

                entity.Property(e => e.Documentid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
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

                entity.Property(e => e.File)
                    .HasColumnType("BLOB")
                    .HasColumnName("FILE");

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

            modelBuilder.Entity<TJobApplicantExperience>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_JOB_APPLICANT_EXPERIENCE_PK");

                entity.ToTable("T_JOB_APPLICANT_EXPERIENCE");

                entity.Property(e => e.Oid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ApplicantOid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("APPLICANT_OID");

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

                entity.Property(e => e.DefaultProduct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_PRODUCT");

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

                entity.Property(e => e.Experienceid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EXPERIENCEID");

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

                entity.Property(e => e.JobLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JOB_LOCATION");

                entity.Property(e => e.Organization)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORGANIZATION");

                entity.Property(e => e.Post)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POST");

                entity.Property(e => e.ReportingTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REPORTING_TO");

                entity.Property(e => e.Salary)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SALARY");

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

            modelBuilder.Entity<TJobApplicantMaster>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_JOB_APPLICANT_MASTER_PK");

                entity.ToTable("T_JOB_APPLICANT_MASTER");

                entity.Property(e => e.Oid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.ApplicantCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPLICANT_CODE");

                entity.Property(e => e.AppliedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPLIED_BY");

                entity.Property(e => e.AppliedPost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPLIED_POST");

                entity.Property(e => e.ApplyDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPLY_DATE");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIRTH_PLACE");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BLOOD_GROUP");

                entity.Property(e => e.CompanyDeptPost)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_DEPT_POST");

                entity.Property(e => e.CompanyDeptPostActiveStatus)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_DEPT_POST_ACTIVE_STATUS");

                entity.Property(e => e.CompanyDeptPostOpenDate)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_DEPT_POST_OPEN_DATE");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_NAME");

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

                entity.Property(e => e.CvPath)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CV_PATH");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_OF_BIRTH");

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
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.ExpectedSelery)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXPECTED_SELERY");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FATHER_NAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");

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

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("JOB_TITLE");

                entity.Property(e => e.Jobid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JOBID");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MARITAL_STATUS");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE_NUMBER");

                entity.Property(e => e.MotherName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOTHER_NAME");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Nid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NID");

                entity.Property(e => e.ParAddDistrict)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PAR_ADD_DISTRICT");

                entity.Property(e => e.ParAddDivision)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PAR_ADD_DIVISION");

                entity.Property(e => e.ParAddPostOffice)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PAR_ADD_POST_OFFICE");

                entity.Property(e => e.ParAddThana)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PAR_ADD_THANA");

                entity.Property(e => e.ParAddVillage)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PAR_ADD_VILLAGE");

                entity.Property(e => e.PerAddDistrict)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PER_ADD_DISTRICT");

                entity.Property(e => e.Post)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POST");

                entity.Property(e => e.PreAddDivision)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRE_ADD_DIVISION");

                entity.Property(e => e.PreAddPostOffice)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRE_ADD_POST_OFFICE");

                entity.Property(e => e.PreAddThana)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRE_ADD_THANA");

                entity.Property(e => e.PreAddVillage)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRE_ADD_VILLAGE");

                entity.Property(e => e.Religion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RELIGION");

                entity.Property(e => e.SignaturePath)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("SIGNATURE_PATH");

                entity.Property(e => e.SpouseName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPOUSE_NAME");

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

            modelBuilder.Entity<TJobCmnmenu>(entity =>
            {
                entity.HasKey(e => e.Menuid)
                    .HasName("T_JOB_CMNMENU_PK");

                entity.ToTable("T_JOB_CMNMENU");

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

            modelBuilder.Entity<TJobEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_JOB_EMPLOYEE");

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

                entity.Property(e => e.EmpId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMP_ID");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("1\n   ")
                    .IsFixedLength();

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDELETE")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

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

            modelBuilder.Entity<TJobRegister>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_JOB_REGISTER_PK");

                entity.ToTable("T_JOB_REGISTER");

                entity.Property(e => e.Oid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OID");

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
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETEON");

                entity.Property(e => e.Deletepc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETEPC");

                entity.Property(e => e.Department)
                    .HasMaxLength(60)
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

                entity.Property(e => e.Empid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMPID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Isactive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISACTIVE");

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ISDELETE");

                entity.Property(e => e.Isreg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISREG");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
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
                    .HasMaxLength(50)
                    .IsUnicode(false)
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
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDELETE")
                    .HasDefaultValueSql("0")
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

            modelBuilder.Entity<TSysUser>(entity =>
            {
                entity.HasKey(e => e.Sysid)
                    .HasName("T_JOB_SYS_USER_PK");

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
                    .HasDefaultValueSql("1")
                    .IsFixedLength();

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDELETE")
                    .HasDefaultValueSql("0")
                    .IsFixedLength();

                entity.Property(e => e.Issys)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISSYS")
                    .HasDefaultValueSql("0\n   ")
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

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("T_USER_PK");

                entity.ToTable("T_USER");

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
                    .HasName("T_USER_MENU_PK");

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
                    .HasDefaultValueSql("1\n   ")
                    .IsFixedLength();

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDELETE")
                    .HasDefaultValueSql("0")
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

            modelBuilder.HasSequence("SEQ_ADDESS_OID");

            modelBuilder.HasSequence("SEQ_ADDRESSES_OID");

            modelBuilder.HasSequence("SEQ_APPLICANTS_OID");

            modelBuilder.HasSequence("SEQ_EXPERIENCE_OID");

            modelBuilder.HasSequence("SEQ_EXPERIENCES_OID");

            modelBuilder.HasSequence("SEQ_OID");

            modelBuilder.HasSequence("SEQ_QULIFICATION_OID");

            modelBuilder.HasSequence("SEQ_QULIFICATIONS_OID");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
