using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    /// <summary>
    /// Класс контролера. Отвечает за приглгшение на пьянку
    /// </summary>
    public class GuestResponse
    {
        //Свойства
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
    }
}