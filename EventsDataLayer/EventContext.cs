using EventsDataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDataLayer
{
    public class EventContext : DbContext
    {
        public DbSet<EventModel> Events { get; set; }
        public DbSet<EventConnectModel> EventsConnect { get; set; }

        public EventContext(DbContextOptions<EventContext> dbContextOptions):base(dbContextOptions)
        {
            Database.EnsureCreated();
        }
    }
}
