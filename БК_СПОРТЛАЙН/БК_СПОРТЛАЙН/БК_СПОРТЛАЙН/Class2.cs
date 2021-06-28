using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БК_СПОРТЛАЙН
{
    class Connect : DbContext
    {
        public DbSet<USER> Users { get; set; }
        public DbSet<HistoryFinansy> historyFinansies { get; set; }
        public DbSet<HistoryStavok> historyStavoks { get; set; }
        public DbSet<stavka> staavki { get; set; }
        public Connect() : base("DBConnectionString") { }
    }
}
