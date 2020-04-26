using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AncestorData.Models.Authentication
{
    public class RegisterModel
    {
        [Required, MaxLength(128), Display(Name = "Użytkownik:")]
        public string Username { get; set; }
        [Required, DataType(DataType.EmailAddress), Display(Name = "Adres e-mail:")]
        public string Email { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Hasło:")]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password)), Display(Name = "Powtórz hasło:")]
        public string DuplicatedPassword { get; set; }
    }
}
