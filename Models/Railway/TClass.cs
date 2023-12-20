using System.ComponentModel.DataAnnotations;

namespace RailwayWebpage.Models.Railway
{
    public class TClass
    {
        [Key]
        public int CId { get; set; }
        public string CName { get; set; }
        public TrainName TrainName { get; set; }
    }
}
