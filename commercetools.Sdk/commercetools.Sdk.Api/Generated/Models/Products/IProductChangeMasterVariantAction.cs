using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductChangeMasterVariantAction))]
    public partial interface IProductChangeMasterVariantAction : IProductUpdateAction
    {
        long? VariantId { get; set;}
        
        string Sku { get; set;}
        
        bool? Staged { get; set;}
    }
}
