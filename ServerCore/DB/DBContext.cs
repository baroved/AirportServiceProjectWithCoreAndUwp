using Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerCore.DB
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plane>().HasData(
        new Plane
        {
            Id = 1,
            ReadyToMove = true
        },
        new Plane
        {
            Id = 2,
            ReadyToMove = true
        },
        new Plane
        {
            Id = 3,
            ReadyToMove = false
        },
        new Plane
        {
            Id = 4,
            ReadyToMove = true
        },
        new Plane
        {
            Id = 5,
            ReadyToMove = false
        }
    );



            modelBuilder.Entity<Station>().HasData(
               new Station
               {
                   Id = 1,
                   IsAvailable = true
                   
               },
               new Station
               {
                   Id = 2,
                   IsAvailable = true
                   
               },
               new Station
               {
                   Id = 3,
                   IsAvailable = true
                   
               },
               new Station
               {
                   Id = 4,
                   IsAvailable = true
                   
               },
               new Station
               {
                   Id = 5,
                   IsAvailable = true
                   
               }
            );
            modelBuilder.Entity<ConnecedStation>().HasData(
                new ConnecedStation
                {
                    Id = 1,
                    FromStationID = 1,
                    ToStationID = 2
                },
                new ConnecedStation
                {
                    Id = 2,
                    FromStationID = 2,
                    ToStationID = 3
                },
                new ConnecedStation
                {
                    Id = 3,
                    FromStationID = 1,
                    ToStationID = 4
                },
                new ConnecedStation
                {
                    Id = 4,
                    FromStationID = 4,
                    ToStationID = 5
                }
                );



            modelBuilder.Entity<EstimatedLanding>().HasData(
               new EstimatedLanding
               {
                   Id = 1,
                   EstimatedTime = DateTime.Now.AddMinutes(40),
                   FlightNum=123,
                   PlaneID=1
                   
               },
               new EstimatedLanding
               {
                   Id = 2,
                   EstimatedTime = DateTime.Now.AddMinutes(30),
                   FlightNum = 103,
                   PlaneID = 2
               },
               new EstimatedLanding
               {
                   Id = 3,
                   EstimatedTime = DateTime.Now.AddMinutes(20),
                   FlightNum = 023,
                   PlaneID = 3
               }
              
               );



            modelBuilder.Entity<EstimatedTakeOff>().HasData(
              new EstimatedLanding
              {
                  Id = 1,
                  EstimatedTime = DateTime.Now.AddMinutes(5),
                  FlightNum = 222,
                  PlaneID = 4

              },
              new EstimatedTakeOff
              {
                  Id = 2,
                  EstimatedTime = DateTime.Now.AddMinutes(10),
                  FlightNum = 111,
                  PlaneID = 5
              }
             

              );
        }


        public DbSet<Plane> Planes { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<ConnecedStation> ConnectedStations { get; set; }
    }
}
