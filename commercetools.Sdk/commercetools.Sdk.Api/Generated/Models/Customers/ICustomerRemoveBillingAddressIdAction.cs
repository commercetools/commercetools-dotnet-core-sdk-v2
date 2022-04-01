using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerRemoveBillingAddressIdAction))]
    public partial interface ICustomerRemoveBillingAddressIdAction : ICustomerUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }
    }
}
