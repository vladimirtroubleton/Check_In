using QuestionDataLayer.Models;
using System.Threading.Tasks;

namespace QuestionDataLayer.Repository
{
    public interface IQuestinosRepository
    {
        Task CreateQuestion(QuestionModel questionModel);
        Task DeleteQuestion(int id);
        Task<QuestionModel[]> GetQuestions();
        QuestionModel GetQuestionsById(int id);
    }
}