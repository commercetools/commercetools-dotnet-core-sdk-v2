using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartRemoveItemShippingAddressAction))]
    public partial interface IMyCartRemoveItemShippingAddressAction : IMyCartUpdateAction
    {
        string AddressKey { get; set; }

    }
}
