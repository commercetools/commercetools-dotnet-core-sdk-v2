using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductRemoveImageAction))]
    public partial interface IProductRemoveImageAction : IProductUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        string ImageUrl { get; set; }

        bool? Staged { get; set; }
    }
}
