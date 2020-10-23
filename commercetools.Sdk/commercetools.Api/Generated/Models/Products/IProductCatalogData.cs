using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductCatalogData 
    {
        bool Published { get; set;}
        
        IProductData Current { get; set;}
        
        IProductData Staged { get; set;}
        
        bool HasStagedChanges { get; set;}
    }
}
