using AuthDataLayer.Models;
using EventsDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Check_InAdmin.Models
{
    public class EventViewModel
    {
        public UserModel[] UsersActivate { get; set; }
        public UserModel[] UsersNoActivate { get; set; }
        public GroupModel Group { get; set; }
        public EventModel Event { get; set; }
        public int CountActiveUsers { get; set; }
    }
}
