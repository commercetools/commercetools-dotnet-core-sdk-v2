using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductCatalogData))]
    public partial interface IProductCatalogData 
    {
        bool Published { get; set;}
        
        IProductData Current { get; set;}
        
        IProductData Staged { get; set;}
        
        bool HasStagedChanges { get; set;}
    }
}
