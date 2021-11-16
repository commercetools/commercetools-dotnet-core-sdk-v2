using commercetools.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetAssetSourcesAction))]
    public partial interface IProductSetAssetSourcesAction : IProductUpdateAction
    {
        long? VariantId { get; set;}
        
        string Sku { get; set;}
        
        bool? Staged { get; set;}
        
        string AssetId { get; set;}
        
        string AssetKey { get; set;}
        
        List<IAssetSource> Sources { get; set;}
    }
}
