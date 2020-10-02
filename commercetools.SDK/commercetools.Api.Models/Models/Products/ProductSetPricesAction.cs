using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setPrices")]
    public partial class ProductSetPricesAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public List<PriceDraft> Prices { get; set;}
        
        public bool Staged { get; set;}
        public ProductSetPricesAction()
        { 
           this.Action = "setPrices";
        }
    }
}
