using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductRemoveVariantAction))]
    public partial interface IProductRemoveVariantAction : IProductUpdateAction
    {
        long? Id { get; set; }

        string Sku { get; set; }

        bool? Staged { get; set; }

    }
}
