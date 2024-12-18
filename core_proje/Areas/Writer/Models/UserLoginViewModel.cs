using System.ComponentModel.DataAnnotations;

namespace core_proje.Areas.Writer.Models
{
	public class UserLoginViewModel
	{
		[Display(Name = "Kullanıcı Adı")]
		[Required(ErrorMessage = "Kullanıcı Adınızı Girin")]
		public String UserName { get; set; }

		[Display(Name = "Şifre")]
		[Required(ErrorMessage = "Şifrenizi Girin")]
		public string Password { get; set; }

    }
}
