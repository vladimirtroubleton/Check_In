using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionDataLayer.ViewModels
{
    public class QuestMiniView
    {
        public string GroupName { get; set; }
        public Guid GroupId { get; set; }

        public string[] Questions { get; set; }
    }
}
