using Common.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Plain> Plains { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<ConnecedStation> ConnectedStations { get; set; }
    }
}
