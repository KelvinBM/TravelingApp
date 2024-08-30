using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Traveling.Core.Domain;

namespace Traveling.Persistence.EntityConfigurations
{
    public class GeographyConfiguration : EntityTypeConfiguration<Geography>
    {
        
        public GeographyConfiguration()
        {
            Property(g => g.Country)
                .IsRequired();

            Property(g => g.Continent)
                .IsRequired();

            //HasMany(g => g.Destinations) // I set this relationship on the DestionationConfiguration
            //    .WithRequired(d => d.Geography)
            //    .HasForeignKey(d => d.GeographyId)
            //    .WillCascadeOnDelete(false);
        }
    }
}