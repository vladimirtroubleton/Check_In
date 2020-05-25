using AuthDataLayer.Models;
using Check_InAdmin.Models;
using QuestionDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Check_InAdmin.ModelBuilders
{
    public class DataInViewModelBuilder : IDataInViewModelBuilder
    {
        public AllDataInViewModel GetViewData(UserModel[] users, GroupModel[] groups)
        {
            return new AllDataInViewModel
            {
                Users = users,
                Groups = groups
            };
        }
    }
}
