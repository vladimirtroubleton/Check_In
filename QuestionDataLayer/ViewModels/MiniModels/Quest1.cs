using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuestionDataLayer.ViewModels.MiniModels
{
    public class Quest1
    {
        [Display(Name = "Нулевой вопрос")]
        [Required(ErrorMessage = "Необходимо ввести хотя бы один вопрос")]
        public string QuestionName { get; set; }
    
        
    }
}
