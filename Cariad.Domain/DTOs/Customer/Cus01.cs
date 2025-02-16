using System.ComponentModel.DataAnnotations;

namespace Cariad.Domain.DTOs.Customer
{
    public class Cus01
    {
        [Required(ErrorMessage = "Name is required")]
        public string CustomerNumber { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Forename { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Initials { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string OccupationStatus { get; set; } = string.Empty;
        public string Occupation { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public string DateOfDeath { get; set; } = string.Empty;
        public string CharityNumber { get; set; } = string.Empty;
        public string SexStatus { get; set; } = string.Empty;
        public string DeliveryChannel { get; set; } = string.Empty;
        public string NationalInsuranceNumber { get; set; } = string.Empty;
        public string MaritalStatus { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public DateTime AccountOpeningDate { get; set; }
        public string CharitableAssignement { get; set; } = string.Empty;
        public string MembershipLength { get; set; } = string.Empty;
        public bool IsPbsEmpoloyee { get; set; }
        public string Street { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string Town { get; set; } = string.Empty;
        public string County { get; set; } = string.Empty;
        public string Postcode { get; set; } = string.Empty;
        public string HomeTelephoneNumber { get; set; } = string.Empty;
        public string MobileTelephoneNumber { get; set; } = string.Empty;
        public string WorkTelephoneNumber { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string EmailAddress { get; set; } = string.Empty;
        public string MobileAuthorisationDate { get; set; } = string.Empty;
        public bool HasForeignAddress { get; set; }
        public bool IsAddressKnown { get; set; }
        public bool HasMailshotsAllowed { get; set; }
        public bool HasWelshMailshows { get; set; }
        public bool IsEmailsAllowed { get; set; }
        public bool IsTelephoneAllowed { get; set; }
        public bool IsSmsAllowed { get; set; }
        public bool HasMembersRewards { get; set; }
        public bool IsMarketingPreferencesUpToDate { get; set; }
        public string CountryOfBirth { get; set; } = string.Empty;
        public string BirthPlace { get; set; } = string.Empty;
        public string ResidenceCountryCode { get; set; } = string.Empty;
        public bool IsTaxResidentOutsideUK { get; set; }
        public bool IsAUSCitizen { get; set; }
        public string TaxResidencyCountry1 { get; set; } = string.Empty;
        public string TaxResidencyCountry2 { get; set; } = string.Empty;
        public string TaxResidencyCountry3 { get; set; } = string.Empty;
        public string TinNumber1 { get; set; } = string.Empty;
        public string TinNumber2 { get; set; } = string.Empty;
        public string TinNumber3 { get; set; } = string.Empty;
        public string IdName1 { get; set; } = string.Empty;
        public string IdName1Additional { get; set; } = string.Empty;
        public string IdName2 { get; set; } = string.Empty;
        public string IdName2Additional { get; set; } = string.Empty;
        public string IdAddress1 { get; set; } = string.Empty;
        public string IdAddress1Additional { get; set; } = string.Empty;
        public string IdAddress2 { get; set; } = string.Empty;
        public string IdAddress2Additional { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; } = string.Empty;
        public DateTime LastInteractionDate { get; set; }
    }
}
