using System.ComponentModel.DataAnnotations;

namespace RailwayWebpage.Models.Railway
{
    public class Seat
    {
        
            [Key]
            public int Id { get; set; }
            public string? Name { get; set; }


        
    }
}
