using commercetools.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerAddStoreAction))]
    public partial interface ICustomerAddStoreAction : ICustomerUpdateAction
    {
        IStoreResourceIdentifier Store { get; set;}
    }
}
