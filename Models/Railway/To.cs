using System.ComponentModel.DataAnnotations;

namespace RailwayWebpage.Models.Railway
{
    public class To
    {
        [Key]
        public int TId { get; set; }
        public string TName { get; set; }
        public From From { get; set; }
    }
}
