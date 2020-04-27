using AncestorData.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AncestorData.Security
{
    public class LoginModelValidator :IModelValidator
    {
        private LoginModel _model;
        public LoginModelValidator(LoginModel model)
        {
            _model = model;
        }

        public bool Validate()
        {
            var emailIsValid = StringChecker.CheckIfStringIsSafe(_model.EmailAddress);
            if (!emailIsValid)
                return false;
            return StringChecker.CheckIfStringIsSafe(_model.Password);
        }
    }
}
