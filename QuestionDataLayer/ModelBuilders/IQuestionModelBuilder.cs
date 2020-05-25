using QuestionDataLayer.Models;
using QuestionDataLayer.ViewModels;
using System.Threading.Tasks;

namespace QuestionDataLayer.ModelBuilders
{
    public interface IQuestionModelBuilder
    {
        QuestionViewModel GenerateValidQuestion(QuestionModel questionModel, QuestionViewModel questMini);
        Task<QuestionResponseModel> GetResponserModel(QuestionViewModel model, int counQuest , string userLogin);
    }
}