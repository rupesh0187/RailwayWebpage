using System.ComponentModel.DataAnnotations;

namespace RailwayWebpage.Models.Railway
{
    public class TPrice
    {
        
        public int Id { get; set; }
        public float Price { get; set; }
        public TrainName TrainName { get; set; }
    }
}
