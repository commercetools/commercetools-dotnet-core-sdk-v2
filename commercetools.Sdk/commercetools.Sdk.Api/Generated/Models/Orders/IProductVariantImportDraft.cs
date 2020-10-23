using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.ProductVariantImportDraft))]
    public interface IProductVariantImportDraft 
    {
        long Id { get; set;}
        
        string Sku { get; set;}
        
        List<IPriceDraft> Prices { get; set;}
        
        List<IAttribute> Attributes { get; set;}
        
        List<IImage> Images { get; set;}
    }
}
