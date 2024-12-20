using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WookTravelProject.Entities;
using System.Data.Entity;

namespace WookTravelProject.Context
{
    public class TravelContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Destination> Destinations { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<Message> Messages { get; set; }
    }
}