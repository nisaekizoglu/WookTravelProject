using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WookTravelProject.Entities
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }

        public string Title { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public int DayNight { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Capacity { get; set; }
        public DateTime CreatedAt { get; set; }

}
}