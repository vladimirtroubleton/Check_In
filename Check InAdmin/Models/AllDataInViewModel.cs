using AuthDataLayer.Models;
using QuestionDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Check_InAdmin.Models
{
    public class AllDataInViewModel
    {
        public QuestionModel[] Questions { get; set; }
        public UserModel[] Users { get; set; }
        public GroupModel[] Groups { get; set; }
    }
}
