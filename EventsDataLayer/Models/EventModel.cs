using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EventsDataLayer.Models
{
    public class EventModel
    {
        [Key]
        public int EventId { get; set; }

        [Display(Name ="Название события")]
        [Required]
        [MinLength(5, ErrorMessage ="Мало букв")]
        public string Title { get; set; }
        [Display(Name = "Описание")]
        [MinLength(5, ErrorMessage = "Мало букв")]
        [Required]
        public string Description { get; set; }
        [Display(Name = "Название группы")]
        [Required]
        public Guid GroupId { get; set; }
        public bool Active { get; set; }
    }
}
