using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "Ad Alanı Zorunlu!")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Telefon Alanı Zorunlu!")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Email Alanı Zorunlu!")]
        [EmailAddress(ErrorMessage = "Geçerli Bir Email Giriniz!")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Katılım Durumunu Belirtiniz!")]
        public bool? WillAttend { get; set; }
    }
}