using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Web;

namespace Traveling.Core.Domain
{
    public class Destination
    {
        public Destination()
        {
            //Categories = new HashSet<TravelCategory>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //[DisplayName("Travel Category")]// [Display(Name = "Travel Categories)] //
        //public ICollection<TravelCategory> Categories { get; set; }

        public TravelCategory Category { get; set; }
        [DisplayName("Travel Category")]
        public int CategoryId { get; set; }// foreign key
        //public Geography Geography { get; set; }
        //public int GeographyId { get; set; }
        public DateTime? DateAdded { get; set; }
        
        public string Image { get; set; }

        // need to add a column for image link or source //
        
    }
}