using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traveling.Models
{
    public class Geography
    {

        public Geography()
        {
            Destinations = new HashSet<Destination>();
        }

        public int Id { get; set; }
        public string Country { get; set; }
        public string Continent { get; set; }
        public ICollection<Destination> Destinations { get; set; } 

    }
}