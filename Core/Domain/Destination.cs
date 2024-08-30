using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traveling.Core.Domain
{
    public class Destination
    {
        public Destination()
        {
            Categories = new HashSet<TravelCategory>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<TravelCategory> Categories { get; set; }
        public Geography Geography { get; set; }
        public int GeographyId { get; set; }
        public DateTime? DateAdded { get; set; }
        
    }
}