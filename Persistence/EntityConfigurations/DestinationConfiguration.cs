using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Traveling.Core.Domain;

namespace Traveling.Persistence.EntityConfigurations
{
    public class DestinationConfiguration : EntityTypeConfiguration<Destination>
    {
        // configurations are set within the constructor
        public DestinationConfiguration()
        {
            // table configs, primary keys, properties(?), relationships//
            Property(destination => destination.Name)
                .IsRequired()
                .HasMaxLength(60);

            Property(d => d.Description)
                .IsRequired()
                .HasMaxLength(190);

            Property(d => d.DateAdded)
                .IsOptional();

            //HasMany(d => d.Categories) // has many categories
            //    .WithMany(categories => categories.Destinations)
            //    .Map(mapping =>
            //    {
            //        mapping.ToTable("LocationCategories");
            //        mapping.MapLeftKey("DestinationId");
            //        mapping.MapRightKey("CategoryId");
            //    });

            HasRequired(d => d.Category)
                .WithMany(c => c.Destinations)
                .HasForeignKey(d => d.CategoryId)
                .WillCascadeOnDelete(false);

            //HasRequired(d => d.Geography)// each destination has a geography
            //    .WithMany(g => g.Destinations)// each geography has many destinations
            //    .HasForeignKey(d => d.GeographyId)// the foreign key is...
            //    .WillCascadeOnDelete(false);

            //HasOptional(d => d.Geography)// each destination has a geography
            //    .WithMany(g => g.Destinations)// each geography has many destinations
            //    .HasForeignKey(d => d.GeographyId)// the foreign key is...
            //    .WillCascadeOnDelete(false);


        }
    }
}