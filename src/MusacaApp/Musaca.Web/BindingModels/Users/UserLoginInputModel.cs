using SIS.MvcFramework.Attributes.Validation;

namespace Musaca.App.BindingModels.Users
{
    public class UserLoginInputModel
    {
        private const string ErrorMessage = "Invalid username or password!";

        [RequiredSis(ErrorMessage)]
        public string Username { get; set; }

        [RequiredSis(ErrorMessage)]
        public string Password { get; set; }
    }
}
