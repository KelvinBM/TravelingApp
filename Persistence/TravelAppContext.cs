using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Traveling.Core.Domain;
using Traveling.Persistence.EntityConfigurations;

namespace Traveling.Persistence
{
    public class TravelAppContext : DbContext
    {

        public TravelAppContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Geography> Geographies { get; set; }
        public DbSet<Tip> Tips { get; set; }
        public DbSet<TravelCategory> TravelCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder); // not required for configurations since they are located in separate files
            modelBuilder.Configurations.Add(new DestinationConfiguration())
                .Add(new GeographyConfiguration())
                .Add(new TipConfiguration())
                .Add(new TravelCategoryConfiguration());
            
        }
    }
}