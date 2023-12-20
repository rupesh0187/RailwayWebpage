using System.ComponentModel.DataAnnotations;

namespace RailwayWebpage.Models.Railway
{
    public class From
    {
        [Key]
        public int FId { get; set; }
        public string FName { get; set; }
    }
}
