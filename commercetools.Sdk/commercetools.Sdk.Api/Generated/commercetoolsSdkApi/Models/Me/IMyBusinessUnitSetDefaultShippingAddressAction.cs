using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetDefaultShippingAddressAction))]
    public partial interface IMyBusinessUnitSetDefaultShippingAddressAction : IMyBusinessUnitUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }

    }
}
