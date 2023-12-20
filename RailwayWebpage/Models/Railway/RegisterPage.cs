using System.ComponentModel.DataAnnotations;

namespace RailwayWebpage.Models.Railway
{
    public class RegisterPage
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

    }
}
