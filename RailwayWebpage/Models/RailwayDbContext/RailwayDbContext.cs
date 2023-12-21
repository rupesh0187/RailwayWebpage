using Microsoft.EntityFrameworkCore;
using RailwayWebpage.Models.Railway;

namespace RailwayWebpage.Models.RailwayDbContext
{
    public class RailwayDbContext :DbContext
    {
        public RailwayDbContext(DbContextOptions options) :base(options) 
        {

        }
        public DbSet<LoginPage> loginPages { get; set; }
        public DbSet<RegisterPage> registerPages { get; set; }
        public DbSet<From> froms { get; set; }
        public DbSet<To> tos { get; set; }
        public DbSet<TrainName> trainnames { get; set; }

        public DbSet<Seat> seats { get; set; }
        public DbSet<Price> prices { get; set; }

        public DbSet<PassengerDetails> passengerdetailes { get; set; }
    }
}
