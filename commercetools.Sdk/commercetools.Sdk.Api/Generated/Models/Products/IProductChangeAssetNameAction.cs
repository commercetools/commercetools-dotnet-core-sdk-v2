using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductChangeAssetNameAction))]
    public partial interface IProductChangeAssetNameAction : IProductUpdateAction
    {
        long? VariantId { get; set;}
        
        string Sku { get; set;}
        
        bool? Staged { get; set;}
        
        string AssetId { get; set;}
        
        string AssetKey { get; set;}
        
        ILocalizedString Name { get; set;}
    }
}
