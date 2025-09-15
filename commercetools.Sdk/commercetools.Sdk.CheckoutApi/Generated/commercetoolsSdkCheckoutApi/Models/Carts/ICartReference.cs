using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Carts.CartReference))]
    public partial interface ICartReference : IReference
    {
        new string Id { get; set; }

    }
}
