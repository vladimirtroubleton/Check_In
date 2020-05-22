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
            questionsDict.Add(0, questionModel.Question);
            questionsDict.Add(1, questionModel.Question1);
            questionsDict.Add(2, questionModel.Question2);
            questionsDict.Add(3, questionModel.Question3);
            questionsDict.Add(4, questionModel.Question4);
            questMini.Questions = questionsDict.Where(x => x.Value != null).Select(x => x.Value).ToArray();

            return questMini;
        }


    }
}
