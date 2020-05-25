using AuthDataLayer.Models;
using Check_InAdmin.Models;
using QuestionDataLayer.Models;

namespace Check_InAdmin.ModelBuilders
{
    public interface IDataInViewModelBuilder
    {
        AllDataInViewModel GetViewData(UserModel[] users, GroupModel[] groups);
    }
}