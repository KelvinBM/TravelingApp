using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traveling.Dtos
{
    public class DestinationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public TravelCategoryDto CategoryDto { get; set; }
        public DateTime? DateAdded { get; set; }
        public string Image { get; set; }
    }
}