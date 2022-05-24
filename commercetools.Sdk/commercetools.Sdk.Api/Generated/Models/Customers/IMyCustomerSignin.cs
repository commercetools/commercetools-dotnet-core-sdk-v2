using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.MyCustomerSignin))]
    public partial interface IMyCustomerSignin
    {
        string Email { get; set; }

        string Password { get; set; }

        IAnonymousCartSignInMode ActiveCartSignInMode { get; set; }

        bool? UpdateProductData { get; set; }
    }
}
