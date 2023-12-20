using System.ComponentModel.DataAnnotations;

namespace RailwayWebpage.Models.Railway
{
    public class LoginPage
    {
        [Key]
        public int LId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public RegisterPage RegisterPage { get; set; }
    }
}
