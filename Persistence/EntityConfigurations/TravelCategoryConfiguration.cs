using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

using Traveling.Models;

namespace Traveling.Persistence.EntityConfigurations
{
    public class TravelCategoryConfiguration : EntityTypeConfiguration<TravelCategory>
    {
        public TravelCategoryConfiguration()
        {
            Property(travelCategory => travelCategory.Name)
                .IsRequired()
                .HasMaxLength(30);// may need to be changed

            //HasMany(tc => tc.Destinations)
            //    .WithMany(d => d.Categories)
            //    .Map(mapping =>
            //    {
            //        mapping.ToTable("DestinationCategories");
            //        mapping.MapLeftKey("DestinationId");
            //        mapping.MapRightKey("CategoryId");
            //    });
        }
    }
}