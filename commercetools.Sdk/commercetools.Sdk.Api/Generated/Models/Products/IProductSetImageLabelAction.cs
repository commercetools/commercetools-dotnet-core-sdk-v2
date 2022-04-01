using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetImageLabelAction))]
    public partial interface IProductSetImageLabelAction : IProductUpdateAction
    {
        string Sku { get; set; }

        long? VariantId { get; set; }

        string ImageUrl { get; set; }

        string Label { get; set; }

        bool? Staged { get; set; }
    }
}
