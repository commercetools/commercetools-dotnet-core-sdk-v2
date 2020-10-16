using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setDiscountedPrice")]
    public partial class ProductSetDiscountedPriceAction : ProductUpdateAction
    {
        public string PriceId { get; set;}
        
        public bool Staged { get; set;}
        
        public DiscountedPrice Discounted { get; set;}
        public ProductSetDiscountedPriceAction()
        { 
           this.Action = "setDiscountedPrice";
        }
    }
}
