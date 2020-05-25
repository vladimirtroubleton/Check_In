using QuestionDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuestionDataLayer.Repository
{
    public interface IQuestinosRepository
    {
        Task CreateQuestion(QuestionModel questionModel);
        Task DeleteQuestion(int id);
        Task DeleteQuestionResponseByModel(QuestionResponseModel model);
        Task<QuestionModel[]> GetQuestions();
        Task<QuestionModel[]> GetQuestionsByGroupId(Guid groupId);
        QuestionModel GetQuestionsById(int id);
        Task CreateResponseQuestion(QuestionResponseModel questionRespModel);
        Task<Dictionary<int, bool>> CheckResponseUser(int[] questIds, string userLogin);

        Task DeleteQuestionsDataByGropId(Guid groupId);
        Task<QuestionResponseModel[]> GetResponseByQuestionId(int id);
        Task<QuestionResponseModel> GetResponseByIdAndLogin(int id, string login);
    }
}