using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AuthDataLayer.Models
{
    public class GroupModel
    {
        public Guid Id { get; set; }
        [Display (Name ="Название группы")]
        public string Name { get; set; }
    }
}
