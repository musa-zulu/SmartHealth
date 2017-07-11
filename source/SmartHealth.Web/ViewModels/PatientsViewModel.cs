using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartHealth.Web.ViewModels
{
    public class PatientsViewModel : ViewModelBase
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        [DisplayName("Home Adress")]
        public string HomeAddress { get; set; }
        [DisplayName("Work Adress")]
        public string WorkAddress { get; set; }
        [DisplayName("Home Number")]
        public long HomeNumber { get; set; }
        [DisplayName("Work Number")]
        public long WorkNumber { get; set; }
        [DisplayName("Cell phone")]
        public long CellPhone { get; set; }
    }
}