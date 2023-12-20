using System.ComponentModel.DataAnnotations;

namespace RailwayWebpage.Models.Railway
{
    public class PassengerDetails
    {
        [Key]
        public int PId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public long Phoneno { get; set; }
        public string PName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Berth { get; set; }
        public float Amount { get; set; }
        public long CardNumber { get; set; }
        public string CardName { get; set; }
        public int CMonth { get; set; }
        public int CYear { get; set; }
        public int Cvno { get; set; }
    }
}
