using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public class ProductCatalogData 
    {
        public bool Published { get; set;}
        
        public ProductData Current { get; set;}
        
        public ProductData Staged { get; set;}
        
        public bool HasStagedChanges { get; set;}
    }
}
