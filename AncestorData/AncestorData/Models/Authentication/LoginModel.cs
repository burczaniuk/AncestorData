using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AncestorData.Models.Authentication
{
    public class LoginModel
    {
        [Required, DataType(DataType.EmailAddress), Display(Name = "Adres e-mail:")]
        public string EmailAddress { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Hasło:")]
        public string Password { get; set; }
        [Required, Display(Name = "Zapamiętaj mnie")]
        public bool IfRemember { get; set; }
        [Required, DataType(DataType.Url)]
        public string PreviousPage { get; set; }
    }
}
