using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatiShop.Models
{
    public class Register
    {
        public int RegisterID { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        [StringLength(30)]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "E-Posta zorunludur.")]
        [Display(Name = "E-mail Adresi")]
        public string EMail { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre zorunludur.")]
        [StringLength(maximumLength:10, MinimumLength = 4, ErrorMessage = "MAksimum 10, min 4 karakterden oluşmalıdır.")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrarı")]
        [Required]
        [Compare("Password", ErrorMessage = "Paralo tekrar alanı yanlıştır")]
        public string RePassword { get; set; }

        [Display(Name = "Telefon Numarası")]
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Girilen telefon numarası geçerli değildir.")]
       
        public string PhoneNumber { get; set; }

        [Display(Name = "Doğum Tarihi")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public bool TermsAccepted { get; set; }


    }
}
