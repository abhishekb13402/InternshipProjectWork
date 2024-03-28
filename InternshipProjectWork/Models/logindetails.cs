using System.ComponentModel.DataAnnotations;

namespace InternshipProjectWork.Models
{
    public class logindetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
