using QuestionDataLayer.Models;
using System;
using System.Threading.Tasks;

namespace QuestionDataLayer.Repository
{
    public interface IQuestinosRepository
    {
        Task CreateQuestion(QuestionModel questionModel);
        Task DeleteQuestion(int id);
        Task<QuestionModel[]> GetQuestions();
        Task<QuestionModel[]> GetQuestionsByGroupId(Guid groupId);
        QuestionModel GetQuestionsById(int id);
    }
}