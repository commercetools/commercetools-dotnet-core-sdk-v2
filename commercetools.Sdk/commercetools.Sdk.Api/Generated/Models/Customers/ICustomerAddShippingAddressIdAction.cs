using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerAddShippingAddressIdAction))]
    public partial interface ICustomerAddShippingAddressIdAction : ICustomerUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }
    }
}
