using System.ComponentModel.DataAnnotations;

namespace RailwayWebpage.Models.Railway
{
    public class TrainName
    {
        [Key]
        public int TNId { get; set; }
        public string TNName { get; set; }
        public To To { get; set; }
    }
}
