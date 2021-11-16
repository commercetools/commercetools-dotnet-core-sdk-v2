using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartRemoveItemShippingAddressAction))]
    public partial interface ICartRemoveItemShippingAddressAction : ICartUpdateAction
    {
        string AddressKey { get; set; }
    }
}
