using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerAddStoreAction))]
    public partial interface ICustomerAddStoreAction : ICustomerUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }

    }
}
