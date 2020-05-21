using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuestionDataLayer.ViewModels.MiniModels
{
    public class Quest3
    {
        [Display(Name = "Нулевой вопрос")]
        [Required(ErrorMessage = "Необходимо ввести хотя бы один вопрос")]
        public string QuestionName { get; set; }
        [Display(Name = "Первый вопрос")]
        public string QuestionName1 { get; set; }
        [Display(Name = "Второй вопрос")]
        public string QuestionName2 { get; set; }

    }
}
