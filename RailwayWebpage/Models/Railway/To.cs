using System.ComponentModel.DataAnnotations;

namespace RailwayWebpage.Models.Railway
{
    public class To
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public From From { get; set; }
    }
}
