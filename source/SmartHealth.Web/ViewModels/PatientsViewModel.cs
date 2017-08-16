using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartHealth.Web.ViewModels
{
    public enum Province
    {
        [Display(Name = "Eastern Cape")]
        EasternCape,
        [Display(Name = "Free State")]
        FreeState,
        [Display(Name = "Gauteng")]
        Gauteng,
        [Display(Name = "KwaZulu-Natal")]
        KwaZuluNatal,
        [Display(Name = "Limpopo")]
        Limpopo,
        [Display(Name = "Mpumalanga")]
        Mpumalanga,
        [Display(Name = "Northern Cape")]
        NorthernCape,
        [Display(Name = "North West")]
        NorthWest,
        [Display(Name = "Western Cape")]
        WesternCape
    }

    public class HomeAddress
    {
        public Guid HomeAddressId { get; set; }
        [DisplayName("Line One")]
        public string AddressLineOne { get; set; }
        [DisplayName("Line Two")]
        public string AddressLineTwo { get; set; }
        [DisplayName("Line Three")]
        public string AddressLineThree { get; set; }
        public string Country { get; set; }
        public Province Province { get; set; }
        public int Code { get; set; }
    }

    public class WorkAddress
    {
        public Guid WorkAddressId { get; set; }
        [DisplayName("Line One")]
        public string AddressLineOne { get; set; }
        [DisplayName("Line Two")]
        public string AddressLineTwo { get; set; }
        [DisplayName("Line Three")]
        public string AddressLineThree { get; set; }
        public string Country { get; set; }
        public Province Province { get; set; }
        public int Code { get; set; }
    }

    public class PatientViewModel : ViewModelBase
    {
        public Guid PatientViewModelId { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }   
        public Guid HomeAddressId { get; set; }
        public HomeAddress HomeAddress { get; set; }        
        public Guid WorkAddressId { get; set; }
        public WorkAddress WorkAddress { get; set; }
        [MaxLength(10)]
        [DisplayName("Home Number")]        
        public long HomeNumber { get; set; }
        [MaxLength(10)]
        [DisplayName("Work Number")]        
        public long WorkNumber { get; set; }
        [MaxLength(10)]
        [DisplayName("Cell phone")]        
        public long CellPhone { get; set; }
    }
}