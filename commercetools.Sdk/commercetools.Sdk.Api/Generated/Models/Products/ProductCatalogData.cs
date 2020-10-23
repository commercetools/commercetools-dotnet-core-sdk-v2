using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class ProductCatalogData : IProductCatalogData
    {
        public bool Published { get; set;}
        
        public IProductData Current { get; set;}
        
        public IProductData Staged { get; set;}
        
        public bool HasStagedChanges { get; set;}
    }
}
