﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AuthDataLayer.ViewModels
{
    public class UserViewModel
    {
        [MaxLength(20,ErrorMessage = "Слишком длинный логин товарищ")]
        [Required(ErrorMessage = "Нужно ввести")]
        public string Login { get; set; }
        [MaxLength(15)]
        [Required(ErrorMessage = "Нужно ввести")]
        public string Name { get; set; }
        [MaxLength(15)]
        [Required(ErrorMessage = "Нужно ввести")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Нужно ввести")]
        [MaxLength(60)]
        [DataType(DataType.Password , ErrorMessage ="Ну почта так не работает")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Нужно ввести")]
       
        //[RegularExpression("#^[0-9]+$#")]
        [MaxLength(3, ErrorMessage = "Вы так стары товарищ?")]
        public string Age { get; set; }
        [Required(ErrorMessage = "Нужно ввести")]
        [MinLength(8 , ErrorMessage ="Ну так не пойдет, минимум 8 символов")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Нужно ввести")]
        public Guid GroupId { get; set; }
    }
}
