using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductAddPriceAction))]
    public partial interface IProductAddPriceAction : IProductUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        IEmbeddedPriceDraft Price { get; set; }

        bool? Staged { get; set; }

    }
}
