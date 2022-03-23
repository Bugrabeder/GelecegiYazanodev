using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebÖdev.Models
{
    public class User
    {
        [Required(ErrorMessage ="Kullanıcı adı boş bırakılamaz.")]
        public string KullaniciAdi { get; set; }
        [Phone]
        public string TelefonNumarasi { get; set; }
        [Required(ErrorMessage = "Email boş bırakılamaz.")]
        [EmailAddress(ErrorMessage ="Email formatı hatalı")]
        public string EMail { get; set; }
        
        public string Durum { get; set; }

    }
}
