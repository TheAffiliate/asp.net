using System.ComponentModel.DataAnnotations;

namespace PROG6212.Models
{
    public class LogInModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
