using System;
using System.ComponentModel.DataAnnotations;

namespace StudentCampusPortal.Models
{
    public class ServiceRequest
    {
        public int RequestId { get; set; }

        [Required(ErrorMessage = "Student name is required")]
        [StringLength(100)]
        public string StudentName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Department is required")]
        [StringLength(100)]
        public string Department { get; set; } = string.Empty;

        [Required(ErrorMessage = "Service type is required")]
        [StringLength(100)]
        public string ServiceType { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Priority { get; set; } = "Medium";

        public string Status { get; set; } = "Pending";

        public DateTime RequestDate { get; set; } = DateTime.Now;
    }
}
