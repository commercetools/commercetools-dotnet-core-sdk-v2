using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetProductVariantKeyAction))]
    public partial interface IProductSetProductVariantKeyAction : IProductUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        string Key { get; set; }

        bool? Staged { get; set; }

    }
}
