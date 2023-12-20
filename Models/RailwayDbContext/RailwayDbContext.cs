using Microsoft.EntityFrameworkCore;
using RailwayWebpage.Models.Railway;

namespace RailwayWebpage.Models.RailwayDbContext
{
    public class RailwayDbContext :DbContext
    {
        public RailwayDbContext(DbContextOptions options) :base(options) 
        {

        }
        public DbSet<LoginPage> LoginPages { get; set; }
        public DbSet<RegisterPage> RegisterPages { get; set; }
        public DbSet<From> froms { get; set; }
        public DbSet<To> tos { get; set; }
        public DbSet<TrainName> trainnames { get; set; }
        public DbSet<TClass> tclasses { get; set; }
        public DbSet<TPrice> tprices { get; set; }
        public DbSet<PassengerDetails> passengerdetailes { get; set; }
    }
}
