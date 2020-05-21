using QuestionDataLayer.Models;
using QuestionDataLayer.ViewModels;

namespace QuestionDataLayer.ModelBuilders
{
    public interface IQuestionModelBuilder
    {
        QuestionViewModel GenerateValidQuestion(QuestionModel questionModel, QuestionViewModel questMini);
    }
}