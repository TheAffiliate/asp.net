using System.ComponentModel.DataAnnotations;

namespace PROG6212.Models
{
    public class ClaimFormModel
    {
        // Personal Details
        [Required]
        public string LecturerName { get; set; }

        [Required]
        public string LecturerSurname { get; set; }

        [Required]
        public string EmployeeNo { get; set; }

        [Required]
        public string ContactDetails { get; set; }

        // Claim Details
        [Required]
        public string Module { get; set; }

        [Required]
        public string Programme { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid number of hours")]
        public int NumberOfHours { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid hourly rate")]
        public decimal HourlyRate { get; set; }
    }
}
