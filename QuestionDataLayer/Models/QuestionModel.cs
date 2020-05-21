using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuestionDataLayer.Models
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Необходимо ввести название опроса")]
        [Display(Name ="Название опроса")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage ="А можно подробнее")]
        public string Name { get; set; }
        [Display(Name = "Нулевой вопрос")]
        [Required(ErrorMessage = "Необходимо ввести хотя бы один вопрос")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]
        public string QuestionName { get; set; }
        [Display(Name = "Первый вопрос")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]
        public string QuestionName1 { get; set; }
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]
        [Display(Name = "Второй вопрос")]
        public string QuestionName2 { get; set; }
        [Display(Name = "Третий вопрос")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]
        public string QuestionName3 { get; set; }
        [Display(Name = "Четвертый вопрос")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]
        public string QuestionName4 { get; set; }
        [Display(Name = "Выберите группу")]
        [Required(ErrorMessage = "Обозначьте группу")]
        public Guid GroupId { get; set; }

    }
}
