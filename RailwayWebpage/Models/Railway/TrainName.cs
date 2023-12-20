using System.ComponentModel.DataAnnotations;

namespace RailwayWebpage.Models.Railway
{
    public class TrainName
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public To To { get; set; }
    }
}
