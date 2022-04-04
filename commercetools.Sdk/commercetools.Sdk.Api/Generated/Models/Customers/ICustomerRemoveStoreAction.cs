using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerRemoveStoreAction))]
    public partial interface ICustomerRemoveStoreAction : ICustomerUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }
    }
}
