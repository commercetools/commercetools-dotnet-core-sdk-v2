using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetKeyAction))]
    public partial interface ICustomerSetKeyAction : ICustomerUpdateAction
    {
        string Key { get; set; }

    }
}
