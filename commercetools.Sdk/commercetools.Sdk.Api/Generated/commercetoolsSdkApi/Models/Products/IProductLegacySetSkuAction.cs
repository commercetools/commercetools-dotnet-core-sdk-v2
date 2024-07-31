using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductLegacySetSkuAction))]
    public partial interface IProductLegacySetSkuAction : IProductUpdateAction
    {
        string Sku { get; set; }

        int VariantId { get; set; }

    }
}
