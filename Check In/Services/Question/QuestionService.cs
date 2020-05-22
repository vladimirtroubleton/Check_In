using AuthDataLayer.Repositories;
using QuestionDataLayer.ModelBuilders;
using QuestionDataLayer.Repository;
using QuestionDataLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Check_In.Services.Question
{
    public class QuestionService
    {
        private IQuestinosRepository questinosRepository;
        private IGroupsRepository groupsRepository;
        private IQuestionModelBuilder questionModelBuilder;

        public QuestionService(IQuestinosRepository questinosRepository, IGroupsRepository groupsRepository, IQuestionModelBuilder questionModelBuilder)
        {
            this.questinosRepository = questinosRepository;
            this.groupsRepository = groupsRepository;
            this.questionModelBuilder = questionModelBuilder;
        }

        public async Task<QuestionViewModel[]> GetQuestionsByGroupId(Guid id)
        {
            var questionMiniList = new List<QuestionViewModel>();
            var questions =await questinosRepository.GetQuestionsByGroupId(id);
            var group = await groupsRepository.GetGroupById(id);

            foreach (var question in questions)
            {
                questionMiniList.Add
                    (
                        questionModelBuilder.GenerateValidQuestion(question , new QuestionViewModel
                        {
                            GroupId = group.Id,
                            QuestionId = question.Id,
                            GroupName = group.Name,
                            QuestionName = question.Name
                        }
                            )
                    ) ;
            }
            return questionMiniList.ToArray();
        }
        public async Task<QuestionViewModel> GetQuestionsById(int id)
        {
   
            var question = questinosRepository.GetQuestionsById(id);
            var group = await groupsRepository.GetGroupById(question.GroupId);
            var questMini = questionModelBuilder.GenerateValidQuestion(question, new QuestionViewModel
                {
                    GroupId = group.Id,
                    QuestionId = question.Id,
                    GroupName = group.Name,
                    QuestionName = question.Name
                }
            );
                 
            return questMini;
        }
    }
}
