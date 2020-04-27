using AncestorData.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AncestorData.Security
{
    public class RegisterModelValidator :IModelValidator
    {
        RegisterModel _model;
        public RegisterModelValidator(RegisterModel model)
        {
            _model = model;
        }
        public bool Validate()
        {
            var emailIsValid = StringChecker.CheckIfStringIsSafe(_model.Email);
            if (!emailIsValid) 
                return false;
            var userNameIsValid = StringChecker.CheckIfStringIsSafe(_model.Username);
            if (!userNameIsValid)
                return false;
            var passwordIsValid = StringChecker.CheckIfStringIsSafe(_model.Password);
            var duplicatedPasswordIsValid = StringChecker.CheckIfStringIsSafe(_model.DuplicatedPassword);
            var passwordsAreSame = _model.Password.Equals(_model.DuplicatedPassword);
            return passwordIsValid && duplicatedPasswordIsValid && passwordsAreSame;
        }
    }
}
