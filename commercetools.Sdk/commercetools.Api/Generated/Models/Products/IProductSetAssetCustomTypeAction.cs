using commercetools.Api.Generated.Models.Products;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductSetAssetCustomTypeAction : IProductUpdateAction
    {
        long VariantId { get; set;}
        
        string Sku { get; set;}
        
        bool Staged { get; set;}
        
        string AssetId { get; set;}
        
        string AssetKey { get; set;}
        
        ITypeResourceIdentifier Type { get; set;}
        
        Object Fields { get; set;}
    }
}
