using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer;

public class AirlineContext : DbContext
{
    public DbSet<Airline> Airlines { get; set; }
    public DbSet<Pilot> Pilots { get; set; }
    public DbSet<CabinMember> CabinMembers { get; set; }
    public DbSet<Flight> Flights { get; set; }
    //
    public DbSet<PassengerInfo> PassengerInfos { get; set; }
    //
    public DbSet<Airplane> Airplanes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=.\SQLExpress;Initial Catalog=Spec_Airline;Integrated Security=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Flight>().HasOne(f => f.Pilot).WithMany(p => p.PilotFlights).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Flight>().HasOne(f => f.CoPilot).WithMany(cp => cp.CoPilotFlights).OnDelete(DeleteBehavior.Restrict);
        #region error
        /*
        'Introducing FOREIGN KEY constraint 'FK_Flights_Pilots_PilotId' on table 'Flights' may cause cycles or multiple cascade paths. 
         Specify ON DELETE NO ACTION or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints
         Could not create constraint or index. See previous errors.'
         */
        #endregion
        //modelBuilder.Entity<Flight>().
    }
}
