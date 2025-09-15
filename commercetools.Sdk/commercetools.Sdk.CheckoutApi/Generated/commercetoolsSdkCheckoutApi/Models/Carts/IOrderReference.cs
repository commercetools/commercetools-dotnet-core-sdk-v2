using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Carts.OrderReference))]
    public partial interface IOrderReference : IReference
    {
        new string Id { get; set; }

    }
}
