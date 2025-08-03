using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegsiterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Resim Url Girin")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage="Lütfen Kullanıcı Adını Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Girin")]
        [Compare("Password",ErrorMessage = "Şifreler Eşleşmiyor")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Girin")]
        public string Mail { get; set; }
    }
}
