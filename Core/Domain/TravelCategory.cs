using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traveling.Core.Domain
{
    public class TravelCategory
    {

        public TravelCategory()
        {
            Destinations = new HashSet<Destination>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Destination> Destinations { get; set; } 

    }
}