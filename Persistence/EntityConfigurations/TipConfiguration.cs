using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Traveling.Core.Domain;

namespace Traveling.Persistence.EntityConfigurations
{
    public class TipConfiguration : EntityTypeConfiguration<Tip>
    {
        public TipConfiguration()
        {

            Property(tip => tip.Title)
                .IsRequired()
                .HasMaxLength(35);// may need to be changed

            Property(t => t.TipText)
                .IsRequired()
                .HasMaxLength(90);// may need to be changed
        }
    }
}