using System.ComponentModel.DataAnnotations;

namespace RailwayWebpage.Models.Railway
{
    public class TPrice
    {
        [Key]
        public int PId { get; set; }
        public float Price { get; set; }
        public TClass TClass { get; set; }
    }
}
