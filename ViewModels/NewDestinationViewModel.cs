using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Traveling.Core.Domain;

namespace Traveling.ViewModels
{
    public class NewDestinationViewModel
    {
        public IEnumerable<TravelCategory> Categories { get; set; }
        public Destination Destination { get; set; }// or can explicitly add properties from this class in place of this line --> useful for modifying models
    }
}