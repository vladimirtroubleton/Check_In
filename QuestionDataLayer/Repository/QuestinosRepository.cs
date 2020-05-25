using Microsoft.EntityFrameworkCore;
using QuestionDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionDataLayer.Repository
{
    public class QuestinosRepository : IQuestinosRepository
    {
        private QuestionsContext context;
        object locker = new object();

        public QuestinosRepository(QuestionsContext context)
        {
            this.context = context;
        }

        public Task<QuestionModel[]> GetQuestions()
        {
            return Task.FromResult( context.Questions.ToArray());
        }

        public QuestionModel GetQuestionsById(int id)
        {
            return context.Questions.Find(id);
        }

        public async Task CreateQuestion(QuestionModel questionModel)
        {
            lock (locker)
            {
                context.Questions.Add(questionModel);
            }
            await context.SaveChangesAsync();
        }

        public async Task DeleteQuestion(int id)
        {
            var questionModel = GetQuestionsById(id);
            lock (locker)
            {
                context.Questions.Remove(questionModel);
            }
            await context.SaveChangesAsync();
        }

        private async Task DeleteQuestionByModel(QuestionModel model)
        {
            lock (locker)
            {
                context.Questions.Remove(model);
            }
            await context.SaveChangesAsync();
        }

        public async Task DeleteQuestionResponseByModel(QuestionResponseModel model)
        {
            lock (locker)
            {
                context.QuestionsRespons.Remove(model);
            }
            await context.SaveChangesAsync();
        }

        public Task<QuestionModel[]> GetQuestionsByGroupId(Guid groupId)
        {
            
            return Task.FromResult(context.Questions.Where(x => x.GroupId == groupId).ToArray());
        }

        public async Task CreateResponseQuestion(QuestionResponseModel questionRespModel)
        {
            lock (locker)
            {
                context.QuestionsRespons.Add(questionRespModel);
            }
            await context.SaveChangesAsync();
        }

        public Task<Dictionary<int,bool>> CheckResponseUser(int[] questIds  , string userLogin )
        {
            Dictionary<int, bool> ResponseChecked = new Dictionary<int, bool>();
            for( int i = 0; i < questIds.Count(); i++)
            {
                ResponseChecked.Add(questIds[i], context.QuestionsRespons.Where(x=> x.UserLogin == userLogin).Select( x=> x.Id).Contains(questIds[i]));
            }
            return Task.FromResult(ResponseChecked);
        }

        public async Task DeleteQuestionsDataByGropId(Guid groupId)
        {
            var questions =await context.Questions.Where(x => x.GroupId == groupId).ToArrayAsync();
            var questionsResp =await context.QuestionsRespons.Where(x => x.GroupId == groupId).ToArrayAsync();
            foreach (var question in questions)
            {
                await DeleteQuestionByModel(question);
            }
            foreach (var qestResp in questionsResp)
            {
                await DeleteQuestionResponseByModel(qestResp);
            }

        }

        public async Task<QuestionResponseModel[]> GetResponseByQuestionId(int id)
        {
            return await context.QuestionsRespons.Where(x=> x.Id == id).ToArrayAsync();
        }

        public async Task<QuestionResponseModel> GetResponseByIdAndLogin(int id, string login)
        {
            return await context.QuestionsRespons.Where(x => x.Id == id && x.UserLogin == login).FirstOrDefaultAsync();
        }
    }
}
