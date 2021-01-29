using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productdrafts;
using commercetools.ImportApi.Models.Productvariants;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productdrafts
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productdrafts.ProductVariantDraftImport))]
    public partial interface IProductVariantDraftImport 
    {
        string Sku { get; set;}
        
        string Key { get; set;}
        
        List<IPriceDraftImport> Prices { get; set;}
        
        List<IAttribute> Attributes { get; set;}
        
        List<IImage> Images { get; set;}
        
        List<IAsset> Assets { get; set;}
    }
}
