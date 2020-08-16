using Microsoft.EntityFrameworkCore;
using EFDemo.Model;
using Microsoft.Extensions.Logging;

namespace EFDemo.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(loggerFactory)
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Demo");
        }
        public DbSet<Leagure> Leagures { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }

        private readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
                builder.AddFilter((category, level)=>
                    category==DbLoggerCategory.Database.Command.Name&&level==LogLevel.Information)
                       .AddConsole());
    }
}
