using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSignInResult))]
    public partial interface ICustomerSignInResult
    {
        ICustomer Customer { get; set; }

        ICart Cart { get; set; }

    }
}
