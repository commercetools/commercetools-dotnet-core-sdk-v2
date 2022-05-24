namespace commercetools.Sdk.Api.Models.Customers
{
    public partial class MyCustomerSignin : IMyCustomerSignin
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public IAnonymousCartSignInMode ActiveCartSignInMode { get; set; }

        public bool? UpdateProductData { get; set; }
    }
}
