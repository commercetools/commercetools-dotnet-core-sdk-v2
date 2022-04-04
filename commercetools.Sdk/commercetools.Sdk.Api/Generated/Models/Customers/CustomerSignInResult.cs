using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.Customers
{
    public partial class CustomerSignInResult : ICustomerSignInResult
    {
        public ICustomer Customer { get; set; }

        public ICart Cart { get; set; }
    }
}
