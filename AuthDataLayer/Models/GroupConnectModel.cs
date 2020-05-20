using System;
using System.Collections.Generic;
using System.Text;

namespace AuthDataLayer.Models
{
    public class GroupConnectModel
    {
        public int Id { get; set; }

        public Guid GroupId { get; set; }
        public string UserLogin { get; set; }
    }
}
