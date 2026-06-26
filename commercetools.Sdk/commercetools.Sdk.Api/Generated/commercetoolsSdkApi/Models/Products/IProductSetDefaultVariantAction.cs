using commercetools.Sdk.Api.Models.Variants;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetDefaultVariantAction))]
    public partial interface IProductSetDefaultVariantAction : IProductUpdateAction
    {
        IVariantResourceIdentifier Variant { get; set; }

        bool? Staged { get; set; }

    }
}
