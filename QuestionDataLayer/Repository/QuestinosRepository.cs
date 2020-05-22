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

        public Task<QuestionModel[]> GetQuestionsByGroupId(Guid groupId)
        {
            return Task.FromResult(context.Questions.Where(x => x.GroupId == groupId).ToArray());
        }
    }
}
