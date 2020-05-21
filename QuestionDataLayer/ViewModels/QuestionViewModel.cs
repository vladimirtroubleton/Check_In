using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionDataLayer.ViewModels
{
    public class QuestionViewModel
    {
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }
        public string GroupName { get; set; }
        public Guid GroupId { get; set; }
        public string[] Questions { get; set; }
    }
}
