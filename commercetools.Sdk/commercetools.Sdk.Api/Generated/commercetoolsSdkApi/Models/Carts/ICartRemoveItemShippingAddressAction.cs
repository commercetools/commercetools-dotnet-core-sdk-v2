using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartRemoveItemShippingAddressAction))]
    public partial interface ICartRemoveItemShippingAddressAction : ICartUpdateAction
    {
        string AddressKey { get; set; }

    }
}
