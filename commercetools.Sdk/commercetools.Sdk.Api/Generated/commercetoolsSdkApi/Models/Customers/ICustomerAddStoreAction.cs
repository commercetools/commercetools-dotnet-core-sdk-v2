using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerAddStoreAction))]
    public partial interface ICustomerAddStoreAction : ICustomerUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }

    }
}
