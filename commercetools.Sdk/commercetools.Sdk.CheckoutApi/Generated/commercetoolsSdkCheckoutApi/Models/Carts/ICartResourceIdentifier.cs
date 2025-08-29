using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Carts.CartResourceIdentifier))]
    public partial interface ICartResourceIdentifier : IResourceIdentifier
    {
        new string Id { get; set; }

        new string Key { get; set; }

    }
}
