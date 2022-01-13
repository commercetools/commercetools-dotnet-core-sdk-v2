using commercetools.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerRemoveStoreAction))]
    public partial interface ICustomerRemoveStoreAction : ICustomerUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }
    }
}
