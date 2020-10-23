using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductSetImageLabelAction : IProductUpdateAction
    {
        string Sku { get; set;}
        
        long VariantId { get; set;}
        
        string ImageUrl { get; set;}
        
        string Label { get; set;}
        
        bool Staged { get; set;}
    }
}
