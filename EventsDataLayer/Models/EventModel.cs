using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDataLayer.Models
{
    public class EventModel
    {
        public int EventId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public Guid GroupId { get; set; }
        public bool Active { get; set; }
    }
}
