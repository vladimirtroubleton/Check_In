using QuestionDataLayer.Models;
using QuestionDataLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionDataLayer.ModelBuilders
{
    public class QuestionModelBuilder : IQuestionModelBuilder
    {

        public QuestionViewModel GenerateValidQuestion(QuestionModel questionModel, QuestionViewModel questMini)
        {

            Dictionary<int, string> questionsDict = new Dictionary<int, string>();
            questionsDict.Add(0, questionModel.Question);
            questionsDict.Add(1, questionModel.Question1);
            questionsDict.Add(2, questionModel.Question2);
            questionsDict.Add(3, questionModel.Question3);
            questionsDict.Add(4, questionModel.Question4);
            questMini.Questions = questionsDict.Where(x => x.Value != null).Select(x => x.Value).ToArray();

            return questMini;
        }

        public Task<QuestionResponseModel> GetResponserModel(QuestionViewModel model , int counQuest , string userLogin)
        {
            QuestionResponseModel questionResponseModel = new QuestionResponseModel { Id = model.QuestionId ,
                                                                                        Name = model.QuestionName,
                                                                                        CountQest = counQuest ,
                                                                                        GroupId = model.GroupId ,
                                                                                        GroupName = model.GroupName,
                                                                                        UserLogin = userLogin};

            switch (counQuest)
            {
                case 1:
                    {
                        questionResponseModel.Question = model.Questions[0];
                        break;
                    }
                case 2:
                    {
                        questionResponseModel.Question = model.Questions[0];
                        questionResponseModel.Question1 = model.Questions[1];
                        break;
                    }
                case 3:
                    {
                        questionResponseModel.Question = model.Questions[0];
                        questionResponseModel.Question1 = model.Questions[1];
                        questionResponseModel.Question2 = model.Questions[2];
                        break;
                    }
                case 4:
                    {
                        questionResponseModel.Question = model.Questions[0];
                        questionResponseModel.Question1 = model.Questions[1];
                        questionResponseModel.Question2 = model.Questions[2];
                        questionResponseModel.Question3 = model.Questions[3];
                        break;
                    }
                case 5:
                    {
                        questionResponseModel.Question = model.Questions[0];
                        questionResponseModel.Question1 = model.Questions[1];
                        questionResponseModel.Question2 = model.Questions[2];
                        questionResponseModel.Question3 = model.Questions[3];
                        questionResponseModel.Question4 = model.Questions[4];
                        break;
                    }
            }

            return Task.FromResult(questionResponseModel);
        }
    }
}
