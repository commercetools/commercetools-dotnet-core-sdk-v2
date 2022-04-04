using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetDefaultBillingAddressAction))]
    public partial interface ICustomerSetDefaultBillingAddressAction : ICustomerUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }
    }
}
