using QuestionDataLayer.Models;
using QuestionDataLayer.ViewModels;
using QuestionDataLayer.ViewModels.MiniModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestionDataLayer.ModelBuilders
{
    public class QuestionModelBuilder : IQuestionModelBuilder
    {

        public QuestionViewModel GenerateValidQuestion(QuestionModel questionModel, QuestionViewModel questMini)
        {

            Dictionary<int, string> questionsDict = new Dictionary<int, string>();
            questionsDict.Add(0, questionModel.QuestionName);
            questionsDict.Add(1, questionModel.QuestionName1);
            questionsDict.Add(2, questionModel.QuestionName2);
            questionsDict.Add(3, questionModel.QuestionName3);
            questionsDict.Add(4, questionModel.QuestionName4);
            questMini.Questions = questionsDict.Where(x => x.Value != null).Select(x => x.Value).ToArray();
            return questMini;
        }


    }
}
