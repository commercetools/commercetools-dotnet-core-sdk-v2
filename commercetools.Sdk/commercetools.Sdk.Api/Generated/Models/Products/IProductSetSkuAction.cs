using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetSkuAction))]
    public partial interface IProductSetSkuAction : IProductUpdateAction
    {
        long VariantId { get; set; }

        string Sku { get; set; }

        bool? Staged { get; set; }
    }
}
