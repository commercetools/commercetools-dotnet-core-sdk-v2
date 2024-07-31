using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartRemoveShippingMethodAction))]
    public partial interface ICartRemoveShippingMethodAction : ICartUpdateAction
    {
        string ShippingKey { get; set; }

    }
}
