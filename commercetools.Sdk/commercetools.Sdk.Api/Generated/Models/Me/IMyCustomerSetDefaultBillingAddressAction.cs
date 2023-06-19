using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetDefaultBillingAddressAction))]
    public partial interface IMyCustomerSetDefaultBillingAddressAction : IMyCustomerUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }

    }
}
