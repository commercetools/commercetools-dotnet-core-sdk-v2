using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductAddExternalImageAction))]
    public partial interface IProductAddExternalImageAction : IProductUpdateAction
    {
        long? VariantId { get; set;}
        
        string Sku { get; set;}
        
        IImage Image { get; set;}
        
        bool? Staged { get; set;}
    }
}
