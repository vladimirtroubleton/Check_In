using System;
using System.Collections.Generic;
using System.Text;

namespace AuthDataLayer.ViewModels
{
    public class GroupViewModel
    {
        public Guid GroupId { get; set; }
        public string[] Users { get; set; }
    }
}
