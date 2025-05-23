﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traveling.Core.Domain;


namespace Traveling.ViewModels
{
    public class HomeViewModel
    {
        //public IEnumerable<Destination> Destinations { get; set; }
        public List<TravelCategory> Categories { get; set; }
        public IEnumerable<Tip> Tips { get; set; }

    }
}