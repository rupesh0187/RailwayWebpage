using System.ComponentModel.DataAnnotations;

namespace RailwayWebpage.Models.Railway
{
    public class From
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
