using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AuthDataLayer.ViewModels
{
    public class LoginViewModel
    {
        
        [MaxLength(20, ErrorMessage = "Слишком длинный логин товарищ")]
        [Required(ErrorMessage = "Нужно ввести")]
        [Display(Name ="Логин")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Нужно ввести")]
        [Display(Name = "Пароль")]
        [MinLength(8, ErrorMessage = "Слишком слыбый пароль товарищ")]
        public string Password { get; set; }
    }
}
