using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Infrastructure
{
    public class AMContextcs :DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers {  get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs{ get; set; }
        public DbSet<Traveller> Traverllers{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
Initial Catalog=AirportManagement-Molka;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
