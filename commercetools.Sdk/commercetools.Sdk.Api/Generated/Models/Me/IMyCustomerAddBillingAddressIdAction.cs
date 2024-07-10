using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerAddBillingAddressIdAction))]
    public partial interface IMyCustomerAddBillingAddressIdAction : IMyCustomerUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }

    }
}
