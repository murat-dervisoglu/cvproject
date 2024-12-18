using System.ComponentModel.DataAnnotations;

namespace core_proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Adınızı Girin")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Lütfen Soyadınızı Girin")]
        public string Surname { get; set; }
        
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Girin")]
        [Compare ("Password", ErrorMessage = "Şifre Doğrulamasını Yanlış Girdiniz. Lütfen Tekrar deneyin")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen E-mail Adresinizi Girin")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Görsel Yolunu Girin")]
        public string ImageURL { get; set; }
    }
}
