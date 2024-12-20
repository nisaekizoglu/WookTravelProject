using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WookTravelProject.Entities
{
    public class Reservation
    {
        [Key]
        public int ReservationsId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int PersonCount { get; set; }
        public DateTime ReservationsDate { get; set; }
        public string Description { get; set; }
        public int DestinationNameId { get; set; }
    }
}