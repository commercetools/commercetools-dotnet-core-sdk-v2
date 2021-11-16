using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductLegacySetSkuAction))]
    public partial interface IProductLegacySetSkuAction : IProductUpdateAction
    {
        string Sku { get; set;}
        
        int VariantId { get; set;}
    }
}
