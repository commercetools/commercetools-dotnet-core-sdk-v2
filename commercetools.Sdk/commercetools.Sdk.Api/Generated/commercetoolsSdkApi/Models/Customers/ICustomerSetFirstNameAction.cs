using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetFirstNameAction))]
    public partial interface ICustomerSetFirstNameAction : ICustomerUpdateAction
    {
        string FirstName { get; set; }

    }
}
