using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobAppApplicantForm
    {
        public TJobAppApplicantForm()
        {
            TJobAppAcaQualifications = new HashSet<TJobAppAcaQualification>();
            TJobAppAddresses = new HashSet<TJobAppAddress>();
            TJobAppExperiences = new HashSet<TJobAppExperience>();
        }

        public decimal Oid { get; set; }
        public string? MobileNumber { get; set; }
        public string? Name { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public string? Nid { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? BirthPlace { get; set; }
        public string? Religion { get; set; }
        public string? BloodGroup { get; set; }
        public string? Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public string? SpouseName { get; set; }
        public string? Email { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string? AppliedPost { get; set; }
        public DateTime? ProbablyJoiningDate { get; set; }
        public string? ExpectedSelery { get; set; }
        public string? AppliedBy { get; set; }
        public string? Department { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string? CompanyName { get; set; }
        public string? JobTitle { get; set; }
        public string? CompanyDeptPost { get; set; }
        public string? CompanyDeptPostOpenDate { get; set; }
        public string? CompanyDeptPostActiveStatus { get; set; }
        public decimal? ImageId { get; set; }
        public decimal? SignatureId { get; set; }
        public decimal? CvId { get; set; }

        public virtual ICollection<TJobAppAcaQualification> TJobAppAcaQualifications { get; set; }
        public virtual ICollection<TJobAppAddress> TJobAppAddresses { get; set; }
        public virtual ICollection<TJobAppExperience> TJobAppExperiences { get; set; }
    }
}
