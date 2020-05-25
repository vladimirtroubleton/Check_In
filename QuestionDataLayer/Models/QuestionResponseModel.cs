using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuestionDataLayer.Models
{
    public class QuestionResponseModel
    {
        [Key]
        public int ResponseId { get; set; }

        public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название опроса")]
        [Display(Name = "Название опроса")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]
        public string Name { get; set; }

        [Display(Name = "Нулевой вопрос")]
        [Required(ErrorMessage = "Необходимо ввести хотя бы один вопрос")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]

        public string Question { get; set; }

        [Display(Name = "Нулевой вопрос")]
        [Required(ErrorMessage = "Необходимо ввести хотя бы один вопрос")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]

        public string QuestionResponse { get; set; }

        [Display(Name = "Первый вопрос")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]

        public string Question1 { get; set; }

        [Display(Name = "Первый вопрос")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]

        public string Question1Response { get; set; }

        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]
        [Display(Name = "Второй вопрос")]

        public string Question2 { get; set; }

        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]
        [Display(Name = "Второй вопрос")]

        public string Question2Response { get; set; }

        [Display(Name = "Третий вопрос")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]

        public string Question3 { get; set; }

        [Display(Name = "Третий вопрос")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]

        public string Question3Response { get; set; }

        [Display(Name = "Четвертый вопрос")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]

        public string Question4 { get; set; }

        [Display(Name = "Четвертый вопрос")]
        [MaxLength(40, ErrorMessage = "Сочинения не поддерживаются")]
        [MinLength(4, ErrorMessage = "А можно подробнее")]

        public string Question4Response { get; set; }

        [Display(Name = "Выберите группу")]
        [Required(ErrorMessage = "Обозначьте группу")]

        public Guid GroupId { get; set; }

        public string GroupName { get; set; }

        public int CountQest { get; set; }

        public string UserLogin { get; set; }
    }
}
