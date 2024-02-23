using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Customers;

namespace commercetools.Api.NewRelicExample.Models
{
    public class SignInResult : ICustomerSignInResult
    {
        public ICustomer Customer { get; set; }
        public ICart Cart { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsValidCredentials { get; set; }
    }
}