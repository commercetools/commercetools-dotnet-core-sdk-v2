using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetLastNameAction))]
    public partial interface ICustomerSetLastNameAction : ICustomerUpdateAction
    {
        string LastName { get; set; }

    }
}
