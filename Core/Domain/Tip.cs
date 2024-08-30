using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traveling.Core.Domain
{
    public class Tip
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TipText { get; set; }
    }
}