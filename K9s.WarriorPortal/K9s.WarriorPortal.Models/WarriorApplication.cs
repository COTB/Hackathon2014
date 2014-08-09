using System;
using System.ComponentModel.DataAnnotations;
using K9s.WarriorPortal.Models.Enum;

namespace K9s.WarriorPortal.Models
{
    public class WarriorApplication
    {
        [Key]
        public int WarriorApplicationID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string MaidenName { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        public string Apartment { get; set; }

        [Required]
        public string City { get; set; }

        public string County { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string ZipCode { get; set; }

        [Required]
        public string HomePhone { get; set; }

        public string AltPhone { get; set; }

        public string Email { get; set; }

        public string GovernmentID { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public string SignificantOtherName { get; set; }

        public string SignificantOtherEmail { get; set; }

        public string SignificantOtherPhone { get; set; }

        public string MilitaryServiceBranch { get; set; }

        [Required]
        public DateTime DateOfServiceFrom { get; set; }

        [Required]
        public DateTime DateOfServiceTo { get; set; }

        public string ServiceLocation { get; set; }

        public string Rank { get; set; }

        public string Rate { get; set; }

        public string DischargeType { get; set; }

        public MedicalBoardReview MedicalBoardReview { get; set; }

        public string EducationalDegrees { get; set; }

        public string Bio { get; set; }
    }
}
