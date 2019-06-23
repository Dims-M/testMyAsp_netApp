using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    /// <summary>
    /// Класс контролера. Отвечает за приглгшение на пьянку
    /// </summary>
    public class GuestResponse
    {
        //Свойства
        public int Id { get; set; }

        //атрибутов C#
        [Required(ErrorMessage = "Пожалуйста, введите свое имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Вы ввели некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите, примите ли участие в вечеринке")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите, примите ли участие в вечеринке")]
        public bool? WillAttend { get; set; }
    }
}