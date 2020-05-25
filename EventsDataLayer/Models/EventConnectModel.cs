using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EventsDataLayer.Models
{
    public class EventConnectModel
    {
        [Key]
        public int ConnectId { get; set; }
        public Guid GroupId { get; set; }
        public int EventId { get; set; }
        public string UserLogin { get; set; }
    }
}
