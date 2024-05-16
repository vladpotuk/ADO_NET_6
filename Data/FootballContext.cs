using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ADO_NET_6.Data
{
    public class FootballContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllfootballdb;Database=FootballDb;Trusted_Connection=True;");
        }
    }
}
