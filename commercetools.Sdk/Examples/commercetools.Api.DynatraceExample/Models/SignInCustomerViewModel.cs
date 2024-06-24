using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace commercetools.Api.DynatraceExample.Models
{
    public class SignInCustomerViewModel : CustomerProfileViewModel
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The password is required")]
        [PasswordPropertyText]
        public string Password { get; set; }

        public bool FailedLogin { get; set; }
        public bool EmailNotVerified { get; set; }

        public SignInCustomerViewModel()
        {

        }

        public SignInCustomerViewModel(CustomerProfileViewModel profile)
        {
            this.ActiveCart = profile.ActiveCart;
            this.Customer = profile.Customer;
        }

        public void ResetAfterLoginFailed()
        {
            FailedLogin = true;
            EmailNotVerified = false;
            Email = "";
            Password = "";
        }
        public void ResetAfterEmailNotVerified()
        {
            FailedLogin = false;
            EmailNotVerified = true;
            Email = "";
            Password = "";
        }
    }
}