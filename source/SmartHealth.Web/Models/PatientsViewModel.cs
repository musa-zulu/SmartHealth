using System;
using System.ComponentModel.DataAnnotations;

namespace SmartHealth.Web.Models
{
    public class PatientsViewModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}