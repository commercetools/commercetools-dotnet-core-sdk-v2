using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerChangeEmailAction))]
    public partial interface ICustomerChangeEmailAction : ICustomerUpdateAction
    {
        string Email { get; set; }

    }
}
